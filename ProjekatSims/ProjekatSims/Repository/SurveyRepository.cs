/***********************************************************************
 * Module:  SurveyService.cs
 * Purpose: Definition of the Class Service.SurveyService
 ***********************************************************************/

using System;
using Model.Upravnik;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Repository
{
    public class SurveyRepository
   {

        private readonly string _path;
        private readonly string _delimiter;

        public SurveyRepository(string path, string delimiter)
        {
            _path = path;
            _delimiter = delimiter;
        }

        public IEnumerable<Survey> GetAll() => readAll();


        private string ConvertEntityToCSVFormat(Survey survey)
            => string.Join(_delimiter,
                survey.Anonymity,
                survey.Author,
                survey.Name,
                survey.Surname,
                survey.Content);


        public Model.Upravnik.Survey GetSurvey(String name, String surname)
      {
            try
            {
                return readAll().SingleOrDefault(rm => rm.Surname == surname);
            }
            catch (ArgumentException)
            {
                Console.WriteLine("Person with that name didn't write a survey -> Get");
                return null;
            }
      }
      
      public List<Survey> GetListofSurveys()
      {
            var surveys = readAll().ToList();
            return surveys;
      }
      
      public Model.Upravnik.Survey AddSurvey(Model.Upravnik.Survey survey)
      {
            appendLineToFile(ConvertEntityToCSVFormat(survey));
            return survey;
        }

      public void Delete(Survey survey)
        {
            var surveys = readAll().ToList();
            
            var roomToRemove = surveys.SingleOrDefault(rm => rm.Content == survey.Content);
            if (roomToRemove != null)
            {
                surveys.Remove(roomToRemove);
                saveAll(surveys);
            }
            else
            {
                Console.WriteLine("The survey that you want to delete does not exist");
            }
        }



        private Survey ConvertCSVFormatToEntity(string articleCSVFormat)
        {
            string[] tokens = articleCSVFormat.Split(_delimiter.ToCharArray());
            return new Survey(
                Boolean.Parse(tokens[0]), (Survey.SurveyAuthor)Enum.Parse(typeof(Survey.SurveyAuthor), tokens[1]), tokens[2], tokens[3], tokens[4]);


        }

        public void WriteIn(List<Survey> surveys)
        {
            surveys.ToList();
            saveAll(surveys);
        }

        private IEnumerable<Survey> readAll()
              => File.ReadAllLines(_path).Select(ConvertCSVFormatToEntity).ToList();

        private void saveAll(IEnumerable<Survey> survey)
        => writeAllLinesToFile(
            survey.Select(ConvertEntityToCSVFormat).ToList());

        private void appendLineToFile(string line)
            => File.AppendAllText(_path, line + Environment.NewLine);

        private void writeAllLinesToFile(IEnumerable<string> content)
            => File.WriteAllLines(_path, content.ToArray());

    }
}
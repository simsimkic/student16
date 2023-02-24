/***********************************************************************
 * Module:  SurveyService.cs
 * Purpose: Definition of the Class Service.SurveyService
 ***********************************************************************/

using System;
using System.Collections.Generic;
using Repository;
using Model.Upravnik;

namespace Service
{
   public class SurveyService
   {


        private readonly SurveyRepository repository;

        public SurveyService(SurveyRepository repository)
        {
            this.repository = repository;
        }

        public IEnumerable<Survey> GetAll()
        {
            var surveys = repository.GetAll();
            return surveys;
        }

        public Model.Upravnik.Survey AddSurvey(Model.Upravnik.Survey survey)
      {
            Survey newSurvey = repository.AddSurvey(survey);
            newSurvey.Anonymity = survey.Anonymity;
            newSurvey.Author = survey.Author;
            newSurvey.Name = survey.Name;
            newSurvey.Surname = survey.Surname;
            newSurvey.Content = survey.Content;

            return newSurvey;
        }
      
      public Model.Upravnik.Survey DeleteSurvey(Model.Upravnik.Survey survey)
      {
            repository.Delete(survey);
            return survey;
        }

        public Survey GetSurvey(String name, String surname)
        {
            var survey = repository.GetSurvey(name,  surname);
            return survey;
        }



    }
}
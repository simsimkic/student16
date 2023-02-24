using nasa_mala_klinika.OtherWindows;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nasa_mala_klinika.Sims.Repository
{
    public class PatientRepository
    {
        private readonly string _path;
        private readonly string _delimiter;

        public PatientRepository(string path, string delimiter)
        {
            _path = path;
            _delimiter = delimiter;
            //InitializeId();
        }

        public IEnumerable<Patient> GetAll() => ReadAll();

        public Patient Get(string jmbg)
        {
            try
            {
                return ReadAll().SingleOrDefault(usr => usr.Jmbg == jmbg);
            }
            catch (ArgumentException)
            {
                Console.WriteLine("User dont exist -> Get");
                return null;
            }
        }

        private string ConvertEntityToCSVFormat(Patient user)
            => string.Join(_delimiter,
                user.Jmbg,
                user.Name,
                user.Surname,
                user.Appointment,
                user.PhoneNumber);

        public Patient Create(Patient user)
        {
            AppendLineToFile(ConvertEntityToCSVFormat(user));
            return user;
        }

        public void Delete(Patient user)
        {
            var users = ReadAll().ToList();
            var userToRemove = users.SingleOrDefault(usr => usr.Jmbg == user.Jmbg);
            if (userToRemove != null)
            {
                users.Remove(userToRemove);
                SaveAll(users);
            }
            else
            {
                Console.WriteLine("Patient dont exist -> Delete");
            }
        }

        private Patient ConvertCSVFormatToEntity(string userCSVFormat)
        {
            string[] tokens = userCSVFormat.Split(_delimiter.ToCharArray());
            return new Patient(
                //double.Parse(tokens[0]),
                tokens[0],
                tokens[1],
                tokens[2],
                DateTime.Parse(tokens[3]),
                tokens[4]);

        }

        public void WriteIn(List<Patient> users)
        {
            //var users = ReadAll().ToList();
            users.ToList();
            SaveAll(users);
        }

        private IEnumerable<Patient> ReadAll()
            => File.ReadAllLines(_path).Select(ConvertCSVFormatToEntity).ToList();

        private void SaveAll(IEnumerable<Patient> users)
        => WriteAllLinesToFile(
            users.Select(ConvertEntityToCSVFormat).ToList());

        private void AppendLineToFile(string line)
            => File.AppendAllText(_path, line + Environment.NewLine);

        private void WriteAllLinesToFile(IEnumerable<string> content)
            => File.WriteAllLines(_path, content.ToArray());
    }
}

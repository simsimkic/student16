using System;

namespace Repository
{
   public class DoctorRepository   
    {
        private readonly string _path;
        private readonly string _delimiter;

        public DoctorRepository(string path, string delimiter)
        {
            _path = path;
            _delimiter = delimiter;
        }

        public IEnumerable<Doctor> GetAll() => ReadAll();

        public Doctor Get(string surname)
        {
            try
            {
                return ReadAll().SingleOrDefault(usr => usr.Surname == surname);
            }
            catch (ArgumentException)
            {
                Console.WriteLine("Doctor dont exist -> Get");
                return null;
            }
        }

        private string ConvertEntityToCSVFormat(Doctor user)
            => string.Join(_delimiter,
                user.Name,
                user.Surname,
                user.TypeOfDoctor,
                user.WorkHourBegin,
                user.WorkHourEnd,
                user.Shift);

        public Doctor Create(Doctor user)
        {
            AppendLineToFile(ConvertEntityToCSVFormat(user));
            return user;
        }

        public void Delete(Doctor user)
        {
            var users = ReadAll().ToList();
            var userToRemove = users.SingleOrDefault(usr => usr.Surname == user.Surname);
            if (userToRemove != null)
            {
                users.Remove(userToRemove);
                SaveAll(users);
            }
            else
            {
                Console.WriteLine("Doctor dont exist -> Delete");
            }
        }

        private Doctor ConvertCSVFormatToEntity(string userCSVFormat)
        {
            string[] tokens = userCSVFormat.Split(_delimiter.ToCharArray());
            return new Doctor(
                tokens[0],
                tokens[1],
                (Doctor.DoctorType)Enum.Parse(typeof(Doctor.DoctorType), tokens[2]),
                tokens[3],
                tokens[4],
                tokens[5]);

        }

        public void WriteIn(List<Doctor> users)
        {
            users.ToList();
            SaveAll(users);
        }

        private IEnumerable<Doctor> ReadAll()
            => File.ReadAllLines(_path).Select(ConvertCSVFormatToEntity).ToList();

        private void SaveAll(IEnumerable<Doctor> users)
        => WriteAllLinesToFile(
            users.Select(ConvertEntityToCSVFormat).ToList());

        private void AppendLineToFile(string line)
            => File.AppendAllText(_path, line + Environment.NewLine);

        private void WriteAllLinesToFile(IEnumerable<string> content)
            => File.WriteAllLines(_path, content.ToArray());
    }
}
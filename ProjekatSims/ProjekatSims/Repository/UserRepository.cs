using nasa_mala_klinika.Sims.Classes;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nasa_mala_klinika.Sims.Repository
{
    public class UserRepository
    {
        private readonly string _path;
        private readonly string _delimiter;

        public UserRepository(string path, string delimiter)
        {
            _path = path;
            _delimiter = delimiter;
            //InitializeId();
        }

        public IEnumerable<User> GetAll() => ReadAll();

        public User Get(string jmbg)
        {
            try
            {
                return ReadAll().SingleOrDefault(usr => usr.Jmbg == jmbg);
            }
            catch(ArgumentException)
            {
                Console.WriteLine("User dont exist -> Get");
                return null;
            }
        }

        private string ConvertEntityToCSVFormat(User user)
            => string.Join(_delimiter,
                user.Jmbg,
                user.Name,
                user.Surname,
                user.DateOfBirth,
                user.GenderType,
                user.Address,
                user.PhoneNumber,
                user.EmailAddress,
                user.Password);

        public User Create(User user)
        {
            AppendLineToFile(ConvertEntityToCSVFormat(user));
            return user;
        }

        public void Delete(User user)
        {
            var users = ReadAll().ToList();
            var userToRemove = users.SingleOrDefault(usr => usr.Jmbg == user.Jmbg);
            if(userToRemove != null)
            {
                users.Remove(userToRemove);
                SaveAll(users);
            }
            else
            {
                Console.WriteLine("User dont exist -> Delete");
            }
        }

        private User ConvertCSVFormatToEntity(string userCSVFormat)
        {
            string[] tokens = userCSVFormat.Split(_delimiter.ToCharArray());
            return new User(
                tokens[0],
                tokens[1],
                tokens[2],
                DateTime.Parse(tokens[3]),
                (User.Gender)Enum.Parse(typeof(User.Gender), tokens[4]),
                tokens[5],
                tokens[6],
                tokens[7],
                tokens[8]);

        }

        public void WriteIn(List<User> users)
        {
            users.ToList();
            SaveAll(users);
        }

        private IEnumerable<User> ReadAll()
            => File.ReadAllLines(_path).Select(ConvertCSVFormatToEntity).ToList();

        private void SaveAll(IEnumerable<User> users)
        => WriteAllLinesToFile(
            users.Select(ConvertEntityToCSVFormat).ToList());

        private void AppendLineToFile(string line)
            => File.AppendAllText(_path, line + Environment.NewLine);

        private void WriteAllLinesToFile(IEnumerable<string> content)
            => File.WriteAllLines(_path, content.ToArray());
    }
}

using nasa_mala_klinika.Sims.Classes;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nasa_mala_klinika.Sims.Repository
{
    public class LogInRepository
    {
        private readonly string _path;
        private readonly string _delimiter;

        public LogInRepository(string path, string delimiter)
        {
            _path = path;
            _delimiter = delimiter;
        }

        public IEnumerable<LogIn> GetAll() => ReadAll();

        public LogIn Get(string username)
        {
            try
            {
                return ReadAll().SingleOrDefault(usr => usr.Username == username);
            }
            catch (ArgumentException)
            {
                Console.WriteLine("User dont exist -> Get");
                return null;
            }
        }

        private LogIn ConvertCSVFormatToEntity(string userCSVFormat)
        {
            string[] tokens = userCSVFormat.Split(_delimiter.ToCharArray());
            return new LogIn(
                tokens[0],
                tokens[1]);

        }

        private IEnumerable<LogIn> ReadAll()
            => File.ReadAllLines(_path).Select(ConvertCSVFormatToEntity).ToList();

        private void AppendLineToFile(string line)
            => File.AppendAllText(_path, line + Environment.NewLine);

        private void WriteAllLinesToFile(IEnumerable<string> content)
            => File.WriteAllLines(_path, content.ToArray());
    }
}

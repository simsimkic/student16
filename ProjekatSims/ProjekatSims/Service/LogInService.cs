using nasa_mala_klinika.Sims.Classes;
using nasa_mala_klinika.Sims.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nasa_mala_klinika.Sims.Service
{
    public class LogInService
    {
        private readonly LogInRepository repository;

        public LogInService(LogInRepository repository)
        {
            this.repository = repository;
        }

        public IEnumerable<LogIn> GetAll()
        {
            var users = repository.GetAll();
            return users;
        }

        public LogIn Get(string username)
        {
            var user = repository.Get(username);
            return user;
        }
    }
}

using nasa_mala_klinika.Sims.Classes;
using nasa_mala_klinika.Sims.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nasa_mala_klinika.Sims.Controller
{
    public class LogInController
    {
        private readonly LogInService service;

        public LogInController(LogInService service)
        {
            this.service = service;
        }

        public IEnumerable<LogIn> GetAll() => service.GetAll();

        public LogIn Get(string username) => service.Get(username);

    }
}

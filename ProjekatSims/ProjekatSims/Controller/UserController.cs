using nasa_mala_klinika.Sims.Classes;
using nasa_mala_klinika.Sims.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nasa_mala_klinika.Sims.Controller
{
    public class UserController
    {
        private readonly UserService service;

        public UserController(UserService service)
        {
            this.service = service;
        }

        public IEnumerable<User> GetAll() => service.GetAll();

        public User Get(string jmbg) => service.Get(jmbg);

        public User Create(User user) => service.Create(user);

        public void Delete(User user) => service.Delete(user);

        public void WriteIn(List<User> users) => service.WriteIn(users);
    }
}

using nasa_mala_klinika.Sims.Classes;
using nasa_mala_klinika.Sims.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nasa_mala_klinika.Sims.Service
{
    public class UserService
    {
        private readonly UserRepository repository;

        public UserService(UserRepository repository)
        {
            this.repository = repository;
        }

        public IEnumerable<User> GetAll()
        {
            var users = repository.GetAll();
            return users;
        }

        public User Get(string jmbg)
        {
            var user = repository.Get(jmbg);
            return user;
        }

        public User Create(User user)
        {
            //SetMissingValues(user);
            User newUser = repository.Create(user);
            newUser.Jmbg = user.Jmbg;
            newUser.Name = user.Name;
            newUser.Surname = user.Surname;

            return newUser;
        }

        public void Delete(User user)
        {
            repository.Delete(user);
        }

        public void WriteIn(List<User> users)
        {
            repository.WriteIn(users);
        }

    }
}

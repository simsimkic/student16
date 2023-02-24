using nasa_mala_klinika.OtherWindows;
using nasa_mala_klinika.Sims.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nasa_mala_klinika.Sims.Service
{
    public class PatientService
    {
        private readonly PatientRepository repository;

        public PatientService(PatientRepository repository)
        {
            this.repository = repository;
        }

        public IEnumerable<Patient> GetAll()
        {
            var users = repository.GetAll();
            return users;
        }

        public Patient Get(string jmbg)
        {
            var user = repository.Get(jmbg);
            return user;
        }

        public Patient Create(Patient user)
        {
            //SetMissingValues(user);
            Patient newUser = repository.Create(user);
            newUser.Jmbg = user.Jmbg;
            newUser.Name = user.Name;
            newUser.Surname = user.Surname;

            return newUser;
        }

        public void Delete(Patient user)
        {
            repository.Delete(user);
        }

        public void WriteIn(List<Patient> users)
        {
            repository.WriteIn(users);
        }

    }
}

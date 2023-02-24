using nasa_mala_klinika.Sims.Classes;
using nasa_mala_klinika.Sims.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nasa_mala_klinika.Sims.Service
{
    public class DoctorService
    {
        private readonly DoctorRepository repository;

        public DoctorService(DoctorRepository repository)
        {
            this.repository = repository;
        }

        public IEnumerable<Doctor> GetAll()
        {
            var users = repository.GetAll();
            return users;
        }

        public Doctor Get(string surname)
        {
            var user = repository.Get(surname);
            return user;
        }

        public Doctor Create(Doctor user)
        {
            //SetMissingValues(user);
            Doctor newUser = repository.Create(user);

            newUser.Name = user.Name;
            newUser.Surname = user.Surname;
            newUser.TypeOfDoctor = user.TypeOfDoctor;
            newUser.WorkHourBegin = user.WorkHourBegin;
            newUser.WorkHourEnd = user.WorkHourEnd;
            newUser.Shift = user.Shift;

            return newUser;
        }

        public void Delete(Doctor user)
        {
            repository.Delete(user);
        }

        public void WriteIn(List<Doctor> users)
        {
            repository.WriteIn(users);
        }

    }
}

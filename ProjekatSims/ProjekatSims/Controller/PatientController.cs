using nasa_mala_klinika.OtherWindows;
using nasa_mala_klinika.Sims.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nasa_mala_klinika.Sims.Controller
{
    public class PatientController
    {
        private readonly PatientService service;

        public PatientController(PatientService service)
        {
            this.service = service;
        }

        public IEnumerable<Patient> GetAll() => service.GetAll();

        public Patient Get(string jmbg) => service.Get(jmbg);

        public Patient Create(Patient user) => service.Create(user);

        public void Delete(Patient user) => service.Delete(user);

        public void WriteIn(List<Patient> users) => service.WriteIn(users);
    }
}

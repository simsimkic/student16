/***********************************************************************
 * Module:  DoctorService.cs
 * Purpose: Definition of the Class Service.DoctorService
 ***********************************************************************/

using System;

namespace Controller
{
   public class DoctorController
    {
        private readonly DoctorService service;

        public DoctorController(DoctorService service)
        {
            this.service = service;
        }

        public IEnumerable<Doctor> GetAll() => service.GetAll();

        public Doctor Get(string surname) => service.Get(surname);

        public Doctor Create(Doctor user) => service.Create(user);

        public void Delete(Doctor user) => service.Delete(user);

        public void WriteIn(List<Doctor> users) => service.WriteIn(users);
    }
}
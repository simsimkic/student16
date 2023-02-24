/***********************************************************************
 * Module:  ManagerService.cs
 * Purpose: Definition of the Class Service.ManagerService
 ***********************************************************************/

using System;

namespace Service
{
   public class ManagerService
   {
      public Model.Upravnik.Renovate RenovateRoom(Model.ZajednickeKlase.Room room, Model.Upravnik.Renovate renovateDate)
      {
         // TODO: implement
         return null;
      }
      
      public Model.ZajednickeKlase.doctor RegistrateDoctor(DateTime timeOfRegistration, Model.ZajednickeKlase.User doctor)
      {
         // TODO: implement
         return null;
      }
      
      public Model.Upravnik.MedicineRequest SendMedicineRequest(Model.ZajednickeKlase.Medicine medicine)
      {
         // TODO: implement
         return null;
      }
      
      public Model.ZajednickeKlase.WorkingHours ChangeRoomWorkingHour(Model.ZajednickeKlase.Room room)
      {
         // TODO: implement
         return null;
      }
      
      public Model.ZajednickeKlase.WorkingHours ChangeDoctorWorkingHour(Model.ZajednickeKlase.doctor doctor)
      {
         // TODO: implement
         return null;
      }
   
      public Repository.ManagerRepository managerRepository;
      public Repository.WorkingHoursRepository workingHoursRepository;
   
   }
}
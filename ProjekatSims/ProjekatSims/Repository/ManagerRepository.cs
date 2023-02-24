/***********************************************************************
 * Module:  ManagerService.cs
 * Purpose: Definition of the Class Service.ManagerService
 ***********************************************************************/

using System;

namespace Repository
{
   public class ManagerRepository
   {
      public List<WorkingHour> GetDoctorWorkingHours(Model.ZajednickeKlase.doctor doctor)
      {
         // TODO: implement
         return null;
      }
      
      public List<Appoinment> GetRoomWorkingHours(Model.ZajednickeKlase.Room room)
      {
         // TODO: implement
         return null;
      }
      
      public List<Doctor> GetListOfRegistratedDoctors()
      {
         // TODO: implement
         return null;
      }
      
      public List<Room> GetListOfRenovatedRooms()
      {
         // TODO: implement
         return null;
      }
      
      public Model.Upravnik.MedicineRequest GetMedicineRequest(Model.ZajednickeKlase.Medicine medicine)
      {
         // TODO: implement
         return null;
      }
   
   }
}
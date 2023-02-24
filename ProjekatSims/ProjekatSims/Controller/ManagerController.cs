/***********************************************************************
 * Module:  ManagerService.cs
 * Purpose: Definition of the Class Service.ManagerService
 ***********************************************************************/

using System;

namespace Controller
{
   public class ManagerController
   {
      public Model.Upravnik.MedicalEquipment CreateNewEquipment(Model.Upravnik.MedicalEquipment equipment)
      {
         // TODO: implement
         return null;
      }
      
      public Model.Upravnik.MedicalEquipment ChangeEquipment(Model.Upravnik.MedicalEquipment equipment)
      {
         // TODO: implement
         return null;
      }
      
      public Model.Upravnik.MedicalEquipment DeleteEquipment(Model.Upravnik.MedicalEquipment equipment)
      {
         // TODO: implement
         return null;
      }
      
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
      
      public Model.ZajednickeKlase.Medicine AddNewMedicine(Model.ZajednickeKlase.Medicine medicine)
      {
         // TODO: implement
         return null;
      }
      
      public Model.ZajednickeKlase.Medicine ChangeMedicine(Model.ZajednickeKlase.Medicine medicine)
      {
         // TODO: implement
         return null;
      }
      
      public Model.ZajednickeKlase.Medicine DeleteMedicine(Model.ZajednickeKlase.Medicine medicine)
      {
         // TODO: implement
         return null;
      }
   
      public Service.ManagerService managerService;
      public Service.MedicineService medicineService;
      public Service.MedicalEquiepmentService medicalEquiepmentService;
   
   }
}
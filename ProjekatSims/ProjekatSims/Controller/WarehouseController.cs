/***********************************************************************
 * Module:  WarehouseController.cs
 * Purpose: Definition of the Class Controller.WarehouseController
 ***********************************************************************/

using System;

namespace Controller
{
   public class WarehouseController
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
      
      public Model.ZajednickeKlase.Medicine VerifyMedicine(Model.ZajednickeKlase.Medicine medicine)
      {
         // TODO: implement
         return null;
      }
      
      public System.Array MakeRexcipe(System.Array medicineList)
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
   
      public Service.MedicalEquiepmentService medicalEquiepmentService;
      public Service.MedicineService medicineService;
   
   }
}
/***********************************************************************
 * Module:  Manager.cs
 * Purpose: Definition of the Class Upravnik.Manager
 ***********************************************************************/

using System;

namespace Model.Upravnik
{
   public class Manager : Model.ZajednickeKlase.User
   {
      public Renovate renovate;
      public System.Collections.ArrayList registration;
      
      /// <pdGenerated>default getter</pdGenerated>
      public System.Collections.ArrayList GetRegistration()
      {
         if (registration == null)
            registration = new System.Collections.ArrayList();
         return registration;
      }
      
      /// <pdGenerated>default setter</pdGenerated>
      public void SetRegistration(System.Collections.ArrayList newRegistration)
      {
         RemoveAllRegistration();
         foreach (Registration oRegistration in newRegistration)
            AddRegistration(oRegistration);
      }
      
      /// <pdGenerated>default Add</pdGenerated>
      public void AddRegistration(Registration newRegistration)
      {
         if (newRegistration == null)
            return;
         if (this.registration == null)
            this.registration = new System.Collections.ArrayList();
         if (!this.registration.Contains(newRegistration))
            this.registration.Add(newRegistration);
      }
      
      /// <pdGenerated>default Remove</pdGenerated>
      public void RemoveRegistration(Registration oldRegistration)
      {
         if (oldRegistration == null)
            return;
         if (this.registration != null)
            if (this.registration.Contains(oldRegistration))
               this.registration.Remove(oldRegistration);
      }
      
      /// <pdGenerated>default removeAll</pdGenerated>
      public void RemoveAllRegistration()
      {
         if (registration != null)
            registration.Clear();
      }
      public System.Collections.ArrayList medicineRequest;
      
      /// <pdGenerated>default getter</pdGenerated>
      public System.Collections.ArrayList GetMedicineRequest()
      {
         if (medicineRequest == null)
            medicineRequest = new System.Collections.ArrayList();
         return medicineRequest;
      }
      
      /// <pdGenerated>default setter</pdGenerated>
      public void SetMedicineRequest(System.Collections.ArrayList newMedicineRequest)
      {
         RemoveAllMedicineRequest();
         foreach (MedicineRequest oMedicineRequest in newMedicineRequest)
            AddMedicineRequest(oMedicineRequest);
      }
      
      /// <pdGenerated>default Add</pdGenerated>
      public void AddMedicineRequest(MedicineRequest newMedicineRequest)
      {
         if (newMedicineRequest == null)
            return;
         if (this.medicineRequest == null)
            this.medicineRequest = new System.Collections.ArrayList();
         if (!this.medicineRequest.Contains(newMedicineRequest))
         {
            this.medicineRequest.Add(newMedicineRequest);
            newMedicineRequest.SetManager(this);      
         }
      }
      
      /// <pdGenerated>default Remove</pdGenerated>
      public void RemoveMedicineRequest(MedicineRequest oldMedicineRequest)
      {
         if (oldMedicineRequest == null)
            return;
         if (this.medicineRequest != null)
            if (this.medicineRequest.Contains(oldMedicineRequest))
            {
               this.medicineRequest.Remove(oldMedicineRequest);
               oldMedicineRequest.SetManager((Manager)null);
            }
      }
      
      /// <pdGenerated>default removeAll</pdGenerated>
      public void RemoveAllMedicineRequest()
      {
         if (medicineRequest != null)
         {
            System.Collections.ArrayList tmpMedicineRequest = new System.Collections.ArrayList();
            foreach (MedicineRequest oldMedicineRequest in medicineRequest)
               tmpMedicineRequest.Add(oldMedicineRequest);
            medicineRequest.Clear();
            foreach (MedicineRequest oldMedicineRequest in tmpMedicineRequest)
               oldMedicineRequest.SetManager((Manager)null);
            tmpMedicineRequest.Clear();
         }
      }
      public System.Collections.ArrayList room;
      
      /// <pdGenerated>default getter</pdGenerated>
      public System.Collections.ArrayList GetRoom()
      {
         if (room == null)
            room = new System.Collections.ArrayList();
         return room;
      }
      
      /// <pdGenerated>default setter</pdGenerated>
      public void SetRoom(System.Collections.ArrayList newRoom)
      {
         RemoveAllRoom();
         foreach (Model.ZajednickeKlase.Room oRoom in newRoom)
            AddRoom(oRoom);
      }
      
      /// <pdGenerated>default Add</pdGenerated>
      public void AddRoom(Model.ZajednickeKlase.Room newRoom)
      {
         if (newRoom == null)
            return;
         if (this.room == null)
            this.room = new System.Collections.ArrayList();
         if (!this.room.Contains(newRoom))
            this.room.Add(newRoom);
      }
      
      /// <pdGenerated>default Remove</pdGenerated>
      public void RemoveRoom(Model.ZajednickeKlase.Room oldRoom)
      {
         if (oldRoom == null)
            return;
         if (this.room != null)
            if (this.room.Contains(oldRoom))
               this.room.Remove(oldRoom);
      }
      
      /// <pdGenerated>default removeAll</pdGenerated>
      public void RemoveAllRoom()
      {
         if (room != null)
            room.Clear();
      }
      public System.Collections.ArrayList doctor;
      
      /// <pdGenerated>default getter</pdGenerated>
      public System.Collections.ArrayList GetDoctor()
      {
         if (doctor == null)
            doctor = new System.Collections.ArrayList();
         return doctor;
      }
      
      /// <pdGenerated>default setter</pdGenerated>
      public void SetDoctor(System.Collections.ArrayList newDoctor)
      {
         RemoveAllDoctor();
         foreach (Model.ZajednickeKlase.doctor odoctor in newDoctor)
            AddDoctor(odoctor);
      }
      
      /// <pdGenerated>default Add</pdGenerated>
      public void AddDoctor(Model.ZajednickeKlase.doctor newDoctor)
      {
         if (newDoctor == null)
            return;
         if (this.doctor == null)
            this.doctor = new System.Collections.ArrayList();
         if (!this.doctor.Contains(newDoctor))
            this.doctor.Add(newDoctor);
      }
      
      /// <pdGenerated>default Remove</pdGenerated>
      public void RemoveDoctor(Model.ZajednickeKlase.doctor oldDoctor)
      {
         if (oldDoctor == null)
            return;
         if (this.doctor != null)
            if (this.doctor.Contains(oldDoctor))
               this.doctor.Remove(oldDoctor);
      }
      
      /// <pdGenerated>default removeAll</pdGenerated>
      public void RemoveAllDoctor()
      {
         if (doctor != null)
            doctor.Clear();
      }
   
   }
}
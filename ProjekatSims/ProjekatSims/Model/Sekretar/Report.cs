/***********************************************************************
 * Module:  Izvestaj.cs
 * Purpose: Definition of the Class Sekretar.Izvestaj
 ***********************************************************************/

using System;

namespace Model.Sekretar
{
   public class Report
   {
      public Boolean Create()
      {
         // TODO: implement
         return null;
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
      public Model.ZajednickeKlase.Patient[] patient;
   
      private DateTime StartDate;
      private DateTime EndDate;
   
   }
}
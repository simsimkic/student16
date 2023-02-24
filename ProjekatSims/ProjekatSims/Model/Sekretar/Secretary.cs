/***********************************************************************
 * Module:  Secretary.cs
 * Purpose: Definition of the Class Model.Sekretar.Secretary
 ***********************************************************************/

using System;

namespace Model.Sekretar
{
   public class Secretary : Model.ZajednickeKlase.User
   {
      public System.Collections.ArrayList receivedNotification;
      
      /// <pdGenerated>default getter</pdGenerated>
      public System.Collections.ArrayList GetReceivedNotification()
      {
         if (receivedNotification == null)
            receivedNotification = new System.Collections.ArrayList();
         return receivedNotification;
      }
      
      /// <pdGenerated>default setter</pdGenerated>
      public void SetReceivedNotification(System.Collections.ArrayList newReceivedNotification)
      {
         RemoveAllReceivedNotification();
         foreach (ReceivedNotification oReceivedNotification in newReceivedNotification)
            AddReceivedNotification(oReceivedNotification);
      }
      
      /// <pdGenerated>default Add</pdGenerated>
      public void AddReceivedNotification(ReceivedNotification newReceivedNotification)
      {
         if (newReceivedNotification == null)
            return;
         if (this.receivedNotification == null)
            this.receivedNotification = new System.Collections.ArrayList();
         if (!this.receivedNotification.Contains(newReceivedNotification))
         {
            this.receivedNotification.Add(newReceivedNotification);
            newReceivedNotification.SetSecretary(this);      
         }
      }
      
      /// <pdGenerated>default Remove</pdGenerated>
      public void RemoveReceivedNotification(ReceivedNotification oldReceivedNotification)
      {
         if (oldReceivedNotification == null)
            return;
         if (this.receivedNotification != null)
            if (this.receivedNotification.Contains(oldReceivedNotification))
            {
               this.receivedNotification.Remove(oldReceivedNotification);
               oldReceivedNotification.SetSecretary((Secretary)null);
            }
      }
      
      /// <pdGenerated>default removeAll</pdGenerated>
      public void RemoveAllReceivedNotification()
      {
         if (receivedNotification != null)
         {
            System.Collections.ArrayList tmpReceivedNotification = new System.Collections.ArrayList();
            foreach (ReceivedNotification oldReceivedNotification in receivedNotification)
               tmpReceivedNotification.Add(oldReceivedNotification);
            receivedNotification.Clear();
            foreach (ReceivedNotification oldReceivedNotification in tmpReceivedNotification)
               oldReceivedNotification.SetSecretary((Secretary)null);
            tmpReceivedNotification.Clear();
         }
      }
      public System.Collections.ArrayList sendNotification;
      
      /// <pdGenerated>default getter</pdGenerated>
      public System.Collections.ArrayList GetSendNotification()
      {
         if (sendNotification == null)
            sendNotification = new System.Collections.ArrayList();
         return sendNotification;
      }
      
      /// <pdGenerated>default setter</pdGenerated>
      public void SetSendNotification(System.Collections.ArrayList newSendNotification)
      {
         RemoveAllSendNotification();
         foreach (SendNotification oSendNotification in newSendNotification)
            AddSendNotification(oSendNotification);
      }
      
      /// <pdGenerated>default Add</pdGenerated>
      public void AddSendNotification(SendNotification newSendNotification)
      {
         if (newSendNotification == null)
            return;
         if (this.sendNotification == null)
            this.sendNotification = new System.Collections.ArrayList();
         if (!this.sendNotification.Contains(newSendNotification))
         {
            this.sendNotification.Add(newSendNotification);
            newSendNotification.SetSecretary(this);      
         }
      }
      
      /// <pdGenerated>default Remove</pdGenerated>
      public void RemoveSendNotification(SendNotification oldSendNotification)
      {
         if (oldSendNotification == null)
            return;
         if (this.sendNotification != null)
            if (this.sendNotification.Contains(oldSendNotification))
            {
               this.sendNotification.Remove(oldSendNotification);
               oldSendNotification.SetSecretary((Secretary)null);
            }
      }
      
      /// <pdGenerated>default removeAll</pdGenerated>
      public void RemoveAllSendNotification()
      {
         if (sendNotification != null)
         {
            System.Collections.ArrayList tmpSendNotification = new System.Collections.ArrayList();
            foreach (SendNotification oldSendNotification in sendNotification)
               tmpSendNotification.Add(oldSendNotification);
            sendNotification.Clear();
            foreach (SendNotification oldSendNotification in tmpSendNotification)
               oldSendNotification.SetSecretary((Secretary)null);
            tmpSendNotification.Clear();
         }
      }
      public System.Collections.ArrayList patient;
      
      /// <pdGenerated>default getter</pdGenerated>
      public System.Collections.ArrayList GetPatient()
      {
         if (patient == null)
            patient = new System.Collections.ArrayList();
         return patient;
      }
      
      /// <pdGenerated>default setter</pdGenerated>
      public void SetPatient(System.Collections.ArrayList newPatient)
      {
         RemoveAllPatient();
         foreach (Model.ZajednickeKlase.Patient oPatient in newPatient)
            AddPatient(oPatient);
      }
      
      /// <pdGenerated>default Add</pdGenerated>
      public void AddPatient(Model.ZajednickeKlase.Patient newPatient)
      {
         if (newPatient == null)
            return;
         if (this.patient == null)
            this.patient = new System.Collections.ArrayList();
         if (!this.patient.Contains(newPatient))
            this.patient.Add(newPatient);
      }
      
      /// <pdGenerated>default Remove</pdGenerated>
      public void RemovePatient(Model.ZajednickeKlase.Patient oldPatient)
      {
         if (oldPatient == null)
            return;
         if (this.patient != null)
            if (this.patient.Contains(oldPatient))
               this.patient.Remove(oldPatient);
      }
      
      /// <pdGenerated>default removeAll</pdGenerated>
      public void RemoveAllPatient()
      {
         if (patient != null)
            patient.Clear();
      }
      public System.Collections.ArrayList search;
      
      /// <pdGenerated>default getter</pdGenerated>
      public System.Collections.ArrayList GetSearch()
      {
         if (search == null)
            search = new System.Collections.ArrayList();
         return search;
      }
      
      /// <pdGenerated>default setter</pdGenerated>
      public void SetSearch(System.Collections.ArrayList newSearch)
      {
         RemoveAllSearch();
         foreach (Model.ZajednickeKlase.Search oSearch in newSearch)
            AddSearch(oSearch);
      }
      
      /// <pdGenerated>default Add</pdGenerated>
      public void AddSearch(Model.ZajednickeKlase.Search newSearch)
      {
         if (newSearch == null)
            return;
         if (this.search == null)
            this.search = new System.Collections.ArrayList();
         if (!this.search.Contains(newSearch))
            this.search.Add(newSearch);
      }
      
      /// <pdGenerated>default Remove</pdGenerated>
      public void RemoveSearch(Model.ZajednickeKlase.Search oldSearch)
      {
         if (oldSearch == null)
            return;
         if (this.search != null)
            if (this.search.Contains(oldSearch))
               this.search.Remove(oldSearch);
      }
      
      /// <pdGenerated>default removeAll</pdGenerated>
      public void RemoveAllSearch()
      {
         if (search != null)
            search.Clear();
      }
      public System.Collections.ArrayList report;
      
      /// <pdGenerated>default getter</pdGenerated>
      public System.Collections.ArrayList GetReport()
      {
         if (report == null)
            report = new System.Collections.ArrayList();
         return report;
      }
      
      /// <pdGenerated>default setter</pdGenerated>
      public void SetReport(System.Collections.ArrayList newReport)
      {
         RemoveAllReport();
         foreach (Report oReport in newReport)
            AddReport(oReport);
      }
      
      /// <pdGenerated>default Add</pdGenerated>
      public void AddReport(Report newReport)
      {
         if (newReport == null)
            return;
         if (this.report == null)
            this.report = new System.Collections.ArrayList();
         if (!this.report.Contains(newReport))
            this.report.Add(newReport);
      }
      
      /// <pdGenerated>default Remove</pdGenerated>
      public void RemoveReport(Report oldReport)
      {
         if (oldReport == null)
            return;
         if (this.report != null)
            if (this.report.Contains(oldReport))
               this.report.Remove(oldReport);
      }
      
      /// <pdGenerated>default removeAll</pdGenerated>
      public void RemoveAllReport()
      {
         if (report != null)
            report.Clear();
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
      public GuestUserCreation[] guestUserCreation;
   
   }
}
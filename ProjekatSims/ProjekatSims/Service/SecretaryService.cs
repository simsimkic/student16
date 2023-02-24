/***********************************************************************
 * Module:  SecretaryService.cs
 * Purpose: Definition of the Class Service.SecretaryService
 ***********************************************************************/

using System;

namespace Service
{
   public class SecretaryService
   {
      public Model.ZajednickeKlase.Patient UserCreation(Model.ZajednickeKlase.User newUser)
      {
         // TODO: implement
         return null;
      }
      
      public Boolean DeleteGuestUser(Model.ZajednickeKlase.User user)
      {
         // TODO: implement
         return null;
      }
      
      public Model.Sekretar.Report CreateReport(DateTime startDate, DateTime endDate)
      {
         // TODO: implement
         return null;
      }
      
      public Model.ZajednickeKlase.Appointement ScheduleNewDate(DateTime date, Model.ZajednickeKlase.Patient patient)
      {
         // TODO: implement
         return null;
      }
      
      public Model.ZajednickeKlase.Appointement ChangeScheduledDate(DateTime date, Model.ZajednickeKlase.Patient patient)
      {
         // TODO: implement
         return null;
      }
      
      public Boolean CancelScheduledDate(Model.ZajednickeKlase.Patient patient)
      {
         // TODO: implement
         return null;
      }
   
      public Repository.ReportRepository reportRepository;
      public Repository.PatientRepository patientRepository;
      public System.Collections.ArrayList schedulingService;
      
      /// <pdGenerated>default getter</pdGenerated>
      public System.Collections.ArrayList GetSchedulingService()
      {
         if (schedulingService == null)
            schedulingService = new System.Collections.ArrayList();
         return schedulingService;
      }
      
      /// <pdGenerated>default setter</pdGenerated>
      public void SetSchedulingService(System.Collections.ArrayList newSchedulingService)
      {
         RemoveAllSchedulingService();
         foreach (SchedulingService oSchedulingService in newSchedulingService)
            AddSchedulingService(oSchedulingService);
      }
      
      /// <pdGenerated>default Add</pdGenerated>
      public void AddSchedulingService(SchedulingService newSchedulingService)
      {
         if (newSchedulingService == null)
            return;
         if (this.schedulingService == null)
            this.schedulingService = new System.Collections.ArrayList();
         if (!this.schedulingService.Contains(newSchedulingService))
            this.schedulingService.Add(newSchedulingService);
      }
      
      /// <pdGenerated>default Remove</pdGenerated>
      public void RemoveSchedulingService(SchedulingService oldSchedulingService)
      {
         if (oldSchedulingService == null)
            return;
         if (this.schedulingService != null)
            if (this.schedulingService.Contains(oldSchedulingService))
               this.schedulingService.Remove(oldSchedulingService);
      }
      
      /// <pdGenerated>default removeAll</pdGenerated>
      public void RemoveAllSchedulingService()
      {
         if (schedulingService != null)
            schedulingService.Clear();
      }
   
   }
}
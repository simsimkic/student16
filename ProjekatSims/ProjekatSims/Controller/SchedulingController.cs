/***********************************************************************
 * Module:  SchedulingService.cs
 * Purpose: Definition of the Class Service.SchedulingService
 ***********************************************************************/

using System;

namespace Controller
{
   public class SchedulingController
   {
      public Model.ZajednickeKlase.Appointement ScheduleNewDate(DateTime date, Model.ZajednickeKlase.Patient patient)
      {
         // TODO: implement
         return null;
      }
      
      public Model.ZajednickeKlase.Appointement ChangeDate(DateTime date, Model.ZajednickeKlase.Patient patient)
      {
         // TODO: implement
         return null;
      }
      
      public Boolean CancelScheduledDate(Model.ZajednickeKlase.Patient patient)
      {
         // TODO: implement
         return null;
      }
   
      public Service.SchedulingService schedulingService;
   
   }
}
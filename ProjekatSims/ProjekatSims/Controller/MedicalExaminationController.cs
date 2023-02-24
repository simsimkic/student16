/***********************************************************************
 * Module:  MedicalExaminationService.cs
 * Purpose: Definition of the Class Service.MedicalExaminationService
 ***********************************************************************/

using System;

namespace Controller
{
   public class MedicalExaminationController
   {
      public Model.Lekar.MedicalExamination ScheduleME(Model.Lekar.MedicalExamination medicalExaminatioon)
      {
         // TODO: implement
         return null;
      }
      
      public Model.Lekar.MedicalExamination CancelME(Model.Lekar.MedicalExamination medicalExamination)
      {
         // TODO: implement
         return null;
      }
      
      public Model.Lekar.MedicalExamination ReallocateME(Model.Lekar.MedicalExamination medicalExamination)
      {
         // TODO: implement
         return null;
      }
      
      public Model.Lekar.Treatment ScheduleTreatment(Model.Lekar.Treatment treatment)
      {
         // TODO: implement
         return null;
      }
      
      public Model.Lekar.Surgery ScheduleSurgery()
      {
         // TODO: implement
         return null;
      }
      
      public int CreaetNewMedicalExamination(Model.ZajednickeKlase.Appointement appointment, Model.ZajednickeKlase.doctor doctor)
      {
         // TODO: implement
         return 0;
      }
   
      public Service.MedicalExaminationService medicalExaminationService;
   
   }
}
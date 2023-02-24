/***********************************************************************
 * Module:  MedicalRecord.cs
 * Purpose: Definition of the Class Model.Pacijent.MedicalRecord
 ***********************************************************************/

using System;

namespace Model.Pacijent
{
   public class MedicalRecord
   {
      private int MedRecordNumber;
      
      private System.Collections.ArrayList historyOfDiseases;
      
      /// <pdGenerated>default getter</pdGenerated>
      public System.Collections.ArrayList GetHistoryOfDiseases()
      {
         if (historyOfDiseases == null)
            historyOfDiseases = new System.Collections.ArrayList();
         return historyOfDiseases;
      }
      
      /// <pdGenerated>default setter</pdGenerated>
      public void SetHistoryOfDiseases(System.Collections.ArrayList newHistoryOfDiseases)
      {
         RemoveAllHistoryOfDiseases();
         foreach (Model.Lekar.MedicalExamination oMedicalExamination in newHistoryOfDiseases)
            AddHistoryOfDiseases(oMedicalExamination);
      }
      
      /// <pdGenerated>default Add</pdGenerated>
      public void AddHistoryOfDiseases(Model.Lekar.MedicalExamination newMedicalExamination)
      {
         if (newMedicalExamination == null)
            return;
         if (this.historyOfDiseases == null)
            this.historyOfDiseases = new System.Collections.ArrayList();
         if (!this.historyOfDiseases.Contains(newMedicalExamination))
            this.historyOfDiseases.Add(newMedicalExamination);
      }
      
      /// <pdGenerated>default Remove</pdGenerated>
      public void RemoveHistoryOfDiseases(Model.Lekar.MedicalExamination oldMedicalExamination)
      {
         if (oldMedicalExamination == null)
            return;
         if (this.historyOfDiseases != null)
            if (this.historyOfDiseases.Contains(oldMedicalExamination))
               this.historyOfDiseases.Remove(oldMedicalExamination);
      }
      
      /// <pdGenerated>default removeAll</pdGenerated>
      public void RemoveAllHistoryOfDiseases()
      {
         if (historyOfDiseases != null)
            historyOfDiseases.Clear();
      }
   
   }
}
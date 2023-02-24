/***********************************************************************
 * Module:  MedicineRequest.cs
 * Purpose: Definition of the Class Upravnik.MedicineRequest
 ***********************************************************************/

using System;

namespace Model.Upravnik
{
   public class MedicineRequest : Model.ZajednickeKlase.Medicine
   {
      public Manager manager;
      
      /// <pdGenerated>default parent getter</pdGenerated>
      public Manager GetManager()
      {
         return manager;
      }
      
      /// <pdGenerated>default parent setter</pdGenerated>
      /// <param>newManager</param>
      public void SetManager(Manager newManager)
      {
         if (this.manager != newManager)
         {
            if (this.manager != null)
            {
               Manager oldManager = this.manager;
               this.manager = null;
               oldManager.RemoveMedicineRequest(this);
            }
            if (newManager != null)
            {
               this.manager = newManager;
               this.manager.AddMedicineRequest(this);
            }
         }
      }
   
      private State State;
   
   }
}
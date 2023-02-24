/***********************************************************************
 * Module:  Surgery.cs
 * Purpose: Definition of the Class Model.Lekar.Surgery
 ***********************************************************************/

using System;

namespace Model.Lekar
{
   public class Surgery
   {
      public System.Collections.ArrayList appointement;
      
      /// <pdGenerated>default getter</pdGenerated>
      public System.Collections.ArrayList GetAppointement()
      {
         if (appointement == null)
            appointement = new System.Collections.ArrayList();
         return appointement;
      }
      
      /// <pdGenerated>default setter</pdGenerated>
      public void SetAppointement(System.Collections.ArrayList newAppointement)
      {
         RemoveAllAppointement();
         foreach (Model.ZajednickeKlase.Appointement oAppointement in newAppointement)
            AddAppointement(oAppointement);
      }
      
      /// <pdGenerated>default Add</pdGenerated>
      public void AddAppointement(Model.ZajednickeKlase.Appointement newAppointement)
      {
         if (newAppointement == null)
            return;
         if (this.appointement == null)
            this.appointement = new System.Collections.ArrayList();
         if (!this.appointement.Contains(newAppointement))
            this.appointement.Add(newAppointement);
      }
      
      /// <pdGenerated>default Remove</pdGenerated>
      public void RemoveAppointement(Model.ZajednickeKlase.Appointement oldAppointement)
      {
         if (oldAppointement == null)
            return;
         if (this.appointement != null)
            if (this.appointement.Contains(oldAppointement))
               this.appointement.Remove(oldAppointement);
      }
      
      /// <pdGenerated>default removeAll</pdGenerated>
      public void RemoveAllAppointement()
      {
         if (appointement != null)
            appointement.Clear();
      }
      public Model.ZajednickeKlase.Room[] room;
   
      private String Name;
      private UrgencyLevel UrgencyLevel;
   
   }
}
/***********************************************************************
 * Module:  Treatment.cs
 * Purpose: Definition of the Class Model.Lekar.Treatment
 ***********************************************************************/

using System;

namespace Model.Lekar
{
   public class Treatment
   {
      public System.Collections.ArrayList inUse;
      
      /// <pdGenerated>default getter</pdGenerated>
      public System.Collections.ArrayList GetInUse()
      {
         if (inUse == null)
            inUse = new System.Collections.ArrayList();
         return inUse;
      }
      
      /// <pdGenerated>default setter</pdGenerated>
      public void SetInUse(System.Collections.ArrayList newInUse)
      {
         RemoveAllInUse();
         foreach (InUse oInUse in newInUse)
            AddInUse(oInUse);
      }
      
      /// <pdGenerated>default Add</pdGenerated>
      public void AddInUse(InUse newInUse)
      {
         if (newInUse == null)
            return;
         if (this.inUse == null)
            this.inUse = new System.Collections.ArrayList();
         if (!this.inUse.Contains(newInUse))
            this.inUse.Add(newInUse);
      }
      
      /// <pdGenerated>default Remove</pdGenerated>
      public void RemoveInUse(InUse oldInUse)
      {
         if (oldInUse == null)
            return;
         if (this.inUse != null)
            if (this.inUse.Contains(oldInUse))
               this.inUse.Remove(oldInUse);
      }
      
      /// <pdGenerated>default removeAll</pdGenerated>
      public void RemoveAllInUse()
      {
         if (inUse != null)
            inUse.Clear();
      }
      public Model.ZajednickeKlase.Appointement appointement;
      public Model.ZajednickeKlase.Room room;
   
      private String Name;
   
   }
}
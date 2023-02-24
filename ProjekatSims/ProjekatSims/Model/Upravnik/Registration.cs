/***********************************************************************
 * Module:  Registration.cs
 * Purpose: Definition of the Class Upravnik.Registration
 ***********************************************************************/

using System;

namespace Model.Upravnik
{
   public class Registration
   {
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
   
      private DateTime TimeOfRegistration;
   
   }
}
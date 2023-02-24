/***********************************************************************
 * Module:  MedicalExamination.cs
 * Purpose: Definition of the Class Model.Lekar.MedicalExamination
 ***********************************************************************/

using System;

namespace Model.Lekar
{
   public class MedicalExamination
   {
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
      public System.Collections.ArrayList treatment;
      
      /// <pdGenerated>default getter</pdGenerated>
      public System.Collections.ArrayList GetTreatment()
      {
         if (treatment == null)
            treatment = new System.Collections.ArrayList();
         return treatment;
      }
      
      /// <pdGenerated>default setter</pdGenerated>
      public void SetTreatment(System.Collections.ArrayList newTreatment)
      {
         RemoveAllTreatment();
         foreach (Treatment oTreatment in newTreatment)
            AddTreatment(oTreatment);
      }
      
      /// <pdGenerated>default Add</pdGenerated>
      public void AddTreatment(Treatment newTreatment)
      {
         if (newTreatment == null)
            return;
         if (this.treatment == null)
            this.treatment = new System.Collections.ArrayList();
         if (!this.treatment.Contains(newTreatment))
            this.treatment.Add(newTreatment);
      }
      
      /// <pdGenerated>default Remove</pdGenerated>
      public void RemoveTreatment(Treatment oldTreatment)
      {
         if (oldTreatment == null)
            return;
         if (this.treatment != null)
            if (this.treatment.Contains(oldTreatment))
               this.treatment.Remove(oldTreatment);
      }
      
      /// <pdGenerated>default removeAll</pdGenerated>
      public void RemoveAllTreatment()
      {
         if (treatment != null)
            treatment.Clear();
      }
      public System.Collections.ArrayList recipe;
      
      /// <pdGenerated>default getter</pdGenerated>
      public System.Collections.ArrayList GetRecipe()
      {
         if (recipe == null)
            recipe = new System.Collections.ArrayList();
         return recipe;
      }
      
      /// <pdGenerated>default setter</pdGenerated>
      public void SetRecipe(System.Collections.ArrayList newRecipe)
      {
         RemoveAllRecipe();
         foreach (Recipe oRecipe in newRecipe)
            AddRecipe(oRecipe);
      }
      
      /// <pdGenerated>default Add</pdGenerated>
      public void AddRecipe(Recipe newRecipe)
      {
         if (newRecipe == null)
            return;
         if (this.recipe == null)
            this.recipe = new System.Collections.ArrayList();
         if (!this.recipe.Contains(newRecipe))
            this.recipe.Add(newRecipe);
      }
      
      /// <pdGenerated>default Remove</pdGenerated>
      public void RemoveRecipe(Recipe oldRecipe)
      {
         if (oldRecipe == null)
            return;
         if (this.recipe != null)
            if (this.recipe.Contains(oldRecipe))
               this.recipe.Remove(oldRecipe);
      }
      
      /// <pdGenerated>default removeAll</pdGenerated>
      public void RemoveAllRecipe()
      {
         if (recipe != null)
            recipe.Clear();
      }
   
      private String Diagnose;
   
   }
}
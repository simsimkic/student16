// File:    Lek.cs
// Created: Saturday, 18 April 2020 22:33:11
// Purpose: Definition of Class Lek

using System;

namespace Model.ZajednickeKlase
{
   public class Medicine
   {
      public System.Collections.ArrayList ingredient;
      
      /// <pdGenerated>default getter</pdGenerated>
      public System.Collections.ArrayList GetIngredient()
      {
         if (ingredient == null)
            ingredient = new System.Collections.ArrayList();
         return ingredient;
      }
      
      /// <pdGenerated>default setter</pdGenerated>
      public void SetIngredient(System.Collections.ArrayList newIngredient)
      {
         RemoveAllIngredient();
         foreach (Ingredient oIngredient in newIngredient)
            AddIngredient(oIngredient);
      }
      
      /// <pdGenerated>default Add</pdGenerated>
      public void AddIngredient(Ingredient newIngredient)
      {
         if (newIngredient == null)
            return;
         if (this.ingredient == null)
            this.ingredient = new System.Collections.ArrayList();
         if (!this.ingredient.Contains(newIngredient))
            this.ingredient.Add(newIngredient);
      }
      
      /// <pdGenerated>default Remove</pdGenerated>
      public void RemoveIngredient(Ingredient oldIngredient)
      {
         if (oldIngredient == null)
            return;
         if (this.ingredient != null)
            if (this.ingredient.Contains(oldIngredient))
               this.ingredient.Remove(oldIngredient);
      }
      
      /// <pdGenerated>default removeAll</pdGenerated>
      public void RemoveAllIngredient()
      {
         if (ingredient != null)
            ingredient.Clear();
      }
   
      protected internal String name;
   
      protected String Id;
      protected String manufacturer;
      protected DateTime expirationDate;
      protected double Quantity;
      protected Boolean Approved;
   
   }
}
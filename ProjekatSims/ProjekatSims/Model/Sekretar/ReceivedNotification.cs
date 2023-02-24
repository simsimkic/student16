/***********************************************************************
 * Module:  ReceivedNotification.cs
 * Purpose: Definition of the Class Sekretar.ReceivedNotification
 ***********************************************************************/

using System;

namespace Model.Sekretar
{
   public class ReceivedNotification
   {
      public Secretary secretary;
      
      /// <pdGenerated>default parent getter</pdGenerated>
      public Secretary GetSecretary()
      {
         return secretary;
      }
      
      /// <pdGenerated>default parent setter</pdGenerated>
      /// <param>newSecretary</param>
      public void SetSecretary(Secretary newSecretary)
      {
         if (this.secretary != newSecretary)
         {
            if (this.secretary != null)
            {
               Secretary oldSecretary = this.secretary;
               this.secretary = null;
               oldSecretary.RemoveReceivedNotification(this);
            }
            if (newSecretary != null)
            {
               this.secretary = newSecretary;
               this.secretary.AddReceivedNotification(this);
            }
         }
      }
   
      private Pacient Sender;
      private String Text;
      private DateTime Date;
      private Boolean SawNotification;
   
   }
}
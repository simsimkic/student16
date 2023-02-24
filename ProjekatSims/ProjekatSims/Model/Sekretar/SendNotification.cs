/***********************************************************************
 * Module:  SendNotification.cs
 * Purpose: Definition of the Class Sekretar.SendNotification
 ***********************************************************************/

using System;

namespace Model.Sekretar
{
   public class SendNotification
   {
      public Boolean Send()
      {
         // TODO: implement
         return null;
      }
   
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
               oldSecretary.RemoveSendNotification(this);
            }
            if (newSecretary != null)
            {
               this.secretary = newSecretary;
               this.secretary.AddSendNotification(this);
            }
         }
      }
   
      private Pacient Recipient;
      private String Text;
   
   }
}
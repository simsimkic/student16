/***********************************************************************
 * Module:  NotificationService.cs
 * Purpose: Definition of the Class Service.NotificationService
 ***********************************************************************/

using System;

namespace Service
{
   public class NotificationService
   {
      public Boolean SendNotification(Model.Sekretar.SendNotification notification)
      {
         // TODO: implement
         return null;
      }
      
      public Model.Sekretar.ReceivedNotification SeeNotifications()
      {
         // TODO: implement
         return null;
      }
      
      public Boolean IsRecipientValid(Model.ZajednickeKlase.User recipient)
      {
         // TODO: implement
         return null;
      }
   
      public Repository.NotificationRepository notificationRepository;
      public Repository.UserRepository userRepository;
   
   }
}
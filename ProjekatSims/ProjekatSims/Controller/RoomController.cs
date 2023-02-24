/***********************************************************************
 * Module:  RoomService.cs
 * Purpose: Definition of the Class Service.RoomService
 ***********************************************************************/

using System;

namespace Controller
{
   public class RoomController
    {
        private readonly RoomService service;

        public RoomController(RoomService service)
        {
            this.service = service;
        }

        public IEnumerable<Room> GetAll() => service.GetAll();

        public Room Get(string id) => service.Get(id);

        public Room Create(Room room) => service.Create(room);

        public void Delete(Room room) => service.Delete(room);

        public void WriteIn(List<Room> rooms) => service.WriteIn(rooms);
    }
}
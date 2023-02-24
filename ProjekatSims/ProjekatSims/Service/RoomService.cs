/***********************************************************************
 * Module:  RoomService.cs
 * Purpose: Definition of the Class Service.RoomService
 ***********************************************************************/

using System;

namespace Service
{
   public class RoomService
    {
        private readonly RoomRepository repository;

        public RoomService(RoomRepository repository)
        {
            this.repository = repository;
        }

        public IEnumerable<Room> GetAll()
        {
            var rooms = repository.GetAll();
            return rooms;
        }

        public Room Get(string id)
        {
            var room = repository.Get(id);
            return room;
        }

        public Room Create(Room room)
        {
            //SetMissingValues(user);
            Room newRoom = repository.Create(room);
            newRoom.Id = room.Id;
            newRoom.TypeOfRoom = room.TypeOfRoom;
            newRoom.Busy = room.Busy;

            return newRoom;
        }

        public void Delete(Room room)
        {
            repository.Delete(room);
        }

        public void WriteIn(List<Room> rooms)
        {
            repository.WriteIn(rooms);
        }

    }
}
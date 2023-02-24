/***********************************************************************
 * Module:  Room.cs
 * Purpose: Definition of the Class Sekretar.Room
 ***********************************************************************/

using System;

namespace Model.ZajednickeKlase
{
   public class Room
    {
        public enum RoomType
        {
            Ordination,
            OperationRoom
        }

        private String _id;
        private RoomType _typeOfRoom;
        private Boolean _busy = false;

        public Room(String id, RoomType typeOfRoom, Boolean busy)
        {
            _id = id;
            _typeOfRoom = typeOfRoom;
            _busy = busy;
        }

        public Room() { }

        public String Id
        {
            get
            {
                return _id;
            }
            set
            {
                if (value != _id)
                {
                    _id = value;
                }
            }
        }

        public RoomType TypeOfRoom
        {
            get
            {
                return _typeOfRoom;
            }
            set
            {
                if (value != _typeOfRoom)
                {
                    _typeOfRoom = value;
                }
            }
        }

        public Boolean Busy
        {
            get
            {
                return _busy;
            }
            set
            {
                if (value != _busy)
                {
                    _busy = value;
                }
            }
        }
    }
}
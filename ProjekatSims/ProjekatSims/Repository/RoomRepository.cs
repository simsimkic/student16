using System;

namespace Repository
{
   public class RoomRepository
    {
        private readonly string _path;
        private readonly string _delimiter;

        public RoomRepository(string path, string delimiter)
        {
            _path = path;
            _delimiter = delimiter;
        }

        public IEnumerable<Room> GetAll() => ReadAll();

        public Room Get(string id)
        {
            try
            {
                return ReadAll().SingleOrDefault(rm => rm.Id == id);
            }
            catch (ArgumentException)
            {
                Console.WriteLine("User dont exist -> Get");
                return null;
            }
        }

        private string ConvertEntityToCSVFormat(Room room)
            => string.Join(_delimiter,
                room.Id,
                room.TypeOfRoom,
                room.Busy);

        public Room Create(Room room)
        {
            AppendLineToFile(ConvertEntityToCSVFormat(room));
            return room;
        }

        public void Delete(Room room)
        {
            var rooms = ReadAll().ToList();
            var roomToRemove = rooms.SingleOrDefault(rm => rm.Id == room.Id);
            if (roomToRemove != null)
            {
                rooms.Remove(roomToRemove);
                SaveAll(rooms);
            }
            else
            {
                Console.WriteLine("Room dont exist -> Delete");
            }
        }

        private Room ConvertCSVFormatToEntity(string roomCSVFormat)
        {
            string[] tokens = roomCSVFormat.Split(_delimiter.ToCharArray());
            return new Room(
                tokens[0],
                (Room.RoomType)Enum.Parse(typeof(Room.RoomType), tokens[1]),
                Boolean.Parse(tokens[2]));

        }

        public void WriteIn(List<Room> rooms)
        {
            rooms.ToList();
            SaveAll(rooms);
        }

        private IEnumerable<Room> ReadAll()
            => File.ReadAllLines(_path).Select(ConvertCSVFormatToEntity).ToList();

        private void SaveAll(IEnumerable<Room> rooms)
        => WriteAllLinesToFile(
            rooms.Select(ConvertEntityToCSVFormat).ToList());

        private void AppendLineToFile(string line)
            => File.AppendAllText(_path, line + Environment.NewLine);

        private void WriteAllLinesToFile(IEnumerable<string> content)
            => File.WriteAllLines(_path, content.ToArray());
    }
}
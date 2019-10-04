using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelProject
{

    abstract class Room {
        protected int ID;
        protected double Price;
        public int Bed;
        public bool IsBooked;

        public Room(int id)
        {
            ID = id;
            IsBooked = false;
        }
    }

    class SingleRoom : Room {
        public SingleRoom(int id) : base(id)
        {
            Bed = 1;
            Price = 100;
        }
    }

    class DoubleRoom : Room {
        public DoubleRoom(int id) : base(id)
        {
            Bed = 2;
            Price = 150;
        }
    }

    class Hotel {
        List<Room> Rooms;
        List<Reservation> Reservations;

        public Hotel()
        {
            Rooms = new List<Room>();
            Reservations = new List<Reservation>();
        }

        public void AddSingleRoom(int id)
        {
            Rooms.Add(new SingleRoom(id));
        }

        public void AddDoubleRoom(int id)
        {
            Rooms.Add(new DoubleRoom(id));
        }

        public List<Room> SearchSingleRoom(int numberOfRoom) {
            List<Room> result = new List<Room>();
            
            int count = 0;
            int numberOfRoomFound = 0;

            while (count < Rooms.Count && numberOfRoomFound <= numberOfRoom)
            {
                if (Rooms[count].Bed == 1 && Rooms[count].IsBooked)
                {
                    result.Add(Rooms[count]);
                    numberOfRoom++;
                }
                else count++;
            }

            return result;
        }

        public List<Room> SearchDoubleRoom(int numberOfRoom)
        {
            List<Room> result = new List<Room>();

            int count = 0;
            int numberOfRoomFound = 0;

            while (count < Rooms.Count && numberOfRoomFound <= numberOfRoom)
            {
                if (Rooms[count].Bed == 2 && Rooms[count].IsBooked)
                {
                    result.Add(Rooms[count]);
                    numberOfRoom++;
                }
                else count++;
            }

            return result;
        }

        public Reservation Reserve(Guest guest, Room room)
        {
            Reservation reservation = new Reservation(guest, room);
            Reservations.Add(reservation);
            return reservation;
        }
    }

    class Guest {
        string Name;
        int Age;

        public Guest(string name, int age)
        {
            Name = name;
            Age = age;
        }
    }

    class Reservation {
        Guest Guest;
        Room Room;

        public Reservation(Guest guest, Room room)
        {
            Guest = guest;
            Room = room;
        }
    }

    class Program

 

    {
        public void Search(int numberOfSingleRoom, Hotel hotel)
        {
            foreach (var room in hotel.SearchSingleRoom(numberOfSingleRoom))
            {
                Console.WriteLine(room.ToString());
            }
        }

        public void Reserve()
        {
            // To be Implemented
        }

        static void Main(string[] args)
        {
            Hotel myHotel = new Hotel();
            myHotel.AddDoubleRoom(1);
            myHotel.AddDoubleRoom(2);
            myHotel.AddSingleRoom(3);
            myHotel.AddSingleRoom(4);

            Guest myGuest = new Guest("Xuan Toan", 23);

        }
    }
}

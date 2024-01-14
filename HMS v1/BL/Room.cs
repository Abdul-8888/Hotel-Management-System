using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMS_v1.BL
{
    public class Room
    {
        private int roomId;
        private int roomNo;
        private int costPerHour;
        private string availability;
        private string type;

        public int RoomId { get => roomId; set => roomId = value; }
        public int RoomNo { get => roomNo; set => roomNo = value; }
        public int CostPerHour { get => costPerHour; set => costPerHour = value; }
        public string Availability { get => availability; set => availability = value; }
        public string Type { get => type; set => type = value; }
    
        public Room(int roomId, int roomNo, int costPerHour, string availability, string type)
        {
            RoomId = roomId;
            RoomNo = roomNo;
            CostPerHour = costPerHour;
            Availability = availability;
            Type = type;
        }

        public Room(int roomNo, int costPerHour, string availability, string type)
        {
            RoomNo = roomNo;
            CostPerHour = costPerHour;
            Availability = availability;
            Type = type;
        }
    }
}

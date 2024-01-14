using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMS_v1.BL
{
    public class Notification
    {
        private int notificationId;
        private string category;
        private int from;
        private int to;
        private string description;

        public string Category { get => category; set => category = value; }
        public string Description { get => description; set => description = value; }
        public int From { get => from; set => from = value; }
        public int To { get => to; set => to = value; }
        public int NotificationId { get => notificationId; set => notificationId = value; }

        public Notification(int notificationId, string category, int from, int to)
        {
            NotificationId = notificationId;
            Category = category;
            From = from;
            To = to;
            Description = "";
        }


        public Notification(string category, int from, int to)
        {
            Category = category;
            From = from;
            To = to;
            Description = "";
        }

        public Notification(int notificationId, string category, string desctiption, int from, int to)
        {
            NotificationId = notificationId;
            Category = category;
            Description = desctiption;
            From = from;
            To = to;
        }

        public Notification(string category, string desctiption, int from, int to)
        {
            Category = category;
            Description = desctiption;
            From = from;
            To = to;
        }
    }
}

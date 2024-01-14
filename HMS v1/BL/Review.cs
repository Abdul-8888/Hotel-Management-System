using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMS_v1.BL
{
    public class Review
    {
        private int reviewId;
        private int customerId;
        private string comment;
        private DateTime date;
        private int rating;

        public int ReviewId { get => reviewId; set => reviewId = value; }
        public int CustomerId { get => customerId; set => customerId = value; }
        public string Comment { get => comment; set => comment = value; }
        public int Rating { get => rating; set => rating = value; }
        public DateTime Date { get => date; set => date = value; }

        public Review(int reviewId, int customerId, string comment, int rating, DateTime date)
        {
            ReviewId = reviewId;
            CustomerId = customerId;
            Comment = comment;
            Rating = rating;
            Date = date;
        }

        public Review(int customerId, string comment, int rating, DateTime date)
        {
            CustomerId = customerId;
            Comment = comment;
            Rating = rating;
            Date = date;
        }
    }
}

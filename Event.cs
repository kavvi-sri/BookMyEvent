using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BookMyEvent.Models
{
    public class Event
    {
        private long event_id;
        private string name;
        private string venue;
        private string location;
        private DateTime start_date;
        private DateTime end_date;
        private double price;
        private string description;

        public long Event_id { get => event_id; set => event_id = value; }
        public string Name { get => name; set => name = value; }
        public string Venue { get => venue; set => venue = value; }
        public string Location { get => location; set => location = value; }
        public DateTime Start_date { get => start_date; set => start_date = value; }
        public DateTime End_date { get => end_date; set => end_date = value; }
        public double Price { get => price; set => price = value; }
        public string Description { get => description; set => description = value; }
    }
}
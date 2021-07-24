using BookMyEvent.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace BookMyEvent.Repository
{
    public class EventRepositoryImpl : IEventRepository
    {
        SqlConnection con = null;
        public Event CreateEvent(Event Event)
        {
            try
            {
                string connectionString = ConfigurationManager.ConnectionStrings["DBConnection"].ConnectionString;
                con = new SqlConnection(connectionString);
                con.Open();
                //SqlCommand is a class
                SqlCommand cmd = new SqlCommand("INSERT INTO BME_TBL_EVENTS values('" + Event.Name + "','" + Event.Venue + "','" + Event.Location + "'," +
                    "'" + Event.Start_date + "','" + Event.End_date + "','" + Event.Price + "','" + Event.Description + "')", con);
                cmd.ExecuteNonQuery();
                return Event;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            con.Close();
            return Event;
        }

        public string DeleteEvent(long event_id)
        {
            try
            {
                string connectionString = ConfigurationManager.ConnectionStrings["DBConnection"].ConnectionString;
                con = new SqlConnection(connectionString);
                con.Open();
                SqlCommand cmd = new SqlCommand("Delete  from BME_TBL_EVENTS WHERE event_id=" + event_id, con);

                SqlDataReader sdr = cmd.ExecuteReader();
                return " Deleted Sucessfully:" + event_id;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return null;
        }
    

        public List<Event> GetAllEvents()
        {
            List<Event> eventsList = new List<Event>();
            try
            {
                Event theEvent = new Event();
                string connectionString = ConfigurationManager.ConnectionStrings["DBConnection"].ConnectionString;
                con = new SqlConnection(connectionString);
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM BME_TBL_EVENTS", con);
                SqlDataReader sdr = cmd.ExecuteReader();
                while (sdr.Read())
                {
                    theEvent = new Event();
                    theEvent.Event_id = Convert.ToInt32(sdr["event_id"]);
                    theEvent.Name = Convert.ToString(sdr["Name"]);
                    theEvent.Venue = Convert.ToString(sdr["Venue"]);
                    theEvent.Location = Convert.ToString(sdr["Location"]);
                    theEvent.Start_date = Convert.ToDateTime(sdr["Start_date"]);
                    theEvent.End_date = Convert.ToDateTime(sdr["End_date"]);
                    theEvent.Price = Convert.ToInt32(sdr["Price"]);
                    theEvent.Description = Convert.ToString(sdr["Description"]);
                    eventsList.Add(theEvent);

                }

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return eventsList;
        }

        public Event GetEventBtId(long event_id)
        {
           try
            {
                Event theEvent = new Event();
                string connectionString = ConfigurationManager.ConnectionStrings["DBConnection"].ConnectionString;
                con = new SqlConnection(connectionString);

                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM BME_TBL_EVENTS WHERE event_id = '" + event_id+"'", con);
                SqlDataReader sdr = cmd.ExecuteReader();
                if (sdr.Read())
                {
                    theEvent = new Event();
                    theEvent.Event_id = Convert.ToInt64(sdr["event_id"]);
                    theEvent.Name = Convert.ToString(sdr["Name"]);
                    theEvent.Venue = Convert.ToString(sdr["Venue"]);
                    theEvent.Location = Convert.ToString(sdr["Location"]);
                    theEvent.Start_date = Convert.ToDateTime(sdr["Start_date"]);
                    theEvent.End_date = Convert.ToDateTime(sdr["End_date"]);
                    theEvent.Price = Convert.ToDouble(sdr["Price"]);
                    theEvent.Description = Convert.ToString(sdr["Description"]);
                    return theEvent;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return null;
        }

            public Event UpdateEvent(long event_id, Event theEvent)
                {
            try
            {

                string connectionString = ConfigurationManager.ConnectionStrings["DBConnection"].ConnectionString;
                con = new SqlConnection(connectionString);
                con.Open();
                SqlCommand cmd = new SqlCommand("Update BME_TBL_EVENTS  SET  Name = '" + theEvent.Name + "', Venue = '" + theEvent.Venue + "', Location = '" + theEvent.Location + "', Start_date = '" + theEvent.Start_date + "', End_date = '" + theEvent.End_date + "',  Price = '" + theEvent.Price + "', Description = '" + theEvent.Description+"' WHERE event_id =" + event_id, con);



                SqlDataReader sdr = cmd.ExecuteReader();
                return theEvent;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return null;
        }

            }
} 
using BookMyEvent.Models;
using BookMyEvent.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace BookMyEvent.Controllers
{
    public class EventController : ApiController
    {
        private EventService EventService;
        public EventController()
        {
            EventService = new EventService();
        }

        [HttpPost]
        [Route("api/Event/save")]
        public Event CreateEvent([FromBody] Event Event)
        {

            try
            {
                return EventService.CreateEvent(Event);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return Event;
        }
        [HttpGet]
        [Route("api/Event/GetAll")]
        public List<Event> GetAllEvents()
        {
            try
            {
                return EventService.GetAllEvents();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return null;
        }
        [HttpGet]
        [Route("api/Event/GetEventById/{event_id}")]
        public Event GetEventBtId(long event_id)
        {
            try
            {
                return EventService.GetEventBtId(event_id);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return EventService.GetEventBtId(event_id);
        }
        [HttpPut]
        [Route("api/Event/update/{event_id}")]
        public Event UpdateEvent(long event_id, Event theEvent)
        {
            try
            {
                return EventService.UpdateEvent(event_id, theEvent);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return null;
        }
        [HttpDelete]
        [Route("api/Event/DeleteById/{event_id}")]
        public string DeleteEvent(long event_id)
        {
            try
            {
                return EventService.DeleteEvent(event_id);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return null;
        }
    }
}

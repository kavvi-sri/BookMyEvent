using BookMyEvent.Models;
using BookMyEvent.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BookMyEvent.Service
{
    public class EventService
    {
        private EventRepositoryImpl EventRepositoryImpl;
        public EventService()
        {
            EventRepositoryImpl = new EventRepositoryImpl();
        }
        public Event CreateEvent(Event Event)
        {

            return EventRepositoryImpl.CreateEvent(Event);
        }
        public List<Event> GetAllEvents()
        {
            return EventRepositoryImpl.GetAllEvents();
        }
        public Event GetEventBtId(long event_id)
        {
            return EventRepositoryImpl.GetEventBtId(event_id);
        }
        public Event UpdateEvent(long event_id, Event theEvent)
        {
            return EventRepositoryImpl.UpdateEvent(event_id, theEvent);
        }
        public string DeleteEvent(long event_id)
        {
            return EventRepositoryImpl.DeleteEvent(event_id);
        }
    }
}
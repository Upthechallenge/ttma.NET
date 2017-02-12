
using data.Infrastructure;
using domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace service
{
    public interface IEventService
    {
        void addHEvent(evenement p);
        void deleteEvent(int  id);

        void deleteEventById(int id);
        List<evenement> getAllEvents();

        evenement getEventById(int i);
        void update(int ID_event);
        int countEvents();

    }
    public class EventService : IEventService
    {
        static DatabaseFactory dbFactory = new DatabaseFactory();
        IUnitOfWork ut = new UnitOfWork(dbFactory);
        public void addEvent(evenement p)
        {
            ut.EventRepository.Add(p);
            ut.commit();
        }

        public void addHEvent(evenement p)
        {
            throw new NotImplementedException();
        }

        public int countEvents()
        {
            return ut.EventRepository.count();
        }
        public void deleteEvent(int id)
        {

            ut.EventRepository.Delete(ut.EventRepository.GetById(id));
           
            ut.commit();
        }

        public void deleteEventById(int id)
        {
            evenement p = ut.EventRepository.GetById(id);
            ut.EventRepository.Delete(p);
            ut.commit();
        }

        public List<evenement> getAllEvents()
        {
            return ut.EventRepository.GetAll().ToList();
        }

        public evenement getEventById(int i)
        {
            return ut.EventRepository.GetById(i);
        }

        public void update(int ID_event)
        {
            evenement p = ut.EventRepository.GetById(ID_event);
            ut.EventRepository.Update(p);
            ut.commit();
        }
      
    }
}

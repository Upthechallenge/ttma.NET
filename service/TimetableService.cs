
using data.Infrastructure;
using domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace service
{
    public interface ITimetableService
    {
        void addTimetable(timetable p);
        void deleteTimetable(timetable p);

        void deleteTimetableById(int id);
        List<timetable> getAllTimetable();

        timetable getTimetableById(int i);
        void update(int id);
        int countTimetable();

    }
    public class TimetableService : ITimetableService
    {
        static DatabaseFactory dbFactory = new DatabaseFactory();
        IUnitOfWork ut = new UnitOfWork(dbFactory);
        public void addTimetable(timetable p)
        {
            ut.TimetableRepository.Add(p);
            ut.commit();
        }
        public int countTimetable()
        {
            return ut.TimetableRepository.count();
        }
        public void deleteTimetable(timetable p)
        {

            ut.TimetableRepository.Delete(p);
            ut.commit();
        }

        public void deleteTimetableById(int id)
        {
            timetable p = ut.TimetableRepository.GetById(id);
            ut.TimetableRepository.Delete(p);
            ut.commit();
        }

        public List<timetable> getAllTimetable()
        {
            return ut.TimetableRepository.GetAll().ToList();
        }
        

        public timetable getTimetableById(int i)
        {
            return ut.TimetableRepository.GetById(i);
        }

        public void update(int id)
        {
            timetable p = ut.TimetableRepository.GetById(id);
            ut.TimetableRepository.Update(p);
            ut.commit();
        }
    }
}

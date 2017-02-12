
using data.Infrastructure;
using domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace service
{
    public interface IDoctorDispService
    {
        void adddisp(doctordisponibility p);
        void deletedisp(doctordisponibility p);

        void deletedispById(int id);
        List<doctordisponibility> getAlldisps();

        doctordisponibility getdispById(int i);
        void update(int id);
        int countdisps();

    }
    public class DoctorDispService : IDoctorDispService
    {
        static DatabaseFactory dbFactory = new DatabaseFactory();
        IUnitOfWork ut = new UnitOfWork(dbFactory);
        public void adddisp(doctordisponibility p)
        {
            ut.DoctordispRepository.Add(p);
            ut.commit();
        }
        public int countdisps()
        {
            return ut.DoctordispRepository.count();
        }
        public void deletedisp(doctordisponibility p)
        {

            ut.DoctordispRepository.Delete(p);
            ut.commit();
        }

        public void deletedispById(int id)
        {
            doctordisponibility p = ut.DoctordispRepository.GetById(id);
            ut.DoctordispRepository.Delete(p);
            ut.commit();
        }

        public List<doctordisponibility> getAlldisps()
        {
            return ut.DoctordispRepository.GetAll().ToList();
        }

        public doctordisponibility getdispById(int i)
        {
            return ut.DoctordispRepository.GetById(i);
        }

        public void update(int id)
        {
            doctordisponibility p = ut.DoctordispRepository.GetById(id);
            ut.DoctordispRepository.Update(p);
            ut.commit();
        }
        public IEnumerable<doctordisponibility> Recherche(string date_disp, string doc)
        {

            var disps = ut.DoctordispRepository.GetMany(t => t.date_disp == date_disp & t.doctor_name == doc );
            return disps;

        }

        public IEnumerable<doctordisponibility> Recherchebydoc(string doc)
        {

            var disps = ut.DoctordispRepository.GetMany(t => t.doctor_name == doc);
            return disps;

        }

    }
}

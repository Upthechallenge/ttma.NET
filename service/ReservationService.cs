using data.Infrastructure;
using domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace service
{
    public interface IReservationService
    {
        void addreserve(reservation p);
        void deletereserve(reservation p);

        void deletereservationById(int id);
        List<reservation> getAllreservations();

        reservation getreservationById(int i);
        void update(reservation p);
      

    }
    public class ReservationService : IReservationService
    {
        static DatabaseFactory dbFactory = new DatabaseFactory();
        IUnitOfWork ut = new UnitOfWork(dbFactory);
        public void addreserve(reservation p)
        {
            ut.ReservationRepository.Add(p);
            ut.commit();
        }
        public int countHotels()
        {
            return ut.ReservationRepository.count();
        }
        public void deletereserve(reservation p) { 

            ut.ReservationRepository.Delete(p);
            ut.commit();
        }

        public void deletereservationById(int id)
        {
            reservation p = ut.ReservationRepository.GetById(id);
            ut.ReservationRepository.Delete(p);
            ut.commit();
        }

        public List<reservation> getAllreservations()
        {
            return ut.ReservationRepository.GetAll().ToList();
        }

        public reservation getreservationById(int i)
        {
            return ut.ReservationRepository.GetById(i);
        }

        public void update(reservation p)
        {

            ut.ReservationRepository.Update(p);
            ut.commit();
        }
    }
}

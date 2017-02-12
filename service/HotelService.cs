using data.Infrastructure;
using domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace service
{
    public interface IHotelService
    {
        void addHotel(hotel p);
        void deleteHotel(hotel p);

        void deleteHotelById(int id);
        List<hotel> getAllHotels();

        hotel getHotelById(int i);
        void update(hotel p);
        int countHotels();

    }
    public class HotelService : IHotelService
    {
        static DatabaseFactory dbFactory = new DatabaseFactory();
        IUnitOfWork ut = new UnitOfWork(dbFactory);
        public void addHotel(hotel p)
        {
            ut.HotelRepository.Add(p);
            ut.commit();
        }
        public int countHotels()
        {
            return ut.HotelRepository.count();
        }
        public void deleteHotel(hotel p)
        {

            ut.HotelRepository.Delete(p);
            ut.commit();
        }

        public void deleteHotelById(int id)
        {
            hotel p = ut.HotelRepository.GetById(id);
            ut.HotelRepository.Delete(p);
            ut.commit();
        }

        public List<hotel> getAllHotels()
        {
            return ut.HotelRepository.GetAll().ToList();
        }

        public hotel getHotelById(int i)
        {
            return ut.HotelRepository.GetById(i);
        }

        public void update(hotel p)
        {
            
            ut.HotelRepository.Update(p);
            ut.commit();
        }
    }
}
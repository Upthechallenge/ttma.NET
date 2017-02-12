
using data.Infrastructure;
using domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace service
{
    public interface ITransportCompagnieService
    {
        void addTransportCompagnie(transportcompagnie p);
        void deleteTransportCompagnie(transportcompagnie p);

        void deleteTransportCompagnieById(int id);
        List<transportcompagnie> getAllTransportCompagnie();

        transportcompagnie getTransportCompagnieById(int i);
        void updateTransportCompagnie(int id);
        int countTransportCompagnie();

    }
    public class TransportCompagnieService : ITransportCompagnieService
    {
        static DatabaseFactory dbFactory = new DatabaseFactory();
        IUnitOfWork ut = new UnitOfWork(dbFactory);
        public void addTransportCompagnie(transportcompagnie p)
        {
            ut.TransportCompagnieRepository.Add(p);
            ut.commit();
        }
        public int countTransportCompagnie()
        {
            return ut.TransportCompagnieRepository.count();
        }
        public void deleteTransportCompagnie(transportcompagnie p)
        {

            ut.TransportCompagnieRepository.Delete(p);
            ut.commit();
        }

        public void deleteTransportCompagnieById(int id)
        {
            transportcompagnie p = ut.TransportCompagnieRepository.GetById(id);
            ut.TransportCompagnieRepository.Delete(p);
            ut.commit();
        }

        public List<transportcompagnie> getAllTransportCompagnie()
        {
            return ut.TransportCompagnieRepository.GetAll().ToList();
        }

        public transportcompagnie getTransportCompagnieById(int i)
        {
            return ut.TransportCompagnieRepository.GetById(i);
        }

        public void updateTransportCompagnie(int id)
        {
            transportcompagnie p = ut.TransportCompagnieRepository.GetById(id);
            ut.TransportCompagnieRepository.Update(p);
            ut.commit();
        }

        public int countAllmarine()
        {
            return ut.TransportCompagnieRepository.GetMany(t => t.companyCategory == "marine").Count();
        }

        public int countAllair()
        {
            return ut.TransportCompagnieRepository.GetMany(t => t.companyCategory == "aircompagny").Count();
        }

        public int countAllroutier()
        {
            return ut.TransportCompagnieRepository.GetMany(t => t.companyCategory == "routiere").Count();
        }

    }
}

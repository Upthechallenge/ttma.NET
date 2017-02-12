
using data.Infrastructure;
using domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace service
{
    public interface IOfferService
    {
        void addOffer(operation p);
        void deleteOffer(operation p);

        void deleteOfferById(int id);
        List<operation> getAllOffers();

        operation getOfferById(int i);
        void update(int id);
        int countOffers();

    }
    public class OfferService : IOfferService
    {
        static DatabaseFactory dbFactory = new DatabaseFactory();
        IUnitOfWork ut = new UnitOfWork(dbFactory);
        public void addOffer(operation p)
        {
            ut.OfferRepository.Add(p);
            ut.commit();
        }
        public int countOffers()
        {
            return ut.OfferRepository.count();
        }
        public void deleteOffer(operation p)
        {

            ut.OfferRepository.Delete(p);
            ut.commit();
        }

        public void deleteOfferById(int id)
        {
            operation p = ut.OfferRepository.GetById(id);
            ut.OfferRepository.Delete(p);
            ut.commit();
        }

        public List<operation> getAllOffers()
        {
            return ut.OfferRepository.GetAll().ToList();
        }

        public operation getOfferById(int i)
        {
            return ut.OfferRepository.GetById(i);
        }

        public void update(int id)
        {
            operation p = ut.OfferRepository.GetById(id);
            ut.OfferRepository.Update(p);
            ut.commit();
        }

        public int countAllFaceSurgery()
        {
            return ut.OfferRepository.GetMany(t => t.type_Operation == "Face Surgery").Count();
        }

        public int countAllbreastSurgery()
        {
            return ut.OfferRepository.GetMany(t => t.type_Operation == "breast Surgery").Count();
        }

        public int countAllSurgeryteeth()
        {
            return ut.OfferRepository.GetMany(t => t.type_Operation == "Surgery teeth").Count();
        }
        public int countAllSurgeryplastic()
        {
            return ut.OfferRepository.GetMany(t => t.type_Operation == "Surgery plastic").Count();
        }

        public int countAllintimateSurgery()
        {
            return ut.OfferRepository.GetMany(t => t.type_Operation == "intimate Surgery").Count();
        }
        public int countAllgastricsBand()
        {
            return ut.OfferRepository.GetMany(t => t.type_Operation == "gastric Band").Count();
        }
    }
}


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using domain.Entities;
using data.Infrastructure;

namespace service
{
    public class InsuranceOfferService : IInsuranceOfferService
    {
        static DatabaseFactory dbFactory = new DatabaseFactory();
        IUnitOfWork utOfWork = new UnitOfWork(dbFactory);

        public void CreateOffer(insurance_offer b)
        {
            utOfWork.Insurance_offerRepository.Add(b);
            utOfWork.commit();

        }
        public void DeleteOffer(insurance_offer b)
        {
            utOfWork.Insurance_offerRepository.Delete(b);
            utOfWork.commit();

        }
        public void DeleteOfferById(int id)
        {
            insurance_offer p = utOfWork.Insurance_offerRepository.GetById(id);
             utOfWork.Insurance_offerRepository.GetById(id);
            utOfWork.Insurance_offerRepository.Delete(p);
            utOfWork.commit();

        }

        public void UpdateOfferById(int id)
        {
            insurance_offer p = utOfWork.Insurance_offerRepository.GetById(id);
            utOfWork.Insurance_offerRepository.GetById(id);
            utOfWork.Insurance_offerRepository.Update(p);
            utOfWork.commit();

        }

        public void UpdateOffer(insurance_offer b)
        {
            utOfWork.Insurance_offerRepository.Update(b);

        }

        public IEnumerable<insurance_offer> Getoffers()
        {
            var offers = utOfWork.Insurance_offerRepository.GetAll();
            return offers;

        }
        public void Save()
        {
            utOfWork.commit();
        }

        public insurance_offer getOfferById(int id )
        {
            return utOfWork.Insurance_offerRepository.GetById(id);
        }

        public int countOffer()
        {
            return utOfWork.Insurance_offerRepository.count();
        }



    }

    public interface IInsuranceOfferService
    {
         IEnumerable<insurance_offer> Getoffers();
         void CreateOffer(insurance_offer b);
        void Save();
        insurance_offer getOfferById(int id);
        void DeleteOffer(insurance_offer b);
        void DeleteOfferById(int id);
        void UpdateOfferById(int id);
        void UpdateOffer(insurance_offer b);

         int countOffer();

    }
}

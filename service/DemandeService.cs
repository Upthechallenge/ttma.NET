
using data.Infrastructure;
using domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace service
{
    public interface IDemandeService
    {
        void addDemande(demande p);
        void deleteDemande(demande p);

        void deleteDemandeById(int id);
        List<demande> getAllDemande();

        demande getDemandeById(int i);
        void updateDemande(int id);
        int countDemande();

    }
    public class DemandeService : IDemandeService
    {
        static DatabaseFactory dbFactory = new DatabaseFactory();
        public demande get;
        IUnitOfWork ut = new UnitOfWork(dbFactory);
        public void addDemande(demande p)
        {
            ut.DemandeRepository.Add(p);
            ut.commit();
        }
        public int countDemande()
        {
            return ut.DemandeRepository.count();
        }
        public void deleteDemande(demande p)
        {

            ut.DemandeRepository.Delete(p);
            ut.commit();
        }

        public void deleteDemandeById(int id)
        {
            demande p = ut.DemandeRepository.GetById(id);
            ut.DemandeRepository.Delete(p);
            ut.commit();
        }

        public List<demande> getAllDemande()
        {
            return ut.DemandeRepository.GetAll().ToList();
        }

        public demande getDemandeById(int i)
        {
            return ut.DemandeRepository.GetById(i);
        }

        public void updateDemande(int id)
        {
            demande p = ut.DemandeRepository.GetById(id);
            ut.DemandeRepository.Update(p);
            ut.commit();
        }
    }
}

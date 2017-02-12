using Data.Infrastructure;
using Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
   public class CongeService:IcongeService 
    {
        static public DatabaseFactory dbFactory = new DatabaseFactory();
        UnitOfWork utwk = new UnitOfWork(dbFactory);
        public void AddConge(conge c)
        {
            utwk.CongeRepository.Add(c);
            utwk.Commit();
        }

        public void DeleteConge(conge c)
        {
            utwk.CongeRepository.Delete((c));
            utwk.Commit();
        }

        public List<conge> getAllConges()
        {
            return utwk.CongeRepository.GetAll().ToList();
        }

        public void ModifierConge(conge c)
        {
            throw new NotImplementedException();
        }

        public void RechercherConge(conge c, int id)
        {
            throw new NotImplementedException();
        }
    }
    public interface IcongeService
    {
        void AddConge(conge c);
           List<conge> getAllConges();

        void DeleteConge(conge c);
        void ModifierConge(conge c);

        void RechercherConge(conge c, int id);


       
    }
}

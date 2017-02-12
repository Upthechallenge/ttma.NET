
using data.Infrastructure;
using domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace service
{
    public interface ICongeService
    {
        void addConge(conge p);
        void deleteConge(conge p);

        void deleteCongeById(int ID);
        List<conge> getAllConge();

        conge getCongeById(int i);
        void update(int ID);
        int countConge();

    }
    public class CongeService : ICongeService
    {
        static DatabaseFactory dbFactory = new DatabaseFactory();
        IUnitOfWork ut = new UnitOfWork(dbFactory);
        public void addConge(conge p)
        {
            ut.CongeRepository.Add(p);
            ut.commit();
        }
        public int countConge()
        {
            return ut.CongeRepository.count();
        }
        public void deleteConge(conge p)
        {

            ut.CongeRepository.Delete(p);
            ut.commit();
        }

        public void deleteCongeById(int ID)
        {
            conge p = ut.CongeRepository.GetById(ID);
            ut.CongeRepository.Delete(p);
            ut.commit();
        }

        public List<conge> getAllConge()
        {
            return ut.CongeRepository.GetAll().ToList();
        }
        

        public conge getCongeById(int i)
        {
            return ut.CongeRepository.GetById(i);
        }

        public void update(int ID)
        {
            conge p = ut.CongeRepository.GetById(ID);
            ut.CongeRepository.Update(p);
            ut.commit();
        }
    }
}

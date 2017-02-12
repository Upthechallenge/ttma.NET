using data.Infrastructure;
using domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace service
{
    public interface IUserService
    {
        void adduser(user p);
        void deleteuser(user p);

        void deleteuserById(int id);
        List<user> getAllusers();

        user getuserById(int i);
        void update(user p);
        

    }
    public class UserService : IUserService
    {
        static DatabaseFactory dbFactory = new DatabaseFactory();
        IUnitOfWork ut = new UnitOfWork(dbFactory);
      
       
        public void deleteuser(user p)
        {

            ut.UserRepository.Delete(p);
            ut.commit();
        }

        public void deleteuserById(int id)
        {
            user p = ut.UserRepository.GetById(id);
            ut.UserRepository.Delete(p);
            ut.commit();
        }

        public List<user> getAllusers()
        {
            return ut.UserRepository.GetAll().ToList();
        }

        public user getuserById(int i)
        {
            return ut.UserRepository.GetById(i);
        }

        public void update(user p)
        {

            ut.UserRepository.Update(p);
            ut.commit();
        }

      public  void adduser(user p)
        {
            ut.UserRepository.Add(p);
            ut.commit();
        }
    }
}

using System;
using data.Infrastructure;
using domain.Entities;

using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace service
{
    public class StaffService : IStaffService
    {
        static public DatabaseFactory dbFactory = new DatabaseFactory();
        UnitOfWork utwk = new UnitOfWork(dbFactory);
        public void AddUser(staff a)
        {
            utwk.StaffRepository.Add(a);
            utwk.commit();
        }

        public void DeleteUser(staff a)
        {
            utwk.StaffRepository.Delete(a);
            utwk.commit();
        }
    public void DeleteUserById(int id)
        {
           staff u = utwk.StaffRepository.GetById(id);
            utwk.StaffRepository.Delete(u);
            utwk.commit();
        }

        public List<staff> getAllUsers()
        {
            return utwk.StaffRepository.GetAll().ToList();

        }
        public int countStaff()
        {
            return utwk.StaffRepository.count();
        }


        public staff GetUser(int id)
        {
            return utwk.StaffRepository.GetById(id);
        }

        public void UpdateUser(staff u)
        {
            utwk.StaffRepository.Update(u);
            utwk.commit();
        }

        public void Save()
        {
            utwk.commit();
        }


    }

    public interface IStaffService
    {
        void AddUser(staff a);
        List<staff> getAllUsers();

        void UpdateUser(staff u);

        void DeleteUser(staff a);

       staff GetUser(int id);
        void DeleteUserById(int id);
        int countStaff();
    }
}

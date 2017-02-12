using data.Infrastructure;

using domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace service
{
    public class AuthentificationService : IAuthentificationService

    {
        static DatabaseFactory dbFactory = new DatabaseFactory();
        IUnitOfWork ut = new UnitOfWork(dbFactory);

        public void CreateUser(staff auth_user)
        {
            ut.AuthentificationRepository.Add(auth_user);
            ut.commit();
        }
        public IEnumerable<staff> afficher()
        {
            return ut.AuthentificationRepository.GetAll().ToList();
        }

        public void Delete(staff auth_user)
        {
            ut.AuthentificationRepository.Delete(auth_user);
            ut.commit();
        }
        public void DeleteUserById(int id)
        {
            staff auth_user = ut.AuthentificationRepository.GetById(id);
            ut.AuthentificationRepository.Delete(auth_user);
            ut.commit();

        }
        public List<staff> getAllUsers()
        {
            return ut.AuthentificationRepository.GetAll().ToList();

        }


        public void Edit(staff auth_user)
        {
            ut.AuthentificationRepository.Edit(auth_user);
            ut.commit();
        }
        public staff GetUser(int id)
        {
            return ut.AuthentificationRepository.GetById(id);
        }
        public staff Authentification(string login, string password)
        {
            staff em = null;
            var liste = ut.AuthentificationRepository.GetAll().ToList();
            foreach (staff e in liste)
            {
                if ((e.login == login) && (e.mdp == password))
                {
                    em = e;
                }
            }
            if (em == null)
            {
                return null;
            }
            else
                return em;
        }
        public string getRoleFromLoginetPassword(string login, string password)
        {
            string role = "";
            var liste = ut.AuthentificationRepository.GetAll().ToList();
            foreach (staff e in liste)
            {
                if ((e.login == login) && (e.mdp == password))
                {
                    role = e.function;
                }
            }
            if (role == "")
            {
                return "RIen";
            }
            else
                return role;
        }
        public string getNameFromLoginAndPasswod(string login, string password)
        {
            string name = "";
            var liste = ut.AuthentificationRepository.GetAll().ToList();
            foreach (staff e in liste)
            {
                if ((e.login == login) && (e.mdp == password))
                {
                    name = e.name;
                }
            }
            if (name == "")
            {
                return "RIen";
            }
            else
                return name;
        }

    }
    public interface IAuthentificationService
    {
        void CreateUser(staff auth_user);
        IEnumerable<staff> afficher();
        void Delete(staff auth_user);
        void DeleteUserById(int id);
        staff GetUser(int id);
        void Edit(staff auth_user);
        staff Authentification(string login, string password);
        List<staff> getAllUsers();
        string getRoleFromLoginetPassword(string login, string password);
        string getNameFromLoginAndPasswod(string login, string password);

    }

}

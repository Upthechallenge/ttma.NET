
using data.Infrastructure;
using domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace service
{
    public interface IDoctorService
    {
        void addDoctor(doctor p);
        void deleteDoctor(doctor p);

        void deleteDoctorById(int id);
        List<doctor> getAllDoctors();

        doctor getDoctorById(int i);
        void update(int id);
        int countDoctors();

    }
    public class DoctorService : IDoctorService
    {
        static DatabaseFactory dbFactory = new DatabaseFactory();
        IUnitOfWork ut = new UnitOfWork(dbFactory);
        public void addDoctor(doctor p)
        {
            ut.DoctorRepository.Add(p);
            ut.commit();
        }
        public int countDoctors()
        {
            return ut.DoctorRepository.count();
        }
        public void deleteDoctor(doctor p)
        {

            ut.DoctorRepository.Delete(p);
            ut.commit();
        }

        public void deleteDoctorById(int id)
        {
            doctor p = ut.DoctorRepository.GetById(id);
            ut.DoctorRepository.Delete(p);
            ut.commit();
        }

        public List<doctor> getAllDoctors()
        {
            return ut.DoctorRepository.GetAll().ToList();
        }

        public doctor getDoctorById(int i)
        {
            return ut.DoctorRepository.GetById(i);
        }

        public void update(int id)
        {
            doctor p = ut.DoctorRepository.GetById(id);
            ut.DoctorRepository.Update(p);
            ut.commit();
        }
    }
}

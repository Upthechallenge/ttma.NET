
using data.Infrastructure;
using domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace service
{
    public interface IConsultationService
    {
        void addConsultation(demandeconsultationenligne p);
        void deleteConsultation(demandeconsultationenligne p);

        void deleteConsultationById(int id);
        List<demandeconsultationenligne> getAllConsultations();

        demandeconsultationenligne getConsultationById(int i);
        void update(int id);
        int countConsultations();

    }
    public class ConsultationService : IConsultationService
    {
        static DatabaseFactory dbFactory = new DatabaseFactory();
        IUnitOfWork ut = new UnitOfWork(dbFactory);
        public void addConsultation(demandeconsultationenligne p)
        {
            ut.ConsultationRepository.Add(p);
            ut.commit();
        }
        public int countConsultations()
        {
            return ut.ConsultationRepository.count();
        }
        public void deleteConsultation(demandeconsultationenligne p)
        {

            ut.ConsultationRepository.Delete(p);
            ut.commit();
        }

        public void deleteConsultationById(int id)
        {
            demandeconsultationenligne p = ut.ConsultationRepository.GetById(id);
            ut.ConsultationRepository.Delete(p);
            ut.commit();
        }

        public List<demandeconsultationenligne> getAllConsultations()
        {
            return ut.ConsultationRepository.GetAll().ToList();
        }

        public demandeconsultationenligne getConsultationById(int i)
        {
            return ut.ConsultationRepository.GetById(i);
        }

        public void update(int id)
        {
            demandeconsultationenligne p = ut.ConsultationRepository.GetById(id);
            ut.ConsultationRepository.Update(p);
            ut.commit();
        }
    }
}



using data.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace data.Infrastructure
{
    public interface IUnitOfWork
    {
        void commit();
        IInsurance_offerRepository Insurance_offerRepository { get; }
        IDoctorRepository DoctorRepository { get; }
        IOfferRepository OfferRepository { get; }
        IConsultationRepository ConsultationRepository { get; }
        IDocdispRepository DoctordispRepository { get; }
        IAuthentificationRepository AuthentificationRepository { get; }
        //Amira
        ICongeRepository CongeRepository { get; }
        ITimetableRepository TimetableRepository { get; }
        //End Amira

        //wassila
        ITransportCompagnieRepository TransportCompagnieRepository { get; }
        IDemandeRepository DemandeRepository { get; }
        //end wassila

        //takwa
        IEventRepository EventRepository { get; }
        //end takwa
        IStaffRepository StaffRepository { get; }

        //mehdi

        IHotelRepository HotelRepository { get; }
        IUserRepository UserRepository { get; }

        IReservationRepository ReservationRepository { get; }
        //Medhi

    }
}

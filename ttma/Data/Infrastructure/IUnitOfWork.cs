using  Data.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace  Data.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        void Commit();


        ICongeRepository CongeRepository { get; }

         


    }
}

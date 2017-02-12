using data;
using data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace data.Infrastructure
{
    public interface IDatabaseFactory : IDisposable
    {

        jpadbContext Get();// ouTestContext DataContext { get; }

    }
}

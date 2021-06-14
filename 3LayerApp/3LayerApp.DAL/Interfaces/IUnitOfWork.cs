using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _3LayerApp.DAL.Entities;

namespace _3LayerApp.DAL.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        IRepository<Saddle> Saddles { get; }
        IRepository<Order> Orders { get; }
        void Save();
    }
}

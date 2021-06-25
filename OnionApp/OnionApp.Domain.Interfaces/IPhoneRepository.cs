using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OnionApp.Domain.Core;

namespace OnionApp.Domain.Interfaces
{
    public interface IPhoneRepository : IDisposable
    {
        IEnumerable<Phone> GetPhoneList();
        Phone GetPhone(int id);
        void Create(Phone item);
        void Update(Phone item);
        void Delete(int id);
        void Save();
    }
}

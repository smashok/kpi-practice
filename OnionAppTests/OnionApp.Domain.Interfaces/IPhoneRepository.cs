using OnionApp.Domain.Core;

using System;
using System.Collections.Generic;

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

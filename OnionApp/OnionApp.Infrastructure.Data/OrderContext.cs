using Microsoft.Analytics.Interfaces;
using Microsoft.Analytics.Interfaces.Streaming;
using Microsoft.Analytics.Types.Sql;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Data.Entity;
using OnionApp.Domain.Core;

namespace OnionApp.Infrastructure.Data
{
    public class OrderContext : DbContext
    {
        public DbSet<Phone> Phones { get; set; }
    }
}
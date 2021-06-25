using Microsoft.Analytics.Interfaces;
using Microsoft.Analytics.Interfaces.Streaming;
using Microsoft.Analytics.Types.Sql;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace OnionApp.Domain.Core
{
    public class Phone
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Price { get; set; }
    }
}
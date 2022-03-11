using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspNetCoreWebApi.Models
{
    public class Employee
    {

        public Guid id { get; set; }

        public string  name { get; set; }

        public long salary { get; set; }

        public string department { get; set; }


    }
}

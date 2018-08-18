using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    public class Department
    {
        public int Id { get; set; }
        public string Country { get; set; }
        public string City { get; set; }

        public Department() : this(0, "no country", "no city") {}

        public Department(int id, string country, string city)
        {
            this.Id = id;
            this.Country = country;
            this.City = city;
        }
    }
}

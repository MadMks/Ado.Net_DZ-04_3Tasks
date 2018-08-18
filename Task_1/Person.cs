using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1
{
    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string City { get; set; }

        public Person() :this("noname", 0, "no city") {}

        public Person(string name, int age, string city)
        {
            this.Name = name;
            this.Age = age;
            this.City = city;
        }
    }
}

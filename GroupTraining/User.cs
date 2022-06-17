using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroupTraining
{
    internal class User
    {
        public string Name { get; set; }
        public string Country { get; set; }
        public int Age { get; set; }

        public User(string name, string country, int age)
        {
            Name = name;
            Country = country;
            Age = age;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StronglyType.Models
{
    public static class Repository
    {
        public static List<Person> people = new List<Person>()
        {
            new Person(){Id = 1, Name = "Nila", Family = "Vo", Age = 20},
            new Person(){Id = 2, Name = "Arash", Family = "Vo", Age = 14}
        };
    }
}
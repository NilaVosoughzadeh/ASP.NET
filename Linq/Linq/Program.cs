using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = {5,10,15,20,25,30,35,40,45,50,55};

            int[] result = (from n in numbers select n).ToArray();
            var lambda = numbers.ToArray();

            var result2 = (from n in numbers
                           orderby n descending
                           select n).ToArray();
            var lambda2 = numbers.OrderByDescending(n => n).ToArray();

            var result3 = (from n in numbers
                           where n > 30 && n < 60
                           orderby n descending
                           select n).ToList();
            var lambda3 = numbers.Where(n => n > 30 && n < 60).OrderByDescending(n => n).ToArray();

            var result4 = (from n in numbers
                           where n == 5
                           select n).First();
            var lambda4 = numbers.First(n => n == 5);

            var result5 = (from n in numbers
                           where n == 5
                           select n).FirstOrDefault();
            var lambda5 = numbers.FirstOrDefault(n => n == 5);

            var result6 = (from n in numbers
                           where n == 5
                           select n).Single();
            var lambda6 = numbers.Single(n => n == 5);

            var result7 = (from n in numbers
                           where n == 5
                           select n).SingleOrDefault();
            var lambda7 = numbers.SingleOrDefault(n => n == 5);

            int count = (from n in numbers
                         select n).Count();
            var lambdaC = numbers.Count();

            int sum = (from n in numbers
                       select n).Sum();
            var lambdaS = numbers.Sum();

            int max = (from n in numbers
                       select n).Max();
            var lambdaMa = numbers.Max();

            int min = (from n in numbers
                       select n ).Min();
            var lambdaMi = numbers.Min();

            var resultNews = (from n in numbers
                              orderby n descending
                              select n).Take(4).ToArray();

            var result8 = (from n in numbers
                           orderby n descending
                           select n).Skip(4).ToArray();

            List<string> names = new List<string>();
            names.Add("Nila");
            names.Add("Vania");
            names.Add("Arash");
            names.Add("Rosana");

            var result9 = (from n in names
                           where n.ToLower().Contains("a")
                           select n).ToArray();

            var result10 = (from n in names
                           where n.ToLower().StartsWith("a")
                           select n).ToArray();

            var result11 = (from n in names
                           where n.ToLower().EndsWith("a")
                           select n).ToArray();
            var result12 = (from n in numbers
                            where n.ToString().Contains("0")
                            select n).ToArray();




            List<Person> people = new List<Person>();
            Person p1 = new Person();
            p1.Id = 1;
            p1.Name = "Nila";
            p1.Family = "Vosoughzadeh";
            people.Add(p1);

            Person p2 = new Person()
            {
                Id = 2,Name = "Arash", Family="Vosoughzadeh"
            };
            people.Add(p2);

            people.Add(new Person() {Id = 3, Name = "Vania" , Family = "Vosoughzadeh"});

            var peopleResult = people.ToList();
            var orderResult = people.OrderByDescending(p  => p.Id).ToList();
            var resultName = people.Where(p => p.Name.ToLower().Contains("V")).ToList();
            var resultId = people.FirstOrDefault(p => p.Id == 1);
            var peopleName = people.Select(p => new
            {
                p.Name,
                p.Family,
            }).ToList();
            var resultAny = people.Any(p => p.Name == "Nila");
        }
    }

    class Person
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Family { get; set; }
    }
}
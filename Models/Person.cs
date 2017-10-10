using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InputOutputLecture.Models
{
    class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Occupation { get; set; }
        public int Age { get; set; }
        public static List<Person> GenerateListOfPeople()
        {
            var people = new List<Person>();

            people.Add(new Person { FirstName = "Eric", LastName = "Flemming", Occupation = "Developer", Age = 24 });
            people.Add(new Person { FirstName = "Steve", LastName = "Smith", Occupation = "Manager", Age = 40 });
            people.Add(new Person { FirstName = "Brendan", LastName = "Enrick", Occupation = "Developer", Age = 30 });
            people.Add(new Person { FirstName = "Jane", LastName = "Doe", Occupation = "Accountant", Age = 34 });
            people.Add(new Person { FirstName = "Beth", LastName = "Stevens", Occupation = "Accountant", Age = 40 });
            people.Add(new Person { FirstName = "Samual", LastName = "Jackson", Occupation = "Chef", Age = 23 });
            people.Add(new Person { FirstName = "Johnny", LastName = "Depp", Occupation = "Chef", Age = 25 });
            people.Add(new Person { FirstName = "Greg", LastName = "Olsson", Occupation = "Developer", Age = 37 });
            people.Add(new Person { FirstName = "Chet", LastName = "Manly", Occupation = "Accountant", Age = 30 });
            people.Add(new Person { FirstName = "Randy", LastName = "Johnson", Occupation = "Developer", Age = 32 });
            people.Add(new Person { FirstName = "Cindy", LastName = "Crawford", Occupation = "Developer", Age = 26 });
            people.Add(new Person { FirstName = "Hugh", LastName = "Heffner", Occupation = "Accountant", Age = 91 });
            people.Add(new Person { FirstName = "Larry", LastName = "Mannheim", Occupation = "Chef", Age = 24 });
            people.Add(new Person { FirstName = "Karl", LastName = "Johan", Occupation = "King", Age = 60 });
            people.Add(new Person { FirstName = "John", LastName = "Wick", Occupation = "Accountant", Age = 32 });
            people.Add(new Person { FirstName = "Magnus", LastName = "Eriksson", Occupation = "Manager", Age = 36 });
            people.Add(new Person { FirstName = "Tim", LastName = "Sicksson", Occupation = "Developer", Age = 35 });
            people.Add(new Person { FirstName = "Lauren", LastName = "Sweet", Occupation = "Accountant", Age = 32 });
            people.Add(new Person { FirstName = "Will", LastName = "Smith", Occupation = "Chef", Age = 40 });
            people.Add(new Person { FirstName = "Jason", LastName = "Stathom", Occupation = "Developer", Age = 38 });
            people.Add(new Person { FirstName = "Elizabeth", LastName = "Hurley", Occupation = "Manager", Age = 55 });

            return people;
        }
    }
}

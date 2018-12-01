using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tuple
{
    class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public int[] Marks { get; set; }

        public override string ToString()
        {
            StringBuilder builder = new StringBuilder();
            builder.AppendLine(Name);
            builder.AppendLine($"{Age}y.o.");

            foreach (var m in Marks)
            {
                builder.Append($"{m} ");
            }
            Console.WriteLine();

            return builder.ToString();
        }
    }
    class Program
    {
        static dynamic Ex01()
        {
            return new { a = 5, b = 10 };
        }

        static (int a, int b) Ex02()
        {
            return (10, 20);
        }

        static void PrintMinMax((int minAge, int maxAge) tuple, List<Person> people)
        {
            //Получение студентов с минимальным и максимальным возрастами
            var p1 = people.FirstOrDefault(p => p.Age == tuple.minAge);
            var p2 = people.FirstOrDefault(p => p.Age == tuple.maxAge);

            Console.WriteLine(p1);
            Console.WriteLine(p2);
        }

        //Return tuple
        static (double average, Person person) Ex03(List<Person> people)
        {
            var maxAvg = people.Max(p => p.Marks.Average());
            var pers = people.First(p => p.Marks.Average() == maxAvg);
            return (maxAvg, pers);
        }

        static void Main(string[] args)
        {
            //dynamic a = 10;
            //a = "Hello";

            //dynamic res = Ex01();
            //Console.WriteLine(res);

            //(int, int) tuple = (5, 7);
            //Console.WriteLine(tuple);           

            //var res = Ex02();

            List<Person> people = new List<Person>
            {
                new Person { Age = 20, Marks = new int[] { 5, 5, 2, 4, 1 }, Name = "Вася" },
                new Person { Age = 16, Marks = new int[] { 1, 2, 2, 5, 4 }, Name = "Петя" },
                new Person { Age = 22, Marks = new int[] { 5, 4, 5, 5, 5 }, Name = "Маша" },
                new Person { Age = 18, Marks = new int[] { 4, 3, 4, 5, 4 }, Name = "Дима" },
            };

            //PrintMinMax((16, 22), people);

            var res = Ex03(people);
            Console.WriteLine($"Average = {res.average}");
            Console.WriteLine(res.person);

            
            Console.Read();
        }
    }
}

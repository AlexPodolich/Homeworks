using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework
{
    class Car
    {
        public string Marka { get; set; }
        public string Model { get; set; }
        public decimal Price { get; set; }
        public string Color { get; set; }

        public Car(string Marka,string Model,decimal Price,string Color)
        {
            this.Marka = Marka;
            this.Model = Model;
            this.Price = Price;
            this.Color = Color;
        }
        public override string ToString()
        {
            return Marka + " " + Model + " " + Price.ToString() + " " + Color;
        }

    }
    class Program
    {
        /// <summary>
        /// All cars with price > 10000
        /// </summary>
        /// <param name="cars">
        /// Input list of cars
        /// </param>
        /// <exception cref="ArgumentException">
        /// If <paramref name="cars"/> is > 10000
        /// </exception>
        /// <returns>Returns all cars with price > 10000</returns>
        static public void first_num(List<Car> cars)
        {
            const int min_price = 10_000;

            Console.WriteLine("Cars with price >= 10000 : ");
            foreach (Car car in cars)
            {
                if (car.Price > min_price) Console.WriteLine(car);
            }
        }

        /// <summary>
        /// All cars with red color
        /// </summary>
        /// <param name="cars">
        /// Input list of cars
        /// </param>
        /// <param name="color">
        /// Input red color for compare
        /// </param>
        /// <exception cref="ArgumentException">
        /// If <paramref name="cars"/> is == "Red"
        /// </exception>
        /// <returns>Returns all cars with red color</returns>
        static public void second_num(List<Car> cars, string color = "Red")
        {
            Console.WriteLine("Cars with red color : ");
            foreach (Car car in cars)
            {
                if (car.Color == color) Console.WriteLine(car);
            }
        }

        /// <summary>
        /// All cars with your price and mark of car
        /// </summary>
        /// <param name="cars">
        /// Input list of cars
        /// </param>
        /// <exception cref="ArgumentException">
        /// If <paramref name="cars"/> is == your_price and == your_mark
        /// </exception>
        /// <returns>Returns all cars with your_price and your_mark</returns>
        static public void third_num(List<Car> cars)
        {
            Console.WriteLine("Enter car price : ");
            string price_car = Console.ReadLine();
            Console.WriteLine("Enter car mark : ");
            string mark_car = Console.ReadLine();

            Console.WriteLine("Cars with your mark and price : ");

            foreach (Car car in cars)
            {
                if (car.Marka == mark_car && car.Price == Convert.ToDecimal(price_car)) Console.WriteLine(car);
            }
        }

        /// <summary>
        /// Price of all cars
        /// </summary>
        /// <param name="cars">
        /// Input list of cars
        /// </param>
        /// <param name="sum">
        /// Sum of all cars
        /// <returns>Returns price of all cars</returns>
        static public void fourth_num(List<Car> cars, decimal sum = 0 )
        {
            Console.WriteLine("Sum of all cars : ");
            sum = cars.Sum(x => x.Price);
            Console.WriteLine(sum);
        }

        /// <summary>
        /// Number cars with red color
        /// </summary>
        /// <param name="cars">
        /// Input list of cars
        /// </param>
        /// <param name="color">
        /// Input red color for compare
        /// </param>
        /// <param name="kol_red_cars">
        /// Number of red cars
        /// </param>
        /// <exception cref="ArgumentException">
        /// If <paramref name="cars"/> is == "Red"
        /// </exception>
        /// <returns>Returns number with red cars</returns>
        static public void fifth_num(List<Car> cars, int kol_red_cars = 0, string color = "Red")
        {
            Console.WriteLine("Number cars with red color : ");

            foreach (Car car in cars)
            {
                if (car.Color == color)
                {
                    kol_red_cars++;
                }
            }
            Console.WriteLine(kol_red_cars);
        }

        /// <summary>
        /// All cheap cars with price lower than 5000
        /// </summary>
        /// <param name="cars">
        /// Input list of cars
        /// </param>
        /// <exception cref="ArgumentException">
        /// If <paramref name="cars"/> is < 5000
        /// </exception>
        /// <returns>Returns all cheap cars with price < 5000</returns>
        static public void sixth_num(List<Car> cars)
        {
            int max_car_price = 5000;

            Console.WriteLine($"Cheap cars with price < {max_car_price} : ");
            foreach (Car car in cars)
            {
                if (car.Price < max_car_price)
                {
                    Console.WriteLine(car.Marka); Console.WriteLine(car.Model);
                }
            }
        }

        /// <summary>
        /// Show only mark and model of cars in your range
        /// </summary>
        /// <param name="cars">
        /// Input list of cars
        /// </param>
        /// <exception cref="ArgumentException">
        /// If <paramref name="cars"/> is < min_price and > max_price
        /// </exception>
        /// <returns>Returns only mark and model of cars in your range</returns>
        static public void seventh_num(List<Car> cars)
        {
            int prov_Red = 0;
            int prov_Black = 0;
            Console.WriteLine("Min price: ");
            int min_car_price = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Max price: ");
            int max_car_price = Int32.Parse(Console.ReadLine());

            Console.WriteLine($"Cars with price > {min_car_price} and price < {max_car_price} : ");
            foreach (Car car in cars)
            {
                if (car.Price > min_car_price && car.Price < max_car_price)
                { 
                    Console.WriteLine(car);
                    if (car.Color == "Red")
                    {
                        prov_Red++;
                    }
                    if (car.Color == "Black")
                    {
                        prov_Black++;
                    }
                } 
            }
            Console.WriteLine($"Cars with Black color : {prov_Black}, with Red color : {prov_Red}");

        }

        static void Main(string[] args)
        {
            List<Car> cars = new List<Car>
            {
                new Car("Audi","1RRE",9_999,"Yellow"),
                new Car ("Bentley","22",12_000,"Black"),
                new Car ("BMW","98",18_500,"Red"),
                new Car ("Bugatti","188",8_999,"Blue"),
                new Car ("Audi","67",5_125,"Black"),
                new Car ("Bentley", "17-C",17_000,"Red"),
                new Car ("BMW","18-D",15_125,"Orange"),
                new Car ("Bugatti","99-VV",4_125,"Green"),
                new Car ("Audi","123_CCQ",13_125,"Black"),
                new Car ("Buick","V67K",4_999,"White"),
            };

            first_num(cars);
            Console.WriteLine("");
            second_num(cars);
            Console.WriteLine("");
            third_num(cars);
            Console.WriteLine("");
            fourth_num(cars);
            Console.WriteLine("");
            fifth_num(cars);
            Console.WriteLine("");
            sixth_num(cars);
            Console.WriteLine("");
            seventh_num(cars);
            Console.ReadKey();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    class Distance
    {
        /// <summary>
        /// Calculate Kilometres to miles
        /// </summary>
        /// <param name="kilometres">
        /// Input distance in kilometres
        /// </param>
        /// <exception cref="ArgumentException">
        /// If <paramref name="kilometres"/> is negative
        /// </exception>
        /// <returns>Returns the distance in miles</returns>
        public static double KilometresToMiles(double kilometres)
        {
            if (kilometres < 0)
            {
                throw new ArgumentException("Kilometres must be greather 0");
            }
            return kilometres * 1.62;
        }

        /// <summary>
        /// Calculate miles to kilometres
        /// </summary>
        /// <param name="miles">
        /// Input distance in miles
        /// </param>
        /// <exception cref="ArgumentException">
        /// If <paramref name="miles"/> is negative
        /// </exception>
        /// <returns>Returns the distance in kilometres</returns>
        public static double MilesToKilometres(double miles)
        {
            if (miles < 0)
            {
                throw new ArgumentException("Miles must be greather 0");
            }
            return miles * 0.62;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello world");
            Console.Read();
        }
    }
}

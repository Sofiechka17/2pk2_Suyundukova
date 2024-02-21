using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace consoleProject
{
    internal class Product
    {
        public string Name { get; set; }
        public double Weight { get; set; }
        public double Gabarite { get; set; }
        public double Costs { get; set; }
        public double coficient;

        public Product(string name, double weight, double gabarite, double costs)
        {
            Name = name;
            Weight = weight;
            Gabarite = gabarite;
            Costs = costs;
            coficient = 0;
        }
        public static bool operator <(Product product1, Product product2)
        {
            return product1.Costs < product2.Costs;
        }
        public static bool operator >(Product product1, Product product2)
        {
            return product1.Costs > product2.Costs;
        }
        public static bool operator ==(Product product1, Product product2)
        {
            return product1.Costs == product2.Costs;
        }
        public static bool operator !=(Product product1, Product product2)
        {
            return product1.Costs != product2.Costs;
        }
        public static bool operator >=(Product product1, Product product2)
        {
            return product1.Costs >= product2.Costs;
        }
        public static bool operator <=(Product product1, Product product2)
        {
            return product1.Costs <= product2.Costs;
        }

        public virtual void getCosts()
        {
            Console.WriteLine($"Стоимость: {Costs}");
        }

    }
}

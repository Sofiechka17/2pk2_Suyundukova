using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace consoleProject
{
    internal class BigWeight : Product
    {
        public BigWeight(string name, double weight, double gabarite, double costs) : base(name, weight, gabarite, costs)
        {
            Name = name;
            Weight = weight;
            Gabarite = gabarite;
            Costs = costs;
            coficient = 1.5;
            getCosts();
        }
        public static bool operator <(BigWeight product1, BigWeight product2)
        {
            return product1.Costs < product2.Costs;
        }
        public static bool operator >(BigWeight product1, BigWeight product2)
        {
            return product1.Costs > product2.Costs;
        }
        public static bool operator ==(BigWeight product1, BigWeight product2)
        {
            return product1.Costs == product2.Costs;
        }
        public static bool operator !=(BigWeight product1, BigWeight product2)
        {
            return product1.Costs != product2.Costs;
        }
        public static bool operator >=(BigWeight product1, BigWeight product2)
        {
            return product1.Costs >= product2.Costs;
        }
        public static bool operator <=(BigWeight product1, BigWeight product2)
        {
            return product1.Costs <= product2.Costs;
        }
        public static double operator +(BigWeight product1, BigWeight product2)
        {
            return product1.Weight + product2.Weight;
        }
        public static double operator -(BigWeight product1, BigWeight product2)
        {
            return product1.Weight - product2.Weight;
        }
        public override void getCosts()
        {
            Costs *= coficient;
        }
    }
}

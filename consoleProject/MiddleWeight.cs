using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace consoleProject
{
    internal class MiddleWeight : Product
    {
        public MiddleWeight(string name, double weight, double gabarite, double costs) : base(name, weight, gabarite, costs)
        {
            Name = name;
            Weight = weight;
            Gabarite = gabarite;
            Costs = costs;
            coficient = 1.0;
            getCosts();
        }
        public static bool operator <(MiddleWeight product1, MiddleWeight product2)
        {
            return product1.Costs < product2.Costs;
        }
        public static bool operator >(MiddleWeight product1, MiddleWeight product2)
        {
            return product1.Costs > product2.Costs;
        }
        public static bool operator ==(MiddleWeight product1, MiddleWeight product2)
        {
            return product1.Costs == product2.Costs;
        }
        public static bool operator !=(MiddleWeight product1, MiddleWeight product2)
        {
            return product1.Costs != product2.Costs;
        }
        public static bool operator >=(MiddleWeight product1, MiddleWeight product2)
        {
            return product1.Costs >= product2.Costs;
        }
        public static bool operator <=(MiddleWeight product1, MiddleWeight product2)
        {
            return product1.Costs <= product2.Costs;
        }
        public static double operator +(MiddleWeight product1, MiddleWeight product2)
        {
            return product1.Weight + product2.Weight;
        }
        public static double operator -(MiddleWeight product1, MiddleWeight product2)
        {
            return product1.Weight - product2.Weight;
        }
        public override void getCosts()
        {
            Costs *= coficient;
        }
    }
}

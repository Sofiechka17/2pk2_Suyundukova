using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace consoleProject
{
    internal class LittleWeight : Product
    {
        public LittleWeight(string name, double weight, double gabarite, double costs) : base(name, weight, gabarite, costs)
        {
            Name = name;
            Weight = weight;
            Gabarite = gabarite;
            Costs = costs;
            coficient = 0.8;
            getCosts();
        }

        public static bool operator <(LittleWeight product1, LittleWeight product2)
        {
            return product1.Costs < product2.Costs;
        }
        public static bool operator >(LittleWeight product1, LittleWeight product2)
        {
            return product1.Costs > product2.Costs;
        }
        public static bool operator ==(LittleWeight product1, LittleWeight product2)
        {
            return product1.Costs == product2.Costs;
        }
        public static bool operator !=(LittleWeight product1, LittleWeight product2)
        {
            return product1.Costs != product2.Costs;
        }
        public static bool operator >=(LittleWeight product1, LittleWeight product2)
        {
            return product1.Costs >= product2.Costs;
        }
        public static bool operator <=(LittleWeight product1, LittleWeight product2)
        {
            return product1.Costs <= product2.Costs;
        }

        public static double operator +(LittleWeight product1, LittleWeight product2)
        {
            return product1.Weight + product2.Weight;
        }
        public static double operator -(LittleWeight product1, LittleWeight product2)
        {
            return product1.Weight - product2.Weight;
        }

        public override void getCosts()
        {
            Costs *= coficient;
        }
    }
}

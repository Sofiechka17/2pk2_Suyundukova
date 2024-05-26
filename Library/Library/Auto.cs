using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Library
{
    public class Auto
    {
        public string model;
        public string condition;
        public string aclass;

        public string Model
        {
            get => model;
            set => model = value;
        }

        public string Condition
        {
            get => condition;
            set => condition = value;
        }

        public string Class
        {
            get => aclass;
            set => aclass = value;
        }

        public Auto() { }

        public Auto(string model, string condition, string aclass)
        {
            this.model = model;
            this.condition = condition;
            this.aclass = aclass;
        }

        public override string ToString()
        {
            return $"{Model}, {Condition}, {Class}";
        }

    }
}

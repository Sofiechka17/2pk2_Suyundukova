using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Library
{
    public class Service : IComparable<Service> // оеализация интерфейса
    {
        public string name;

        public string Name
        {
            get => name;
            set => name = value;
        }

        public Service() { }

        public Service(string name)
        {
            this.name = name;

        }

        public override string ToString()
        {
            return $"{Name}";
        }

        /// <summary>
        /// Реализация IComporable
        /// </summary>
        public int CompareTo(Service other)
        {
            return name.CompareTo(other.name);   // сравнение по названию
        }
    }
}

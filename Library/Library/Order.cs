using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public class Order
    {
        public string surnameandname;
        public string date;
        public string service;
        public string thisorder;

        public string NameAndSurname
        {
            get => surnameandname;
            set => surnameandname = value;
        }
        public string Date
        {
            get => date;
            set => date = value;
        }
        public string Service
        {
            get => service;
            set => service = value;
        }
        public string ThisOrder
        {
            get => thisorder;
            set => thisorder = value;
        }

        public Order() { }

        public Order(string surnameandname, string date, string service, string thisorder)
        { 
            this.surnameandname = surnameandname;
            this.date = date;
            this.service = service;
            this.thisorder = thisorder;
        }

        public override string ToString()
        {
            return $"{NameAndSurname}, {Date}, {Service}, {ThisOrder}";
        }

    }
}

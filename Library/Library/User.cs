using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public class User
    {
        public string nameAndSurname;
        public string email;
        public string password;

        public string NameAndSurname
        {
            get => nameAndSurname;
            set => nameAndSurname = value;
        }
        public string Email
        {
            get => email;
            set => email = value;
        }
        public string Password
        {
            get => password;
            set => password = value;
        }
        public User() { }

        public User(string nameandsurname, string email, string password)
        {
            this.nameAndSurname = nameandsurname;
            this.email = email;
            this.password = password;
        }

        public User(string email, string password)
        {
            this.email = email;
            this.password = password;
        }

        public override string ToString()
        {
            return $"{NameAndSurname}, {Email} : {Password}";
        }


    }
}

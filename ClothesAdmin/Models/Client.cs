using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ClothesAdmin.Models
{
    internal class Client
    {
        public int Id { get; }
        public string DNI { get; }
        public string Email { get; }

        public Client(int id, string dni, string email)
        {
            Id = id;
            DNI = dni;
            Email = email;
        }

        public Client(string dni, string email)
        {
            DNI = dni;
            Email = email;
        }
    }
}

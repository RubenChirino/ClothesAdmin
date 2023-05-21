using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Xml.Linq;

namespace ClothesAdmin.Models
{
    internal class Sale
    {

        public int Id { get; }
        public int IdProduct { get; }
        public int IdUser { get; }
        public int IdClient { get; }


        public Sale(int id, int idProduct,
            int idUser, int idClient)
        {
            Id = id;
            IdProduct = idProduct;
            IdUser = idUser;
            IdClient = idClient;
        }

        public Sale(int idProduct,
            int idUser, int idClient)
        {
            IdProduct = idProduct;
            IdUser = idUser;
            IdClient = idClient;
        }

    }
}

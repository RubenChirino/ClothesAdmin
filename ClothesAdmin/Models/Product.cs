using System;
using System.Collections.Generic;

namespace ClothesAdmin.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Image { get; set; }
        public string Description { get; set; }
        public int Stock { get; set; }
        public double Price { get; set; }
        public string Color { get; set; }
        public string Size { get; set; }
        public string Categorie { get; set; }
        public int IsActive { get; set; }
        public enum Sizes
        {
            XS,
            S,
            M,
            L,
            XL,
            XXL,
            XXXL
        }

        public enum Categories
        {
            casual,
            elegant,
            formal,
            office
        }

        public Product(int id, string name,
            string image, string description, int stock,
            double price, string color, string size,
            string categorie, int isActive)
        {
            Id = id;
            Name = name;
            Image = image;
            Description = description;
            Stock = stock;
            Price = price;
            Color = color;
            Size = size;
            Categorie = categorie;
            IsActive = isActive;
        }

        public Product(string name,
            string image, string description, int stock,
            double price, string color, string size,
            string categorie, int isActive)
        {
            Name = name;
            Image = image;
            Description = description;
            Stock = stock;
            Price = price;
            Color = color;
            Size = size;
            Categorie = categorie;
            IsActive = isActive;
        }

    }
}

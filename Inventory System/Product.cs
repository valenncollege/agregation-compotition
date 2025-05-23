using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Inventory_System
{
    public class Product
    {
        private string id;
        private string name;
        private double price;
        private int stock;
        private List<ProductImage> listImage;
        private List<Supplier> listSupplier;

        public string Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public double Price { get => price; set => price = value; }
        public int Stock { get => stock; set => stock = value; }
        public List<ProductImage> ListImage { get => listImage; private set => listImage = value; }
        public List<Supplier> ListSupplier { get => listSupplier; set => listSupplier = value; }

        public Product(string pId, string pName, double pPrice, int pStock)
        {
            this.Id = pId;
            this.Name = pName;
            this.Price = pPrice;
            this.Stock = pStock;
            this.ListImage = new List<ProductImage>();
            this.ListSupplier = new List<Supplier>();
        }

        public void AddImage(string inputId, string inputFileName)
        {
            ProductImage newImage = new ProductImage(inputId, inputFileName);
            this.ListImage.Add(newImage);
        }
    }
}
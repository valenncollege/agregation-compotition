using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Restaurant_System
{
    public class Menu
    {
        private string id;
        private string name;
        private string description;
        private double price;
        private Promo promoMenu;
        private List<Order> listOrder;

        public string Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public string Description { get => description; set => description = value; }
        public double Price { get => price; set => price = value; }
        public Promo PromoMenu { get => promoMenu; set => promoMenu = value; }
        public List<Order> ListOrder { get => listOrder; set => listOrder = value; }

        public Menu(string pId, string pName, string pDescription, double pPrice, Promo
            pPromo)
        {
            this.Id = pId;
            this.Name = pName;
            this.Description = pDescription;
            this.Price = pPrice;
            this.PromoMenu = pPromo;
            this.ListOrder = new List<Order>();
        }

    }
}
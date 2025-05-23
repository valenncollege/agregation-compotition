using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Restaurant_System
{
    public class Promo
    {
        private string id;
        private string name;
        private double discount;
        private DateTime startDate;
        private DateTime endDate;
        private List<Menu> listMenu;

        public string Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public double Discount { get => discount; set => discount = value; }
        public DateTime StartDate { get => startDate; set => startDate = value; }
        public DateTime EndDate { get => endDate; set => endDate = value; }
        public List<Menu> ListMenu { get => listMenu; set => listMenu = value; }

        public Promo(string pId, string pName, double pDiscount, DateTime pStart, DateTime 
            pEnd)
        {
            this.Id = pId;
            this.Name = pName;
            this.Discount = pDiscount;
            this.StartDate = pStart;
            this.EndDate = pEnd;
            this.ListMenu = new List<Menu>();
        }
    }
}
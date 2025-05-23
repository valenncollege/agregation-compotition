using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Inventory_System
{
    public class Supplier
    {
        private string id;
        private string name;
        private string address;

        public string Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public string Address { get => address; set => address = value; }

        public Supplier(string pId, string pName, string pAddress)
        {
            this.Id = pId;
            this.Name = pName;
            this.Address = pAddress;
        }
    }
}
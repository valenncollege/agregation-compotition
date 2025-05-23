using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Restaurant_System
{
    public class Table
    {
        private int no;
        private bool type;
        private int capacity;
        private List<Order> listOrder;

        public int No { get => no; set => no = value; }
        public bool Type { get => type; set => type = value; }
        public int Capacity { get => capacity; set => capacity = value; }
        public List<Order> ListOrder { get => listOrder; set => listOrder = value; }

        public Table(int pNo, bool pType, int pCapacity)
        {
            this.No = pNo;
            this.Type = pType;
            this.Capacity = pCapacity;
            this.ListOrder = new List<Order>();
        }
    }
}
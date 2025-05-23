using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Restaurant_System
{
    public class Order
    {
        private string id;
        private DateTime date;
        private int total;
        private Payment paymentofOrder;

        public string Id { get => id; set => id = value; }
        public DateTime Date { get => date; set => date = value; }
        public Payment PaymentofOrder { get => paymentofOrder; private set => paymentofOrder = value; }
        public int Total { get => total; set => total = value; }

        public Order(string pId, DateTime pDate, int pTotal, Payment pPayment)
        {
            this.Id = pId;
            this.Date = pDate;
            this.Total = pTotal;
            this.PaymentofOrder = pPayment;
        }

        public void AddPayment(bool inputType, string inputCardNum, double inputAmount, 
            double inputCharge)
        {
            Payment newPayment = new Payment(inputType, inputCardNum, inputAmount, inputCharge);
            this.PaymentofOrder = newPayment;
        }
    }
}
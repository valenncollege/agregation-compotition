using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Restaurant_System
{
    public class Payment
    {
        private bool type;
        private string cardNumber;
        private double amount;
        private double charge;

        public bool Type { get => type; set => type = value; }
        public string CardNumber { get => cardNumber; set => cardNumber = value; }
        public double Amount { get => amount; set => amount = value; }
        public double Charge { get => charge; set => charge = value; }

        public Payment(bool pType, string pCardNum, double pAmount, double pCharge)
        {
            this.Type = pType;
            this.CardNumber = pCardNum;
            this.Amount = pAmount;
            this.Charge = pCharge;
        }
    }
}
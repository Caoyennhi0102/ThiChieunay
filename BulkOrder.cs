using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace THITHU
{
    public class BulkOrder:Order
    {
        private double DisCount;

        public double DisCount1 { get => DisCount; set => DisCount = value; }


        public BulkOrder() : base() { }

        public BulkOrder(string orderID, string customerName, DateTime orderDate, int quantity, double unitPrice, double discount) : base()
        {
            this.OrderID1 = orderID;
            this.CustomesName1 = customerName;
            this.OrderDate1 = orderDate;
            this.Quantity1 = quantity;
            this.Price1 = unitPrice;
            this.DisCount1 = discount;
        }

        public override double TotalPrice()
        {
            double totalPrice = base.TotalPrice();
            return totalPrice - (totalPrice * DisCount1 / 100);
        }
    }
}

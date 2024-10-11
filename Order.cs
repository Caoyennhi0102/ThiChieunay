using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace THITHU
{
    public class Order
    {
        

            private string OrderID;
            private string CustomerName;
            private DateTime OrderDate;
            private int Quantity;
            private double Price;

            public string OrderID1 { get => OrderID; set => OrderID = value; }
            public string CustomesName1 { get => CustomerName; set => CustomerName = value; }
            public DateTime OrderDate1 { get => OrderDate; set => OrderDate = value; }
            public int Quantity1 { get => Quantity; set => Quantity = value; }
            public double Price1 { get => Price; set => Price = value; }



            public Order() { }

            public Order(string orderID, string customerName, DateTime orderDate, int quantity, double unitPrice)
            {
                OrderID = orderID;
                CustomerName = customerName;
                OrderDate = orderDate;
                Quantity = quantity;
                Price = unitPrice;
            }

            public virtual double TotalPrice()
            {
                return Quantity1 * Price1;
            }
        }
    }




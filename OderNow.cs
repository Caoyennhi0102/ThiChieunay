using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace THITHU
{
    public partial class OderNow : Form
    {
        List<Order> orderList = new List<Order>();
        public OderNow()
        {
            InitializeComponent();
        }

        private void btNhap_Click(object sender, EventArgs e)
        {
            string orderID = txtMaDonHang.Text;
            string customerName = txtTenKhachHang.Text;
            DateTime orderDate = dateTimePicker1.Value;
            int quantity = int.Parse(txtSoLuongSanpham.Text);
            double unitPrice = double.Parse(txtDonGia.Text);

            Order order;

            if (comboBox1.SelectedItem.ToString() == "Bulk")
            {
                double discount = double.Parse(txtDiscount.Text);
                order = new BulkOrder(orderID, customerName, orderDate, quantity, unitPrice, discount);
            }
            else
            {
                order = new Order(orderID, customerName, orderDate, quantity, unitPrice);
            }

            orderList.Add(order);
            UpdateDataGridView();
        }

        private void UpdateDataGridView()
        {
            dataGridView1.Rows.Clear();
            foreach (var order in orderList)
            {
                dataGridView1.Rows.Add(order.OrderID1, order.CustomesName1, order.OrderDate1.ToString("dd/MM/yyyy"), order.Quantity1, order.Price1, order.TotalPrice());
            }
        }

        private void btSum_Click(object sender, EventArgs e)
        {
            double totalValue = 0;
            foreach (var order in orderList)
            {
                totalValue += order.TotalPrice();
            }
            MessageBox.Show($"Tổng giá trị các đơn hàng: {totalValue} VND", "Tổng giá trị");
        }
    }
}

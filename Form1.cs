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
    public partial class Form1 : Form
    {
        List<ElectricCar> electricCars = new List<ElectricCar>();
        ElectricCar electric = new ElectricCar();
        public Form1()
        {
            InitializeComponent();
            dataGridView1.Columns.Add("HangXe1", "Hãng Xe");
            dataGridView1.Columns.Add("BienSo1", "Biển Số");
            dataGridView1.Columns.Add("NamSanXuat1","Năm Sản Xuất");
            dataGridView1.Columns.Add("GiaBan1", "Giá Bán");
            dataGridView1.Columns.Add("BatteryCapacity", "Dung Lượng PIN");


        }

        private void btThem_Click(object sender, EventArgs e)
        {
            electric.HangXe1 = txthangXe.Text;
            electric.BienSo1 = txtBienSo.Text;
            electric.NamSanXuat1 = txtNamSanXuat.Text;
            electric.GiaBan1 = double.Parse(txtGiaBan.Text);
            electricCars.Add(electric);
            dataGridView1.Rows.Add(txthangXe.Text, txtBienSo.Text, txtNamSanXuat.Text, double.Parse(txtGiaBan.Text), int.Parse(txtDLP.Text));
            ClearText();
           
        }
        private void ClearText()
        {
            txthangXe.Clear();
            txtBienSo.Clear();
            txtNamSanXuat.Clear();
            txtGiaBan.Clear();
            txtDLP.Clear();
        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            for(int i = electricCars.Count -1; i >= 0; i--)
            {
                if (electricCars[i].HangXe1 == txthangXe.Text)
                {
                    electricCars.RemoveAt(i);
                    dataGridView1.DataSource = null;
                    dataGridView1.DataSource = electricCars;
                }
            }
        }
    }
}

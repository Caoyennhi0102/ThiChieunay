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
    public partial class NhanVien : Form
    {
        List<Employee> employeeslist = new List<Employee>();
        Employee nv = new Employee();
        Manager manager = new Manager();
        public NhanVien()
        {
            InitializeComponent();

            dataGridView1.Columns.Add("Name1", "Họ Và Tên");
            dataGridView1.Columns.Add("ID1", "Mã Nhân Viên");
            dataGridView1.Columns.Add("ChucVu1", "Chức Vụ");
            dataGridView1.Columns.Add("LuongCoBan1", "Lương Cơ Bản");
            
            comboBox1.Items.Add("Quản Lý");
            comboBox1.Items.Add("Nhân Viên");

        }

        private void btNhap_Click(object sender, EventArgs e)
        {

            if(comboBox1.SelectedItem.ToString() == "Quản lý")
            {
                manager.Name1 = txtHovaTen.Text;
                manager.ID1 = txtID.Text;
                manager.ChucVu1 = comboBox1.SelectedItem.ToString();
                manager.LuongCoBan1 = double.Parse(txtluongcoban.Text);
                manager.TeamSize1 = int.Parse(txtTeamSize.Text);

                MessageBox.Show($"Lương Thực Lĩnh Quản Lý:{manager.LuongThucLinh()}VND");
                employeeslist.Add(manager);
            }
            else
            {
                nv.Name1 = txtHovaTen.Text;
                nv.ID1 = txtID.Text;
                nv.ChucVu1 = comboBox1.SelectedItem.ToString();
                nv.LuongCoBan1 = double.Parse(txtluongcoban.Text);
                MessageBox.Show($"Lương Thực Lĩnh Nhân Viên:{nv.LuongThucLinh()}VND");
                employeeslist.Add(nv);

            }

           
            UpdateDatagirdView();

           
            
        }
        private void UpdateDatagirdView()
        {
            dataGridView1.Rows.Clear();
            foreach(var Emp in employeeslist)
            {
               if(Emp is Manager)
                {
                    var manager = Emp as Manager;
                    dataGridView1.Rows.Add(manager.Name1, manager.ID1, manager.ChucVu1, manager.LuongCoBan1, manager.TeamSize1, manager.LuongThucLinh());
                }
                else
                {
                    dataGridView1.Rows.Add(Emp.Name1, Emp.ID1, Emp.ChucVu1, Emp.LuongCoBan1, Emp.LuongThucLinh());
                }
                
            }
        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            string Todelete = txtID.Text;

            Employee employee = employeeslist.FirstOrDefault(emp => emp.ID1 == txtID.Text);
            if(employee != null)
            {
                employeeslist.Remove(employee);

                UpdateDatagirdView();

                MessageBox.Show("Đã xóa nhân viên thành công");
            }
            else
            {
                MessageBox.Show("Không tìm thấy nhân viên với mã này");
            }
        }

        private void btSua_Click(object sender, EventArgs e)
        {
            string isEdit = txtID.Text;

            Employee updateemployee = employeeslist.FirstOrDefault(isedit => isedit.ID1 == txtID.Text);

            if(updateemployee != null)
            {
                updateemployee.Name1 = txtHovaTen.Text;
                updateemployee.ChucVu1 = comboBox1.SelectedItem.ToString();
                updateemployee.LuongCoBan1 = double.Parse(txtluongcoban.Text);


                if(updateemployee is Manager managerEditTeamSize)
                {
                    manager.TeamSize1 = int.Parse(txtTeamSize.Text);
                }

                UpdateDatagirdView();

                MessageBox.Show("Đã cập nhật thông tin nhân viên thành công.");
            }
            else
            {
                MessageBox.Show("Không tìm thấy nhân viên với mã này.");
            }
        }

        private void btTim_Click(object sender, EventArgs e)
        {
            string searchID = txtID.Text;

            Employee employeeSearch = employeeslist.FirstOrDefault(x => x.ID1 == txtID.Text);

            if(employeeSearch != null)
            {
                txtHovaTen.Text = employeeSearch.Name1;
                txtID.Text = employeeSearch.ID1;
                txtluongcoban.Text = employeeSearch.LuongCoBan1.ToString();


                if(employeeSearch is Manager searchmanager)
                {
                    txtTeamSize.Text = manager.TeamSize1.ToString();
                    comboBox1.SelectedItem = "Quản Lý";
                }
                else
                {
                    comboBox1.SelectedItem = "Nhân Viên";
                }

                MessageBox.Show("Đã tìm thấy nhân viên.");
            }
            else
            {
                MessageBox.Show("Không tìm thấy nhân viên với mã này.");
            }
        }
    }
}

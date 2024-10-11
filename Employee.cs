using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace THITHU
{
    public class Employee
    {
        private string Name;
        private string ID;
        private string ChucVu;
        private double LuongCoBan;
        private double phucap;
        private double thue = 0.1;
        private double BaoHiem = 0.10;



        public string Name1 { get => Name; set => Name = value; }
        public string ID1 { get => ID; set => ID = value; }
        public string ChucVu1 { get => ChucVu; set => ChucVu = value; }
        public double LuongCoBan1 { get => LuongCoBan; set => LuongCoBan = value; }
       
        public Employee() { }

        public Employee(string name, string id, string chucvu, double luongcoban)
        {
            this.Name1 = name;
            this.ID1 = id;
            this.ChucVu1 = chucvu;
            this.LuongCoBan1 = luongcoban;
           
        }
        // Tính lương thực lĩnh
        public virtual double LuongThucLinh()
        {
            double BaoHiem = 0.1 * LuongCoBan1;
            double Tax = LuongCoBan1 * 0.05;
            return LuongCoBan1 - BaoHiem - Tax;
        }
     
    }
}
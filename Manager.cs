using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace THITHU
{
    public  class Manager:Employee
    {
        private  int TeamSize;

        public int TeamSize1 { get => TeamSize; set => TeamSize = value; }

        public Manager():base()  { }

        public Manager(string name, string id, string chucvu, double luongcobang, int  teamsize) : base()
        {
            this.Name1 = name;
            this.ID1 = id;
            this.ChucVu1 = chucvu;
            this.LuongCoBan1 = luongcobang;
           
            this.TeamSize1 = teamsize;
        }

        public override double LuongThucLinh()
        {
            double BaoHiem = 0.1 * LuongCoBan1;
            double Bonus = LuongCoBan1 * 0.2;
            double Bonus2 = TeamSize1 * 100;
            double Tax = LuongCoBan1 * 0.5;
            return LuongCoBan1 - BaoHiem - Tax + Bonus;
        }


    }
}

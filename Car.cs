using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace THITHU
{
     public class Car
    {
        private string HangXe;
        private string BienSo;
        private string NamSanXuat;
        private double GiaBan;

        public string HangXe1 { get => HangXe; set => HangXe = value; }
        public string BienSo1 { get => BienSo; set => BienSo = value; }
        public string NamSanXuat1 { get => NamSanXuat; set => NamSanXuat = value; }
        public double GiaBan1 { get => GiaBan; set => GiaBan = value; }

        public Car() { }


        public Car(string hangxe, string bienSo, string namsanxuat, double giaban)
        {
            this.HangXe1 = HangXe;
            this.BienSo1 = bienSo;
            this.NamSanXuat1 = namsanxuat;
            this.GiaBan1 = giaban;
        }
    }
}

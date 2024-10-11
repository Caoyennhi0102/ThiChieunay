using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace THITHU
{
    public class ElectricCar:Car
    {
        private int BatteryCapacity;

        public int BatteryCapacity1 { get => BatteryCapacity; set => BatteryCapacity = value; }


        public ElectricCar() { }


        public ElectricCar(string hangxe, string bienso, string namsanxuat, double giaban, int batteryCapacity) : base()
        {
            this.HangXe1 = hangxe;
            this.BienSo1 = bienso;
            this.NamSanXuat1 = namsanxuat;
            this.GiaBan1 = giaban;
            this.BatteryCapacity1 = batteryCapacity;
        }
    }
}

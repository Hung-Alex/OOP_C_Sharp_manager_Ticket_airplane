using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace manager_vemaybay
{
    class ticket_maybay:IChucNang
    {
        private string name;
        private int ngayBay;
        private int giaVe;
        public  ticket_maybay()
        {

        }
  
        public int GetGiaVe
        {
            get { return this.giaVe; }
        }
        public void InPut()
        {
            Console.Write("Moi Ban nhap ten chuyen :");
            name = Console.ReadLine();
            Console.Write("moi ban nhap ngay bay :");
            ngayBay = int.Parse(Console.ReadLine());
            Console.Write("moi ban nhap gia ve :");
            giaVe = int.Parse(Console.ReadLine());
        }
        public override string ToString()
        {
            return $"Ten Chuyen: {this.name}\n Ngay Bay :{this.ngayBay}\n GiaVe :{this.giaVe}==>";
        }
    }
}

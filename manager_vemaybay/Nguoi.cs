using System;
using System.Collections.Generic;
using System.Text;

namespace manager_vemaybay
{
    class Nguoi:IChucNang
    {
        protected string hoTen;
        protected string gioiTinh;
        protected int age;
        public Nguoi()
        {

        }
        public void InPut()
        {
            Console.Write("Moi ban nhap ten :");
            this.hoTen = Console.ReadLine();
            Console.Write("moi ban nhap gioi tinh cua ban :");
            this.gioiTinh = Console.ReadLine();
            Console.Write("moi ban nhap tuoi :");
            age = int.Parse(Console.ReadLine());
        }
        public override string ToString()
        {
            return $"Ten :{this.hoTen}\n Gioi Tinh :{this.gioiTinh}\n age: {age}";
        }
    }
}

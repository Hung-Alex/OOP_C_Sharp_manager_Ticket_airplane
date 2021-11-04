using System;

namespace manager_vemaybay
{
    class Program
    {
        static void Main(string[] args)
        {
            HanhKhach a = new HanhKhach();
            a.InPut();
            Console.WriteLine(a.ToString());
            Console.WriteLine($"Tong tien : =>>{a.TongTien()}");
            Console.ReadKey();

        }
    }
}

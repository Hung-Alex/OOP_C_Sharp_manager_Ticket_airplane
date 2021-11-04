using System;
using System.Collections.Generic;
using System.Text;

namespace manager_vemaybay
{
    class HanhKhach:Nguoi
    {
        List<ticket_maybay> collection = new List<ticket_maybay>();

        public HanhKhach()
        {

        }
        public void InPut()
        {
            int cout = 0;
            base.InPut();
            Console.Write("ban muon mua bao nhieu ve");
            cout = int.Parse(Console.ReadLine());
            for (int i = 0; i <cout; i++)
            {
                ticket_maybay m = new ticket_maybay();
                Console.WriteLine($"ticket {i}");
                m.InPut();
                collection.Add(m);
            }
            
        }
        public override string ToString()
        {
            string s = "";
            s += base.ToString();
            foreach (var item in collection)
            {
                s += "\n" + item.ToString();
            }
            return s;
        }
        public int TongTien()
        {
            int sum = 0;
            foreach (var item in collection)
            {
                sum += item.GetGiaVe;
            }
            return sum;
        }
    }
}

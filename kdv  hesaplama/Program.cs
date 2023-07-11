using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kdv__hesaplama
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("kdv  oranın   lütfen  0,8  veya 0,1 veya 0,18  diye  yazınız");
            Console.WriteLine("ürün fiyatı");
            string girlenfıyat = Console.ReadLine();
            float fiyat=Convert.ToSingle(girlenfıyat);



            Console.WriteLine("kdv oranı");
            string gkdv = Console.ReadLine();
            float kdv = Convert.ToSingle(gkdv);
            float sonuc1 = fiyat * kdv / 100;

            Console.WriteLine("ürün kdv   dahil  olamndkı   fiyatı"+" "+ sonuc1 +" " +"tldir");
           

            Console.ReadLine();
        }
    }
}

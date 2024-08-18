using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace Week5FınalPractice
{
    public class Car
    {
        public DateTime productionDate;
        public int serialNumber { get; set; }
        public string? brand { get; set; }
        public string? model { get; set; }
        public string? color { get; set; }
        public int doorCount { get; set; }

        //Üretim Tarihi değeri araba üretilirken otomatik olarak o an olarak atanacak.
        public Car ()
        {
           productionDate = DateTime.Now;
        }

       public void showCarDetails()
        {
            Console.WriteLine("ARAÇ DETAYLARI");

            Console.WriteLine($"Aracın üretildiği tarih: {productionDate}");
            Console.WriteLine($"Seri numarası: {serialNumber}");
            Console.WriteLine($"Markası: {brand}");
            Console.WriteLine($"Modeli: {model}");
            Console.WriteLine($"Rengi: {color}");
            Console.WriteLine($"Kapı sayısı: {doorCount}");
            Console.WriteLine("");

        }

    }
}

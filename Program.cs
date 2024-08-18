using System.Globalization;
using Week5FınalPractice;

public class Program
{

    public static void Main(string[] args)
    {
        List<Car> carList = new List<Car>();

        while (true)
        {
            Console.Write("Araba üretmek istiyor musunuz? Evet ise 'e' Hayır ise 'h' yazınız : ");
            string userDecision = Console.ReadLine();

            //Kullanıcının cevabı hayır programı sonlandıralım,
            //evet ise bir araba nesnesi üretip özelliklerini konsol ekranından kullanıcıya girdirelim
            if (userDecision.ToLower() == "h")
            {
                Console.WriteLine("Görüşmek üzere");
                break;
            }
            if (userDecision.ToLower() == "e")
            {
                secondOrMoreCar:
               Car newCar = new Car();
                Console.Write("Aracınızın Seri numarasınız giriniz:");
                newCar.serialNumber =Convert.ToInt32(Console.ReadLine());

                Console.Write("Aracınızın Markasını giriniz:");
                newCar.brand = Console.ReadLine();

                Console.Write("Aracınızın modelini giriniz: ");
                newCar.model = Console.ReadLine();

                Console.Write("Aracınızın rengini giriniz: ");
                newCar.color = Console.ReadLine();

            //goto komutunu araştırınız.
            SelectDoors:
                Console.Write("Aracınızın kapı sayısını giriniz: ");
                if (!int.TryParse(Console.ReadLine(), out int doors) || (doors != 2 && doors != 4))
                {
                    Console.WriteLine("sadece 2 veya 4 kapılı seçebilirsiniz");
                    goto SelectDoors;
                }
                newCar.doorCount = doors;

                carList.Add(newCar);

                Console.Write("Başka bir araba daha üretmek ister misiniz? (evet veya hayır)");
                string userMoreCarDecision = Console.ReadLine().ToLower();
                if(userMoreCarDecision == "evet")
                {
                    goto secondOrMoreCar;
                }

            }
            else
            {
                Console.WriteLine("Yanlış bir cevap girdiniz lütfen tekrar deneyiniz!");
            }

        }

        Console.WriteLine("Listedeki bütün araçlar:\n");
        foreach (Car c in carList)
        {
            c.showCarDetails();
        }

    }

}



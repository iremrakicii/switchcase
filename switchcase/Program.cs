using System;

namespace switchcase
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Rüya Manavına Hoşgeldiniz!");
            Console.WriteLine("Elma = 2 TL");
            Console.WriteLine("Armut = 3 TL");
            Console.WriteLine("Çilek = 2 TL");
            Console.WriteLine("Muz = 3 TL");
            Console.WriteLine("Diğer bütün meyveler = 4 TL");
            Console.WriteLine("");
            Console.WriteLine("");
            
            Console.Write("Hangi Meyveyi Satın Almak İstersiniz? (elma/armut/çilek/muz/diğer):");

            string meyve = Console.ReadLine().ToLower();


            //IF ELSE İLE KONTROL

            if (meyve != null) 
            {
                if (meyve == "elma")
                    Console.WriteLine("Seçtiğiniz meyvenin fiyatı = 2 TL");
                else if (meyve == "armut")
                    Console.WriteLine("Seçtiğiniz meyvenin fiyatı= 3 TL");
                else if (meyve == "çilek")
                    Console.WriteLine("Seçtiğiniz meyvenin fiyatı = 2 TL");
                else if (meyve == "muz")
                    Console.WriteLine("Seçtiğiniz meyvenin fiyatı = 3 TL");
                else
                    Console.WriteLine("Seçtiğiniz meyvenin fiyatı = 4 TL");
            }
            // SWITCH CASE İLE KONTROL

            switch (meyve) // Bu tür bir problemi çözmek için switch-case yapısını kullanmak daha doğru ve verimli bir yaklaşımdır.
                           //okunabilirlik ve sabit değerleri karşılaştırma olarak daha uygun.
            {
                case "elma":
                    Console.WriteLine("Seçtiğiniz meyvenin fiyatı = 2 TL");
                    break;
                case "armut":
                    Console.WriteLine("Seçtiğiniz meyvenin fiyatı = 3 TL");
                    break;
                case "çilek":
                    Console.WriteLine("Seçtiğiniz meyvenin fiyatı = 2 TL");
                    break;
                case "muz":
                    Console.WriteLine("Seçtiğiniz meyvenin fiyatı = 3 TL");
                    break;
                default:
                    Console.WriteLine("Seçtiğiniz meyvenin fiyatı = 4 TL");
                    break;
            }
        }

       

    }
}

    

using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            // UserBuyValue();

            //***************************************************//


            // turDeyiskenleri();

            //***************************************************//

            // Conditions();

            //***************************************************//

            // SwitchCaseConditions();

            //***************************************************//

            // Loops();

            //***************************************************//

            calculatorApp();




        }

        //UserBuyValueExample
        private static void UserBuyValue()
        {
            Console.WriteLine("Zehmet Olmasa Adinizi girin : ");

            string ad = Console.ReadLine();

            Console.WriteLine("Zehmet Olmasa Soyadinizi girin : ");

            string soyad = Console.ReadLine();

            Console.WriteLine("Kullanicin Adi : " + ad);

            Console.WriteLine("Kullanicin Soyaddi : " + soyad);

            Console.ReadLine();
        }

        // C# Tür Dönüşümleri 
        private static void turDeyiskenleri()
        {
            string sayi = "1";

            string sayi1 = "10";

            int a = int.Parse(sayi);

            int b = int.Parse(sayi1);

            Console.WriteLine(a + b);

            Console.ReadLine();
        }
        // C# Conditions 
        private static void Conditions()
        {
            Console.WriteLine("Zehmet Olmasa reqem girin : ");

            string value = Console.ReadLine();

            int deyer = Convert.ToInt32(value);

            if (deyer > 30)
            {
                Console.WriteLine("Deyerin cavabi 30 dan boyukdur......");
            }
            else
            {
                Console.WriteLine("Deyerin Cavabi 30 dan kicikdir.......");
            }

            Console.ReadLine();
           
        }

        private static void SwitchCaseConditions()
        {
            int bakiye = 700;

            Console.WriteLine("ATM -e Hos Geldiniz");

            Console.WriteLine("Zehmet olmasa bir islem secin....");

            Console.WriteLine("1 - Hesabi gor");

            Console.WriteLine("2 - Pul cek");

            Console.WriteLine("3 - Pul yatir");

            Console.WriteLine("4 - Cixis ele");

            string secimVal = Console.ReadLine();

            switch (secimVal)
            {
                case "1":

                    Console.WriteLine("Hesabiniz : " + bakiye);

                    Console.ReadLine();

                    break;

                case "2":

                    Console.WriteLine("Cekmek istediyiniz tutari girin");

                    int value = Convert.ToInt32(Console.ReadLine());

                    if (value > bakiye)
                    {
                        Console.WriteLine("Balansinizdan artiq pul cekdiniz");
                        
                        Console.ReadLine();
                    }
                    else
                    {
                        Console.WriteLine("Qalan balansiniz : "+(bakiye-value));

                        Console.ReadLine();

                    }

                    break;

                case "3":

                    Console.WriteLine("Yatirmaq istediyiniz tutari girin");

                    int valueD = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Yeno Bakiyeniz : " + bakiye + valueD);

                    Console.ReadLine();

                    break;

                case "4":

                    Console.WriteLine("Hesabinizdan cixis edilir, Xos gunler");

                    Console.ReadLine();

                    break;

                default:

                    Console.WriteLine("Zehmet olmasa kecerli bir reqem girin....");

                    Console.ReadLine();

                    break;

            }
        }
        // C# Loops 
        private static void Loops()
        {

            for(int i = 1; i <= 10; i++)
            {
                for(int t = 1; t <= i; t++)
                {
                    Console.Write(t);
                }
                Console.WriteLine();
            }

            Console.ReadLine();

            for(int a = 1; a <= 10; a++)
            {
                if (a == 7)
                {
                    break;
                }
                Console.WriteLine("a -nin deyeri" +a);
            }

            Console.ReadLine();

        }

        // C# Calculator App 

        private static void calculatorApp()
        {
            for(int a = 1; a <= 10; a++)
            {
                for (int z = 1; z <= 10; z++)
                {
                    Console.WriteLine(a + "x" + z + "=" + (a * z));
                }
            }

            Console.ReadLine();
        }

    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.OOP
{
    public class Customer
    {

        public string isim;

        public string soyisim;

        public string maasDeyeri;

        public string cinssiyet;

        private int yas;

       public Customer()
        {
            Console.WriteLine("Customer Consturctor Method is Runnig.....");
        }
       

        public void customerInfoForm()
        {
            Console.WriteLine("Isim : " + isim);

            Console.WriteLine("Soyisim : " + soyisim);

            Console.WriteLine("Maasi : " + maasDeyeri);

            Console.WriteLine("Cinsiyyeti : " + cinssiyet);

            Console.WriteLine("Yasi : " + yas);
        }

    }
}

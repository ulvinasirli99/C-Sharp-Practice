using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Ders2
    {

        // Int value sum methods..........
       public int sumValue(int a, int c)
        {

            int sum = a + c;

            return sum;

        }

        public string nameSurname(string name,string surname)
        {
            string namE = name;

            string surN = surname;

            Console.WriteLine("Name : " + namE + " " + "Surname : " + surN);

            Console.ReadLine();

            return name + surname;

        }



    }

}

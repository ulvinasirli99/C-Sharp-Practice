using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.OOP
{
   public class Student
    {

        private string studentName;

        public void setStudentName(string isim)
        {
            studentName = isim;

        }

        public string getStudentName()
        {

            return studentName;

        }
    }
}

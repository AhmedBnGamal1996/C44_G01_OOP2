
using System.Security.Cryptography.X509Certificates;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace C44_G01_OOP02
{


    // Develop a Class to represent the Hiring Date Data:
    // consisting of fields to hold the day, month and Years.

    internal class HiringDate
    {


        public int year { get; set; }
        public int month { get; set; }
        public int day { get; set; }

        public HiringDate(int day , int month,  int year  )
        {

            if (year >=2000 &&  month >= 1 && month <= 12 && day >= 1 && day <= 31 )
            {

                this.year = year;  
                this.month = month;
                this.day = day; 


            }
            else
            {
                Console.WriteLine( "Invalid Date");
            }
            
            


        }
        public override string ToString()
        {
            return $"{day:D2} / {month:D2} / {year}";
        }



    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_2
{
   
    class Program
    {
        public void tempconverter()//Farenhit = (celcius*(9/5))+32
        {
            Console.WriteLine("Sr.No\tTemperature(Celsius)\tTemperature(Fahrenheit)");
            int srno = 1;
            int celsius = 0;
            while (srno<=11)
            {
           
                int fahrenheit = (celsius * 9) / 5 + 32;
                Console.WriteLine("{0}\t{1}\t\t\t{2}",srno,celsius,fahrenheit);
                srno++;
                celsius = celsius + 10;

            }
        }
        static void Main(string[] args)
        {
            Program obj = new Program();
            obj.tempconverter();
            Console.ReadLine();
        }
    }
}

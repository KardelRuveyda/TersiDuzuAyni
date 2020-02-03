using System;
using System.Threading.Tasks;
using System.Linq;

namespace TersiDuzuAyni
{
   class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 36500; i++)
            {
                Console.WriteLine("Tersi düzü aynı gün: " + DateTime.Today.AddDays(i).ToString("ddMmyyyy"));
            }
            Console.ReadLine();
        }
       

        public static string Tersi (DateTime dateTime)
        {
            var day = dateTime.ToString("ddMMyyyy");
            char[] reverse = day.ToArray();
            Array.Reverse(reverse);
            var a = new string(reverse);
            return a; 
        }

        public static bool Kontrol(DateTime dateTime)
        {
            string day = dateTime.ToString("ddMmyyyy");
            var a = day == Tersi(dateTime) ? true : false;
            return a;
        }
        
     }

}

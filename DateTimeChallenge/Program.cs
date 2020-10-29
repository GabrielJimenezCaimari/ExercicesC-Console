using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateTimeChallenge
{
    class Program
    {
        static void Main(string[] args)
        {
            //Basic Challenge
            //Pedir dia
            Console.Write("Introduce una fecha(formato M/d/yy): ");
            string diaresta = Console.ReadLine();
            DateTime dateresta = DateTime.ParseExact(diaresta, "M/d/yy", null);
            TimeSpan calculo = DateTime.Now.Subtract(dateresta);
            if (calculo.Days != 1)
            {
                Console.WriteLine($"Han pasado { calculo.Days }  dias desde { diaresta }");
            }
            else
            {
                Console.WriteLine($"Ha pasado { calculo.Days } dia desde { diaresta }");
            }

            //Pedir Tiempo
            Console.Write("Introduce una hora(formato H:mm): ");
            string horaresta = Console.ReadLine();
            DateTime timeresta = DateTime.ParseExact(horaresta, "H:mm", null);
            TimeSpan calculohora = DateTime.Now.Subtract(timeresta);
            Console.WriteLine($"Han pasado {calculohora.Hours} horas y {calculohora.Minutes} minutos");
            //Bonus Challenge

            Console.ReadLine();
        }
    }
}

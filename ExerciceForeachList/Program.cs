using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace ExerciceForeachList
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> nom = AñadirPersona();

            foreach(string hola in nom)
            {
                Console.WriteLine($"Hola  { hola }");
            }
            Console.ReadLine();
        }

        static List<string> AñadirPersona()
        {
            List<string> nom = new List<string>();

            nom.Add("Jhon");
            nom.Add("Mary");
            nom.Add("Sue");
            nom.Add("Greg");
            nom.Add("Yolanda");
            nom.Add("Jose");
            nom.Add("Bill");
            
            return nom;
        }

        
    }
}

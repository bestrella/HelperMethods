using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelperMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            string myvalue = superSecretFormula("World");
            Console.WriteLine(myvalue);
            Console.ReadLine();
        }

        private static string superSecretFormula()
        {
            
            return "hello world.";
        }


        private static string superSecretFormula(string name)
        {


            return String.Format("Hello {0}", name);
        }


           
    }
}

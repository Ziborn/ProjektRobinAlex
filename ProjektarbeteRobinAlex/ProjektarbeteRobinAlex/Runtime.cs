using CocaColaLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjektarbeteRobinAlex
{
    class Runtime
    {
        public void Start()
        {
            var colaLib = new ColaLibrary();

            for(int i = 1; i <= 100; i++)
            {
                Console.WriteLine(colaLib.InputOperator(i));
                
            }
            Console.ReadKey();
        }
    }
}

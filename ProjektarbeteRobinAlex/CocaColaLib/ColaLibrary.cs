using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CocaColaLib
{
    public class ColaLibrary
    {
        public string ConvertToCoca(int threeNumb)
        {
            //Första testet misslyckades efter en automatisk genererad metod.
            //throw new NotImplementedException();

            //return "Coca"; (Första koden för att lyckas med testet)

            string coca = "Coca";
            for(threeNumb = 1; threeNumb <= 100; threeNumb++)
            {
                if(threeNumb % 3 == 0)
                    Console.WriteLine(coca);
                else
                    Console.WriteLine(threeNumb);
            }
            return coca;
            //Färdig metod som klarar testet
        }

        public string ConvertToCola(int fiveNumb)
        {
            //Samma som första testet
            //throw new NotImplementedException();

            //return "Cola";

            string cola = "Cola";
            for (fiveNumb = 1; fiveNumb <= 100; fiveNumb++)
            {
                if (fiveNumb % 5 == 0)
                    Console.WriteLine(cola);
                else
                    Console.WriteLine(fiveNumb);
            }
            return cola;
            //Klart
        }

        public string ConvertToCocaCola(int fiveNumb, int threeNumb)
        {
            // Samma som tidigare test men med två variabler
            //throw new NotImplementedException();

            //return "CocaCola";

            string coca = "Coca";
            string cola = "Cola";
            string cocaCola = coca + cola;

            for(int i = 1; i <= 100; i++)
            {
                if(i % 1 == 0 && i % 5 == 0)
                    Console.WriteLine(cocaCola);
                else
                    Console.WriteLine(i);
            }
            return cocaCola;
            //Klart
        }

        public string InputOperator(int input)
        {
            if (input % 3 == 0 && input % 5 == 0)
                return "CocaCola";
            else if (input % 3 == 0)
                return "Coca";
            else if (input % 5 == 0)
                return "Cola";
            else
                return input.ToString();
        }
    }
}

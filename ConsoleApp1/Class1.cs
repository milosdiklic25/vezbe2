using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Class1
    {
        public void metoda(int n)
        {
            if (n % 10 == 3)
                Console.WriteLine("Sadrzi 3");
            else if ((n % 100 > 30) && (n % 100 < 40))
                Console.WriteLine("Sadrzi 3");
            else
                return;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_с_картинками
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Row в переводчике это ряд.
            int oneRow = 3;
            int pictures = 52;
            int fullRows;
            int notFullRows;

            fullRows = pictures / oneRow;
            
            notFullRows = pictures % oneRow;

            Console.WriteLine($"Количество полных рядов {fullRows} из картинок, и {notFullRows} картинка сверх меры");


        }
    }
}

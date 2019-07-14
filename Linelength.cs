using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Kolmio2
{
    class Program
    {
        static void Main(string[] args)
        {
            double alkuX, alkuY, loppuX, loppuY;
            WriteLine("anna viivan alkupisteen koordinaatit");
            Write("x-koordinaatti: ");
            alkuX = double.Parse(ReadLine());
            Write("y-koordinaatti: ");
            alkuY = double.Parse(ReadLine());
            WriteLine("anna viivan loppupisteen koordinaatit");
            Write("x-koordinaatti: ");
            loppuX = double.Parse(ReadLine());
            Write("y-koordinaatti: ");
            loppuY = double.Parse(ReadLine());

            WriteLine($"Viivan pituus on {ViivanPituus(alkuX, alkuY, loppuX, loppuY)}");
            ReadLine();

        }
        static double ViivanPituus(double x1,double y1, double x2, double y2)
        {
            double sivuA, sivuB;
            //lyhyiden sivujen pituudet (= x- ja y-akselilla)
            sivuA = Math.Abs(x1 - x2);
            sivuB = Math.Abs(y1 - y2);
            //Hypotenuusan pituus
            return Math.Sqrt(sivuA * sivuA + sivuB * sivuB);
        }

    }
}

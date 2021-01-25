using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TERNINGKASTET
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rdn = new Random();
            
            
            
            int terningkast = rdn.Next(1, 7);
            Console.WriteLine("Tryk på vilkårlig knap for at slå med terningen");
            Console.ReadKey();

            switch(terningkast)
            {
                case 1:
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Du slog en etter");                    
                    break;

                case 2:
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine("Du slog en toer");
                    break;

                case 3:
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("Du slog en treer");
                    break;

                case 4:
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.WriteLine("Du slog en fire");
                    break;

                case 5:
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("Du slog en femmer");
                    break;

                case 6:
                    Console.ForegroundColor = ConsoleColor.DarkGray;
                    Console.WriteLine("Du slog en sekser");
                    break;

            }
            Console.ReadKey();
        }
    }
}

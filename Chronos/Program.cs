using System;
using System.Diagnostics;
using System.Threading;

namespace Chronos
{
    public class Program
    {
        private static void Main(string[] args)
        {
            /*
            namespace                   : System.Diagnostics
            decorrido em milissegundos  : ElapsedMilliseconds
            cronómetro a contar o tempo : IsRunning
            Comecar a contar o tempo    : Start()
            parar de contar o tempo     : Stop()
            */

            Stopwatch chrono1 = new Stopwatch();
            Stopwatch chrono2 = new Stopwatch();
            
            chrono1.Start();
            Thread.Sleep(500); 

            chrono2.Start();
            Thread.Sleep(250);

            chrono1.Stop();
            chrono2.Stop();
            
            double xts = chrono1.Elapsed.TotalMilliseconds;
            double xts2 = chrono2.Elapsed.TotalMilliseconds;
            
            // normally shows 3 with the *10 shows 4.. 
            // cut with (int) for no round 
            Console.WriteLine($"{(int)(xts*10)}");
            Console.WriteLine($"{(int)(xts2*10)}");

        }
    }
}

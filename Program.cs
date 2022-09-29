using System;


namespace Stopwatch
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu();
        }

        static void Menu()
        {
            Console.Clear();

            Console.WriteLine("*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*");
            Console.WriteLine(" ");
            Console.WriteLine("Digite o tempo que deseja cronômetrar:");
            Console.WriteLine(" ");
            Console.WriteLine("S = Segundo => 10s = 10 Segundos.");
            Console.WriteLine("M = Minuto => 10m = 10 minutos.");
            Console.WriteLine("0s = sair");
            Console.WriteLine(" ");
            Console.WriteLine("*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*");


            string data = Console.ReadLine().ToLower();
            char type = char.Parse(data.Substring(data.Length - 1, 1));
            int time = int.Parse(data.Substring(0, data.Length - 1));
            int multiplier = 1;

            if (type == 'm')
                multiplier = 60;

            if (time == 0)
            {
                Sair();
                System.Environment.Exit(0);
            }


            PreStart(time * multiplier);
        }

        static void PreStart(int time)
        {
            Console.Clear();
            Console.WriteLine("Ready...");
            Thread.Sleep(1000);
            Console.WriteLine("Set...");
            Thread.Sleep(1000);
            Console.WriteLine("Go...");
            Thread.Sleep(2500);

            Start(time);
        }

        static void Start(int time)

        {
            int currentTime = 0;

            while (currentTime != time)
            {
                Console.Clear();
                currentTime++;
                Console.WriteLine(currentTime);
                Thread.Sleep(1000);
            }

            Console.Clear();
            Console.WriteLine("Stopwatch finalizado!");
            Thread.Sleep(2500);
            Menu();
        }

        static void Sair()
        {
            Console.WriteLine("................................................");
            Console.WriteLine(" ");
            Console.WriteLine("     Obrigado por utilizar nosso sistema!");
            Console.WriteLine(" ");
            Console.WriteLine("     Volte sempre :)");
            Console.WriteLine(" ");
            Console.WriteLine("................................................");
        }
    }
}

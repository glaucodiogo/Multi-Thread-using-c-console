using System;
using System.Threading;

namespace EstudoMultProcessamentoSimultaneo
{
    class Program
    {
        static void Main(string[] args)
        {

            Thread oThread = new Thread(() => WorkThread(9));
            oThread.IsBackground = true;
            oThread.Start();

            Thread oThread2 = new Thread(() =>WorkThread(0));
            oThread2.IsBackground = true;
            oThread2.Start();


            Thread oThread3 = new Thread(() => WorkThread(2));
            oThread3.IsBackground = true;
            oThread3.Start();

            Console.WriteLine("Main Thread Quits ..!");
            Console.ReadLine();

        }

        public static void WorkThread(int numero)
        {


            for(int i = 0; i <= 100; i++)
            {
                Console.WriteLine("Thread de trabalho está em andamento ..!");
                Thread.Sleep(2000); // Dormir por 2 segundos

            }

            Console.WriteLine("Thread de trabalho encerra ..!");

        }

    }
}

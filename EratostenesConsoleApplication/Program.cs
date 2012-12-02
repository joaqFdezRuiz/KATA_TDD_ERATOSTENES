using System.Collections.Generic;

namespace EratostenesConsoleApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            Eratostenes.IEratostenes iEratostenes = new Eratostenes.Eratostenes();
            List<int> lista = iEratostenes.Juego(100000);

            foreach (var item in lista)
            {
                System.Console.Write(item + ",");
            }
            System.Console.ReadLine();
        }
    }
}

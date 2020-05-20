using System;

namespace ProvaMetodi
{
    class Program
    {
        static void Main(string[] args)
        {
            string sensibile = ClasseBioInformatica.Metodi.LetturaSensibile();
            long lunghezzas = ClasseBioInformatica.Metodi.LunghezzaSensibile();
            Console.WriteLine(sensibile);
            Console.WriteLine("è lunga " + lunghezzas);
        }
    }
}

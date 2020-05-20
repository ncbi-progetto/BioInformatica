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
            Console.WriteLine(".");
            Console.WriteLine(".");
            Console.WriteLine(".");
            string resistente = ClasseBioInformatica.Metodi.LetturaResistente();
            long lunghezzar = ClasseBioInformatica.Metodi.LunghezzaResistente();
            Console.WriteLine(resistente);
            Console.WriteLine("è lunga " + lunghezzar);
            Console.WriteLine(".");
            Console.WriteLine(".");
            Console.WriteLine(". ");
            int posizione = ClasseBioInformatica.Metodi.CarattereDiverso();
            Console.WriteLine("la differenza si trova al carattere: " + posizione);
            Console.WriteLine(".");
            Console.WriteLine(".");
            Console.WriteLine(".");
            string porzioneuguale = ClasseBioInformatica.Metodi.PorzioneUguale();
            Console.Write("la porzione uguale è : ");
            Console.WriteLine(porzioneuguale);
            Console.WriteLine(".");
            Console.WriteLine(".");
            Console.WriteLine(".");
            int differenze = ClasseBioInformatica.Metodi.DifferenzeStringhe();
            Console.WriteLine("Le differenze sono : " + differenze);
            Console.ReadLine();
        }
    }
}

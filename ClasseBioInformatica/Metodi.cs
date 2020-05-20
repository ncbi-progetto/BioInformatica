using System;
using System.IO;

namespace ClasseBioInformatica
{
    public class Metodi
    {
        //LETTURA    
        public static string sensibile = "sensibile.txt";
        public static string resistente = "resistente.txt";
        public static string LetturaSensibile()
        {
            string lines = "";
            if (File.Exists(sensibile))
            {
                using (StreamReader srs = new StreamReader(sensibile))
                {
                    lines = srs.ReadToEnd();
                }
            }
            return lines;
        }
        public static string LetturaResistente()
        {
            string liner = "";
            if (File.Exists(resistente))
            {
                using (StreamReader srr = new StreamReader(resistente))
                {
                    liner = srr.ReadToEnd();
                }
            }
            return liner;
        }

        //LUNGHEZZA
        public static long LunghezzaSensibile()
        {
            string lines = Metodi.LetturaSensibile();
            long sensibilelength = lines.Length;
            return sensibilelength;
        }
        public static long LunghezzaResistente()
        {
            string lines = Metodi.LetturaResistente();
            long resistentelength = lines.Length;
            return resistentelength;
        }

        //POSIZIONE DIFFERENZA
        public static int CarattereDiverso()
        {
            string sensibile = Metodi.LetturaSensibile();
            string resistente = Metodi.LetturaResistente();
            for (int i = 0; i < Math.Min(sensibile.Length, resistente.Length); i++)
            {
                if (sensibile[i] != resistente[i])
                    return i;
            }
            return -1;
        }

    }
}

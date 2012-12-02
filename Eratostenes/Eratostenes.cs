using System;
using System.Collections.Generic;

namespace Eratostenes
{
    public class Eratostenes : IEratostenes
    {
        public List<int> Juego(int numMax)
        {
            if (numMax < 2)
                throw new ArgumentException("El num. pasado como parametro tiene que ser => 2");

            List<int> lista = CreamosLista(numMax);

            for (int i = 0; i < lista.Count; i++)
                for (int j = i + 1; j < lista.Count; j++)
                    if (EsMultiplo(lista[j], lista[i]))
                        EliminaItem(lista, j);
            
            return lista;
        }

        private static void EliminaItem(List<int> lista, int j)
        {
            lista.Remove(lista[j]);
        }

        private static bool EsMultiplo(int dividendo, int divisor)
        {
            return dividendo % divisor == 0;
        }

        private static List<int> CreamosLista(int numMax)
        {
            List<int> lista = new List<int>();
            for (int i = 2; i <= numMax; i++)
                lista.Add(i);
            return lista;
        }
    }
}

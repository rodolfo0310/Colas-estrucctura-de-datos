using System;
using System.Collections.Generic;

class cola
    {
        static void Main(string[] args)
        {
            Queue<int> elementos = new Queue<int>();

            //Anadiendo elementos a la cola

            foreach (int elemento in new int[5] {5, 8, 10, 12, 13 })
            {
                elementos.Enqueue(elemento);
            }

            //LEIDY DE LEON
            //Leer un elemento en una cola
            Console.WriteLine ("Leyendo la cola");
            foreach(int elemento in elementos);
            Console.WriteLine(elementos);

        }
    }
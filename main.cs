using System;
using System.Collections.Generic;

class cola
    {
        static void Main(string[] args)
        {
            //Bryan Rodríguez.
            Queue<int> elementos = new Queue<int>();

            //Anadiendo elementos a la cola

            foreach (int elemento in new int[5] {5, 8, 10, 12, 13 })
            {
                elementos.Enqueue(elemento);
            }

            //LEIDY DE LEON
            //Leer un elemento en una cola
            //Imprimimos el iterador que apunta hacia la colección
            Console.WriteLine ("Leyendo la cola");
            foreach(int elemento in elementos){
                  Console.WriteLine(elemento);
            }

        }
    }

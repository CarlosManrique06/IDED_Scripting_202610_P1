using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDED_Scripting_202610_P1
{
    internal class Sandbox
    {
        public static void Main(string[] args)
        {
            // You can use this space to test your code before submitting it.
            Console.WriteLine("Hello, World!");
            // ===== EJERCICIO 1 =====
            Console.WriteLine("=== EJERCICIO 1: FindNumberInSortedList ===\n");

            List<int> lista = new List<int> { 15, 3, 8, 5, 20, 7, 1 };
            int target = 8;

            Console.WriteLine("Lista original:");
            ImprimirLista(lista);

            bool encontrado = TestMethods.FindNumberInSortedList(target, lista);

            Console.WriteLine("Lista ordenada descendentemente:");
            ImprimirLista(lista);
            Console.WriteLine($"¿El número {target} está en la lista? {encontrado}");

            // ===== EJERCICIO 2 =====
            Console.WriteLine("\n=== EJERCICIO 2: Pila ===\n");

            Stack<int> pila = new Stack<int>();
            pila.Push(4);
            pila.Push(15);
            pila.Push(7);
            pila.Push(10);
            pila.Push(11);
            pila.Push(6);

            Console.WriteLine("Pila original:");
            ImprimirPila(pila);

            // 2a: FindPrime
            Console.WriteLine("\n--- 2a: FindPrime ---");
            int primerPrimo = TestMethods.FindPrime(pila);
            Console.WriteLine($"Primer primo encontrado: {primerPrimo}");
            Console.WriteLine("Pila después de FindPrime (debe estar igual):");
            ImprimirPila(pila);

            // 2b: RemoveFirstPrime
            Console.WriteLine("\n--- 2b: RemoveFirstPrime ---");
            Stack<int> pilaSinPrimo = TestMethods.RemoveFirstPrime(pila);
            Console.WriteLine("Pila sin el primer primo:");
            ImprimirPila(pilaSinPrimo);
            Console.WriteLine("Pila original ");
            ImprimirPila(pila);

            // 2c: QueueFromStack
            Console.WriteLine("\n--- 2c: QueueFromStack ---");
            Queue<int> cola = TestMethods.QueueFromStack(pila);
            Console.WriteLine("Cola creada desde la pila:");
            ImprimirCola(cola);
            Console.WriteLine("Pila original");
            ImprimirPila(pila);
        }

        static void ImprimirLista(List<int> lista)
        {
            Console.Write("[ ");
            for (int i = 0; i < lista.Count; i++)
            {
                Console.Write(lista[i]);
                if (i < lista.Count - 1)
                    Console.Write(", ");
            }
            Console.WriteLine(" ]");
        }

        static void ImprimirPila(Stack<int> pila)
        {
            Stack<int> temp = new Stack<int>();
            Console.Write("(tope) [ ");

            while (pila.Count > 0)
            {
                int elemento = pila.Pop();
                Console.Write(elemento + " ");
                temp.Push(elemento);
            }

            while (temp.Count > 0)
                pila.Push(temp.Pop());

            Console.WriteLine("] (base)");
        }

        static void ImprimirCola(Queue<int> cola)
        {
            Queue<int> temp = new Queue<int>();
            Console.Write("(frente) [ ");

            while (cola.Count > 0)
            {
                int elemento = cola.Dequeue();
                Console.Write(elemento + " ");
                temp.Enqueue(elemento);
            }

            while (temp.Count > 0)
                cola.Enqueue(temp.Dequeue());

            Console.WriteLine("] (final)");
        }


        
    }
}
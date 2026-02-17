namespace IDED_Scripting_202610_P1
{
    internal class TestMethods
    {
        //---------------------------------------------------------------------------------------------------------------------------
       public static void SeparateElements(Queue<int> input, out Stack<int> included, out Stack<int> excluded)
        {
            included = new Stack<int>();
            excluded = new Stack<int>();

            int size = input.Count;

            int[] tempIncluded = new int[size];
            int[] tempExcluded = new int[size];

            int countIncluded = 0;
            int countExcluded = 0;

            for (int i = 0; i < size; i++)
            {
                int number = input.Dequeue();

                if (BelongsToSequence(number))
                {
                    tempIncluded[countIncluded++] = number;
                }
                else
                {
                    tempExcluded[countExcluded++] = number;
                }
            }

            // Insertar en orden inverso para mantener el orden original
            for (int i = countIncluded - 1; i >= 0; i--)
            {
                included.Push(tempIncluded[i]);
            }

            for (int i = countExcluded - 1; i >= 0; i--)
            {
                excluded.Push(tempExcluded[i]);
            }
        }

        private static bool BelongsToSequence(int number)
        {
            if (number == 0)
                return false;

            int absolute = number < 0 ? -number : number;

            int root = 1;

            while (root * root < absolute)
            {
                root++;
            }

            if (root * root != absolute)
                return false;

            if (root % 2 != 0 && number < 0)
                return true;

            if (root % 2 == 0 && number > 0)
                return true;

            return false;
        }
//----------------------------------------------------------------------------------------------------------------------------------------------------------------------
       public static List<int> GenerateSortedSeries(int n)
{
    List<int> result = new List<int>();

    if (n <= 0)
    {
        return result;
    }

    for (int i = 1; i <= n; i++)
    {
        int value = i * i;

        if (i % 2 != 0) // impar → negativo
        {
            value = -value;
        }

        // Insertar manualmente en orden ascendente
        int position = 0;

        while (position < result.Count && result[position] < value)
        {
            position++;
        }

        result.Insert(position, value);
    }

    return result;
}

        

//---------------------------------------------------------------------------------------------------------------------------------------------------------------------
        public static bool FindNumberInSortedList(int target, in List<int> list)
        {
            
            for (int i = 0; i < list.Count - 1; i++)
            {
                for (int j = 0; j < list.Count - 1 - i; j++)
                {
                    if (list[j] < list[j + 1])
                    {
                        int temp = list[j];
                        list[j] = list[j + 1];
                        list[j + 1] = temp;
                    }
                }
            }

           
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i] == target)
                    return true;
            }

            return false;
        }
        //----------------------------------------------------------------------------------------------------------------------------------------------------------------------------
        public static int FindPrime(in Stack<int> list)
        {
            Stack<int> temp = new Stack<int>();
            int primoEncontrado = 0;

            // Buscar primo
            while (list.Count > 0)
            {
                int elemento = list.Pop();
                temp.Push(elemento);

                if (primoEncontrado == 0 && IsPrime(elemento))
                {
                    primoEncontrado = elemento;
                }
            }

            // Restaurar pila 
            while (temp.Count > 0)
            {
                list.Push(temp.Pop());
            }

            return primoEncontrado;
        }

        public static bool IsPrime(int n)
        {
            if (n <= 1)
                return false;

            for (int i = 2; i <= Math.Sqrt(n); i++)
            {
                if (n % i == 0)
                    return false;
            }

            return true;
        }

        public static Stack<int> RemoveFirstPrime(in Stack<int> stack)
        {
            Stack<int> temp = new Stack<int>();
            int EliminarPrimo = -1;

            // Encontrar cuál es el primer primo
            while (stack.Count > 0)
            {
                int elemento = stack.Pop();
                temp.Push(elemento);

                if (EliminarPrimo == -1 && IsPrime(elemento))
                {
                   EliminarPrimo = elemento;
                }
            }

            // Restaurar stack sin el primo
            Stack<int> resultado = new Stack<int>();
            bool yaElimine = false;

            while (temp.Count > 0)
            {
                int elemento = temp.Pop();
                stack.Push(elemento);

                if (elemento == EliminarPrimo && !yaElimine)
                {
                    yaElimine = true;
                   
                }
                else
                {
                    resultado.Push(elemento);
                }
            }

            return resultado;
        }

        public static Queue<int> QueueFromStack(Stack<int> stack)
        {
            Stack<int> temp = new Stack<int>();
            Queue<int> cola = new Queue<int>();

            // Desapilar 
            while (stack.Count > 0)
            {
                temp.Push(stack.Pop());
            }

            // Pasar a cola 
            while (temp.Count > 0)
            {
                int elemento = temp.Pop();
                cola.Enqueue(elemento);
                stack.Push(elemento);
            }

            return cola;
        }
    }
}

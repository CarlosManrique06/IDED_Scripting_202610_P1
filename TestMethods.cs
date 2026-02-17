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
        public static List<int> GenerateSortedSeries(int n) => null;
        


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
        public static int FindPrime(in Stack<int> list) => 0;

        public static bool IsPrime(int n) => false;

        public static Stack<int> RemoveFirstPrime(in Stack<int> stack) => null;

        public static Queue<int> QueueFromStack(Stack<int> stack) => null;
    }
}

namespace IDED_Scripting_202610_P1
{
    internal class TestMethods
    {
        public static void SeparateElements(Queue<int> input, out Stack<int> included, out Stack<int> excluded)
        {
            included = null;
            excluded = null;
        }

        public static List<int> GenerateSortedSeries(int n) => null;

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

        public static int FindPrime(in Stack<int> list) => 0;

        public static bool IsPrime(int n) => false;

        public static Stack<int> RemoveFirstPrime(in Stack<int> stack) => null;

        public static Queue<int> QueueFromStack(Stack<int> stack) => null;
    }
}
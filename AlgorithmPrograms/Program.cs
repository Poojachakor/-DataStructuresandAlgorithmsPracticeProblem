namespace AlgorithmPrograms
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 5, 0, 3, 9, 6, 2, 1 };
            BubbleSort.doBubbleSort(array);
            Console.WriteLine("Sorted Array");
            foreach (int i in array)
                Console.WriteLine(i + " ");
        }
    }
}
namespace AlgorithmPrograms
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr2 = { 32, 12, 9, 65, 24, 5 };
            MergeSort.Sort(arr2, 0, arr2.Length - 1);
            MergeSort.PrintArray(arr2);

        }
    }

}
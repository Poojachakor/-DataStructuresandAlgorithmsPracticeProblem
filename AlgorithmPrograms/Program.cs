namespace AlgorithmPrograms
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 4, 10, 15, 25, 30, 49, 61, 80, 110, 120 };  //=0th + last/2=
            int target = 25;
            //  BinarySearch binarysearch = new BinarySearch();
            int index = BinarySearch.BinarySearchDemo(array, target);
            Console.WriteLine(index);
            if (index < 0)
            {
                Console.WriteLine($"{target} is not found");
            }
            else
            {
                Console.WriteLine($"{target} is found at index: {index}");
            }
        }

    }
    

}
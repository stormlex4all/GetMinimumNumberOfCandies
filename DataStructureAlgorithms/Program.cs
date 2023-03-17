namespace DataStructureAlgorithms
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }

        /// <summary>
        /// Solves an DSA Question in the readme
        /// </summary>
        /// <param name="n"></param>
        /// <param name="arr"></param>
        /// <returns></returns>
        public static long GetMinimumNumberOfCandies(int n, IList<int> arr)
        {
            //to determine if there is a chain of reducing values longer than half the length of the List
            if (HelperMethods.GetLongestContinuousConsecutiveReduction(arr) >= arr.Count / 2)
            {
                arr = HelperMethods.ReverseIEnumerableB(arr);
            }
            long[] candies = new long[n];
            for (int i = 0; i < arr.Count; i++)
            {
                int item = arr[i];
                long itemC = candies[i];
                int c = 1;
                if (i == 0)
                {
                    candies[i] = c;
                    continue;
                }
                else
                {
                    int pItem = arr[i - 1];
                    long pItemC = candies[i - 1];
                    if (item > pItem)
                    {
                        candies[i] = ++pItemC;
                    }
                    else
                    {
                        candies[i] = 1;
                        if (candies[i - 1] == candies[i])
                        {
                            int j = i;
                            while (j >= 0 && j - 1 >= 0 && arr[j - 1] > arr[j] && candies[j - 1] == candies[j])
                            {
                                candies[j - 1] = ++candies[j - 1];
                                j--;
                            }
                        }
                    }
                }
            }

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"{arr[i]}: {candies[i]}");
            }
            return candies.Sum();
        }
    }
}
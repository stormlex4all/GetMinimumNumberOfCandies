namespace DataStructureAlgorithms
{
    public static class HelperMethods
    {
        /// <summary>
        /// Gets the number of the longest chain of reducing numbers
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>
        public static int GetLongestContinuousConsecutiveReduction(IList<int> nums)
        {
            int n = 0;
            for (int i = 0; i < nums.Count; i++)
            {
                if (i + 1 >= nums.Count)
                {
                    break;
                }
                if (nums[i] - nums[i + 1] == 1)
                {
                    n++;
                }
                else
                {
                    n = 0;
                }
            }
            return n;
        }

        /// <summary>
        /// Reverses the order of the items in the List with an O(n/2) as long as the items are struct types
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="enumerable"></param>
        /// <returns></returns>
        public static IList<T> ReverseIEnumerableB<T>(IList<T> enumerable) where T : struct
        {
            double l = enumerable.Count() - 1;
            int s = 0;
            double m = Math.Floor(l / 2);
            for (int i = 0; i < l + 1; i++)
            {
                if (i > m)
                {
                    break;
                }
                s = (int)l - i;
                T n1 = enumerable.ElementAt(i);
                T n2 = enumerable.ElementAt(s);
                enumerable[s] = n1;
                enumerable[i] = n2;
            }
            return enumerable;
        }
    }
}

namespace DSA_Code
{
    public class FrequentK
    {
        public static void Main()
        {
            int[] nums = new int[10];
            int k = 2;

            Dictionary<int, int> frequent = new Dictionary<int, int>();

            foreach(var num in nums)
            {
                if(frequent.ContainsKey(num))
                {
                    frequent[num]++;
                }
                else
                {
                    frequent[num] = 1;
                }
            }
            var output = frequent.OrderByDescending(x => x.Value).Take(k).Select(x => x.Key).ToArray();
        }
    }
}

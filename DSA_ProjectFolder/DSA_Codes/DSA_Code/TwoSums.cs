namespace DSA_Code
{
    public class TwoSums
    {
        public static void Main()
        {
            var n = Console.Read();
            var target = Console.Read();
            int[] num = new int[n];
            var output = new Dictionary<int, int>();
            for (int i=0; i < num.Length; i++)
            {
                var remaining = target - num[i];

                if (output.ContainsKey(remaining))
                {
                    //return new int[] { output[i], i };
                }
                output[num[i]] = i;
            }
            //return new int[] { };
        }
    }
}

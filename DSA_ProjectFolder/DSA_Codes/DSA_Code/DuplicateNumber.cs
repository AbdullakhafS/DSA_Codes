namespace DSA_Code
{
    public class DuplicateNumber
    {
        public static void Main()
        {
            var n = Console.Read();
            int[] array = new int[n];

            if (array.Length != new HashSet<int>(array).Count())
            {
                Console.WriteLine(false);
            }
            else
            {
                Console.WriteLine(true);
            }
        }
    }
}

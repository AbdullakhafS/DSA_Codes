public class YoungPhysicist
{
    static void Main()
    {
        // Read the number of force vectors
        int n = int.Parse(Console.ReadLine());

        // Arrays to store sums of x, y, z components
        int[] sum = new int[3]; // sum[0] = sumX, sum[1] = sumY, sum[2] = sumZ

        for (int i = 0; i < n; i++)
        {
            // Read input and split into x, y, z components
            string[] input = Console.ReadLine().Split();
            sum[0] += int.Parse(input[0]); // sumX
            sum[1] += int.Parse(input[1]); // sumY
            sum[2] += int.Parse(input[2]); // sumZ
        }

        // Check if all sums are zero
        if (sum[0] == 0 && sum[1] == 0 && sum[2] == 0)
            Console.WriteLine("YES");
        else
            Console.WriteLine("NO");
    }
}
namespace DSA_Code
{
    public class ProductOfArray
    {
        public static void Main()
        {
            int n = 10;
            int[] product = new int[n];
            int[] input = new int[n];
            
            product[0] = 1;

            for(int i =1; i<n; i++)
            {
                product[i] = product[i - 1] * input[i - 1];
            }

            var rightproduct = 1;
            for(int i=n-1; i>=0; i--)
            {
                product[i] *= rightproduct;
                rightproduct *= input[i];
            }
            var output = product;
        }
    }
}

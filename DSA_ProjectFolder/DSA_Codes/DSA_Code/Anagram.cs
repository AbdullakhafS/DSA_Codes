namespace DSA_Code
{
    public class Anagram
    {
        public static void Main()
        {
            string s = Console.ReadLine();
            string t = Console.ReadLine();

            Dictionary<char, int> anagram = new Dictionary<char, int>();

            if (s.Length != t.Length)
            {
                //return false;
            }

            for(int i=0; i<s.Length; i++)
            {
                if (anagram.TryGetValue(s[i], out var count))
                {
                    anagram[s[i]]++;
                }
                else
                    anagram[s[i]] = 1;
            }

            for(int i =0; i<s.Length; i++)
            {
                if (anagram.TryGetValue(t[i], out var count))
                {
                    if (count == 0)
                    {
                        // return false;
                    }
                    anagram[t[i]]--;
                }
                else
                {
                    // return false;
                }
            }
            // return true;
        }
    }
}

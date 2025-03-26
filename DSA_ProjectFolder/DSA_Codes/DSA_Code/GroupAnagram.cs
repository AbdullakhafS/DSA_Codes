namespace DSA_Code
{
    public class GroupAnagram
    {
        public static void Main()
        {
            Dictionary<string, List<string>> anagram = new Dictionary<string, List<string>>();

            string[] strs = new string[] { };

            foreach(string str in strs)
            {
                char[] chars = str.ToCharArray();
                Array.Sort(chars);
                string sorted = new string(chars);

                if(!anagram.ContainsKey(sorted))
                {
                    anagram[sorted] = new List<string>();
                }
                anagram[sorted].Add(str);
            }
            //return anagram.Select(x => x.Value).ToList<IList<string>>();
        }
    }
}

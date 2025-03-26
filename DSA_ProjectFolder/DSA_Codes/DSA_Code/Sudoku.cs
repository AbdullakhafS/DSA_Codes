namespace DSA_Code
{
    public class Sudoku
    {
        public static void Main()
        {
            int n = 9;
            char[][] board = new char[n][n];
            HashSet<char>[] rows = new HashSet<char>[n];
            HashSet<char>[] cols = new HashSet<char>[n];
            HashSet<char>[] boxes = new HashSet<char>[n];

            for(int i=0; i<n; i++)
            {
                rows[i] = new HashSet<char>();
                cols[i] = new HashSet<char>();
                boxes[i] = new HashSet<char>();
            }

            for(int i=0; i<n; i++)
            {
                for(int j=0; j<n; j++)
                {
                    var num = board[i][j];
                    if (num == '.') continue;

                    var boxIndex = (i / 3) * 3 + (j / 3);

                    if (rows[i].Contains(num) || cols[j].Contains(num) || boxes[boxIndex].Contains(num))
                    {
                        //return false;
                    }
                    rows[i].Add(num);
                    cols[j].Add(num);
                    boxes[boxIndex].Add(num);
                }
            }
            //return true;
        }
    }
}

namespace AlgorithmHelper.SubstringMatch
{
    public class SubstringMatch
    {
        private SubstringMatch()
        {
        }


        public static int BruteForce(string s, string t)
        {
            if (s.Length < t.Length) return -1;

            // [i,i + t.Length - 1] == t
            for (int i = 0; i + t.Length - 1 < s.Length; i++)
            {
                int j = 0;
                for (; j < t.Length; j++)
                {
                    if (s[i + j] != t[j]) break;
                }

                if (j == t.Length) return i;
            }

            return -1;
        }
    }
    
    
    
}
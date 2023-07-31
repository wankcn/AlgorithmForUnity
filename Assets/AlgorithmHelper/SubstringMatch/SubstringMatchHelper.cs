using System;
using System.Diagnostics;
using Debug = UnityEngine.Debug;

namespace AlgorithmHelper.SubstringMatch
{
    public class SubstringMatchHelper
    {
        private SubstringMatchHelper()
        {
        }


        public static void MatchTest(string name, string s, string t)
        {
            int pos = -1;
            Stopwatch sw = new Stopwatch();
            sw.Start();
            if (name.Equals("BruteForce")) pos = SubstringMatch.BruteForce(s, t);
            if (s.IndexOf(t, StringComparison.Ordinal) != pos)
                throw new Exception(name + "Failed!");
            sw.Stop();
            Debug.Log($"{name}: res = {pos}, time = {sw.Elapsed.TotalSeconds} s");
        }
    }
}
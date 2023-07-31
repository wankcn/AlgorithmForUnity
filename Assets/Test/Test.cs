using System.Text;
using AlgorithmHelper.SubstringMatch;
using UnityEngine;


public class Test : MonoBehaviour
{
    void Start()
    {
        string s = "qwertyuiopASDFGHJK";
        string t = "DF";

        SubstringMatchHelper.MatchTest("BruteForce", s, t);


        // Worst case
        int n = 1000000, m = 1000;
        StringBuilder src = new StringBuilder();
        for (int i = 0; i < n; i++) src.Append('a');
        StringBuilder target = new StringBuilder();
        for (int i = 0; i < m - 1; i++) target.Append('a');
        target.Append('b');
        SubstringMatchHelper.MatchTest("BruteForce", src.ToString(), target.ToString());
    }
}
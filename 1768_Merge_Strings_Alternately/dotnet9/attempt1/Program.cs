global using System;
global using System.Collections.Generic;
global using System.Collections;
global using System.Linq;
global using System.Text;
global using System.Threading.Tasks;

using leetcode;

string PrintTests(Input input, string expected)
{
    Solution solution = new();
    string merged = solution.MergeAlternately(input.word1, input.word2);
    string status = expected == merged ? "success" : "failure";
    return $"[{status}] Merge Alternately word 1: '{input.word1}', word 2: '{input.word2}' ==> '{merged}'";
}

Console.WriteLine(PrintTests(new Input("abc", "def"), "adbecf"));
Console.WriteLine(PrintTests(new Input("ab", "def"), "adbef"));
Console.WriteLine(PrintTests(new Input("abc", "de"), "adbec"));
Console.WriteLine(PrintTests(new Input("", "de"), "de"));
Console.WriteLine(PrintTests(new Input("abc", ""), "abc"));

record struct Input(string word1, string word2);
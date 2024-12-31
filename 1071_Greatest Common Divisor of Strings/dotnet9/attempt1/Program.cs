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
    string gcd = solution.GcdOfStrings(input.str1, input.str2);
    string status = expected == gcd ? "success" : "failure";
    return $"[{status}] Greatest Common Divisor of Strings word 1: '{input.str1}', word 2: '{input.str2}' ==> '{gcd}'";
}
var a = "A".AsSpan();
var ab = "AB".AsSpan();
Console.WriteLine(Solution.RepeatedMatch("AAAAA", ref a));
Console.WriteLine(Solution.RepeatedMatch("ABABAB", ref ab));
Console.WriteLine(Solution.RepeatedMatch("ABCABAB", ref ab));
Console.WriteLine(Solution.RepeatedMatch("ABABCABC", ref ab));

Console.WriteLine(PrintTests(new Input("ABCABC", "ABC"), "ABC"));
Console.WriteLine(PrintTests(new Input("ABABAB", "ABAB"), "AB"));
Console.WriteLine(PrintTests(new Input("ABABABAB", "ABAB"), "ABAB"));

Console.WriteLine(PrintTests(new Input("LEET", "CODE"), ""));
Console.WriteLine(PrintTests(new Input("AAAAB", "AAAABAAAAB"), "AAAAB"));
Console.WriteLine(PrintTests(new Input("A", "AAAA"), "A"));

record struct Input(string str1, string str2);
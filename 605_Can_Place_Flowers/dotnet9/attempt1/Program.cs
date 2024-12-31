global using System;
global using System.Collections.Generic;
global using System.Collections;
global using System.Linq;
global using System.Text;
global using System.Threading.Tasks;

using leetcode;

string PrintList<T>(IList<T> bools)
{
    StringBuilder sb = new StringBuilder(bools.Count() * 7 + 2);
    sb.Append("[");
    foreach (var v in bools)
    {
        sb.Append(v);
        sb.Append(',');
    }
    sb.Append("]");

    return sb.ToString();
}

string PrintArray<T>(T[] bools) => PrintList<T>(bools.ToList());
bool Matches(bool[] expected, IList<bool> actual)
{
    for (int i = 0; i < expected.Length; i++)
    {
        if (expected[i] != actual[i]) return false;
    }
    return true;
}

string PrintTests(Input input, bool expected)
{
    Solution solution = new();
    var processed = solution.CanPlaceFlowers(input.flowerBed, input.n);
    string status = expected == processed ? "success" : "failure";
    return $"[{status}] Can place flowers: '{PrintArray(input.flowerBed)}' when given an extra: {input.n} ==> '{processed}'";
}

Console.WriteLine(PrintTests(new Input([1, 0, 0, 0, 1], 1), true));
Console.WriteLine(PrintTests(new Input([1, 0, 0, 0, 1], 2), false));
Console.WriteLine(PrintTests(new Input([1, 0, 0, 0, 0, 1], 2), false));
Console.WriteLine(PrintTests(new Input([0, 0, 0], 2), true));
Console.WriteLine(PrintTests(new Input([0, 0, 1], 1), true));
Console.WriteLine(PrintTests(new Input([0, 0, 0, 1], 1), true));
Console.WriteLine(PrintTests(new Input([0, 0, 0, 1], 2), false));
Console.WriteLine(PrintTests(new Input([0, 0, 0, 0, 1], 2), true));
Console.WriteLine(PrintTests(new Input([0, 1, 0], 1), false));
Console.WriteLine(PrintTests(new Input([0, 1, 0, 0], 1), true));
Console.WriteLine(PrintTests(new Input([0, 1, 0, 0, 0], 1), true));
Console.WriteLine(PrintTests(new Input([0, 1, 0, 0, 0, 0], 2), true));

record Input(int[] flowerBed, int n);
using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        BeautifulArrangements ba = new BeautifulArrangements();
        Console.WriteLine(ba.Arrangements(5)); // Output should be 10
    }
}

public class BeautifulArrangements
{
    public int Arrangements(int n)
    {
        int count = 0;
        var permutations = GetPermutations(Enumerable.Range(1, n).ToList(), n);

        foreach (var perm in permutations)
        {
            if (IsBeautifulArrangement(perm))
            {
                count++;
            }
        }

        return count;
    }

    private bool IsBeautifulArrangement(List<int> perm)
    {
        for (int i = 0; i < perm.Count; i++)
        {
            int pos = i + 1; // 1-based index
            int value = perm[i];

            if (value % pos != 0 && pos % value != 0)
            {
                return false;
            }
        }
        return true;
    }

    private IEnumerable<List<int>> GetPermutations(List<int> list, int length)
    {
        if (length == 1)
        {
            var test = list.Select(t => new List<int> { t });
            return test;
        }

        var t = GetPermutations(list, length - 1);
        var many = t.SelectMany(t1 => list.Where(e => !t1.Contains(e)),
            (t1, t2) => t1.Concat(new List<int> { t2 }).ToList());

        return many;
    }
}
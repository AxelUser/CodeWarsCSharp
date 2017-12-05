using System;
using System.Linq;

namespace SharpKatas.ExesAndOhs
{
    public static class Kata
    {
        public static bool XO(string input)
        {
            var stats = input
                .ToLower()
                .Where(c => c == 'x' || c == 'o')
                .Aggregate(new Tuple<int, int>(0, 0), (tuple, c) =>
                {
                    if (c == 'x')
                        return Tuple.Create(tuple.Item1 + 1, tuple.Item2);
                    return Tuple.Create(tuple.Item1, tuple.Item2 + 1);
                });
            return stats.Item1 == stats.Item2;
        }
    }
}

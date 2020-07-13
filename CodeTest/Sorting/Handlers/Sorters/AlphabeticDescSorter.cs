using System.Linq;

namespace CodeTest.Sorting.Handlers.Sorters
{
    public class AlphabeticDescSorter : ISorter
    {
        public SortBy SortBy => SortBy.AlphabeticDesc;

        public string[] Sort(string[] words)
            => words
            .OrderByDescending(s => s)
            .ToArray();
    }
}

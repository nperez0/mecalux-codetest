using System.Linq;

namespace CodeTest.Sorting.Handlers.Sorters
{
    public class AlphabeticAscSorter : ISorter
    {
        public SortBy SortBy => SortBy.AlphabeticAsc;

        public string[] Sort(string[] words)
            => words
            .OrderBy(s => s)
            .ToArray();
    }
}

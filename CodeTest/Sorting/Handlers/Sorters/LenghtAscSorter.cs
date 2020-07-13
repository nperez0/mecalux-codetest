using System.Linq;

namespace CodeTest.Sorting.Handlers.Sorters
{
    public class LenghtAscSorter : ISorter
    {
        public SortBy SortBy => SortBy.LenghtAsc;

        public string[] Sort(string[] words)
            => words
            .OrderBy(s => s.Length)
            .ToArray();
    }
}

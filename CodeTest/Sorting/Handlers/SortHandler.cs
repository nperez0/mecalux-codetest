using System;
using System.Collections.Generic;
using System.Linq;

namespace CodeTest.Sorting.Handlers
{
    public class SortHandler
    {
        readonly IDictionary<SortBy, ISorter> _sorters;

        public SortHandler(IEnumerable<ISorter> sorters)
        {
            _sorters = sorters.ToDictionary(s => s.SortBy);
        }

        public string[] Sort(string[] words, SortBy sortBy)
        {
            if (!_sorters.TryGetValue(sortBy, out ISorter sorter))
                throw new InvalidOperationException($"There is no sorter for {sortBy}");

            return sorter.Sort(words);
        }
    }
}

using CodeTest.Sorting.Handlers;

namespace CodeTest.Sorting
{
    public class SortService
    {
        ISortHandler _sortHandler;

        public SortService(ISortHandler sortHandler)
        {
            _sortHandler = sortHandler;
        }

        public string Sort(string text, SortBy sortBy)
        {
            if (string.IsNullOrWhiteSpace(text)) return text;

            var words = text.Split(' ');
            var sorted = _sortHandler.Sort(words, sortBy);

            return string.Join(' ', sorted);
        }
    }
}

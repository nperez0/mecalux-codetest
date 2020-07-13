namespace CodeTest.Sorting.Handlers
{
    public interface ISorter
    {
        SortBy SortBy { get; }

        string[] Sort(string[] words);
    }
}

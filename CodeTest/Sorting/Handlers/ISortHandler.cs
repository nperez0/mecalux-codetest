namespace CodeTest.Sorting.Handlers
{
    public interface ISortHandler
    {
        string[] Sort(string[] words, SortBy sortBy);
    }
}
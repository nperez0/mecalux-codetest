using CodeTest.Sorting;
using CodeTest.Sorting.Handlers;

namespace CodeTest.Tests.Sorting.Handler
{
    public class WhenHandlerSort : TestBase<SortHandler>
    {
        protected SortBy SortBy { get; set; }

        protected string[] Result { get; set; }

        protected override void When()
        {
            Result = Sut.Sort(null, SortBy);
        }
    }
}

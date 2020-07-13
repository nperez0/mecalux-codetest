using CodeTest.Sorting;

namespace CodeTest.Tests.Sorting.Service
{
    public class WhenServiceSort : TestBase<SortService>
    {
        protected string Text { get; set; }

        protected string Result { get; set; }

        protected override void When()
        {
            Result = Sut.Sort(Text, SortBy.AlphabeticAsc);
        }
    }
}

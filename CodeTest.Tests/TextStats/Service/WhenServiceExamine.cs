using CodeTest.TextStats;

namespace CodeTest.Tests.TextStats.Service
{
    public class WhenServiceExamine : TestBase<TextStatsService>
    {
        protected string Text { get; set; }

        protected TextStatistics Stats { get; set; }

        protected override void When()
        {
            Stats = Sut.Examine(Text);
        }
    }
}

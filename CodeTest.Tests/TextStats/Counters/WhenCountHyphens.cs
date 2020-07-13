using CodeTest.TextStats;
using CodeTest.TextStats.Handlers.Counters;
using NUnit.Framework;
using FluentAssertions;

namespace CodeTest.Tests.TextStats.Counters
{
    public class WhenCountHyphens : TestBase<HyphensCounter>
    {
        TextStatistics _stats;

        protected override void Given()
        {
            _stats = new TextStatistics()
            {
                Text = "Lorem-ipsum dolor-sit amet consectetur-adipiscing-elit"
            };
        }

        protected override void When()
        {
            Sut.Count(_stats);
        }

        [Test]
        public void ShouldUpdateStats()
        {
            _stats.Hyphens.Should().Be(4);
        }
    }
}

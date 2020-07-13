using CodeTest.Sorting.Handlers.Sorters;
using FluentAssertions;
using NUnit.Framework;

namespace CodeTest.Tests.Sorting.Sorters
{
    public class WhenSortAlphabeticDesc : TestBase<AlphabeticDescSorter>
    {
        string[] _words;
        string[] _result;

        protected override void Given()
        {
            _words = new [] { "Aserejé", "ja", "deje", "tejebe", "tude", "jebere" };
        }

        protected override void When()
        {
            _result = Sut.Sort(_words);
        }

        [Test]
        public void ShouldHaveItems()
        {
            _result.Should().HaveCount(6);
        }

        [Test]
        public void ShouldSortCorrectly()
        {
            _result.Should().BeInDescendingOrder();
        }
    }
}

using CodeTest.Sorting;
using CodeTest.Sorting.Handlers;
using AutoFixture;
using NSubstitute;
using System.Collections.Generic;
using NUnit.Framework;
using FluentAssertions;

namespace CodeTest.Tests.Sorting.Handler
{
    public class AndFindsSorter : WhenHandlerSort
    {
        protected override void Given()
        {
            var sorter = Fixture.Create<ISorter>();

            sorter.SortBy.Returns(SortBy.AlphabeticAsc);
            sorter.Sort(Arg.Any<string[]>()).Returns(new[] { "Hello", "World!" });

            Fixture.Register<IEnumerable<ISorter>>(() => new[] { sorter });

            SortBy = SortBy.AlphabeticAsc;
        }

        [Test]
        public void ShouldReturnSortedWords()
        {
            Result.Should().BeEquivalentTo(new[] { "Hello", "World!" });
        }
    }
}

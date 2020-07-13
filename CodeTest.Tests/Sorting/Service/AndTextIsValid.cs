using AutoFixture;
using NSubstitute;
using CodeTest.Sorting.Handlers;
using CodeTest.Sorting;
using NUnit.Framework;
using FluentAssertions;

namespace CodeTest.Tests.Sorting.Service
{
    public class AndTextIsValid : WhenServiceSort
    {
        protected override void Given()
        {
            var handler = Fixture.Freeze<ISortHandler>();

            handler.Sort(Arg.Any<string[]>(), Arg.Any<SortBy>())
                .Returns(new[] { "Hello", "World!" });

            Text = "World! Hello";
        }

        [Test]
        public void ShouldReturnSortedText()
        {
            Result.Should().Be("Hello World!");
        }
    }
}

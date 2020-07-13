using CodeTest.Sorting;
using CodeTest.Sorting.Handlers;
using AutoFixture;
using System.Collections.Generic;
using NUnit.Framework;
using FluentAssertions;
using System.Linq;
using System;

namespace CodeTest.Tests.Sorting.Handler
{
    public class AndSorterIsNotFound : WhenHandlerSort
    {
        protected override void Given()
        {
            Fixture.Register<IEnumerable<ISorter>>(() => Enumerable.Empty<ISorter>());

            SortBy = SortBy.AlphabeticDesc;

            RecordAnyExceptionsThrown();
        }

        [Test]
        public void ShouldThrownInvalidOperationException()
        {
            ThrownException.Should().BeOfType<InvalidOperationException>();
            ThrownException.Message.Should().Be($"There is no sorter for {SortBy}");
        }
    }
}

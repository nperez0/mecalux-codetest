using CodeTest.TextStats.Handlers;
using NUnit.Framework;
using AutoFixture;
using NSubstitute;
using System.Collections.Generic;
using CodeTest.TextStats;

namespace CodeTest.Tests.TextStats.Handler
{
    public class WhenHandlerCount : TestBase<CounterHandler>
    {
        ICounter _counter;

        protected override void Given()
        {
            _counter = Fixture.Create<ICounter>();

            Fixture.Register<IEnumerable<ICounter>>(() => new[] { _counter });
        }

        protected override void When()
        {
            Sut.Count(null);
        }

        [Test]
        public void ShouldCallCounter()
        {
            _counter.Received(1).Count(Arg.Any<TextStatistics>());
        }
    }
}

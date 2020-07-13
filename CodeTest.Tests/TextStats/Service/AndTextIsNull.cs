using CodeTest.TextStats.Handlers;
using NUnit.Framework;
using AutoFixture;
using NSubstitute;
using CodeTest.TextStats;

namespace CodeTest.Tests.TextStats.Service
{
    public class AndTextIsNull : WhenServiceExamine
    {
        ICounterHandler _counterHandler;

        protected override void Given()
        {
            _counterHandler = Fixture.Freeze<ICounterHandler>();
        }

        [Test]
        public void ShouldNotCallHandler()
        {
            _counterHandler.Received(0).Count(Arg.Any<TextStatistics>());
        }
    }
}

using CodeTest.TextStats.Handlers;
using NUnit.Framework;
using AutoFixture;
using NSubstitute;
using CodeTest.TextStats;

namespace CodeTest.Tests.TextStats.Service
{
    public class AndTextIsValid : WhenServiceExamine
    {
        ICounterHandler _counterHandler;

        protected override void Given()
        {
            _counterHandler = Fixture.Freeze<ICounterHandler>();

            Text = "Hello World!";
        }

        [Test]
        public void ShouldCallHandler()
        {
            _counterHandler.Received(1).Count(Arg.Any<TextStatistics>());
        }
    }
}

using NUnit.Framework;
using FluentAssertions;

namespace CodeTest.Tests.Sorting.Service
{
    public class AndTextIsEmpty : WhenServiceSort  
    {
        [Test]
        public void ShouldReturnEmptyString()
        {
            Result.Should().BeNull();
        }
    }
}

using System.Linq;

namespace CodeTest.TextStats.Handlers.Counters
{
    public class SpacesCounter : ICounter
    {
        public void Count(TextStatistics stats)
        {
            stats.Spaces = stats
                .Text
                .Count(c => c == ' ');
        }
    }
}

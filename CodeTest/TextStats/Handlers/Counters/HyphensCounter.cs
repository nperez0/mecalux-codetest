using System.Linq;

namespace CodeTest.TextStats.Handlers.Counters
{
    public class HyphensCounter : ICounter
    {
        public void Count(TextStatistics stats)
        {
            stats.Hyphens = stats
                .Text
                .Count(c => c == '-');
        }
    }
}

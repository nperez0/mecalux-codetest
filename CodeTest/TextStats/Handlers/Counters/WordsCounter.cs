using System.Linq;

namespace CodeTest.TextStats.Handlers.Counters
{
    public class WordsCounter : ICounter
    {
        public void Count(TextStatistics stats)
        {
            stats.Words = stats
                .Text
                .Split(' ')
                .SelectMany(c => c.Split('-'))
                .Count();
        }
    }
}

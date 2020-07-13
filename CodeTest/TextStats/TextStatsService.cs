using CodeTest.TextStats.Handlers;

namespace CodeTest.TextStats
{
    public class TextStatsService
    {
        readonly ICounterHandler _handler;

        public TextStatsService(ICounterHandler handler)
        {
            _handler = handler;
        }

        public TextStatistics Examine(string text)
        {
            var stats = new TextStatistics() { Text = text };

            if (text != null)
                _handler.Count(stats);

            return stats;
        }
    }
}

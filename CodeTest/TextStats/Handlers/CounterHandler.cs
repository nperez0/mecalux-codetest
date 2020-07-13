using System.Collections.Generic;

namespace CodeTest.TextStats.Handlers
{
    public class CounterHandler : ICounterHandler
    {
        readonly IEnumerable<ICounter> _counters;

        public CounterHandler(IEnumerable<ICounter> counters)
        {
            _counters = counters;
        }

        public void Count(TextStatistics stats)
        {
            foreach (var counter in _counters)
            {
                counter.Count(stats);
            }
        }
    }
}

using System;
using System.Web.Mvc;
using MvcMusicStore.PerformanceCounters;
using PerformanceCounterHelper;

namespace MvcMusicStore.PerformanceCounters
{
    public class PerformanceCountersConfig
    {
        public static void ConfigureCounters()
        {
            var controllerCounters = DependencyResolver.Current.GetService(typeof(CounterHelper<CustomeCounters>)) as CounterHelper<CustomeCounters>;
            foreach (CustomeCounters counter in Enum.GetValues(typeof(CustomeCounters)))
            {
                controllerCounters.Reset(counter);
            }
        }
    }
}
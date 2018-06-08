using System.Diagnostics;
using PerformanceCounterHelper;

namespace MvcMusicStore.PerformanceCounters
{
    [PerformanceCounterCategory("MusicStoreControllersCounters", PerformanceCounterCategoryType.SingleInstance, "Counters for controllers")]
    public enum CustomeCounters
    {
        [PerformanceCounter("SuccessLogInCounter", "Counts a number of successful logIn attempts.", PerformanceCounterType.NumberOfItems32)]
        SuccessLogInsCounter = 1,

        [PerformanceCounter("SuccessLogOffCounter", "Counts a number of successful logOff attempts.", PerformanceCounterType.NumberOfItems32)]
        SuccessLogOffsCounter = 2,

        [PerformanceCounter("BrowseAverageTimeCounter", "Counts average time for processing StoreController Browse request.", PerformanceCounterType.AverageTimer32)]
        ProcessingBrowseRequestAverageTime = 3
    }
}
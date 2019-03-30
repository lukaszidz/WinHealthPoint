using System;
using System.Diagnostics;
using System.Threading;
using WinHealthPoint.Api.Models;

namespace WinHealthPoint.Api.Services
{
    public class PerformanceService : IPerformanceService
    {
        public PerformanceDTO GetInfo()
        {
            var performanceCounter = new PerformanceCounter("Processor", "% Processor Time", "_Total");

            performanceCounter.NextValue();
            Thread.Sleep(1000);

            return new PerformanceDTO
            {
                CpuUsage = Convert.ToByte(Math.Round(performanceCounter.NextValue(), 0))
            };
        }
    }
}
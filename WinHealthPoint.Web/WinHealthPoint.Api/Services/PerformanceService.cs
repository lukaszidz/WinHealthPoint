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
                CpuUsage = GetCpuUsage(),
                MemoryUsage = GetMemoryUsage()
            };
        }

        private byte GetCpuUsage()
        {
            var performanceCounter = new PerformanceCounter("Processor", "% Processor Time", "_Total");

            performanceCounter.NextValue();
            Thread.Sleep(1000);

            return Convert.ToByte(Math.Round(performanceCounter.NextValue(), 0));
        }

        private byte GetMemoryUsage()
        {
            PerformanceCounter mem = new PerformanceCounter("Memory", "% Committed Bytes In Use");
            return Convert.ToByte(Math.Round(mem.NextValue(), 0));
        }
    }
}
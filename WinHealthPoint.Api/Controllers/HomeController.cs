using System.Web.Http;
using WinHealthPoint.Api.Models;
using WinHealthPoint.Api.Services;

namespace WinHealthPoint.Api.Controllers
{
    public class HomeController : ApiController
    {
        private IPerformanceService _performanceService;

        public HomeController(IPerformanceService performanceService)
        {
            _performanceService = performanceService;
        }

        public PerformanceDTO GetPerformance()
        {
            return _performanceService.GetInfo();
        }
    }
}
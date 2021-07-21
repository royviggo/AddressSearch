using AddressSearch.Web.Mappings;
using AddressSearch.Web.Models;
using GeonorgeAddressSearch;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Diagnostics;
using System.Threading.Tasks;

namespace AddressSearch.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IGeonorgeAddressSearchService _searchService;

        public HomeController(ILogger<HomeController> logger, IGeonorgeAddressSearchService searchService)
        {
            _logger = logger;
            _searchService = searchService;
        }

        [HttpGet]
        public async Task<IActionResult> Index(IndexViewModel model)
        {
            if (model != null && !string.IsNullOrEmpty(model.Search))
            {
                var searchRequest = GeonorgeAddressSearchMapping.Map(model);
                try
                {
                    model.SearchResults = GeonorgeAddressSearchMapping.Map(await _searchService.SearchAsync(searchRequest));
                }
                catch (Exception e)
                {
                    _logger.LogError($"{e.Message} {e.StackTrace}");
                    model.ErrorMessage = e.Message;
                }
            }

            return View(model);
        }

        [HttpGet]
        public IActionResult Details(DetailsViewModel model)
        {
            return PartialView(model);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}

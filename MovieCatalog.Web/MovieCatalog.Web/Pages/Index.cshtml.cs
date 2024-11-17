using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MovieCatalogApi.Services;
using MovieCatalogApi.Entities;
using Microsoft.EntityFrameworkCore;

namespace MovieCatalog.Web.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        //private readonly IMovieCatalogDataService _service;


        public IndexModel(ILogger<IndexModel> logger/*, IMovieCatalogDataService service*/)
        {
            _logger = logger;
            //_service = service;
        }

        //public Dictionary<Genre, int> genres { get; set; } = default!;

        /*public async Task<IActionResult> OnGetAsync()
        {
            /if (genres == null) return Page();
            genres = await _service.GetGenresAsync();
            return Page();/
            genres = await _service.GetGenresWithTitleCountsAsync();
            return Page();
        }*/
        public void OnGet()
        {

        }

    }
}

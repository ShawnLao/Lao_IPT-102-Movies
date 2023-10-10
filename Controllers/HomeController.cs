using lao_IPT102_Movies_10_10_2023.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace lao_IPT102_Movies_10_10_2023.Controllers
{
	public class HomeController : Controller
	{
		private readonly ILogger<HomeController> _logger;
		private readonly List<lao_MovieModel> _lao_Movies;
		public HomeController(ILogger<HomeController> logger)
		{
			_logger = logger;

			_lao_Movies = new List<lao_MovieModel>
			{
				new lao_MovieModel{Movie_ID = 1, Movie_CoverPicture ="disneywishcover.png", Movie_Title ="Disney Wish", Movie_ReleaseYear = "2023", Movie_Rating = "34", Movie_Genre = "Animation / Adventure / Comedy ", Movie_TrailerLink = "https://www.imdb.com/video/vi2144782105/?playlistId=tt11304740&ref_=tt_ov_vi"},
				new lao_MovieModel{Movie_ID = 2, Movie_CoverPicture ="thecontinentaljohnwick.png", Movie_Title ="The Continental: From The World Of John Wick", Movie_ReleaseYear = "2023", Movie_Rating = "3", Movie_Genre = "Series / Action / Crime / Thriller ", Movie_TrailerLink = "https://www.imdb.com/video/vi4002006809/?playlistId=tt6486762&ref_=tt_ov_vi"},
				new lao_MovieModel{Movie_ID = 3, Movie_CoverPicture ="thecreatorcover.png", Movie_Title ="The Creator", Movie_ReleaseYear = "2023", Movie_Rating = "1", Movie_Genre = "Action / Adventure / Drama", Movie_TrailerLink = "https://www.imdb.com/video/vi3790980889/?playlistId=tt11858890&ref_=tt_ov_vi"},
				new lao_MovieModel{Movie_ID = 4, Movie_CoverPicture ="genvcover.png", Movie_Title ="GEN V", Movie_ReleaseYear = "2023", Movie_Rating = "4", Movie_Genre = "Action / Adventure / Comedy", Movie_TrailerLink = "https://www.imdb.com/video/vi3051603737/?playlistId=tt13159924&ref_=tt_pr_ov_viQ"},
				new lao_MovieModel{Movie_ID = 5, Movie_CoverPicture ="sawxcover.png", Movie_Title ="Saw X", Movie_ReleaseYear = "2023", Movie_Rating = "4", Movie_Genre = "Horror / Mystery / Thriller", Movie_TrailerLink = "https://www.imdb.com/video/vi2715076377/?playlistId=tt21807222&ref_=tt_pr_ov_vi"},
				new lao_MovieModel{Movie_ID = 6, Movie_CoverPicture ="barbiemoviecover.png", Movie_Title ="Barbie", Movie_ReleaseYear = "2023", Movie_Rating = "6", Movie_Genre = "Adventure / Comedy / Fantasy", Movie_TrailerLink = "https://www.imdb.com/video/vi945734681/?playlistId=tt1517268&ref_=tt_pr_ov_vi"},
				new lao_MovieModel{Movie_ID = 7, Movie_CoverPicture ="talktomecover.png", Movie_Title ="Talk To Me", Movie_ReleaseYear = "2022", Movie_Rating = "11", Movie_Genre = "Horror / Thriller", Movie_TrailerLink = "https://www.imdb.com/video/vi3628712985/?playlistId=tt10638522&ref_=tt_pr_ov_vi"},
				new lao_MovieModel{Movie_ID = 8, Movie_CoverPicture ="thegodfathercover.png", Movie_Title ="The God Father", Movie_ReleaseYear = "1972", Movie_Rating = "74", Movie_Genre = "Crime / Drama", Movie_TrailerLink = "https://www.imdb.com/video/vi1348706585/?playlistId=tt0068646&ref_=tt_pr_ov_vi"},
				new lao_MovieModel{Movie_ID = 9, Movie_CoverPicture ="thegoodthebadandtheuglycover.png", Movie_Title ="The Good, the Bad and the Ugly", Movie_ReleaseYear = "1966", Movie_Rating = "576", Movie_Genre = "Adventure / Western", Movie_TrailerLink = "https://www.imdb.com/video/vi3416964889/?playlistId=tt0060196&ref_=tt_pr_ov_vi"},
				new lao_MovieModel{Movie_ID = 10, Movie_CoverPicture = "americanpsychocover.png", Movie_Title ="American Psycho", Movie_ReleaseYear = "2000", Movie_Rating = "220", Movie_Genre = "Crime / Drama / Horror", Movie_TrailerLink = "https://www.imdb.com/video/vi4060743449/?playlistId=tt0144084&ref_=tt_pr_ov_vi"},
				new lao_MovieModel{Movie_ID = 11, Movie_CoverPicture = "thefightclubcover.png", Movie_Title ="Fight Club", Movie_ReleaseYear = "1999", Movie_Rating = "91", Movie_Genre = "Drama", Movie_TrailerLink = "https://www.imdb.com/video/vi781228825/?playlistId=tt0137523&ref_=tt_ov_vi"},
				new lao_MovieModel{Movie_ID = 12, Movie_CoverPicture = "drivecover.png", Movie_Title ="Drive", Movie_ReleaseYear = "2011", Movie_Rating = "328", Movie_Genre = "Action / Drama", Movie_TrailerLink = "https://www.imdb.com/video/vi2772212761/?playlistId=tt0780504&ref_=tt_pr_ov_vi"},
				new lao_MovieModel{Movie_ID = 13, Movie_CoverPicture = "bladerunner2049cover.png", Movie_Title ="Blade Runner 2049", Movie_ReleaseYear = "2017", Movie_Rating = "177", Movie_Genre = "Action / Drama / Mystery ", Movie_TrailerLink = "https://www.imdb.com/video/vi3362371865/?playlistId=tt1856101&ref_=tt_pr_ov_vi"},
				new lao_MovieModel{Movie_ID = 14, Movie_CoverPicture = "thematrix1999cover.png", Movie_Title ="The Matrix (1999)", Movie_ReleaseYear = "1999", Movie_Rating = "206", Movie_Genre = "Action / Sci-Fi", Movie_TrailerLink = "https://www.imdb.com/video/vi1032782617/?playlistId=tt0133093&ref_=tt_pr_ov_vi"},
				new lao_MovieModel{Movie_ID = 15, Movie_CoverPicture = "spider-manacrossthespiderversecover.png", Movie_Title ="Spider-Man: Across the Spider-Verse", Movie_ReleaseYear = "2023", Movie_Rating = "39", Movie_Genre = "Animation / Action / Adventure", Movie_TrailerLink = "https://www.imdb.com/video/vi207143961/?playlistId=tt9362722&ref_=ext_shr_lnk"},
			};

		}

		public IActionResult Index()
		{
			return View();
		}

		public IActionResult Privacy()
		{
			return View();
		}

		public ActionResult lao_Movies(int id)
		{
			var movie = _lao_Movies.Find(m => m.Movie_ID == id);
			if (movie == null)
				return NotFound();
			return View(movie);

		}

		public ActionResult lao_MovieTables()
		{

			return View(_lao_Movies);
		}

		[ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
		public IActionResult Error()
		{
			return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
		}
	}
}
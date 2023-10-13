using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using BSIT3L_Movies.Models;
using System.Collections.Generic;

namespace BSIT3L_Movies.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;
    private readonly List<MovieViewModel> _movies;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
        _movies = new List<MovieViewModel>
        {
            new MovieViewModel { Id = 1, Name = "Iron Man", Rating = "94%", ReleaseYear = 2008, Genre = "Action/Adventure", Img = "img/IM1.jpg", Desc = "After being held captive in an Afghan cave, billionaire engineer Tony Stark creates a unique weaponized suit of armor to fight evil.", Direct = "Jon Favreau" },
            new MovieViewModel { Id = 2, Name = "The Incredible Hulk", Rating = "67%", ReleaseYear = 2008, Genre = "Action/Adventure", Img = "img/TIH.jpg", Desc = "Bruce Banner, a scientist on the run from the U.S. Government, must find a cure for the monster he turns into whenever he loses his temper", Direct = "Louis Leterrier" },
            new MovieViewModel { Id = 3, Name = "Iron Man 2", Rating = "72%", ReleaseYear = 2010, Genre = "Action/Adventure", Img = "img/IM2.jpg", Desc = "With the world now aware of his identity as Iron Man, Tony Stark must contend with both his declining health and a vengeful mad man with ties to his father's legacy.", Direct = "Jon Favreau" },
             new MovieViewModel { Id = 4, Name = "Thor", Rating = "77%", ReleaseYear = 2011, Genre = "Action/Adventure", Img = "img/T.jpg", Desc = "The powerful but arrogant god Thor is cast out of Asgard to live amongst humans in Midgard (Earth), where he soon becomes one of their finest defenders.", Direct = "Kenneth Branagh" },
            new MovieViewModel { Id = 5, Name = "Captain America: The First Avenger", Rating = "80%", ReleaseYear = 2011, Genre = "Action/Adventure", Img = "img/CA1.jpg", Desc = "Steve Rogers, a rejected military soldier, transforms into Captain America after taking a dose of a Super-Soldier serum. But being Captain America comes at a price as he attempts to take down a warmonger and a terrorist organization.", Direct = "Joe Johnston" },
            new MovieViewModel { Id = 6, Name = "The Avengers", Rating = "91%", ReleaseYear = 2012, Genre = "Action/Adventure",Img = "img/AV1.jpg", Desc = "Earth's mightiest heroes must come together and learn to fight as a team if they are going to stop the mischievous Loki and his alien army from enslaving humanity.", Direct = "Joss Whedon" },
             new MovieViewModel { Id = 7, Name = "Iron Man 3", Rating = "79%", ReleaseYear = 2013, Genre = "Action/Adventure", Img = "img/IR3.jpg", Desc = "When Tony Stark's world is torn apart by a formidable terrorist called the Mandarin, he starts an odyssey of rebuilding and retribution.", Direct = "Shane Black" },
            new MovieViewModel { Id = 8, Name = "Thor: The Dark World", Rating = "67%", ReleaseYear = 2013, Genre = "Action/Adventure", Img = "img/T2.jpg", Desc = "When the Dark Elves attempt to plunge the universe into darkness, Thor must embark on a perilous and personal journey that will reunite him with doctor Jane Foster.", Direct = "Alan Taylor" },
            new MovieViewModel { Id = 9, Name = "Captain America: The Winter Soldier", Rating = "90%", ReleaseYear = 2014, Genre = "Action/Adventure", Img = "img/CA2.jfif", Desc = "As Steve Rogers struggles to embrace his role in the modern world, he teams up with a fellow Avenger and S.H.I.E.L.D agent, Black Widow, to battle a new threat from history: an assassin known as the Winter Soldier.", Direct = "Anthony Russo & Joe Russo" },
             new MovieViewModel { Id = 10, Name = "Guardians of The Galaxy", Rating = "92%", ReleaseYear = 2014, Genre = "Action/Adventure", Img = "img/G1.jfif", Desc = "A group of intergalactic criminals must pull together to stop a fanatical warrior with plans to purge the universe.", Direct = "James Gunn" },
            new MovieViewModel { Id = 11, Name = "Avengers: Age of Ultron", Rating = "76%", ReleaseYear = 2015, Genre = "Action/Adventure", Img = "img/AV2.jfif", Desc = "When Tony Stark and Bruce Banner try to jump-start a dormant peacekeeping program called Ultron, things go horribly wrong and it's up to Earth's mightiest heroes to stop the villainous Ultron from enacting his terrible plan.", Direct = "Joss Whedon" },
            new MovieViewModel { Id = 12, Name = "Ant-Man", Rating = "83%", ReleaseYear = 2015, Genre = "Action/Adventure", Img = "img/A1.jfif", Desc = "Armed with a super-suit with the astonishing ability to shrink in scale but increase in strength, cat burglar Scott Lang must embrace his inner hero and help his mentor, Dr. Hank Pym, pull off a plan that will save the world.", Direct = "Peyton Reed" },
             new MovieViewModel { Id = 13, Name = "Captain America: Civil War", Rating = "91%", ReleaseYear = 2016, Genre = "Action/Adventure", Img = "img/CA3.jfif", Desc = "Political involvement in the Avengers' affairs causes a rift between Captain America and Iron Man.", Direct = "Anthony Russo & Joe Russo" },
            new MovieViewModel { Id = 14, Name = "Doctor Strange", Rating = "89%", ReleaseYear = 2016, Genre = "Action/Adventure", Img = "img/D1.jfif", Desc = "While on a journey of physical and spiritual healing, a brilliant neurosurgeon is drawn into the world of the mystic arts.", Direct = "Scott Derrickson" },
            new MovieViewModel { Id = 15, Name = "Guardians of The Galaxy VOL2", Rating = "85%", ReleaseYear = 2017, Genre = "Action/Adventure", Img = "img/G2.jfif", Desc = "The Guardians struggle to keep together as a team while dealing with their personal family issues, notably Star-Lord's encounter with his father, the ambitious celestial being Ego.", Direct = "James Gunn" },
        };
    }

    public IActionResult Index()
    {
        return View(_movies);
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}


using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VideoGameLibary.Models;
using VideoGameLibary.Interface;
using VideoGameLibary.Data;

namespace VideoGameLibary.Controllers
{
    public class VideoGameController : Controller
    {
        IDataAccessLayer dal = new VideoGameDAL();

        public VideoGameController()
        {
            
        }

        public IActionResult GameMain()
        {
            return View(dal.GetVideoGames());
        }

        public IActionResult AddGame()
        {
            return View();
        }

        public IActionResult Search()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddVideoGame(VideoGame game)
        {
            if(game != null)
            {
                dal.AddVideoGame(game);
                return View("GameMain", dal.GetVideoGames());
            }

            return View("GameMain");
        }

        public IActionResult SearchGame(string name)
        {
            List<VideoGame> g;
            g = dal.GetVideoGame(name).ToList();
            return View("GameMain",g);
        }

        public IActionResult SearchCollection(string genre, string playform, string rating)
        {
            return View("GameMain", dal.GetFilteredGames(genre, playform, rating));
        }

        public IActionResult Remove(int? ID)
        {
            dal.Remove(ID);
            return View("GameMain", dal.GetVideoGames());
        }

        [HttpGet]
        public IActionResult LoanGame(int ID)
        {
            var laon = dal.FindVideoGame(ID);
            laon.Loan();
            return View("GameMain", dal.GetVideoGames());

        }

        [HttpPost]
        public IActionResult Return(int Id)
        {
            var r = dal.FindVideoGame(Id);
            r.Return();
            return View("GameMain", dal.GetVideoGames());
        }
    }
}

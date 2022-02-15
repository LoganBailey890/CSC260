using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VideoGameLibary.Models;
using VideoGameLibary.Interface;

namespace VideoGameLibary.Data
{
    public class VideoGameDAL : IDataAccessLayer
    {
        private static List<VideoGame> gameList = new List<VideoGame>
        {
            new VideoGame("Black desert online","All platforms","  ","E",2015,"BlackDesert.png"),
            new VideoGame("Amoung us","PC","Social Deduction","E",2018,"AmoungUs.jpg"),
            new VideoGame("New World","PC","MMORPG","M",2021,"NewWorld.jpg"),
            new VideoGame("Dying Light 2","All platforms","RPG","M",2022,"DyingLigth2.jpg"),
            new VideoGame("Dying Ligth","All Platforms","RPG","M",2015,"DyingLight.jpg")
        };

        public void AddVideoGame(VideoGame videoGame)
        {
            gameList.Add(videoGame);
        }

        public IEnumerable<VideoGame> GetVideoGames()
        {
            return gameList;
        }
        /*        public void RemoveVideogame(string title)
                {
                    var foundGame = GetVideoGame(title);
                    if (foundGame != null)
                    {
                        gameList.Remove(foundGame);
                    }
                }*/

        public void Remove(int? ID)
        {
            var foundGame = FindVideoGame(ID);
            if (foundGame != null)
            {
                gameList.Remove(foundGame);
            }
        }

        public IEnumerable<VideoGame> GetFilteredGames(string genre, string playform, string rating)
        {
            List<VideoGame> temp = new List<VideoGame>();
            bool generaCheck = genre != null;
            bool platformCheck = playform != null;
            bool ratingCheck = rating != null;
            
            foreach(var g in gameList)
            {

                if((!generaCheck || g.Genre.ToLower().Contains(genre.ToLower()) && (!platformCheck || g.PlatForm.ToLower().Contains(playform.ToLower()) && (!ratingCheck || g.AgeRateing.ToLower().Contains(rating.ToLower())))))
                {
                    temp.Add(g);
                }
            }
            return temp;
        }



        public VideoGame FindVideoGame(int? ID)
        {
            VideoGame foundGame = null;
            if (ID != null)
            {
                gameList.ForEach(g =>
                {
                    if (g.ID == ID)
                    {
                        foundGame = g;
                    }
                });
            }
            return foundGame;
        }

        public IEnumerable<VideoGame> GetVideoGame(string name)
        {
            List<VideoGame> videoGames = new List<VideoGame>();
            if (!string.IsNullOrEmpty(name))
            {
                gameList.ForEach(g =>
                {
                    if (g.Title.ToLower().Contains(name.ToLower()))
                    {
                        videoGames.Add(g);
                    }

                });

            }
            return videoGames;
        }


    }
}

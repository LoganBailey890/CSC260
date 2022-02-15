using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VideoGameLibary.Models;


namespace VideoGameLibary.Interface
{

    public interface IDataAccessLayer
    {


        IEnumerable<VideoGame> GetVideoGames();

        void AddVideoGame(VideoGame videoGame);

        void Remove(int? ID);

        VideoGame FindVideoGame(int? ID);

        IEnumerable<VideoGame> GetVideoGame(string name);

        IEnumerable<VideoGame> GetFilteredGames(string genre, string playform, string rating);


    }
}

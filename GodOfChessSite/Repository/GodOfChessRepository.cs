using GodOfChessSite.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GodOfChessSite.Repository
{
    public class GodOfChessRepository : IRepository
    {
        private List<Game> _games;

        public GodOfChessRepository()
        {
            _games = new List<Game>()
            {
                new Game()
                {
                    Title = "DarkEscape",
                    Genre = "Horror",
                    ReleaseDate = new DateTime(2022, 12, 21)
                },
                new Game()
                {
                    Title = "QuizzySnow",
                    Genre = "Quiz",
                    ReleaseDate = new DateTime(2022, 12, 23)
                },
                new Game()
                {
                    Title = "VisualNovell",
                    Genre = "Novella",
                    ReleaseDate = new DateTime(2020, 12, 30)
                }
            };
        }

        public List<Game> GetAllGames()
        {
            return _games;
        }
    }
}

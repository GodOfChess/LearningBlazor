using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GodOfChessSite.Helpers
{
    public class GameHandler
    {
        public RSPOptions Choose { get; set; }
        public RSPOptions WinCondition { get; set; }
        public RSPOptions LoseCondition { get; set; }
        public string Image { get; set; }

        public GameState GameResult(GameHandler opponent)
        {
            if (Choose == opponent.Choose)
                return GameState.Draw;
            else if (LoseCondition == opponent.Choose)
                return GameState.Victory;
            else return GameState.Lose;
        }
    }
}

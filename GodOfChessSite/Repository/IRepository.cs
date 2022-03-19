using GodOfChessSite.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GodOfChessSite.Repository
{
    interface IRepository
    {
        public List<Game> GetAllGames();
    }
}

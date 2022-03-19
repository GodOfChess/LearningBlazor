using GodOfChessSite.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GodOfChessSite
{
    public class SingletonService
    {
        public int Value { get; set; }
    }
    public class TransientService
    {
        public int Value { get; set; }
    }

    public class SouvenirService
    {
        private readonly AppDBContext _appDBContext;
        public SouvenirService(AppDBContext appDBContext)
        {
            _appDBContext = appDBContext;
        }

        public async Task<List<Souvenir>> GetAllSouvenirsAsync()
        {
            return await _appDBContext.Souvenirs.ToListAsync();
        }

        public async Task AddSouvenirAsync(Souvenir souvenir)
        {
            try
            {
                await _appDBContext.Souvenirs.AddAsync(souvenir);
                await _appDBContext.SaveChangesAsync();
            }
            catch
            {
                throw new Exception("Что-то пошло не так");
            }
        }

        public async Task DeleteSouvenirAsync(Souvenir souvenir)
        {
            _appDBContext.Remove(souvenir);
            await _appDBContext.SaveChangesAsync();
        }
    }
}

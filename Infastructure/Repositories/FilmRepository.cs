using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Application.Abstractions.Repositories;
using Domain.Entities;
namespace Infastructure.Repositories
{
    internal class FilmRepository : IFilmRepositories
    {
        public Task<Film> AddFilmAsync(Film film)
        {
            throw new NotImplementedException();
        }

        public Task<Film> DeleteFilmAsync(long filmId)
        {
            throw new NotImplementedException();
        }

        public Task<List<Film>> GetAllFilmAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Film> GetByIdFilmAsync(long filmId)
        {
            throw new NotImplementedException();
        }

        public Task<Film> UpdateFilmAsync(Film film, long filmId)
        {
            throw new NotImplementedException();
        }
    }
}

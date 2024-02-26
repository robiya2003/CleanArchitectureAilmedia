using Application.DTOS;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Abstractions.Repositories
{
    public interface IFilmRepositories
    {
        public Task<Film> AddFilmAsync(Film film);
        public Task<Film> GetByIdFilmAsync(long filmId);
        public Task<List<Film>> GetAllFilmAsync();
        public Task<Film> UpdateFilmAsync(Film film, long filmId);
        public Task<Film> DeleteFilmAsync(long filmId);
    }
}

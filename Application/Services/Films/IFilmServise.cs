using Application.DTOS;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services.Films
{
    public interface IFilmServise
    {
        public Task<Film> AddFilmAsync(FilmDTO filmDTO);
        public Task<Film> GetByIdFilmAsync(long filmId);
        public Task<List<Film>> GetAllFilmAsync();
        public Task<Film> UpdateFilmAsync(FilmDTO filmDTO, long filmId);
        public Task<Film> DeleteFilmAsync(long filmId);
    }
}

using Application.Abstractions.Repositories;
using Application.DTOS;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services.Films
{
    public class FilmServise : IFilmServise
    {
        private readonly IFilmRepositories _filmRepositories;
        public FilmServise(IFilmRepositories filmRepositories)
        {
            _filmRepositories = filmRepositories;
        }
        public Task<Film> AddFilmAsync(FilmDTO filmDTO)
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

        public Task<Film> UpdateFilmAsync(FilmDTO filmDTO, long filmId)
        {
            throw new NotImplementedException();
        }
    }
}

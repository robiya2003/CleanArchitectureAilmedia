using Application.DTOS;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Abstractions.Repositories
{
    public interface IFilmMakerRepositories
    {
        public Task<FilmMaker> AddFilmMakerAsync(FilmMaker FilmMaker);
        public Task<FilmMaker> GetByIdFilmMakerAsync(long FilmMakerId);
        public Task<List<FilmMaker>> GetAllFilmMakerAsync();
        public Task<FilmMaker> UpdateFilmMakerAsync(FilmMaker FilmMaker, long FilmMakerId);
        public Task<FilmMaker> DeleteFilmMakerAsync(long FilmMakerId);
    }
}

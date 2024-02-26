using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Application.Abstractions.Repositories;
using Domain.Entities;
namespace Infastructure.Repositories
{
    internal class FilmMakerRepository : IFilmMakerRepositories
    {
        public Task<FilmMaker> AddFilmMakerAsync(FilmMaker FilmMaker)
        {
            throw new NotImplementedException();
        }

        public Task<FilmMaker> DeleteFilmMakerAsync(long FilmMakerId)
        {
            throw new NotImplementedException();
        }

        public Task<List<FilmMaker>> GetAllFilmMakerAsync()
        {
            throw new NotImplementedException();
        }

        public Task<FilmMaker> GetByIdFilmMakerAsync(long FilmMakerId)
        {
            throw new NotImplementedException();
        }

        public Task<FilmMaker> UpdateFilmMakerAsync(FilmMaker FilmMaker, long FilmMakerId)
        {
            throw new NotImplementedException();
        }
    }
}

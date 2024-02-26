using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Application.Abstractions.Repositories;
using Domain.Entities;
namespace Infastructure.Repositories
{
    internal class GenreRepository : IGenreRepositories
    {
        public Task<Genre> AddGenreAsync(Genre Genre)
        {
            throw new NotImplementedException();
        }

        public Task<Genre> DeleteGenreAsync(long GenreId)
        {
            throw new NotImplementedException();
        }

        public Task<List<Genre>> GetAllGenreAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Genre> GetByIdGenreAsync(long GenreId)
        {
            throw new NotImplementedException();
        }

        public Task<Genre> UpdateGenreAsync(Genre Genre, long GenreId)
        {
            throw new NotImplementedException();
        }
    }
}

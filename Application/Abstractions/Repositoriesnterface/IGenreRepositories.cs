using Application.DTOS;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Abstractions.Repositories
{
    public interface IGenreRepositories
    {
        public Task<Genre> AddGenreAsync(Genre Genre);
        public Task<Genre> GetByIdGenreAsync(long GenreId);
        public Task<List<Genre>> GetAllGenreAsync();
        public Task<Genre> UpdateGenreAsync(Genre Genre, long GenreId);
        public Task<Genre> DeleteGenreAsync(long GenreId);
    }
}

using Application.Services.Actors;
using Application.Services.FilmMakers;
using Application.Services.Films;
using Application.Services.Genres;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application
{
    public static class ApplicationDependencyInjection
    {
        public static IServiceCollection AddApplicationServises(this IServiceCollection services)
        {
            services.AddScoped<IActorServise, ActorServise>();
            services.AddScoped<IFilmMakerServise, FilmMakerServise>();
            services.AddScoped<IFilmServise, FilmServise>();
            services.AddScoped<IGenreServise, GenreServise>();
            return services;
        }
    }
}

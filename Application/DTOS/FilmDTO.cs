using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.DTOS
{
    public class FilmDTO
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public long FilmMakerId { get; set; }
        public int AgeRestriction { get; set; }
        public int PublishedYear { get; set; }
        public string photopath { get; set; }
        public string videopath { get; set; }
        
        public List<long> Actors { get; set; }
        public List<long> Genres { get; set; }
    }
}

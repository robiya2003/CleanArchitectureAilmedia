using Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Film:AudiTable
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public long FilmMakerId {  get; set; }
        public int AgeRestriction { get; set;}
        public int PublishedYear {  get; set; }
        public FilmMaker FilmMaker { get; set; }
        public List<Actor> Actors { get; set; }
        public  List<Genre> Genres { get; set; }
    }
}

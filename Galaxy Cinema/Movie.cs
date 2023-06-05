using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Galaxy_Cinema
{
    internal class Movie
    {
        public Image Picture { get; set; }
        public string Name { get; set; }
        public string NameVN { get; set; }
        public string Point { get; set; }
        public string AgeToWatch { get; set; }
        public string Duration { get; set; }
        public string Categories { get; set; }
        public string Actor { get; set; }
        public string Producer { get; set; }
        public string Director { get; set; }
        public string Country { get; set; }
        public string StartScreening { get; set; }
        public string Description { get; set; }
        public Movie(Image picture, string name, string nameVN, string point, string age,
                    string duration, string categories, string actor, string producer,
                    string director, string country, string start, string description) 
        {
            this.Picture = picture;
            this.Name = name;
            this.NameVN = nameVN;
            this.Point = point;
            this.AgeToWatch = age;
            this.Duration = duration;
            this.Categories = categories;
            this.Actor = actor;
            this.Producer = producer;
            this.Director = director;
            this.Country = country;
            this.StartScreening = start;
            this.Description = description;
        }

        public Movie(Image picture, string name, string nameVN, string age)
        {
            this.Picture = picture;
            this.Name = name;
            this.NameVN = nameVN;
            this.AgeToWatch = age;
        }
    }
}

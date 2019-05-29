using CoreMovieApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreMovieApp.Data
{
    public class MovieRepository
    {
        private static List<Movie> movies = null;

        static MovieRepository()
        {
            movies = new List<Movie>()
            {
                new Movie() {Id=1,CategoryID=2,Name="Ant-Man and The Wasp",ShortDescription="Real heroes. Not actual size. Watch the brand-new trailer for Ant-Man and the Wasp. In theaters July 6th.",
                ImageUrl="ant-manthewasp3.jpg",Description="From the Marvel Cinematic Universe comes a new chapter featuring heroes with the astonishing ability to shrink: “Ant-Man and The Wasp.” In the aftermath of “Captain America: Civil War,” Scott Lang (Paul Rudd) grapples with the consequences of his choices as both a Super Hero and a father. As he struggles to rebalance his home life with his responsibilities as Ant-Man, he’s confronted by Hope van Dyne (Evangeline Lilly) and Dr. Hank Pym (Michael Douglas) with an urgent new mission. Scott must once again put on the suit and learn to fight alongside The Wasp as the team works together to uncover secrets from their past."},
                new Movie() {Id=2,CategoryID=3,Name="Avengers: EndGame",ShortDescription="Real heroes. Not actual size. Watch the brand-new trailer for Ant-Man and the Wasp. In theaters July 6th.",
                ImageUrl="avengersendgame1.jpg",Description="The grave course of events set in motion by Thanos that wiped out half the universe and fractured the Avengers ranks compels the remaining Avengers to take one final stand in Marvel Studios' grand conclusion to twenty-two films, 'Avengers: Endgame.'"},
                new Movie() {Id=3,CategoryID=4,Name="Black Panther",ShortDescription="HERO. LEGEND. KING. Watch Marvel Studio's Black Panther teaser trailer now.",
                ImageUrl="blackpanther4.jpg",Description="A ridiculous week of Marvel news as Marvel Ultimate Alliance 3: The Black Order trailer dropped, new Captain Marvel Funkos were announced, Marvel Studios' Black Panther was nominated for the Golden Globes and SO MUCH MORE."},
                new Movie() {Id=4,CategoryID=5,Name="Captain Marvel",ShortDescription="Which Goose the Cat is Real? | Making Marvel Studios’ Captain Marvel",
                ImageUrl="captainmarvel2.jpg",Description="From Skrull transformations to Goose the Cat to Captain Marvel herself, see how the Visual Effects from Marvel Studios' Captain Marvel are brought to life!."},
                new Movie() {Id=5,CategoryID=6,Name="Captain Marvel",ShortDescription="Which Goose the Cat is Real? | Making Marvel Studios’ Captain Marvel",
                ImageUrl="spider-manfarfromhome5.jpg",Description="From Skrull transformations to Goose the Cat to Captain Marvel herself, see how the Visual Effects from Marvel Studios' Captain Marvel are brought to life!."}
            };
        }

        public static List<Movie> Movies
        {
            get
            {
                return movies;
            }
        }

        public static void AddMovie(Movie movie)
        {
            movies.Add(movie);
        }

        public static Movie GetByID(int Id)
        {
            return movies.FirstOrDefault(x => x.Id == Id);
        }
    }
}

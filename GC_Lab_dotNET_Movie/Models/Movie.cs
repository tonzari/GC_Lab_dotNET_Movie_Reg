using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GC_Lab_dotNET_Movie.Models
{
    public class Movie
    {
        public string ID { get; set; }
        public string Title { get; set; }
        public string Genre { get; set; }
        public string Year { get; set; }
        public string Actors { get; set; }
        public string Directors { get; set; }

/*        public static int ID { get; set; }
        public string Title { get; set; }
        public string Genre { get; set; }
        public int Year { get; set; }
        public List<Actor> Actors { get; set; }
        public List<Director> Directors { get; set; }*/

        // not sure if we can have constructor
/*        public Movie(int iD, string title, string genre, int year, List<Actor> actors, List<Director> directors)
        {
            ID++;
            Title = title;
            Genre = genre;
            Year = year;
            Actors = actors;
            Directors = directors;
        }*/
    }

    // Extra classes to customize the Movie class

/*    public abstract class Person
    {
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }

        public Person(string FirstName, string MiddleName, string LastName)
        {
            this.FirstName = FirstName;
            if (!string.IsNullOrEmpty(MiddleName))
            {
                this.MiddleName = MiddleName;
            }
            else
            {
                this.MiddleName = "";
            }
            this.LastName = LastName;
        }
    }

    public class Actor : Person
    {
        public Actor(string FirstName, string MiddleName, string LastName) : base(FirstName, MiddleName, LastName)
        {
        }
    }

    public class Director : Person
    {
        public Director(string FirstName, string MiddleName, string LastName) : base(FirstName, MiddleName, LastName)
        {
        }
    }*/
}

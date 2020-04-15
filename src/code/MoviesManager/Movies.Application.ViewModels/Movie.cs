using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;

namespace Movies.Application.ViewModels
{
    /// <summary>
    /// View model for the Movie
    /// </summary>
    public class Movie
    {
        /// <summary>
        /// Id of the movie
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Name of the movie
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// This helps us decide if this movie is approproate for younger audiences
        /// </summary>
        public string Rating { get; set; }

        /// <summary>
        /// Genre answers the question is this an action or a romantic comedy film?
        /// </summary>
        public string Genre { get; set; }

        /// <summary>
        /// How long the movie is
        /// </summary>
        public double Minutes { get; set; }
    }
}

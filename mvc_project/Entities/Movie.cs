using mvc_project.Models.Movie;

namespace mvc_project.Entities
{
    public class Movie
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Category { get; set; }
        public bool InBillboard { get; set; }

        public static Movie Create(
            string name,
            string category,
            bool inBillboard
            )
        {
            return new Movie
            {
                Name = name,
                Category = category,
                InBillboard = inBillboard
            };
        }

        public void Update(
            string name,
            string category,
            bool inBillboard
            )
        {
            Name = name;
            Category = category;
            InBillboard = inBillboard;   
        }

        public static explicit operator CreateUpdateMovie(Movie movie)
        {
            return new CreateUpdateMovie
            {
                Id = movie.Id,
                Name = movie.Name,
                Category = movie.Category,
                InBillboard = movie.InBillboard
            };
        }
    }
}
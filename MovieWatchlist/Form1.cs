using MovieCollectionApp;

namespace MovieWatchlist
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            // This is automatically called in the designer file
            LoadMovies();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string searchTerm = textBoxSearch.Text;
            var movies = DatabaseHelper.GetAllMovies();
            var filteredMovies = movies.Where(m => m.Name.ToLower().Contains(searchTerm.ToLower())).ToList();
            dataGridViewMovies.DataSource = filteredMovies;
        }

        private void btnAddMovie_Click(object sender, EventArgs e)
        {
            using (var addMovieForm = new AddMovieForm())
            {
                if (addMovieForm.ShowDialog() == DialogResult.OK)
                {
                    // Add movie to database
                    var newMovie = new Movie
                    {
                        Name = addMovieForm.MovieName,
                        ReleaseYear = addMovieForm.ReleaseYear,
                        Genre = addMovieForm.Genre,
                        Watched = addMovieForm.IsWatched
                    };

                    AddMovie(newMovie); // Save to DB
                    LoadMovies(); // Refresh the grid
                }
            }
        }


        private void btnToggleWatched_Click(object sender, EventArgs e)
        {
            if (dataGridViewMovies.SelectedRows.Count > 0)
            {
                int movieId = Convert.ToInt32(dataGridViewMovies.SelectedRows[0].Cells["Id"].Value);
                DatabaseHelper.ToggleWatchedStatus(movieId);
                LoadMovies();  // Refresh the list
            }
            else
            {
                MessageBox.Show("Please select a movie to toggle watched status.");
            }
        }

        private void btnDeleteMovie_Click(object sender, EventArgs e)
        {
            if (dataGridViewMovies.SelectedRows.Count > 0)
            {
                int movieId = Convert.ToInt32(dataGridViewMovies.SelectedRows[0].Cells["Id"].Value);

                // Confirm deletion with the user
                var result = MessageBox.Show("Are you sure you want to delete this movie?",
                                             "Confirm Delete",
                                             MessageBoxButtons.YesNo,
                                             MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    DatabaseHelper.DeleteMovie(movieId);
                    LoadMovies(); // Refresh the movie list
                }
            }
            else
            {
                MessageBox.Show("Please select a movie to delete.");
            }
        }


        private void comboBoxSort_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedSort = comboBoxSort.SelectedItem?.ToString() ?? "Name";
            if (string.IsNullOrEmpty(selectedSort)) return;

            var movies = DatabaseHelper.GetAllMovies();
            List<Movie> sortedMovies;

            switch (selectedSort)
            {
                case "Id":
                    sortedMovies = movies.OrderBy(m => m.Id).ToList();
                    break;
                case "Name":
                    sortedMovies = movies.OrderBy(m => m.Name).ToList();
                    break;
                case "Release Year":
                    sortedMovies = movies.OrderBy(m => m.ReleaseYear).ToList();
                    break;
                case "Genre":
                    sortedMovies = movies.OrderBy(m => m.Genre).ToList();
                    break;
                case "Watched":
                    sortedMovies = movies.OrderByDescending(m => m.Watched).ToList();
                    break;
                default:
                    sortedMovies = movies;
                    break;
            }

            dataGridViewMovies.DataSource = sortedMovies;
        }

        private void LoadMovies()
        {
            var movies = DatabaseHelper.GetAllMovies();
            dataGridViewMovies.DataSource = movies;
        }

        private void AddMovie(Movie movie)
        {
            DatabaseHelper.AddMovie(
                    movie.Name,
                    movie.ReleaseYear,
                    movie.Genre,
                    movie.Watched
                );
        }

        
    }
}

using System;
using System.Collections.Generic;
using System.Data.SQLite;

namespace MovieCollectionApp
{
    public static class DatabaseHelper
    {
        private const string DatabaseFileName = "movies.db";
        private const string ConnectionString = "Data Source=movies.db;Version=3;";

        public static void InitializeDatabase()
        {
            if (!System.IO.File.Exists(DatabaseFileName))
            {
                SQLiteConnection.CreateFile(DatabaseFileName);
            }

            using (var connection = new SQLiteConnection(ConnectionString))
            {
                connection.Open();

                string createTableQuery = @"
                    CREATE TABLE IF NOT EXISTS Movies (
                        Id INTEGER PRIMARY KEY AUTOINCREMENT,
                        Name TEXT NOT NULL,
                        ReleaseYear INTEGER,
                        Genre TEXT,
                        Watched BOOLEAN DEFAULT 0
                    );";

                using (var command = new SQLiteCommand(createTableQuery, connection))
                {
                    command.ExecuteNonQuery();
                }

                Console.WriteLine("Database initialized.");
            }
        }

        public static void AddMovie(string name, int releaseYear, string genre, bool watched)
        {
            using (var connection = new SQLiteConnection(ConnectionString))
            {
                connection.Open();
                string insertQuery = @"
                    INSERT INTO Movies (Name, ReleaseYear, Genre, Watched)
                    VALUES (@Name, @ReleaseYear, @Genre, @Watched);";

                using (var command = new SQLiteCommand(insertQuery, connection))
                {
                    command.Parameters.AddWithValue("@Name", name);
                    command.Parameters.AddWithValue("@ReleaseYear", releaseYear);
                    command.Parameters.AddWithValue("@Genre", genre);
                    command.Parameters.AddWithValue("@Watched", watched ? 1 : 0);
                    command.ExecuteNonQuery();
                }
            }
        }

        public static List<Movie> GetAllMovies()
        {
            var movies = new List<Movie>();

            using (var connection = new SQLiteConnection(ConnectionString))
            {
                connection.Open();
                string selectQuery = "SELECT * FROM Movies;";

                using (var command = new SQLiteCommand(selectQuery, connection))
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        movies.Add(new Movie
                        {
                            Id = reader.GetInt32(0),
                            Name = reader.GetString(1),
                            ReleaseYear = reader.GetInt32(2),
                            Genre = reader.GetString(3),
                            Watched = reader.GetBoolean(4)
                        });
                    }
                }
            }

            return movies;
        }

        public static void ToggleWatchedStatus(int id)
        {
            using (var connection = new SQLiteConnection(ConnectionString))
            {
                connection.Open();
                string toggleQuery = @"
                    UPDATE Movies
                    SET Watched = CASE WHEN Watched = 1 THEN 0 ELSE 1 END
                    WHERE Id = @Id;";

                using (var command = new SQLiteCommand(toggleQuery, connection))
                {
                    command.Parameters.AddWithValue("@Id", id);
                    command.ExecuteNonQuery();
                }
            }
        }

        public static void DeleteMovie(int id)
        {
            using (var connection = new SQLiteConnection(ConnectionString))
            {
                connection.Open();
                string query = "DELETE FROM Movies WHERE Id = @Id";
                using (var command = new SQLiteCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Id", id);
                    command.ExecuteNonQuery();
                }
            }
        }

    }

    public class Movie
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int ReleaseYear { get; set; }
        public string Genre { get; set; }
        public bool Watched { get; set; }
    }
}

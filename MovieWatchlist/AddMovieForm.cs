using System;
using System.Windows.Forms;
using System.Xml.Linq;

namespace MovieWatchlist
{
    public partial class AddMovieForm : Form
    {
        public string MovieName { get; private set; }
        public int ReleaseYear { get; private set; }
        public string Genre { get; private set; }
        public bool IsWatched { get; private set; }

        public AddMovieForm()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            // Validate input
            if (string.IsNullOrWhiteSpace(txtName.Text) || string.IsNullOrWhiteSpace(txtGenre.Text))
            {
                MessageBox.Show("Name and Genre are required fields.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!int.TryParse(txtReleaseYear.Text, out int year) || year < 1800 || year > DateTime.Now.Year)
            {
                MessageBox.Show("Please enter a valid release year.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Set properties
            MovieName = txtName.Text.Trim();
            ReleaseYear = year;
            Genre = txtGenre.Text.Trim();
            IsWatched = chkWatched.Checked;

            this.DialogResult = DialogResult.OK; // Indicate success
            this.Close();
        }

        
    }
}

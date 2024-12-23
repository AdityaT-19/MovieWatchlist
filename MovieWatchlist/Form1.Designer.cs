namespace MovieWatchlist
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">True if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            panel1 = new Panel();
            textBoxSearch = new TextBox();
            btnSearch = new Button();
            btnAddMovie = new Button();
            btnToggleWatched = new Button();
            btnDeleteMovie = new Button();
            labelSort = new Label();
            comboBoxSort = new ComboBox();
            dataGridViewMovies = new DataGridView();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewMovies).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(textBoxSearch);
            panel1.Controls.Add(btnSearch);
            panel1.Controls.Add(btnAddMovie);
            panel1.Controls.Add(btnToggleWatched);
            panel1.Controls.Add(btnDeleteMovie);
            panel1.Controls.Add(labelSort);
            panel1.Controls.Add(comboBoxSort);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 63);
            panel1.TabIndex = 0;
            // 
            // textBoxSearch
            // 
            textBoxSearch.Location = new Point(10, 20);
            textBoxSearch.Name = "textBoxSearch";
            textBoxSearch.PlaceholderText = "Search by name...";
            textBoxSearch.Size = new Size(200, 23);
            textBoxSearch.TabIndex = 0;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(220, 20);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(100, 23);
            btnSearch.TabIndex = 1;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // btnAddMovie
            // 
            btnAddMovie.Location = new Point(330, 20);
            btnAddMovie.Name = "btnAddMovie";
            btnAddMovie.Size = new Size(100, 23);
            btnAddMovie.TabIndex = 2;
            btnAddMovie.Text = "Add Movie";
            btnAddMovie.UseVisualStyleBackColor = true;
            btnAddMovie.Click += btnAddMovie_Click;
            // 
            // btnToggleWatched
            // 
            btnToggleWatched.Location = new Point(440, 20);
            btnToggleWatched.Name = "btnToggleWatched";
            btnToggleWatched.Size = new Size(100, 23);
            btnToggleWatched.TabIndex = 3;
            btnToggleWatched.Text = "Toggle Watched";
            btnToggleWatched.UseVisualStyleBackColor = true;
            btnToggleWatched.Click += btnToggleWatched_Click;
            // 
            // btnDeleteMovie
            // 
            btnDeleteMovie.Location = new Point(672, 18);
            btnDeleteMovie.Name = "btnDeleteMovie";
            btnDeleteMovie.Size = new Size(100, 23);
            btnDeleteMovie.TabIndex = 5;
            btnDeleteMovie.Text = "Delete Movie";
            btnDeleteMovie.UseVisualStyleBackColor = true;
            btnDeleteMovie.Click += btnDeleteMovie_Click;
            // 
            // labelSort
            // 
            labelSort.BackColor = Color.Transparent;
            labelSort.Location = new Point(550, 4);
            labelSort.Name = "labelSort";
            labelSort.Size = new Size(100, 23);
            labelSort.TabIndex = 6;
            labelSort.Text = "Sort by:";
            // 
            // comboBoxSort
            // 
            comboBoxSort.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxSort.Items.AddRange(new object[] { "Id","Name", "Release Year", "Genre", "Watched" });
            comboBoxSort.SelectedIndex = 0;
            comboBoxSort.Location = new Point(546, 19);
            comboBoxSort.Name = "comboBoxSort";
            comboBoxSort.Size = new Size(120, 23);
            comboBoxSort.TabIndex = 5;
            comboBoxSort.SelectedIndexChanged += comboBoxSort_SelectedIndexChanged;
            // 
            // dataGridViewMovies
            // 
            dataGridViewMovies.AllowUserToAddRows = false;
            dataGridViewMovies.AllowUserToDeleteRows = false;
            dataGridViewMovies.AllowUserToOrderColumns = true;
            dataGridViewMovies.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewMovies.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewMovies.Dock = DockStyle.Fill;
            dataGridViewMovies.Location = new Point(0, 63);
            dataGridViewMovies.MultiSelect = false;
            dataGridViewMovies.Name = "dataGridViewMovies";
            dataGridViewMovies.ReadOnly = true;
            dataGridViewMovies.Size = new Size(800, 537);
            dataGridViewMovies.TabIndex = 1;

            // Adjustments to panel1 layout and controls
            panel1.Controls.Clear(); // Clear existing controls for reordering
            panel1.Controls.Add(textBoxSearch);
            panel1.Controls.Add(btnSearch);
            panel1.Controls.Add(btnAddMovie);
            panel1.Controls.Add(btnToggleWatched);
            panel1.Controls.Add(labelSort);
            panel1.Controls.Add(comboBoxSort);
            panel1.Controls.Add(btnDeleteMovie);

            // Update control positions and sizes
            // textBoxSearch
            textBoxSearch.Location = new Point(10, 20);
            textBoxSearch.Size = new Size(180, 23);

            // btnSearch
            btnSearch.Location = new Point(200, 20);
            btnSearch.Size = new Size(80, 23);

            // btnAddMovie
            btnAddMovie.Location = new Point(290, 20);
            btnAddMovie.Size = new Size(100, 23);

            // btnToggleWatched
            btnToggleWatched.Location = new Point(400, 20);
            btnToggleWatched.Size = new Size(120, 23);

            // labelSort
            labelSort.Location = new Point(530, 20);
            labelSort.Size = new Size(50, 23);
            labelSort.TextAlign = ContentAlignment.MiddleRight;

            // comboBoxSort
            comboBoxSort.Location = new Point(590, 20);
            comboBoxSort.Size = new Size(120, 23);

            // btnDeleteMovie
            btnDeleteMovie.Location = new Point(720, 20);
            btnDeleteMovie.Size = new Size(100, 23);

            // panel1
            panel1.Dock = DockStyle.Top;
            panel1.Height = 63;
            panel1.AutoSizeMode = AutoSizeMode.GrowAndShrink;

            // Anchor settings for responsive design
            textBoxSearch.Anchor = AnchorStyles.Left;
            btnSearch.Anchor = AnchorStyles.Left;
            btnAddMovie.Anchor = AnchorStyles.Left;
            btnToggleWatched.Anchor = AnchorStyles.Left;
            labelSort.Anchor = AnchorStyles.Left;
            comboBoxSort.Anchor = AnchorStyles.Left;
            btnDeleteMovie.Anchor = AnchorStyles.Left;

            // Refining the dataGridViewMovies properties
            dataGridViewMovies.Dock = DockStyle.Fill;
            dataGridViewMovies.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewMovies.AllowUserToAddRows = false;
            dataGridViewMovies.AllowUserToDeleteRows = false;
            dataGridViewMovies.MultiSelect = false;

            // 
            // Form1
            // 
            ClientSize = new Size(850, 600);
            Controls.Add(dataGridViewMovies);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Movie Collection/Watchlist";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewMovies).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnAddMovie;
        private System.Windows.Forms.Button btnToggleWatched;
        private System.Windows.Forms.DataGridView dataGridViewMovies;
        private System.Windows.Forms.Button btnDeleteMovie;
        private Label labelSort;
        private ComboBox comboBoxSort;


    }
}

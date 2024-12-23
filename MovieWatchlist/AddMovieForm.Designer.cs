namespace MovieWatchlist
{
    partial class AddMovieForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            txtName = new TextBox();
            txtReleaseYear = new TextBox();
            txtGenre = new TextBox();
            chkWatched = new CheckBox();
            btnSave = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // txtName
            // 
            txtName.Location = new Point(20, 66);
            txtName.Name = "txtName";
            txtName.PlaceholderText = "Movie Name";
            txtName.Size = new Size(250, 23);
            txtName.TabIndex = 0;
            // 
            // txtReleaseYear
            // 
            txtReleaseYear.Location = new Point(20, 95);
            txtReleaseYear.Name = "txtReleaseYear";
            txtReleaseYear.PlaceholderText = "Release Year";
            txtReleaseYear.Size = new Size(250, 23);
            txtReleaseYear.TabIndex = 1;
            // 
            // txtGenre
            // 
            txtGenre.Location = new Point(20, 124);
            txtGenre.Name = "txtGenre";
            txtGenre.PlaceholderText = "Genre";
            txtGenre.Size = new Size(250, 23);
            txtGenre.TabIndex = 2;
            // 
            // chkWatched
            // 
            chkWatched.AutoSize = true;
            chkWatched.Location = new Point(20, 153);
            chkWatched.Name = "chkWatched";
            chkWatched.Size = new Size(73, 19);
            chkWatched.TabIndex = 3;
            chkWatched.Text = "Watched";
            chkWatched.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(20, 178);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(250, 30);
            btnSave.TabIndex = 4;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(20, 24);
            label1.Name = "label1";
            label1.Size = new Size(101, 15);
            label1.TabIndex = 5;
            label1.Text = "Add a New Movie";
            // 
            // AddMovieForm
            // 
            ClientSize = new Size(300, 240);
            Controls.Add(label1);
            Controls.Add(txtName);
            Controls.Add(txtReleaseYear);
            Controls.Add(txtGenre);
            Controls.Add(chkWatched);
            Controls.Add(btnSave);
            Name = "AddMovieForm";
            Text = "Add Movie";
            ResumeLayout(false);
            PerformLayout();
        }

        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtReleaseYear;
        private System.Windows.Forms.TextBox txtGenre;
        private System.Windows.Forms.CheckBox chkWatched;
        private System.Windows.Forms.Button btnSave;
        private Label label1;
    }
}

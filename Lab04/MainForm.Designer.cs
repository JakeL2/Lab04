namespace Lan04
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ManageMoviesButton = new System.Windows.Forms.Button();
            this.ManageActorsButton = new System.Windows.Forms.Button();
            this.ManageGenreButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ManageMoviesButton
            // 
            this.ManageMoviesButton.Location = new System.Drawing.Point(12, 12);
            this.ManageMoviesButton.Name = "ManageMoviesButton";
            this.ManageMoviesButton.Size = new System.Drawing.Size(130, 38);
            this.ManageMoviesButton.TabIndex = 0;
            this.ManageMoviesButton.Text = "Manage Movies";
            this.ManageMoviesButton.UseVisualStyleBackColor = true;
            this.ManageMoviesButton.Click += new System.EventHandler(this.ManageMoviesButton_Click);
            // 
            // ManageActorsButton
            // 
            this.ManageActorsButton.Location = new System.Drawing.Point(148, 12);
            this.ManageActorsButton.Name = "ManageActorsButton";
            this.ManageActorsButton.Size = new System.Drawing.Size(130, 38);
            this.ManageActorsButton.TabIndex = 1;
            this.ManageActorsButton.Text = "Manage Actors";
            this.ManageActorsButton.UseVisualStyleBackColor = true;
            this.ManageActorsButton.Click += new System.EventHandler(this.ManageActorsButton_Click);
            // 
            // ManageGenreButton
            // 
            this.ManageGenreButton.Location = new System.Drawing.Point(284, 12);
            this.ManageGenreButton.Name = "ManageGenreButton";
            this.ManageGenreButton.Size = new System.Drawing.Size(130, 38);
            this.ManageGenreButton.TabIndex = 2;
            this.ManageGenreButton.Text = "Manage Genres";
            this.ManageGenreButton.UseVisualStyleBackColor = true;
            this.ManageGenreButton.Click += new System.EventHandler(this.ManageGenreButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(452, 69);
            this.Controls.Add(this.ManageGenreButton);
            this.Controls.Add(this.ManageActorsButton);
            this.Controls.Add(this.ManageMoviesButton);
            this.Name = "MainForm";
            this.Text = "CRCMDB";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ManageMoviesButton;
        private System.Windows.Forms.Button ManageActorsButton;
        private System.Windows.Forms.Button ManageGenreButton;
    }
}


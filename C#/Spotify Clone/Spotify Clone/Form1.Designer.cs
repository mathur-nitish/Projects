namespace Spotify_Clone
{
    partial class Songify
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Songify));
            this.ExitButton = new System.Windows.Forms.Button();
            this.SongList = new System.Windows.Forms.ListBox();
            this.Playerpanel = new System.Windows.Forms.Panel();
            this.SelectSongs = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SongProgress = new System.Windows.Forms.ProgressBar();
            this.Songinformation = new System.Windows.Forms.Label();
            this.SongName = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.DisplaySong = new System.Windows.Forms.Label();
            this.DisplayInformation = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Playerpanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // ExitButton
            // 
            this.ExitButton.BackColor = System.Drawing.Color.Transparent;
            this.ExitButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ExitButton.BackgroundImage")));
            this.ExitButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ExitButton.FlatAppearance.BorderSize = 0;
            this.ExitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExitButton.Location = new System.Drawing.Point(1513, 2);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(39, 39);
            this.ExitButton.TabIndex = 0;
            this.ExitButton.UseVisualStyleBackColor = false;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // SongList
            // 
            this.SongList.BackColor = System.Drawing.Color.DimGray;
            this.SongList.FormattingEnabled = true;
            this.SongList.ItemHeight = 16;
            this.SongList.Location = new System.Drawing.Point(190, 297);
            this.SongList.Name = "SongList";
            this.SongList.Size = new System.Drawing.Size(1362, 404);
            this.SongList.TabIndex = 2;
            // 
            // Playerpanel
            // 
            this.Playerpanel.BackColor = System.Drawing.Color.Teal;
            this.Playerpanel.Controls.Add(this.SelectSongs);
            this.Playerpanel.Controls.Add(this.button3);
            this.Playerpanel.Controls.Add(this.button1);
            this.Playerpanel.Controls.Add(this.button2);
            this.Playerpanel.Controls.Add(this.SongProgress);
            this.Playerpanel.Controls.Add(this.Songinformation);
            this.Playerpanel.Controls.Add(this.SongName);
            this.Playerpanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Playerpanel.Location = new System.Drawing.Point(0, 718);
            this.Playerpanel.Name = "Playerpanel";
            this.Playerpanel.Size = new System.Drawing.Size(1564, 100);
            this.Playerpanel.TabIndex = 1;
            this.Playerpanel.Paint += new System.Windows.Forms.PaintEventHandler(this.Playerpanel_Paint);
            // 
            // SelectSongs
            // 
            this.SelectSongs.Location = new System.Drawing.Point(1351, 28);
            this.SelectSongs.Name = "SelectSongs";
            this.SelectSongs.Size = new System.Drawing.Size(185, 41);
            this.SelectSongs.TabIndex = 6;
            this.SelectSongs.Text = "Browse Songs";
            this.SelectSongs.UseVisualStyleBackColor = true;
            this.SelectSongs.Click += new System.EventHandler(this.SelectSongs_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Transparent;
            this.button3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button3.BackgroundImage")));
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Location = new System.Drawing.Point(831, 14);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(39, 39);
            this.button3.TabIndex = 5;
            this.button3.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(697, 14);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(39, 39);
            this.button1.TabIndex = 3;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button2.BackgroundImage")));
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(764, 14);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(39, 39);
            this.button2.TabIndex = 4;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // SongProgress
            // 
            this.SongProgress.Location = new System.Drawing.Point(440, 59);
            this.SongProgress.Name = "SongProgress";
            this.SongProgress.Size = new System.Drawing.Size(740, 10);
            this.SongProgress.TabIndex = 2;
            // 
            // Songinformation
            // 
            this.Songinformation.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Songinformation.Location = new System.Drawing.Point(12, 47);
            this.Songinformation.Name = "Songinformation";
            this.Songinformation.Size = new System.Drawing.Size(253, 44);
            this.Songinformation.TabIndex = 1;
            this.Songinformation.Text = "SongInformation";
            // 
            // SongName
            // 
            this.SongName.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SongName.Location = new System.Drawing.Point(12, 15);
            this.SongName.Name = "SongName";
            this.SongName.Size = new System.Drawing.Size(160, 32);
            this.SongName.TabIndex = 0;
            this.SongName.Text = "SongName";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(214, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(246, 279);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // DisplaySong
            // 
            this.DisplaySong.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DisplaySong.Location = new System.Drawing.Point(476, 170);
            this.DisplaySong.Name = "DisplaySong";
            this.DisplaySong.Size = new System.Drawing.Size(160, 32);
            this.DisplaySong.TabIndex = 4;
            this.DisplaySong.Text = "SongName";
            // 
            // DisplayInformation
            // 
            this.DisplayInformation.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DisplayInformation.Location = new System.Drawing.Point(476, 213);
            this.DisplayInformation.Name = "DisplayInformation";
            this.DisplayInformation.Size = new System.Drawing.Size(253, 44);
            this.DisplayInformation.TabIndex = 6;
            this.DisplayInformation.Text = "SongInformation";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DimGray;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(172, 718);
            this.panel1.TabIndex = 7;
            // 
            // Songify
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(1564, 818);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.DisplayInformation);
            this.Controls.Add(this.DisplaySong);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.SongList);
            this.Controls.Add(this.Playerpanel);
            this.Controls.Add(this.ExitButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Songify";
            this.Text = "Songify";
            this.TopMost = true;
            this.Playerpanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.ListBox SongList;
        private System.Windows.Forms.Panel Playerpanel;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ProgressBar SongProgress;
        private System.Windows.Forms.Label Songinformation;
        private System.Windows.Forms.Label SongName;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label DisplaySong;
        private System.Windows.Forms.Label DisplayInformation;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button SelectSongs;
    }
}


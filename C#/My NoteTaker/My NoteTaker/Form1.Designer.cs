namespace My_NoteTaker
{
    partial class NoteTaker
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NoteTaker));
            this.Files = new System.Windows.Forms.DataGridView();
            this.NotesBox = new System.Windows.Forms.TextBox();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.SaveButton = new System.Windows.Forms.Button();
            this.Title = new System.Windows.Forms.Label();
            this.NoteLabel = new System.Windows.Forms.Label();
            this.NewButton = new System.Windows.Forms.Button();
            this.TitleBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.Files)).BeginInit();
            this.SuspendLayout();
            // 
            // Files
            // 
            this.Files.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Files.BackgroundColor = System.Drawing.Color.DarkCyan;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.DarkCyan;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Lucida Sans", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.DarkCyan;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Files.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.Files.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.DarkTurquoise;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Lucida Sans", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.DarkTurquoise;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Files.DefaultCellStyle = dataGridViewCellStyle2;
            this.Files.GridColor = System.Drawing.Color.DarkCyan;
            this.Files.Location = new System.Drawing.Point(12, 21);
            this.Files.Name = "Files";
            this.Files.RowHeadersWidth = 51;
            this.Files.RowTemplate.Height = 24;
            this.Files.Size = new System.Drawing.Size(306, 493);
            this.Files.TabIndex = 0;
            this.Files.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.previousNotes_CellContentClick);
            // 
            // NotesBox
            // 
            this.NotesBox.BackColor = System.Drawing.Color.LightSeaGreen;
            this.NotesBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.NotesBox.Location = new System.Drawing.Point(324, 106);
            this.NotesBox.Multiline = true;
            this.NotesBox.Name = "NotesBox";
            this.NotesBox.Size = new System.Drawing.Size(764, 355);
            this.NotesBox.TabIndex = 2;
            this.NotesBox.TextChanged += new System.EventHandler(this.NotesBox_TextChanged);
            // 
            // DeleteButton
            // 
            this.DeleteButton.BackColor = System.Drawing.Color.LightSeaGreen;
            this.DeleteButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("DeleteButton.BackgroundImage")));
            this.DeleteButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.DeleteButton.FlatAppearance.BorderSize = 0;
            this.DeleteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeleteButton.Location = new System.Drawing.Point(324, 467);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(43, 47);
            this.DeleteButton.TabIndex = 3;
            this.DeleteButton.Text = ".";
            this.DeleteButton.UseVisualStyleBackColor = false;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // SaveButton
            // 
            this.SaveButton.BackColor = System.Drawing.Color.LightSlateGray;
            this.SaveButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Fuchsia;
            this.SaveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SaveButton.Location = new System.Drawing.Point(956, 467);
            this.SaveButton.Margin = new System.Windows.Forms.Padding(1);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(123, 31);
            this.SaveButton.TabIndex = 4;
            this.SaveButton.Text = "Save";
            this.SaveButton.UseVisualStyleBackColor = false;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // Title
            // 
            this.Title.BackColor = System.Drawing.Color.LightSlateGray;
            this.Title.Font = new System.Drawing.Font("Lucida Sans", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title.Location = new System.Drawing.Point(325, 21);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(763, 24);
            this.Title.TabIndex = 5;
            this.Title.Text = "Title : ";
            this.Title.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // NoteLabel
            // 
            this.NoteLabel.BackColor = System.Drawing.Color.LightSlateGray;
            this.NoteLabel.Font = new System.Drawing.Font("Lucida Sans", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NoteLabel.Location = new System.Drawing.Point(325, 79);
            this.NoteLabel.Name = "NoteLabel";
            this.NoteLabel.Size = new System.Drawing.Size(763, 24);
            this.NoteLabel.TabIndex = 6;
            this.NoteLabel.Text = "Note";
            this.NoteLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // NewButton
            // 
            this.NewButton.BackColor = System.Drawing.Color.LightSlateGray;
            this.NewButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Fuchsia;
            this.NewButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NewButton.Location = new System.Drawing.Point(814, 467);
            this.NewButton.Margin = new System.Windows.Forms.Padding(1);
            this.NewButton.Name = "NewButton";
            this.NewButton.Size = new System.Drawing.Size(123, 31);
            this.NewButton.TabIndex = 7;
            this.NewButton.Text = "New";
            this.NewButton.UseVisualStyleBackColor = false;
            this.NewButton.Click += new System.EventHandler(this.NewButton_Click);
            // 
            // TitleBox
            // 
            this.TitleBox.BackColor = System.Drawing.Color.LightSeaGreen;
            this.TitleBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TitleBox.Location = new System.Drawing.Point(324, 48);
            this.TitleBox.Name = "TitleBox";
            this.TitleBox.Size = new System.Drawing.Size(764, 28);
            this.TitleBox.TabIndex = 1;
            this.TitleBox.TextChanged += new System.EventHandler(this.TitleBox_TextChanged);
            // 
            // NoteTaker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1100, 534);
            this.Controls.Add(this.NewButton);
            this.Controls.Add(this.NoteLabel);
            this.Controls.Add(this.Title);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.NotesBox);
            this.Controls.Add(this.TitleBox);
            this.Controls.Add(this.Files);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Lucida Sans", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "NoteTaker";
            this.Text = "Note Taker";
            this.Load += new System.EventHandler(this.NoteTaker_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Files)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView Files;
        private System.Windows.Forms.TextBox NotesBox;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.Label NoteLabel;
        private System.Windows.Forms.Button NewButton;
        private System.Windows.Forms.TextBox TitleBox;
    }
}


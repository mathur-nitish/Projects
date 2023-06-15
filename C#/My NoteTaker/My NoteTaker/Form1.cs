using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace My_NoteTaker
{
    public partial class NoteTaker : Form
    {
        DataTable notes = new DataTable();
        bool editing = false;
        public NoteTaker()
        {
            InitializeComponent();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            SaveButton.TabStop = false;
            SaveButton.FlatStyle = FlatStyle.Flat;
            SaveButton.FlatAppearance.BorderSize = 0;
            SaveButton.FlatAppearance.BorderColor = Color.FromArgb(0, 255, 255, 255); //transparent
            if (editing)
            {
                notes.Rows[Files.CurrentCell.RowIndex]["Title"] = TitleBox.Text;
                notes.Rows[Files.CurrentCell.RowIndex]["Notes"] = NotesBox.Text;
            }
            else
            {
                notes.Rows.Add(TitleBox.Text, NotesBox.Text);
            }
            TitleBox.Text = "";
            NotesBox.Text = "";
            editing = false;
        }

        private void NoteTaker_Load(object sender, EventArgs e)
        {
            notes.Columns.Add("Title");
            notes.Columns.Add("Notes");

            Files.DataSource = notes;

        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            try
            {
                notes.Rows[Files.CurrentCell.RowIndex].Delete();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Invalid Note selected!");
            }

        }


        private void previousNotes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            TitleBox.Text = notes.Rows[Files.CurrentCell.RowIndex].ItemArray[0].ToString();
            NotesBox.Text = notes.Rows[Files.CurrentCell.RowIndex].ItemArray[1].ToString();
            editing = true;
        }

        private void NotesBox_TextChanged(object sender, EventArgs e)
        {


        }

        private void TitleBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void NewButton_Click(object sender, EventArgs e)
        {
            TitleBox.Text = "";
            NotesBox.Text = "";
        }
    }
}

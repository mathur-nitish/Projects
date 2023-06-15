using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Spotify_Clone
{
    public partial class Songify : Form
    {
        private MusicPlayer musicPlayer = new MusicPlayer();
        public Songify()
        {
            InitializeComponent();
        }

        String[] paths, files;


        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void SelectSongs_Click(object sender, EventArgs e)
        {
            //OpenFileDialog ofd = new OpenFileDialog();
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = "Mp3 Files|*.mp3";
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    musicPlayer.open(ofd.FileName);
                }
                if (ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    files = ofd.SafeFileNames;
                    paths = ofd.FileNames;

                    for (int i = 0; i < files.Length; i++)
                    {
                        SongList.Items.Add(files[i]);
                    }
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            musicPlayer.play();
        }

        private void Playerpanel_Paint(object sender, PaintEventArgs e)
        {
            
        }


        
    }

}

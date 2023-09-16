using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MusicPlayerApplication
{
    public partial class MusicPlayerApp : Form
    {
        public MusicPlayerApp()
        {
            InitializeComponent();
        }
        // Two Global Variable of String type Array one will hold Title or Name of Song  and Second Array store path of song 
        string[] paths, files;

        private void ButtonSelectSong_Click(object sender, EventArgs e)
        {
            // select song
            OpenFileDialog ofd   = new OpenFileDialog();
            //Select Multiple Song 
            ofd.Multiselect = true;
            if(ofd.ShowDialog()==System.Windows.Forms.DialogResult.OK)
            {
                files = ofd.SafeFileNames; //saves the name of the track in files array
                paths = ofd.FileNames; //Save the paths of the tracks in path array

                //Display the music titles in ListBox
                for(int i=0;i<files.Length;i++)
                {
                    ListBoxSongs.Items.Add(files[i]);// Display song in ListBox
                }
            }
        }

        private void ListBoxSongs_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Play Music
            axWindowsMediaPlayerMusic.URL = paths[ListBoxSongs.SelectedIndex] ;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            // close the app
            this.Close();
        }
    }
}

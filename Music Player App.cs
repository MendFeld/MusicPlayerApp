﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MusicPlayerApp
{
    public partial class MusicPlayerApp : Form
    {
        public MusicPlayerApp()
        {
            InitializeComponent();
        }

        //Create Global Variables of String Type Array to save the titles or name of the Tracks and path of the track
        String[] paths, files;

        private void BtnSelectSongs_Click(object sender, EventArgs e)
        {
            //Code to Select Songs
            OpenFileDialog ofd = new OpenFileDialog();
            //Code to select multiple files
            ofd.Multiselect = true;

            if (ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                files = ofd.SafeFileNames; //Save the names of the track in files array
                paths = ofd.FileNames; //Save the paths of the tracks in path array
                //Display the music titles in listbox
                for (int i = 0; i < files.Length; i++)
                {
                    listBoxSongs.Items.Add(files[i]); //Display Songs in Listbox
                }
            }
        }

        private void ListBoxSongs_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Write a code to play music This code does not exist in current context 
        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {
            //Code to Close the App
            this.Close();
        }
    }
}

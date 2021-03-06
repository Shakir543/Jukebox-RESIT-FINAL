﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

//When application is opened the genres and tracks wont appear until you move the scrollbar and then will appear. This was kind of a bug I couldn't fix.
//

namespace JukeBox
{
    public partial class Jukebox : Form

    {
        int currentGenre = 0; // Shows the current genre


        public Jukebox()
        {
            InitializeComponent();



        }







        private void button1_Click(object sender, EventArgs e)
        {
            Setup f2 = new Setup(); //creates new setup form
            f2.ShowDialog(); // shows setup form
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            AboutForm f3 = new AboutForm(); //creates new About form
            f3.ShowDialog(); //shows new About Form
        }

        private void Main_Load(object sender, EventArgs e)
        {

            update(); //updates the main from and essentially saves any changes
        }

        private void update()
        {
            List<List<string>> genre = readFile(); 
            GenreName.Text = genre[currentGenre][1].ToString();

            UpdateGenrelist(); 


        }

        private void UpdateGenrelist()
        {
            List<List<string>> genre = readFile();
            int max = Convert.ToInt32(genre[currentGenre][0]);//converts to string
            for (int i = 0; i < max; i++)
            {
                Genrelist.Items.Add(genre[currentGenre][i + 2]);//adds genre
            }
        }

        private List<List<string>> readFile()
        {

            StreamReader sr = new StreamReader("../../Media.txt");//reads the Media file

            // read in the number of genres from the file
            int genreNumber = Convert.ToInt32(sr.ReadLine());//converts it to string

            //list to hold the genres
            List<List<string>> genre = new List<List<string>>();

            
            for (int i = 0; i < genreNumber; i++)
            {
                List<string> newgenre = new List<string>();
                int trackNumber = Convert.ToInt32(sr.ReadLine());
                newgenre.Add((trackNumber.ToString()));
                newgenre.Add(sr.ReadLine());
                for (int f = 0; f < trackNumber; f++)
                {
                    newgenre.Add(sr.ReadLine());
                }
                genre.Add(newgenre);
            }
            return (genre);
        }

        private void Genrelist_DoubleClick(object sender, EventArgs e)
        {
            if (Genrelist.SelectedItem != null)
            {
                if (Playlist.Items.Count == 0 && playingNow.Text == "")//if playlist is empty then it sends the track straight from genrelist to playingNow
                {
                    playingNow.Text = Genrelist.SelectedItem.ToString();//if playingnow is empty then adds the song and plays it
                    playTrack();

                }
                else if (Playlist.Items.Count > 0 || (Playlist.Items.Count == 0 && playingNow.Text != ""))
                {
                    //adds to the playlist if playingnow has song playing
                    Playlist.Items.Add(Genrelist.SelectedItem.ToString());
                }
            }
            readFile(); //reads the media file
        }

        private void playTrack()
        {
            // select the track, play the track
            MediaPlayer.Ctlcontrols.stop();//stop track
            MediaPlayer.URL = filename(); //where the mediaplayer plays the songs from
            MediaPlayer.Ctlcontrols.play(); //play track
        }



        private string filename()
        {

            string filename = playingNow.Text; //adds the name to playingNow
            string path = Environment.CurrentDirectory; //Gets the current directory
            string newPath = Path.GetFullPath(Path.Combine(path, @"..\..\..\"));
            string finalPath = newPath + "Tracks\\" + filename; //the path to get the tracks
            return finalPath;
        }

        private void MediaPlayer_PlayStateChange(object sender, AxWMPLib._WMPOCXEvents_PlayStateChangeEvent e)
        {
            //Timer is enabled  here
            if (e.newState == 8)
            {
                timer1.Enabled = true;
            }

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //removes played song and moves to next song in the list
            if (Playlist.Items.Count != 0)
            {
                playingNow.Text = Playlist.Items[0].ToString();
                Playlist.Items.RemoveAt(0);
                playTrack(); //play track
                timer1.Enabled = false; //
            }
        }

        private void ChooseGenre_Scroll(object sender, ScrollEventArgs e)
        {
            if (ChooseGenre.Value == 0)
            {
                Genrelist.Items.Clear();
                GenreName.Text = "OST"; 
                Genrelist.Items.Add("Fullmetal Alchemist Brotherhood Opening 1-Again creditless.mp3");
            }
            else if (ChooseGenre.Value == 10) //The Value = scroll bar pressed twice to show next set off genre and tracks
            {
                Genrelist.Items.Clear(); //Clears previous items so new other one can appear
                GenreName.Text = "SCORPION"; // The genre title
                Genrelist.Items.Add("Drake - Gods Plan (Official Audio).mp3"); //adds track to genrelist
                Genrelist.Items.Add("Drake - In My Feelings (Official Audio) (Scorpion Album).mp3"); //Adds track to the genrelist
            }
            else if (ChooseGenre.Value == 20)
            {
                Genrelist.Items.Clear();
                GenreName.Text = "EXO"; // The genre title
                Genrelist.Items.Add("EXO Kokobop.mp3"); // adds track to genrelist
                Genrelist.Items.Add("EXO Mama.mp3");   // adds track to the genrelist
            
            }
        }
        

      
       

        private void MediaPlayer_Enter(object sender, EventArgs e)
        {

        }

        private void Jukebox_Load(object sender, EventArgs e)
        {

        }
    }
}

// Sometimes the application requires resizing when starting it, so everything will appear :), I think it was an issue with my laptop too.

                                //Assignment by Shakir Shabbir b7021334




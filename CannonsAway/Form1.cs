using System;
using System.Diagnostics;
using System.Windows.Forms;
using System.Media;

namespace CannonsAway
{
    public partial class frmCanon : Form
    {
        FireClass myFire = new FireClass();
        Scoring myScore = new Scoring();


        public frmCanon()
        {
            InitializeComponent();
        }
        //Idea of game is based on russion roulette. Player gets a spin of the chamber - in this game spins up random number between 0 & 7.
        //When Player clicks on Play the following happens; images reset and random number selected. Counter resets.
        
        private void btnPlay_Click(object sender, EventArgs e)
            {
            pxCanon.Visible = true;
            pxBall1.Visible = true;
            pxBall2.Visible = true;
            pxBall3.Visible = true;
            pxBall4.Visible = true;
            pxBall5.Visible = true;
            pxBall6.Visible = true;
            pxCastleGood.Visible = true;
            pxYouWin.Visible = false;

            //method being run to create a random number for player
            myFire.rnd = myFire.Canon();
            //this sets the counter to 6 to start play.
            myFire.counter = 6;
            //this sets the shootaway chances to 2 at start of play.
            myScore.Shootaway = 2;

            //this puts the display up into the top line for players to see.
            debug();

        }





        //Debug shows the Random Number, Counter and Shootaways
        public void debug()
        {
            this.Text = " Rnd = " + myFire.rnd + " Counter = " + myFire.counter + " Shootaway = " + myScore.Shootaway;

        }


        //Method for playing sound on clicking Canon. I could improve this coding by creating a class and putting the sound method over into it, but I haven't got there yet.
        public void pxCanon_Click(object sender, EventArgs e)
        {
            System.Media.SoundPlayer player = new SoundPlayer();
            player.SoundLocation = @"C:\Users\Owner\OneDrive\Projects\CannonsAway\CannonsAway\Resources\battle002.wav";
            player.Load();
            player.Play();

            myFire.counter--;
            debug();
            if (myFire.counter < 1)
                MessageBox.Show("You haven't hit - You Lose! Play Again or Exit.");

            if (myFire.rnd == 4 && myFire.counter == 4)
                MessageBox.Show("Congratulations! You are a star! You hit the castle in 2!");




        }
        //This was meant to give the player two shots to miss, but I couldn't get it to stop at 0.
        private void btnShootaway_Click(object sender, EventArgs e)
        {
            if (myScore != null)
                myScore.Shootaway--;
            MessageBox.Show("You are closer");
        }
        //exit game option for players
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //public int TxtTotal(object sender, EventArgs e)
        //{
        //    myScore.AddScore(0);
        //}
    }
            
        
    }

    //public class Scored
    //    {

    //    }

    //public class ScoredClass : Scored
    //{
    //    public ScoredClass()
    //    {
    //    }
    //}

    //public int btnScore_Click(object sender, EventArgs e)
    //{

    //}



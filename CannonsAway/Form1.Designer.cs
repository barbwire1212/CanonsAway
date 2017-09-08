namespace CannonsAway
{
    partial class frmCanon
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCanon));
            this.label1 = new System.Windows.Forms.Label();
            this.rbxWords = new System.Windows.Forms.RichTextBox();
            this.pxCastleGood = new System.Windows.Forms.PictureBox();
            this.btnPlay = new System.Windows.Forms.Button();
            this.pxCanon = new System.Windows.Forms.PictureBox();
            this.pxBall1 = new System.Windows.Forms.PictureBox();
            this.pxBall2 = new System.Windows.Forms.PictureBox();
            this.pxBall4 = new System.Windows.Forms.PictureBox();
            this.pxBall3 = new System.Windows.Forms.PictureBox();
            this.pxBall5 = new System.Windows.Forms.PictureBox();
            this.pxYouWin = new System.Windows.Forms.PictureBox();
            this.pxBall6 = new System.Windows.Forms.PictureBox();
            this.txtTotalWins = new System.Windows.Forms.TextBox();
            this.btnShootaway = new System.Windows.Forms.Button();
            this.btnScore = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pxCastleGood)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pxCanon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pxBall1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pxBall2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pxBall4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pxBall3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pxBall5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pxYouWin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pxBall6)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(41, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Canons Away";
            // 
            // rbxWords
            // 
            this.rbxWords.Location = new System.Drawing.Point(46, 61);
            this.rbxWords.Name = "rbxWords";
            this.rbxWords.Size = new System.Drawing.Size(452, 138);
            this.rbxWords.TabIndex = 1;
            this.rbxWords.Text = resources.GetString("rbxWords.Text");
            // 
            // pxCastleGood
            // 
            this.pxCastleGood.BackColor = System.Drawing.Color.Transparent;
            this.pxCastleGood.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pxCastleGood.Image = global::CannonsAway.Properties.Resources.cartoon_castle_clipart_1;
            this.pxCastleGood.Location = new System.Drawing.Point(664, 12);
            this.pxCastleGood.Name = "pxCastleGood";
            this.pxCastleGood.Size = new System.Drawing.Size(230, 284);
            this.pxCastleGood.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pxCastleGood.TabIndex = 2;
            this.pxCastleGood.TabStop = false;
            // 
            // btnPlay
            // 
            this.btnPlay.BackColor = System.Drawing.Color.Lime;
            this.btnPlay.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlay.Location = new System.Drawing.Point(46, 289);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(123, 45);
            this.btnPlay.TabIndex = 4;
            this.btnPlay.Text = "PLAY";
            this.btnPlay.UseVisualStyleBackColor = false;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // pxCanon
            // 
            this.pxCanon.BackColor = System.Drawing.Color.Transparent;
            this.pxCanon.Image = global::CannonsAway.Properties.Resources.cannon1a;
            this.pxCanon.Location = new System.Drawing.Point(52, 432);
            this.pxCanon.Name = "pxCanon";
            this.pxCanon.Size = new System.Drawing.Size(269, 134);
            this.pxCanon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pxCanon.TabIndex = 5;
            this.pxCanon.TabStop = false;
            this.pxCanon.Visible = false;
            this.pxCanon.Click += new System.EventHandler(this.pxCanon_Click);
            // 
            // pxBall1
            // 
            this.pxBall1.Image = global::CannonsAway.Properties.Resources.Cannonball;
            this.pxBall1.Location = new System.Drawing.Point(93, 572);
            this.pxBall1.Name = "pxBall1";
            this.pxBall1.Size = new System.Drawing.Size(43, 40);
            this.pxBall1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pxBall1.TabIndex = 6;
            this.pxBall1.TabStop = false;
            this.pxBall1.Visible = false;
            // 
            // pxBall2
            // 
            this.pxBall2.BackColor = System.Drawing.Color.Transparent;
            this.pxBall2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pxBall2.Image = global::CannonsAway.Properties.Resources.Cannonball;
            this.pxBall2.Location = new System.Drawing.Point(142, 572);
            this.pxBall2.Name = "pxBall2";
            this.pxBall2.Size = new System.Drawing.Size(35, 38);
            this.pxBall2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pxBall2.TabIndex = 6;
            this.pxBall2.TabStop = false;
            this.pxBall2.Visible = false;
            // 
            // pxBall4
            // 
            this.pxBall4.BackColor = System.Drawing.Color.Transparent;
            this.pxBall4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pxBall4.Image = global::CannonsAway.Properties.Resources.Cannonball;
            this.pxBall4.Location = new System.Drawing.Point(224, 572);
            this.pxBall4.Name = "pxBall4";
            this.pxBall4.Size = new System.Drawing.Size(35, 38);
            this.pxBall4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pxBall4.TabIndex = 6;
            this.pxBall4.TabStop = false;
            this.pxBall4.Visible = false;
            // 
            // pxBall3
            // 
            this.pxBall3.BackColor = System.Drawing.Color.Transparent;
            this.pxBall3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pxBall3.Image = global::CannonsAway.Properties.Resources.Cannonball;
            this.pxBall3.Location = new System.Drawing.Point(183, 572);
            this.pxBall3.Name = "pxBall3";
            this.pxBall3.Size = new System.Drawing.Size(35, 38);
            this.pxBall3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pxBall3.TabIndex = 6;
            this.pxBall3.TabStop = false;
            this.pxBall3.Visible = false;
            // 
            // pxBall5
            // 
            this.pxBall5.BackColor = System.Drawing.Color.Transparent;
            this.pxBall5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pxBall5.Image = global::CannonsAway.Properties.Resources.Cannonball;
            this.pxBall5.Location = new System.Drawing.Point(265, 572);
            this.pxBall5.Name = "pxBall5";
            this.pxBall5.Size = new System.Drawing.Size(35, 38);
            this.pxBall5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pxBall5.TabIndex = 6;
            this.pxBall5.TabStop = false;
            this.pxBall5.Visible = false;
            // 
            // pxYouWin
            // 
            this.pxYouWin.BackColor = System.Drawing.Color.Transparent;
            this.pxYouWin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pxYouWin.Image = global::CannonsAway.Properties.Resources.CastleYouWin;
            this.pxYouWin.Location = new System.Drawing.Point(664, 12);
            this.pxYouWin.Name = "pxYouWin";
            this.pxYouWin.Size = new System.Drawing.Size(235, 284);
            this.pxYouWin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pxYouWin.TabIndex = 8;
            this.pxYouWin.TabStop = false;
            this.pxYouWin.Visible = false;
            // 
            // pxBall6
            // 
            this.pxBall6.BackColor = System.Drawing.Color.Transparent;
            this.pxBall6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pxBall6.Image = global::CannonsAway.Properties.Resources.Cannonball;
            this.pxBall6.Location = new System.Drawing.Point(305, 572);
            this.pxBall6.Name = "pxBall6";
            this.pxBall6.Size = new System.Drawing.Size(35, 38);
            this.pxBall6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pxBall6.TabIndex = 6;
            this.pxBall6.TabStop = false;
            this.pxBall6.Visible = false;
            // 
            // txtTotalWins
            // 
            this.txtTotalWins.BackColor = System.Drawing.Color.White;
            this.txtTotalWins.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalWins.Location = new System.Drawing.Point(794, 517);
            this.txtTotalWins.Name = "txtTotalWins";
            this.txtTotalWins.Size = new System.Drawing.Size(100, 29);
            this.txtTotalWins.TabIndex = 11;
            //this.txtTotalWins.TextChanged += new System.EventHandler(this.txtTotalWins_TextChanged);
            // 
            // btnShootaway
            // 
            this.btnShootaway.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnShootaway.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShootaway.Location = new System.Drawing.Point(216, 292);
            this.btnShootaway.Name = "btnShootaway";
            this.btnShootaway.Size = new System.Drawing.Size(158, 41);
            this.btnShootaway.TabIndex = 13;
            this.btnShootaway.Text = "Shoot Away!";
            this.btnShootaway.UseVisualStyleBackColor = false;
            this.btnShootaway.Click += new System.EventHandler(this.btnShootaway_Click);
            // 
            // btnScore
            // 
            this.btnScore.Location = new System.Drawing.Point(664, 517);
            this.btnScore.Name = "btnScore";
            this.btnScore.Size = new System.Drawing.Size(108, 29);
            this.btnScore.TabIndex = 14;
            this.btnScore.Text = "Your Score";
            this.btnScore.UseVisualStyleBackColor = true;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(735, 572);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(95, 26);
            this.btnExit.TabIndex = 15;
            this.btnExit.Text = "Exit Game";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // frmCanon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CannonsAway.Properties.Resources.cartoon_castle_illustration_shows_old_lock_landscape_summer_background_meadows_road_illustration_done_style_31743298;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(923, 652);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnScore);
            this.Controls.Add(this.btnShootaway);
            this.Controls.Add(this.txtTotalWins);
            this.Controls.Add(this.pxBall6);
            this.Controls.Add(this.pxBall5);
            this.Controls.Add(this.pxBall3);
            this.Controls.Add(this.pxBall4);
            this.Controls.Add(this.pxBall2);
            this.Controls.Add(this.pxBall1);
            this.Controls.Add(this.btnPlay);
            this.Controls.Add(this.rbxWords);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pxCanon);
            this.Controls.Add(this.pxCastleGood);
            this.Controls.Add(this.pxYouWin);
            this.DoubleBuffered = true;
            this.Name = "frmCanon";
            this.Text = "Canon Practice";
            ((System.ComponentModel.ISupportInitialize)(this.pxCastleGood)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pxCanon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pxBall1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pxBall2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pxBall4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pxBall3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pxBall5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pxYouWin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pxBall6)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox rbxWords;
        private System.Windows.Forms.PictureBox pxCastleGood;
        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.PictureBox pxCanon;
        private System.Windows.Forms.PictureBox pxBall1;
        private System.Windows.Forms.PictureBox pxBall2;
        private System.Windows.Forms.PictureBox pxBall4;
        private System.Windows.Forms.PictureBox pxBall3;
        private System.Windows.Forms.PictureBox pxBall5;
        private System.Windows.Forms.PictureBox pxYouWin;
        private System.Windows.Forms.PictureBox pxBall6;
        private System.Windows.Forms.TextBox txtTotalWins;
        private System.Windows.Forms.Button btnShootaway;
        private System.Windows.Forms.Button btnScore;
        private System.Windows.Forms.Button btnExit;
    }
}


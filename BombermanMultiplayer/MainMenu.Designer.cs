namespace BombermanMultiplayer
{
    partial class MainMenu
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
            this.btnLocalGame = new System.Windows.Forms.Button();
            this.btnLanMode = new System.Windows.Forms.Button();
            this.lbTitle = new System.Windows.Forms.Label();
            this.button_mp4 = new System.Windows.Forms.Button();
            this.button_wav = new System.Windows.Forms.Button();
            this.button_mp3 = new System.Windows.Forms.Button();
            this.BombPictureBox = new System.Windows.Forms.PictureBox();
            this.BombermanPictureBox = new System.Windows.Forms.PictureBox();
            this.ExplosionPictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.BombPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BombermanPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ExplosionPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // btnLocalGame
            // 
            this.btnLocalGame.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnLocalGame.AutoSize = true;
            this.btnLocalGame.Location = new System.Drawing.Point(105, 110);
            this.btnLocalGame.Margin = new System.Windows.Forms.Padding(2);
            this.btnLocalGame.Name = "btnLocalGame";
            this.btnLocalGame.Size = new System.Drawing.Size(192, 39);
            this.btnLocalGame.TabIndex = 0;
            this.btnLocalGame.Text = "Local Mode";
            this.btnLocalGame.UseVisualStyleBackColor = true;
            this.btnLocalGame.Click += new System.EventHandler(this.btnLocalGame_Click);
            // 
            // btnLanMode
            // 
            this.btnLanMode.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnLanMode.AutoSize = true;
            this.btnLanMode.Location = new System.Drawing.Point(105, 150);
            this.btnLanMode.Margin = new System.Windows.Forms.Padding(2);
            this.btnLanMode.Name = "btnLanMode";
            this.btnLanMode.Size = new System.Drawing.Size(192, 39);
            this.btnLanMode.TabIndex = 1;
            this.btnLanMode.Text = "LAN Mode";
            this.btnLanMode.UseVisualStyleBackColor = true;
            this.btnLanMode.Click += new System.EventHandler(this.btnLanMode_Click);
            // 
            // lbTitle
            // 
            this.lbTitle.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbTitle.AutoSize = true;
            this.lbTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitle.Location = new System.Drawing.Point(105, 72);
            this.lbTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(211, 39);
            this.lbTitle.TabIndex = 2;
            this.lbTitle.Text = "Bomberman";
            this.lbTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button_mp4
            // 
            this.button_mp4.Location = new System.Drawing.Point(12, 226);
            this.button_mp4.Name = "button_mp4";
            this.button_mp4.Size = new System.Drawing.Size(72, 22);
            this.button_mp4.TabIndex = 3;
            this.button_mp4.Text = "Play mp4";
            this.button_mp4.UseVisualStyleBackColor = true;
            this.button_mp4.Click += new System.EventHandler(this.button_mp4_Click);
            // 
            // button_wav
            // 
            this.button_wav.Location = new System.Drawing.Point(90, 226);
            this.button_wav.Name = "button_wav";
            this.button_wav.Size = new System.Drawing.Size(62, 22);
            this.button_wav.TabIndex = 4;
            this.button_wav.Text = "Play wav";
            this.button_wav.UseVisualStyleBackColor = true;
            this.button_wav.Click += new System.EventHandler(this.button_wav_Click);
            // 
            // button_mp3
            // 
            this.button_mp3.Location = new System.Drawing.Point(158, 226);
            this.button_mp3.Name = "button_mp3";
            this.button_mp3.Size = new System.Drawing.Size(75, 23);
            this.button_mp3.TabIndex = 5;
            this.button_mp3.Text = "Play mp3";
            this.button_mp3.UseVisualStyleBackColor = true;
            this.button_mp3.Click += new System.EventHandler(this.button_mp3_Click);
            // 
            // BombPictureBox
            // 
            this.BombPictureBox.BackColor = System.Drawing.SystemColors.Control;
            this.BombPictureBox.InitialImage = null;
            this.BombPictureBox.Location = new System.Drawing.Point(159, 12);
            this.BombPictureBox.Name = "BombPictureBox";
            this.BombPictureBox.Size = new System.Drawing.Size(61, 50);
            this.BombPictureBox.TabIndex = 6;
            this.BombPictureBox.TabStop = false;
            this.BombPictureBox.Visible = false;
            // 
            // BombermanPictureBox
            // 
            this.BombermanPictureBox.Location = new System.Drawing.Point(127, 12);
            this.BombermanPictureBox.Name = "BombermanPictureBox";
            this.BombermanPictureBox.Size = new System.Drawing.Size(32, 50);
            this.BombermanPictureBox.TabIndex = 7;
            this.BombermanPictureBox.TabStop = false;
            this.BombermanPictureBox.Visible = false;
            // 
            // ExplosionPictureBox
            // 
            this.ExplosionPictureBox.Location = new System.Drawing.Point(220, 12);
            this.ExplosionPictureBox.Name = "ExplosionPictureBox";
            this.ExplosionPictureBox.Size = new System.Drawing.Size(53, 50);
            this.ExplosionPictureBox.TabIndex = 8;
            this.ExplosionPictureBox.TabStop = false;
            this.ExplosionPictureBox.Visible = false;
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(402, 260);
            this.Controls.Add(this.ExplosionPictureBox);
            this.Controls.Add(this.BombermanPictureBox);
            this.Controls.Add(this.BombPictureBox);
            this.Controls.Add(this.button_mp3);
            this.Controls.Add(this.button_wav);
            this.Controls.Add(this.button_mp4);
            this.Controls.Add(this.lbTitle);
            this.Controls.Add(this.btnLanMode);
            this.Controls.Add(this.btnLocalGame);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MainMenu";
            this.Text = "MainMenu";
            ((System.ComponentModel.ISupportInitialize)(this.BombPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BombermanPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ExplosionPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLocalGame;
        private System.Windows.Forms.Button btnLanMode;
        private System.Windows.Forms.Label lbTitle;
        private System.Windows.Forms.Button button_mp4;
        private System.Windows.Forms.Button button_wav;
        private System.Windows.Forms.Button button_mp3;
        private System.Windows.Forms.PictureBox BombPictureBox;
        private System.Windows.Forms.PictureBox BombermanPictureBox;
        private System.Windows.Forms.PictureBox ExplosionPictureBox;
    }
}
namespace BoardGames {
    partial class Two_Up {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose ( bool disposing ) {
            if (disposing && ( components != null )) {
                components.Dispose();
            }
            base.Dispose( disposing );
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent () {
            this.components = new System.ComponentModel.Container();
            this.coin1PictureBox = new System.Windows.Forms.PictureBox();
            this.coin2PictureBox = new System.Windows.Forms.PictureBox();
            this.throwCoinButton = new System.Windows.Forms.Button();
            this.playAgainButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.playerScoreLabel = new System.Windows.Forms.Label();
            this.computerScoreLabel = new System.Windows.Forms.Label();
            this.outcomeLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.twoUpTimer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.coin1PictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.coin2PictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // coin1PictureBox
            // 
            this.coin1PictureBox.Location = new System.Drawing.Point(47, 101);
            this.coin1PictureBox.Name = "coin1PictureBox";
            this.coin1PictureBox.Size = new System.Drawing.Size(150, 150);
            this.coin1PictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.coin1PictureBox.TabIndex = 0;
            this.coin1PictureBox.TabStop = false;
            // 
            // coin2PictureBox
            // 
            this.coin2PictureBox.Location = new System.Drawing.Point(341, 101);
            this.coin2PictureBox.Name = "coin2PictureBox";
            this.coin2PictureBox.Size = new System.Drawing.Size(150, 150);
            this.coin2PictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.coin2PictureBox.TabIndex = 1;
            this.coin2PictureBox.TabStop = false;
            // 
            // throwCoinButton
            // 
            this.throwCoinButton.BackColor = System.Drawing.Color.Tomato;
            this.throwCoinButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.throwCoinButton.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.throwCoinButton.Location = new System.Drawing.Point(11, 303);
            this.throwCoinButton.Name = "throwCoinButton";
            this.throwCoinButton.Size = new System.Drawing.Size(152, 51);
            this.throwCoinButton.TabIndex = 2;
            this.throwCoinButton.Text = "Throw Coins";
            this.throwCoinButton.UseVisualStyleBackColor = false;
            this.throwCoinButton.Click += new System.EventHandler(this.throwCoinButton_Click);
            // 
            // playAgainButton
            // 
            this.playAgainButton.BackColor = System.Drawing.Color.Tomato;
            this.playAgainButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.playAgainButton.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playAgainButton.Location = new System.Drawing.Point(190, 303);
            this.playAgainButton.Name = "playAgainButton";
            this.playAgainButton.Size = new System.Drawing.Size(152, 51);
            this.playAgainButton.TabIndex = 3;
            this.playAgainButton.Text = "Play Again";
            this.playAgainButton.UseVisualStyleBackColor = false;
            this.playAgainButton.Visible = false;
            this.playAgainButton.Click += new System.EventHandler(this.playAgainButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.BackColor = System.Drawing.Color.Tomato;
            this.cancelButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cancelButton.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelButton.Location = new System.Drawing.Point(364, 303);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(160, 51);
            this.cancelButton.TabIndex = 4;
            this.cancelButton.Text = "Cancel Game";
            this.cancelButton.UseVisualStyleBackColor = false;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(30, 265);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 24);
            this.label1.TabIndex = 5;
            this.label1.Text = "Player\'s score:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(319, 265);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(162, 24);
            this.label2.TabIndex = 6;
            this.label2.Text = "Computer\'s score:";
            // 
            // playerScoreLabel
            // 
            this.playerScoreLabel.AutoSize = true;
            this.playerScoreLabel.BackColor = System.Drawing.Color.White;
            this.playerScoreLabel.Font = new System.Drawing.Font("Comic Sans MS", 8F);
            this.playerScoreLabel.Location = new System.Drawing.Point(169, 269);
            this.playerScoreLabel.Name = "playerScoreLabel";
            this.playerScoreLabel.Size = new System.Drawing.Size(20, 23);
            this.playerScoreLabel.TabIndex = 7;
            this.playerScoreLabel.Text = "0";
            // 
            // computerScoreLabel
            // 
            this.computerScoreLabel.AutoSize = true;
            this.computerScoreLabel.BackColor = System.Drawing.Color.White;
            this.computerScoreLabel.Font = new System.Drawing.Font("Comic Sans MS", 8F);
            this.computerScoreLabel.Location = new System.Drawing.Point(487, 268);
            this.computerScoreLabel.Name = "computerScoreLabel";
            this.computerScoreLabel.Size = new System.Drawing.Size(20, 23);
            this.computerScoreLabel.TabIndex = 8;
            this.computerScoreLabel.Text = "0";
            // 
            // outcomeLabel
            // 
            this.outcomeLabel.AutoSize = true;
            this.outcomeLabel.Font = new System.Drawing.Font("Comic Sans MS", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outcomeLabel.ForeColor = System.Drawing.Color.Chocolate;
            this.outcomeLabel.Location = new System.Drawing.Point(230, 162);
            this.outcomeLabel.Name = "outcomeLabel";
            this.outcomeLabel.Size = new System.Drawing.Size(96, 29);
            this.outcomeLabel.TabIndex = 9;
            this.outcomeLabel.Text = "Outcome";
            this.outcomeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.outcomeLabel.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Snap ITC", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label3.Location = new System.Drawing.Point(266, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(182, 46);
            this.label3.TabIndex = 11;
            this.label3.Text = "GAMES";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Snap ITC", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(106, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(167, 46);
            this.label4.TabIndex = 10;
            this.label4.Text = "BOARD";
            // 
            // twoUpTimer
            // 
            this.twoUpTimer.Tick += new System.EventHandler(this.twoUpTimer_Tick);
            // 
            // Two_Up
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(540, 371);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.outcomeLabel);
            this.Controls.Add(this.computerScoreLabel);
            this.Controls.Add(this.playerScoreLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.playAgainButton);
            this.Controls.Add(this.throwCoinButton);
            this.Controls.Add(this.coin2PictureBox);
            this.Controls.Add(this.coin1PictureBox);
            this.Name = "Two_Up";
            this.Text = "Two_Ups";
            ((System.ComponentModel.ISupportInitialize)(this.coin1PictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.coin2PictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox coin1PictureBox;
        private System.Windows.Forms.PictureBox coin2PictureBox;
        private System.Windows.Forms.Button throwCoinButton;
        private System.Windows.Forms.Button playAgainButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label playerScoreLabel;
        private System.Windows.Forms.Label computerScoreLabel;
        private System.Windows.Forms.Label outcomeLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Timer twoUpTimer;
    }
}
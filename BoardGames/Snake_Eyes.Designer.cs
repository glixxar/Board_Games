namespace BoardGames {
    partial class Snake_Eyes {
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
            this.dice1PictureBox = new System.Windows.Forms.PictureBox();
            this.dice2PictureBox = new System.Windows.Forms.PictureBox();
            this.continueButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.rollButton = new System.Windows.Forms.Button();
            this.playerLabel = new System.Windows.Forms.Label();
            this.playerScoreLabel = new System.Windows.Forms.Label();
            this.houseLabel = new System.Windows.Forms.Label();
            this.houseScoreLabel = new System.Windows.Forms.Label();
            this.dummyLabel = new System.Windows.Forms.Label();
            this.rollLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.snakeEyesTimer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dice1PictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dice2PictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // dice1PictureBox
            // 
            this.dice1PictureBox.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dice1PictureBox.Location = new System.Drawing.Point(101, 119);
            this.dice1PictureBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dice1PictureBox.Name = "dice1PictureBox";
            this.dice1PictureBox.Size = new System.Drawing.Size(53, 48);
            this.dice1PictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.dice1PictureBox.TabIndex = 0;
            this.dice1PictureBox.TabStop = false;
            // 
            // dice2PictureBox
            // 
            this.dice2PictureBox.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dice2PictureBox.Location = new System.Drawing.Point(331, 119);
            this.dice2PictureBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dice2PictureBox.Name = "dice2PictureBox";
            this.dice2PictureBox.Size = new System.Drawing.Size(53, 48);
            this.dice2PictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.dice2PictureBox.TabIndex = 1;
            this.dice2PictureBox.TabStop = false;
            // 
            // continueButton
            // 
            this.continueButton.BackColor = System.Drawing.Color.Tomato;
            this.continueButton.Enabled = false;
            this.continueButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.continueButton.Font = new System.Drawing.Font("Comic Sans MS", 10F);
            this.continueButton.Location = new System.Drawing.Point(30, 258);
            this.continueButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.continueButton.Name = "continueButton";
            this.continueButton.Size = new System.Drawing.Size(175, 45);
            this.continueButton.TabIndex = 2;
            this.continueButton.Text = "Continue Playing";
            this.continueButton.UseVisualStyleBackColor = false;
            this.continueButton.Click += new System.EventHandler(this.continueButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.BackColor = System.Drawing.Color.Tomato;
            this.cancelButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cancelButton.Font = new System.Drawing.Font("Comic Sans MS", 10F);
            this.cancelButton.Location = new System.Drawing.Point(274, 258);
            this.cancelButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(175, 45);
            this.cancelButton.TabIndex = 3;
            this.cancelButton.Text = "Cancel Game";
            this.cancelButton.UseVisualStyleBackColor = false;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // rollButton
            // 
            this.rollButton.BackColor = System.Drawing.Color.Tomato;
            this.rollButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.rollButton.Font = new System.Drawing.Font("Comic Sans MS", 10F);
            this.rollButton.Location = new System.Drawing.Point(186, 119);
            this.rollButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rollButton.Name = "rollButton";
            this.rollButton.Size = new System.Drawing.Size(116, 48);
            this.rollButton.TabIndex = 4;
            this.rollButton.Text = "Roll Dice";
            this.rollButton.UseVisualStyleBackColor = false;
            this.rollButton.Click += new System.EventHandler(this.rollButton_Click);
            // 
            // playerLabel
            // 
            this.playerLabel.AutoSize = true;
            this.playerLabel.Font = new System.Drawing.Font("Comic Sans MS", 9F);
            this.playerLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.playerLabel.Location = new System.Drawing.Point(61, 221);
            this.playerLabel.Name = "playerLabel";
            this.playerLabel.Size = new System.Drawing.Size(114, 20);
            this.playerLabel.TabIndex = 5;
            this.playerLabel.Text = "Player\'s Score:";
            // 
            // playerScoreLabel
            // 
            this.playerScoreLabel.AutoSize = true;
            this.playerScoreLabel.BackColor = System.Drawing.Color.White;
            this.playerScoreLabel.Font = new System.Drawing.Font("Comic Sans MS", 8F);
            this.playerScoreLabel.Location = new System.Drawing.Point(188, 221);
            this.playerScoreLabel.Name = "playerScoreLabel";
            this.playerScoreLabel.Size = new System.Drawing.Size(18, 19);
            this.playerScoreLabel.TabIndex = 6;
            this.playerScoreLabel.Text = "0";
            // 
            // houseLabel
            // 
            this.houseLabel.AutoSize = true;
            this.houseLabel.Font = new System.Drawing.Font("Comic Sans MS", 9F);
            this.houseLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.houseLabel.Location = new System.Drawing.Point(300, 220);
            this.houseLabel.Name = "houseLabel";
            this.houseLabel.Size = new System.Drawing.Size(101, 20);
            this.houseLabel.TabIndex = 7;
            this.houseLabel.Text = "House Score:";
            // 
            // houseScoreLabel
            // 
            this.houseScoreLabel.AutoSize = true;
            this.houseScoreLabel.BackColor = System.Drawing.Color.White;
            this.houseScoreLabel.Font = new System.Drawing.Font("Comic Sans MS", 8F);
            this.houseScoreLabel.Location = new System.Drawing.Point(411, 222);
            this.houseScoreLabel.Name = "houseScoreLabel";
            this.houseScoreLabel.Size = new System.Drawing.Size(18, 19);
            this.houseScoreLabel.TabIndex = 8;
            this.houseScoreLabel.Text = "0";
            // 
            // dummyLabel
            // 
            this.dummyLabel.Font = new System.Drawing.Font("Comic Sans MS", 11F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.dummyLabel.ForeColor = System.Drawing.Color.Chocolate;
            this.dummyLabel.Location = new System.Drawing.Point(65, 182);
            this.dummyLabel.Name = "dummyLabel";
            this.dummyLabel.Size = new System.Drawing.Size(364, 26);
            this.dummyLabel.TabIndex = 9;
            this.dummyLabel.Text = "Dummy Text";
            this.dummyLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.dummyLabel.Visible = false;
            // 
            // rollLabel
            // 
            this.rollLabel.Font = new System.Drawing.Font("Comic Sans MS", 11F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.rollLabel.ForeColor = System.Drawing.Color.Chocolate;
            this.rollLabel.Location = new System.Drawing.Point(101, 76);
            this.rollLabel.Name = "rollLabel";
            this.rollLabel.Size = new System.Drawing.Size(283, 26);
            this.rollLabel.TabIndex = 10;
            this.rollLabel.Text = "First Roll";
            this.rollLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Snap ITC", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label3.Location = new System.Drawing.Point(236, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(151, 39);
            this.label3.TabIndex = 13;
            this.label3.Text = "GAMES";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Snap ITC", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(94, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(139, 39);
            this.label4.TabIndex = 12;
            this.label4.Text = "BOARD";
            // 
            // snakeEyesTimer
            // 
            this.snakeEyesTimer.Tick += new System.EventHandler(this.snakeEyesTimer_Tick);
            // 
            // Snake_Eyes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(480, 321);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.rollLabel);
            this.Controls.Add(this.dummyLabel);
            this.Controls.Add(this.houseScoreLabel);
            this.Controls.Add(this.houseLabel);
            this.Controls.Add(this.playerScoreLabel);
            this.Controls.Add(this.playerLabel);
            this.Controls.Add(this.rollButton);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.continueButton);
            this.Controls.Add(this.dice2PictureBox);
            this.Controls.Add(this.dice1PictureBox);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Snake_Eyes";
            this.Text = "Snake_Eyes";
            ((System.ComponentModel.ISupportInitialize)(this.dice1PictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dice2PictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox dice1PictureBox;
        private System.Windows.Forms.PictureBox dice2PictureBox;
        private System.Windows.Forms.Button continueButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button rollButton;
        private System.Windows.Forms.Label playerLabel;
        private System.Windows.Forms.Label playerScoreLabel;
        private System.Windows.Forms.Label houseLabel;
        private System.Windows.Forms.Label houseScoreLabel;
        private System.Windows.Forms.Label dummyLabel;
        private System.Windows.Forms.Label rollLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Timer snakeEyesTimer;
    }
}
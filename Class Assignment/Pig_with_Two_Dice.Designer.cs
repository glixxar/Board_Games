namespace Class_Assignment {
    partial class Pig_with_Two_Dice {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            this.whoseTurn = new System.Windows.Forms.Label();
            this.rollOrHold = new System.Windows.Forms.Label();
            this.OnePigPictureBox1 = new System.Windows.Forms.PictureBox();
            this.OnePigPictureBox2 = new System.Windows.Forms.PictureBox();
            this.Dice1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.Player1Score = new System.Windows.Forms.TextBox();
            this.Player2Score = new System.Windows.Forms.TextBox();
            this.RestartGroup = new System.Windows.Forms.GroupBox();
            this.YesRadio = new System.Windows.Forms.RadioButton();
            this.NoRadio = new System.Windows.Forms.RadioButton();
            this.RollButton = new System.Windows.Forms.Button();
            this.HoldButton = new System.Windows.Forms.Button();
            this.rollTimer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.OnePigPictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.OnePigPictureBox2)).BeginInit();
            this.RestartGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // whoseTurn
            // 
            this.whoseTurn.AutoSize = true;
            this.whoseTurn.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.whoseTurn.Location = new System.Drawing.Point(32, 57);
            this.whoseTurn.Name = "whoseTurn";
            this.whoseTurn.Size = new System.Drawing.Size(115, 17);
            this.whoseTurn.TabIndex = 0;
            this.whoseTurn.Text = "Whose Turn to";
            // 
            // rollOrHold
            // 
            this.rollOrHold.AutoSize = true;
            this.rollOrHold.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rollOrHold.Location = new System.Drawing.Point(32, 74);
            this.rollOrHold.Name = "rollOrHold";
            this.rollOrHold.Size = new System.Drawing.Size(94, 17);
            this.rollOrHold.TabIndex = 1;
            this.rollOrHold.Text = "Roll or Hold";
            // 
            // OnePigPictureBox1
            // 
            this.OnePigPictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.OnePigPictureBox1.Location = new System.Drawing.Point(167, 57);
            this.OnePigPictureBox1.Name = "OnePigPictureBox1";
            this.OnePigPictureBox1.Size = new System.Drawing.Size(55, 55);
            this.OnePigPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.OnePigPictureBox1.TabIndex = 2;
            this.OnePigPictureBox1.TabStop = false;
            // 
            // OnePigPictureBox2
            // 
            this.OnePigPictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.OnePigPictureBox2.Location = new System.Drawing.Point(167, 152);
            this.OnePigPictureBox2.Name = "OnePigPictureBox2";
            this.OnePigPictureBox2.Size = new System.Drawing.Size(55, 55);
            this.OnePigPictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.OnePigPictureBox2.TabIndex = 3;
            this.OnePigPictureBox2.TabStop = false;
            // 
            // Dice1
            // 
            this.Dice1.AutoSize = true;
            this.Dice1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Dice1.Location = new System.Drawing.Point(164, 37);
            this.Dice1.Name = "Dice1";
            this.Dice1.Size = new System.Drawing.Size(54, 17);
            this.Dice1.TabIndex = 4;
            this.Dice1.Text = "Dice 1";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(164, 132);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 17);
            this.label4.TabIndex = 5;
            this.label4.Text = "Dice 2";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(272, 57);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(115, 17);
            this.label5.TabIndex = 6;
            this.label5.Text = "Player 1 Total:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(272, 123);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(115, 17);
            this.label6.TabIndex = 7;
            this.label6.Text = "Player 2 Total:";
            // 
            // Player1Score
            // 
            this.Player1Score.Location = new System.Drawing.Point(393, 57);
            this.Player1Score.Name = "Player1Score";
            this.Player1Score.ReadOnly = true;
            this.Player1Score.Size = new System.Drawing.Size(100, 22);
            this.Player1Score.TabIndex = 8;
            // 
            // Player2Score
            // 
            this.Player2Score.Location = new System.Drawing.Point(393, 123);
            this.Player2Score.Name = "Player2Score";
            this.Player2Score.ReadOnly = true;
            this.Player2Score.Size = new System.Drawing.Size(100, 22);
            this.Player2Score.TabIndex = 9;
            // 
            // RestartGroup
            // 
            this.RestartGroup.Controls.Add(this.NoRadio);
            this.RestartGroup.Controls.Add(this.YesRadio);
            this.RestartGroup.Enabled = false;
            this.RestartGroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RestartGroup.Location = new System.Drawing.Point(275, 209);
            this.RestartGroup.Name = "RestartGroup";
            this.RestartGroup.Size = new System.Drawing.Size(218, 100);
            this.RestartGroup.TabIndex = 10;
            this.RestartGroup.TabStop = false;
            this.RestartGroup.Text = "Another Game?";
            // 
            // YesRadio
            // 
            this.YesRadio.AutoSize = true;
            this.YesRadio.Location = new System.Drawing.Point(41, 35);
            this.YesRadio.Name = "YesRadio";
            this.YesRadio.Size = new System.Drawing.Size(56, 21);
            this.YesRadio.TabIndex = 0;
            this.YesRadio.TabStop = true;
            this.YesRadio.Text = "Yes";
            this.YesRadio.UseVisualStyleBackColor = true;
            this.YesRadio.CheckedChanged += new System.EventHandler(this.YesRadio_CheckedChanged);
            // 
            // NoRadio
            // 
            this.NoRadio.AutoSize = true;
            this.NoRadio.Location = new System.Drawing.Point(41, 62);
            this.NoRadio.Name = "NoRadio";
            this.NoRadio.Size = new System.Drawing.Size(49, 21);
            this.NoRadio.TabIndex = 1;
            this.NoRadio.TabStop = true;
            this.NoRadio.Text = "No";
            this.NoRadio.UseVisualStyleBackColor = true;
            this.NoRadio.CheckedChanged += new System.EventHandler(this.NoRadio_CheckedChanged);
            // 
            // RollButton
            // 
            this.RollButton.BackColor = System.Drawing.Color.LimeGreen;
            this.RollButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RollButton.Location = new System.Drawing.Point(27, 263);
            this.RollButton.Name = "RollButton";
            this.RollButton.Size = new System.Drawing.Size(107, 46);
            this.RollButton.TabIndex = 11;
            this.RollButton.Text = "Roll";
            this.RollButton.UseVisualStyleBackColor = false;
            this.RollButton.Click += new System.EventHandler(this.RollButton_Click);
            // 
            // HoldButton
            // 
            this.HoldButton.BackColor = System.Drawing.Color.Red;
            this.HoldButton.Enabled = false;
            this.HoldButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HoldButton.Location = new System.Drawing.Point(140, 263);
            this.HoldButton.Name = "HoldButton";
            this.HoldButton.Size = new System.Drawing.Size(107, 46);
            this.HoldButton.TabIndex = 12;
            this.HoldButton.Text = "Hold";
            this.HoldButton.UseVisualStyleBackColor = false;
            this.HoldButton.Click += new System.EventHandler(this.HoldButton_Click);
            // 
            // rollTimer
            // 
            this.rollTimer.Tick += new System.EventHandler(this.rollTimer_Tick);
            // 
            // Pig_with_Two_Dice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(540, 373);
            this.Controls.Add(this.HoldButton);
            this.Controls.Add(this.RollButton);
            this.Controls.Add(this.RestartGroup);
            this.Controls.Add(this.Player2Score);
            this.Controls.Add(this.Player1Score);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Dice1);
            this.Controls.Add(this.OnePigPictureBox2);
            this.Controls.Add(this.OnePigPictureBox1);
            this.Controls.Add(this.rollOrHold);
            this.Controls.Add(this.whoseTurn);
            this.Name = "Pig_with_Two_Dice";
            this.Text = "Pig_with_Two_Dice";
            ((System.ComponentModel.ISupportInitialize)(this.OnePigPictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.OnePigPictureBox2)).EndInit();
            this.RestartGroup.ResumeLayout(false);
            this.RestartGroup.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label whoseTurn;
        private System.Windows.Forms.Label rollOrHold;
        private System.Windows.Forms.PictureBox OnePigPictureBox1;
        private System.Windows.Forms.PictureBox OnePigPictureBox2;
        private System.Windows.Forms.Label Dice1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox Player1Score;
        private System.Windows.Forms.TextBox Player2Score;
        private System.Windows.Forms.GroupBox RestartGroup;
        private System.Windows.Forms.RadioButton NoRadio;
        private System.Windows.Forms.RadioButton YesRadio;
        private System.Windows.Forms.Button RollButton;
        private System.Windows.Forms.Button HoldButton;
        private System.Windows.Forms.Timer rollTimer;
    }
}
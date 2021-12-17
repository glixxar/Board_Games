namespace Class_Assignment {
    partial class Pig_Game {
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
            this.whoseTurn = new System.Windows.Forms.Label();
            this.OnePigPictureBox = new System.Windows.Forms.PictureBox();
            this.Player1Label = new System.Windows.Forms.Label();
            this.Player2Label = new System.Windows.Forms.Label();
            this.Player1Score = new System.Windows.Forms.TextBox();
            this.Player2Score = new System.Windows.Forms.TextBox();
            this.RollButton = new System.Windows.Forms.Button();
            this.HoldButton = new System.Windows.Forms.Button();
            this.RestartGroup = new System.Windows.Forms.GroupBox();
            this.NoRadio = new System.Windows.Forms.RadioButton();
            this.YesRadio = new System.Windows.Forms.RadioButton();
            this.rollOrHold = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.OnePigPictureBox)).BeginInit();
            this.RestartGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // whoseTurn
            // 
            this.whoseTurn.AutoSize = true;
            this.whoseTurn.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.whoseTurn.Location = new System.Drawing.Point(12, 56);
            this.whoseTurn.Name = "whoseTurn";
            this.whoseTurn.Size = new System.Drawing.Size(110, 17);
            this.whoseTurn.TabIndex = 0;
            this.whoseTurn.Text = "Whose turn to";
            // 
            // OnePigPictureBox
            // 
            this.OnePigPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.OnePigPictureBox.Location = new System.Drawing.Point(128, 46);
            this.OnePigPictureBox.Name = "OnePigPictureBox";
            this.OnePigPictureBox.Size = new System.Drawing.Size(55, 55);
            this.OnePigPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.OnePigPictureBox.TabIndex = 1;
            this.OnePigPictureBox.TabStop = false;
            // 
            // Player1Label
            // 
            this.Player1Label.AutoSize = true;
            this.Player1Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Player1Label.Location = new System.Drawing.Point(233, 46);
            this.Player1Label.Name = "Player1Label";
            this.Player1Label.Size = new System.Drawing.Size(115, 17);
            this.Player1Label.TabIndex = 2;
            this.Player1Label.Text = "Player 1 Total:";
            // 
            // Player2Label
            // 
            this.Player2Label.AutoSize = true;
            this.Player2Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Player2Label.Location = new System.Drawing.Point(233, 84);
            this.Player2Label.Name = "Player2Label";
            this.Player2Label.Size = new System.Drawing.Size(115, 17);
            this.Player2Label.TabIndex = 3;
            this.Player2Label.Text = "Player 2 Total:";
            // 
            // Player1Score
            // 
            this.Player1Score.Location = new System.Drawing.Point(354, 46);
            this.Player1Score.Name = "Player1Score";
            this.Player1Score.ReadOnly = true;
            this.Player1Score.Size = new System.Drawing.Size(100, 22);
            this.Player1Score.TabIndex = 4;
            // 
            // Player2Score
            // 
            this.Player2Score.Location = new System.Drawing.Point(354, 84);
            this.Player2Score.Name = "Player2Score";
            this.Player2Score.ReadOnly = true;
            this.Player2Score.Size = new System.Drawing.Size(100, 22);
            this.Player2Score.TabIndex = 5;
            // 
            // RollButton
            // 
            this.RollButton.BackColor = System.Drawing.Color.LimeGreen;
            this.RollButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RollButton.Location = new System.Drawing.Point(15, 216);
            this.RollButton.Name = "RollButton";
            this.RollButton.Size = new System.Drawing.Size(107, 46);
            this.RollButton.TabIndex = 6;
            this.RollButton.Text = "Roll";
            this.RollButton.UseVisualStyleBackColor = false;
            this.RollButton.Click += new System.EventHandler(this.RollButton_Click);
            // 
            // HoldButton
            // 
            this.HoldButton.BackColor = System.Drawing.Color.Red;
            this.HoldButton.Enabled = false;
            this.HoldButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HoldButton.Location = new System.Drawing.Point(128, 216);
            this.HoldButton.Name = "HoldButton";
            this.HoldButton.Size = new System.Drawing.Size(107, 46);
            this.HoldButton.TabIndex = 7;
            this.HoldButton.Text = "Hold";
            this.HoldButton.UseVisualStyleBackColor = false;
            this.HoldButton.Click += new System.EventHandler(this.HoldButton_Click);
            // 
            // RestartGroup
            // 
            this.RestartGroup.Controls.Add(this.NoRadio);
            this.RestartGroup.Controls.Add(this.YesRadio);
            this.RestartGroup.Enabled = false;
            this.RestartGroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RestartGroup.Location = new System.Drawing.Point(290, 142);
            this.RestartGroup.Name = "RestartGroup";
            this.RestartGroup.Size = new System.Drawing.Size(164, 120);
            this.RestartGroup.TabIndex = 8;
            this.RestartGroup.TabStop = false;
            this.RestartGroup.Text = "Another Game?";
            // 
            // NoRadio
            // 
            this.NoRadio.AutoSize = true;
            this.NoRadio.Location = new System.Drawing.Point(39, 59);
            this.NoRadio.Name = "NoRadio";
            this.NoRadio.Size = new System.Drawing.Size(49, 21);
            this.NoRadio.TabIndex = 1;
            this.NoRadio.TabStop = true;
            this.NoRadio.Text = "No";
            this.NoRadio.UseVisualStyleBackColor = true;
            this.NoRadio.CheckedChanged += new System.EventHandler(this.NoRadio_CheckedChanged);
            // 
            // YesRadio
            // 
            this.YesRadio.AutoSize = true;
            this.YesRadio.Location = new System.Drawing.Point(39, 32);
            this.YesRadio.Name = "YesRadio";
            this.YesRadio.Size = new System.Drawing.Size(56, 21);
            this.YesRadio.TabIndex = 0;
            this.YesRadio.TabStop = true;
            this.YesRadio.Text = "Yes";
            this.YesRadio.UseVisualStyleBackColor = true;
            this.YesRadio.CheckedChanged += new System.EventHandler(this.YesRadio_CheckedChanged);
            // 
            // rollOrHold
            // 
            this.rollOrHold.AutoSize = true;
            this.rollOrHold.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rollOrHold.Location = new System.Drawing.Point(12, 73);
            this.rollOrHold.Name = "rollOrHold";
            this.rollOrHold.Size = new System.Drawing.Size(94, 17);
            this.rollOrHold.TabIndex = 9;
            this.rollOrHold.Text = "Roll or Hold";
            // 
            // Pig_Game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(478, 305);
            this.Controls.Add(this.rollOrHold);
            this.Controls.Add(this.RestartGroup);
            this.Controls.Add(this.HoldButton);
            this.Controls.Add(this.RollButton);
            this.Controls.Add(this.Player2Score);
            this.Controls.Add(this.Player1Score);
            this.Controls.Add(this.Player2Label);
            this.Controls.Add(this.Player1Label);
            this.Controls.Add(this.OnePigPictureBox);
            this.Controls.Add(this.whoseTurn);
            this.Name = "Pig_Game";
            this.Text = "Pig_Game";
            ((System.ComponentModel.ISupportInitialize)(this.OnePigPictureBox)).EndInit();
            this.RestartGroup.ResumeLayout(false);
            this.RestartGroup.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label whoseTurn;
        private System.Windows.Forms.PictureBox OnePigPictureBox;
        private System.Windows.Forms.Label Player1Label;
        private System.Windows.Forms.Label Player2Label;
        private System.Windows.Forms.TextBox Player1Score;
        private System.Windows.Forms.TextBox Player2Score;
        private System.Windows.Forms.Button RollButton;
        private System.Windows.Forms.Button HoldButton;
        private System.Windows.Forms.GroupBox RestartGroup;
        private System.Windows.Forms.RadioButton NoRadio;
        private System.Windows.Forms.RadioButton YesRadio;
        private System.Windows.Forms.Label rollOrHold;
    }
}
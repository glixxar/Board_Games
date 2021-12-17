namespace BoardGames {
    partial class Board_Games {
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
            this.label1 = new System.Windows.Forms.Label();
            this.gameGroupBox = new System.Windows.Forms.GroupBox();
            this.cardRadioButton = new System.Windows.Forms.RadioButton();
            this.diceRadioButton = new System.Windows.Forms.RadioButton();
            this.coinRadioButton = new System.Windows.Forms.RadioButton();
            this.startButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.gameGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Snap ITC", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(27, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 46);
            this.label1.TabIndex = 0;
            this.label1.Text = "BOARD";
            // 
            // gameGroupBox
            // 
            this.gameGroupBox.Controls.Add(this.cardRadioButton);
            this.gameGroupBox.Controls.Add(this.diceRadioButton);
            this.gameGroupBox.Controls.Add(this.coinRadioButton);
            this.gameGroupBox.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.gameGroupBox.Font = new System.Drawing.Font("Comic Sans MS", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gameGroupBox.ForeColor = System.Drawing.Color.Chocolate;
            this.gameGroupBox.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.gameGroupBox.Location = new System.Drawing.Point(46, 100);
            this.gameGroupBox.Name = "gameGroupBox";
            this.gameGroupBox.Size = new System.Drawing.Size(286, 181);
            this.gameGroupBox.TabIndex = 3;
            this.gameGroupBox.TabStop = false;
            this.gameGroupBox.Text = "Select Game:";
            // 
            // cardRadioButton
            // 
            this.cardRadioButton.AutoSize = true;
            this.cardRadioButton.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cardRadioButton.ForeColor = System.Drawing.Color.DarkOrange;
            this.cardRadioButton.Location = new System.Drawing.Point(59, 122);
            this.cardRadioButton.Name = "cardRadioButton";
            this.cardRadioButton.Size = new System.Drawing.Size(157, 37);
            this.cardRadioButton.TabIndex = 2;
            this.cardRadioButton.Text = "Card Game";
            this.cardRadioButton.UseVisualStyleBackColor = true;
            this.cardRadioButton.CheckedChanged += new System.EventHandler(this.coinRadioButton_CheckedChanged);
            // 
            // diceRadioButton
            // 
            this.diceRadioButton.AutoSize = true;
            this.diceRadioButton.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.diceRadioButton.ForeColor = System.Drawing.Color.DarkOrange;
            this.diceRadioButton.Location = new System.Drawing.Point(59, 81);
            this.diceRadioButton.Name = "diceRadioButton";
            this.diceRadioButton.Size = new System.Drawing.Size(155, 37);
            this.diceRadioButton.TabIndex = 1;
            this.diceRadioButton.Text = "Dice Game";
            this.diceRadioButton.UseVisualStyleBackColor = true;
            this.diceRadioButton.CheckedChanged += new System.EventHandler(this.coinRadioButton_CheckedChanged);
            // 
            // coinRadioButton
            // 
            this.coinRadioButton.AutoSize = true;
            this.coinRadioButton.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.coinRadioButton.ForeColor = System.Drawing.Color.DarkOrange;
            this.coinRadioButton.Location = new System.Drawing.Point(59, 41);
            this.coinRadioButton.Name = "coinRadioButton";
            this.coinRadioButton.Size = new System.Drawing.Size(153, 37);
            this.coinRadioButton.TabIndex = 0;
            this.coinRadioButton.Text = "Coin Game";
            this.coinRadioButton.UseVisualStyleBackColor = true;
            this.coinRadioButton.CheckedChanged += new System.EventHandler(this.coinRadioButton_CheckedChanged);
            // 
            // startButton
            // 
            this.startButton.BackColor = System.Drawing.Color.Tomato;
            this.startButton.Enabled = false;
            this.startButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.startButton.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startButton.ForeColor = System.Drawing.Color.Black;
            this.startButton.Location = new System.Drawing.Point(105, 297);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(182, 55);
            this.startButton.TabIndex = 2;
            this.startButton.Text = "START";
            this.startButton.UseVisualStyleBackColor = false;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.BackColor = System.Drawing.Color.Tomato;
            this.exitButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.exitButton.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitButton.ForeColor = System.Drawing.Color.Black;
            this.exitButton.Location = new System.Drawing.Point(105, 358);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(182, 56);
            this.exitButton.TabIndex = 3;
            this.exitButton.Text = "EXIT";
            this.exitButton.UseVisualStyleBackColor = false;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Snap ITC", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(190, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(182, 46);
            this.label2.TabIndex = 4;
            this.label2.Text = "GAMES";
            // 
            // Board_Games
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(384, 440);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.gameGroupBox);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Board_Games";
            this.Text = "Board Games";
            this.gameGroupBox.ResumeLayout(false);
            this.gameGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gameGroupBox;
        private System.Windows.Forms.RadioButton cardRadioButton;
        private System.Windows.Forms.RadioButton diceRadioButton;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton coinRadioButton;
    }
}


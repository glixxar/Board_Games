namespace Class_Assignment {
    partial class Form1 {
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
            this.Title = new System.Windows.Forms.Label();
            this.groupGame = new System.Windows.Forms.GroupBox();
            this.radioCard = new System.Windows.Forms.RadioButton();
            this.radioDice = new System.Windows.Forms.RadioButton();
            this.startButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.groupGame.SuspendLayout();
            this.SuspendLayout();
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title.Location = new System.Drawing.Point(24, 28);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(269, 36);
            this.Title.TabIndex = 0;
            this.Title.Text = "Interactive Games";
            // 
            // groupGame
            // 
            this.groupGame.Controls.Add(this.radioCard);
            this.groupGame.Controls.Add(this.radioDice);
            this.groupGame.Location = new System.Drawing.Point(60, 67);
            this.groupGame.Name = "groupGame";
            this.groupGame.Size = new System.Drawing.Size(179, 136);
            this.groupGame.TabIndex = 1;
            this.groupGame.TabStop = false;
            this.groupGame.Text = "Select Game Type";
            // 
            // radioCard
            // 
            this.radioCard.AutoSize = true;
            this.radioCard.Location = new System.Drawing.Point(25, 83);
            this.radioCard.Name = "radioCard";
            this.radioCard.Size = new System.Drawing.Size(101, 21);
            this.radioCard.TabIndex = 1;
            this.radioCard.Text = "Card Game";
            this.radioCard.UseVisualStyleBackColor = true;
            this.radioCard.CheckedChanged += new System.EventHandler(this.radioCard_CheckedChanged);
            // 
            // radioDice
            // 
            this.radioDice.AutoSize = true;
            this.radioDice.Location = new System.Drawing.Point(27, 47);
            this.radioDice.Name = "radioDice";
            this.radioDice.Size = new System.Drawing.Size(99, 21);
            this.radioDice.TabIndex = 0;
            this.radioDice.Text = "Dice Game";
            this.radioDice.UseVisualStyleBackColor = true;
            this.radioDice.CheckedChanged += new System.EventHandler(this.radioDice_CheckedChanged);
            // 
            // startButton
            // 
            this.startButton.Enabled = false;
            this.startButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startButton.Location = new System.Drawing.Point(85, 238);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(126, 46);
            this.startButton.TabIndex = 2;
            this.startButton.Text = "START";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitButton.Location = new System.Drawing.Point(85, 325);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(126, 46);
            this.exitButton.TabIndex = 3;
            this.exitButton.Text = "EXIT";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(315, 454);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.groupGame);
            this.Controls.Add(this.Title);
            this.Name = "Form1";
            this.Text = "Games";
            this.groupGame.ResumeLayout(false);
            this.groupGame.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.GroupBox groupGame;
        private System.Windows.Forms.RadioButton radioCard;
        private System.Windows.Forms.RadioButton radioDice;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Button exitButton;
    }
}


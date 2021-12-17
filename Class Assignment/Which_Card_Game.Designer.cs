namespace Class_Assignment {
    partial class Which_Card_Game {
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
            this.label1 = new System.Windows.Forms.Label();
            this.buttonCardChooseExit = new System.Windows.Forms.Button();
            this.comboCard = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(32, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(238, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Choose a Game to play";
            // 
            // buttonCardChooseExit
            // 
            this.buttonCardChooseExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCardChooseExit.Location = new System.Drawing.Point(100, 182);
            this.buttonCardChooseExit.Name = "buttonCardChooseExit";
            this.buttonCardChooseExit.Size = new System.Drawing.Size(88, 35);
            this.buttonCardChooseExit.TabIndex = 1;
            this.buttonCardChooseExit.Text = "EXIT";
            this.buttonCardChooseExit.UseVisualStyleBackColor = true;
            this.buttonCardChooseExit.Click += new System.EventHandler(this.buttonCardChooseExit_Click);
            // 
            // comboCard
            // 
            this.comboCard.FormattingEnabled = true;
            this.comboCard.Location = new System.Drawing.Point(87, 96);
            this.comboCard.Name = "comboCard";
            this.comboCard.Size = new System.Drawing.Size(121, 24);
            this.comboCard.TabIndex = 2;
            this.comboCard.SelectedIndexChanged += new System.EventHandler(this.comboCard_SelectedIndexChanged);
            // 
            // Which_Card_Game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(307, 274);
            this.Controls.Add(this.comboCard);
            this.Controls.Add(this.buttonCardChooseExit);
            this.Controls.Add(this.label1);
            this.Name = "Which_Card_Game";
            this.Text = "Which_Card_Game";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonCardChooseExit;
        private System.Windows.Forms.ComboBox comboCard;
    }
}
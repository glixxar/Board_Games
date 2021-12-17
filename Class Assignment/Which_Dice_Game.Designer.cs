namespace Class_Assignment {
    partial class Which_Dice_Game {
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radio2Die = new System.Windows.Forms.RadioButton();
            this.radio1Die = new System.Windows.Forms.RadioButton();
            this.buttonPigExit = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radio2Die);
            this.groupBox1.Controls.Add(this.radio1Die);
            this.groupBox1.Location = new System.Drawing.Point(43, 40);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(261, 155);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Select which Pig to play";
            // 
            // radio2Die
            // 
            this.radio2Die.AutoSize = true;
            this.radio2Die.Location = new System.Drawing.Point(60, 95);
            this.radio2Die.Name = "radio2Die";
            this.radio2Die.Size = new System.Drawing.Size(111, 21);
            this.radio2Die.TabIndex = 0;
            this.radio2Die.Text = "Two Dice Pig";
            this.radio2Die.UseVisualStyleBackColor = true;
            this.radio2Die.Click += new System.EventHandler(this.radio2Die_CheckedChanged);
            // 
            // radio1Die
            // 
            this.radio1Die.AutoSize = true;
            this.radio1Die.Location = new System.Drawing.Point(60, 45);
            this.radio1Die.Name = "radio1Die";
            this.radio1Die.Size = new System.Drawing.Size(117, 21);
            this.radio1Die.TabIndex = 0;
            this.radio1Die.Text = "Single Die Pig";
            this.radio1Die.UseVisualStyleBackColor = true;
            this.radio1Die.Click += new System.EventHandler(this.radio1Die_CheckedChanged);
            // 
            // buttonPigExit
            // 
            this.buttonPigExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPigExit.Location = new System.Drawing.Point(103, 224);
            this.buttonPigExit.Name = "buttonPigExit";
            this.buttonPigExit.Size = new System.Drawing.Size(129, 37);
            this.buttonPigExit.TabIndex = 1;
            this.buttonPigExit.Text = "EXIT";
            this.buttonPigExit.UseVisualStyleBackColor = true;
            this.buttonPigExit.Click += new System.EventHandler(this.buttonPigExit_Click);
            // 
            // Which_Dice_Game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(369, 315);
            this.Controls.Add(this.buttonPigExit);
            this.Controls.Add(this.groupBox1);
            this.Name = "Which_Dice_Game";
            this.Text = "Dice_Games";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radio2Die;
        private System.Windows.Forms.RadioButton radio1Die;
        private System.Windows.Forms.Button buttonPigExit;
    }
}
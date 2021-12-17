namespace BoardGames {
    partial class Which_Dice_Game {
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
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.diceExitButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.diceComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Text = "Snake Eyes\r\nShip Captain and Crew";
            this.notifyIcon1.Visible = true;
            // 
            // diceExitButton
            // 
            this.diceExitButton.BackColor = System.Drawing.Color.Tomato;
            this.diceExitButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.diceExitButton.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.diceExitButton.ForeColor = System.Drawing.Color.Black;
            this.diceExitButton.Location = new System.Drawing.Point(113, 244);
            this.diceExitButton.Name = "diceExitButton";
            this.diceExitButton.Size = new System.Drawing.Size(182, 56);
            this.diceExitButton.TabIndex = 13;
            this.diceExitButton.Text = "EXIT";
            this.diceExitButton.UseVisualStyleBackColor = false;
            this.diceExitButton.Click += new System.EventHandler(this.diceExitButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Snap ITC", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(194, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(182, 46);
            this.label2.TabIndex = 12;
            this.label2.Text = "GAMES";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Snap ITC", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(31, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(167, 46);
            this.label3.TabIndex = 11;
            this.label3.Text = "BOARD";
            // 
            // diceComboBox
            // 
            this.diceComboBox.BackColor = System.Drawing.SystemColors.Info;
            this.diceComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.diceComboBox.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.diceComboBox.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.diceComboBox.FormattingEnabled = true;
            this.diceComboBox.Items.AddRange(new object[] {
            "Snake Eyes",
            "Ship Captain and Crew"});
            this.diceComboBox.Location = new System.Drawing.Point(50, 170);
            this.diceComboBox.Name = "diceComboBox";
            this.diceComboBox.Size = new System.Drawing.Size(294, 41);
            this.diceComboBox.TabIndex = 10;
            this.diceComboBox.SelectedIndexChanged += new System.EventHandler(this.diceComboBox_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Harlow Solid Italic", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Chocolate;
            this.label1.Location = new System.Drawing.Point(44, 110);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(300, 35);
            this.label1.TabIndex = 9;
            this.label1.Text = "Choose a Game to Play:";
            // 
            // Which_Dice_Game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(408, 324);
            this.Controls.Add(this.diceExitButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.diceComboBox);
            this.Controls.Add(this.label1);
            this.Name = "Which_Dice_Game";
            this.Text = "Which_Dice_Game";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.Button diceExitButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox diceComboBox;
        private System.Windows.Forms.Label label1;
    }
}
namespace BoardGames {
    partial class Crazy_Eights {
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
            this.computerLabel = new System.Windows.Forms.Label();
            this.playerLabel = new System.Windows.Forms.Label();
            this.dealButton = new System.Windows.Forms.Button();
            this.sortButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.drawPilePictureBox = new System.Windows.Forms.PictureBox();
            this.discardPilePictureBox = new System.Windows.Forms.PictureBox();
            this.instructionsLabel = new System.Windows.Forms.Label();
            this.computerTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.playerTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.drawPilePictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.discardPilePictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // computerLabel
            // 
            this.computerLabel.AutoSize = true;
            this.computerLabel.Font = new System.Drawing.Font("Comic Sans MS", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.computerLabel.ForeColor = System.Drawing.Color.Chocolate;
            this.computerLabel.Location = new System.Drawing.Point(223, 9);
            this.computerLabel.Name = "computerLabel";
            this.computerLabel.Size = new System.Drawing.Size(164, 45);
            this.computerLabel.TabIndex = 0;
            this.computerLabel.Text = "Computer";
            // 
            // playerLabel
            // 
            this.playerLabel.AutoSize = true;
            this.playerLabel.Font = new System.Drawing.Font("Comic Sans MS", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playerLabel.ForeColor = System.Drawing.Color.Chocolate;
            this.playerLabel.Location = new System.Drawing.Point(249, 371);
            this.playerLabel.Name = "playerLabel";
            this.playerLabel.Size = new System.Drawing.Size(115, 45);
            this.playerLabel.TabIndex = 1;
            this.playerLabel.Text = "Player";
            // 
            // dealButton
            // 
            this.dealButton.BackColor = System.Drawing.Color.Tomato;
            this.dealButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.dealButton.Font = new System.Drawing.Font("Comic Sans MS", 10F);
            this.dealButton.Location = new System.Drawing.Point(35, 380);
            this.dealButton.Name = "dealButton";
            this.dealButton.Size = new System.Drawing.Size(147, 42);
            this.dealButton.TabIndex = 2;
            this.dealButton.Text = "Deal";
            this.dealButton.UseVisualStyleBackColor = false;
            this.dealButton.Click += new System.EventHandler(this.dealButton_Click);
            // 
            // sortButton
            // 
            this.sortButton.BackColor = System.Drawing.Color.Tomato;
            this.sortButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.sortButton.Font = new System.Drawing.Font("Comic Sans MS", 9F);
            this.sortButton.Location = new System.Drawing.Point(22, 184);
            this.sortButton.Name = "sortButton";
            this.sortButton.Size = new System.Drawing.Size(189, 42);
            this.sortButton.TabIndex = 3;
            this.sortButton.Text = "Sort Player\'s Hand";
            this.sortButton.UseVisualStyleBackColor = false;
            // 
            // cancelButton
            // 
            this.cancelButton.BackColor = System.Drawing.Color.Tomato;
            this.cancelButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cancelButton.Font = new System.Drawing.Font("Comic Sans MS", 10F);
            this.cancelButton.Location = new System.Drawing.Point(411, 380);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(147, 42);
            this.cancelButton.TabIndex = 4;
            this.cancelButton.Text = "Cancel Game";
            this.cancelButton.UseVisualStyleBackColor = false;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // drawPilePictureBox
            // 
            this.drawPilePictureBox.Location = new System.Drawing.Point(231, 158);
            this.drawPilePictureBox.Name = "drawPilePictureBox";
            this.drawPilePictureBox.Size = new System.Drawing.Size(70, 95);
            this.drawPilePictureBox.TabIndex = 7;
            this.drawPilePictureBox.TabStop = false;
            this.drawPilePictureBox.Click += new System.EventHandler(this.drawPilePictureBox_Click);
            // 
            // discardPilePictureBox
            // 
            this.discardPilePictureBox.Location = new System.Drawing.Point(307, 158);
            this.discardPilePictureBox.Name = "discardPilePictureBox";
            this.discardPilePictureBox.Size = new System.Drawing.Size(70, 95);
            this.discardPilePictureBox.TabIndex = 8;
            this.discardPilePictureBox.TabStop = false;
            // 
            // instructionsLabel
            // 
            this.instructionsLabel.BackColor = System.Drawing.Color.White;
            this.instructionsLabel.Location = new System.Drawing.Point(393, 186);
            this.instructionsLabel.Name = "instructionsLabel";
            this.instructionsLabel.Size = new System.Drawing.Size(180, 40);
            this.instructionsLabel.TabIndex = 9;
            this.instructionsLabel.Text = "                                                              \r\n                 " +
    "                                             \r\n                                 " +
    "                             \r\n";
            // 
            // computerTableLayoutPanel
            // 
            this.computerTableLayoutPanel.AutoSize = true;
            this.computerTableLayoutPanel.ColumnCount = 13;
            this.computerTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7.692307F));
            this.computerTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7.692308F));
            this.computerTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7.692308F));
            this.computerTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7.692308F));
            this.computerTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7.692308F));
            this.computerTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7.692308F));
            this.computerTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7.692308F));
            this.computerTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7.692308F));
            this.computerTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7.692308F));
            this.computerTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7.692308F));
            this.computerTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7.692308F));
            this.computerTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7.692308F));
            this.computerTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7.692308F));
            this.computerTableLayoutPanel.Location = new System.Drawing.Point(12, 57);
            this.computerTableLayoutPanel.Name = "computerTableLayoutPanel";
            this.computerTableLayoutPanel.RowCount = 1;
            this.computerTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.computerTableLayoutPanel.Size = new System.Drawing.Size(570, 95);
            this.computerTableLayoutPanel.TabIndex = 10;
            // 
            // playerTableLayoutPanel
            // 
            this.playerTableLayoutPanel.AutoSize = true;
            this.playerTableLayoutPanel.ColumnCount = 13;
            this.playerTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7.692307F));
            this.playerTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7.692307F));
            this.playerTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7.692307F));
            this.playerTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7.692307F));
            this.playerTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7.692307F));
            this.playerTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7.692307F));
            this.playerTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7.692307F));
            this.playerTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7.692307F));
            this.playerTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7.692307F));
            this.playerTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7.692307F));
            this.playerTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7.692307F));
            this.playerTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7.692307F));
            this.playerTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7.692307F));
            this.playerTableLayoutPanel.Location = new System.Drawing.Point(12, 259);
            this.playerTableLayoutPanel.Name = "playerTableLayoutPanel";
            this.playerTableLayoutPanel.RowCount = 1;
            this.playerTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.playerTableLayoutPanel.Size = new System.Drawing.Size(570, 95);
            this.playerTableLayoutPanel.TabIndex = 11;
            // 
            // Crazy_Eights
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(598, 444);
            this.Controls.Add(this.playerTableLayoutPanel);
            this.Controls.Add(this.computerTableLayoutPanel);
            this.Controls.Add(this.instructionsLabel);
            this.Controls.Add(this.discardPilePictureBox);
            this.Controls.Add(this.drawPilePictureBox);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.sortButton);
            this.Controls.Add(this.dealButton);
            this.Controls.Add(this.playerLabel);
            this.Controls.Add(this.computerLabel);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Crazy_Eights";
            this.Text = "Crazy_Eights";
            ((System.ComponentModel.ISupportInitialize)(this.drawPilePictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.discardPilePictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label computerLabel;
        private System.Windows.Forms.Label playerLabel;
        private System.Windows.Forms.Button dealButton;
        private System.Windows.Forms.Button sortButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.PictureBox drawPilePictureBox;
        private System.Windows.Forms.PictureBox discardPilePictureBox;
        private System.Windows.Forms.Label instructionsLabel;
        private System.Windows.Forms.TableLayoutPanel computerTableLayoutPanel;
        private System.Windows.Forms.TableLayoutPanel playerTableLayoutPanel;
    }
}
namespace Class_Assignment
{
    partial class Twenty_One
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dealButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.standButton = new System.Windows.Forms.Button();
            this.hitButton = new System.Windows.Forms.Button();
            this.testButton = new System.Windows.Forms.Button();
            this.playerBustedLabel = new System.Windows.Forms.Label();
            this.playerGamesWonLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.playerTotalPointsLabel = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.playerTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.dealerTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.label6 = new System.Windows.Forms.Label();
            this.dealerTotalPointsLabel = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.dealerGamesWonLabel = new System.Windows.Forms.Label();
            this.dealerBustedLabel = new System.Windows.Forms.Label();
            this.numOfAcesLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // dealButton
            // 
            this.dealButton.BackColor = System.Drawing.Color.Gainsboro;
            this.dealButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.dealButton.Font = new System.Drawing.Font("Comic Sans MS", 10F);
            this.dealButton.Location = new System.Drawing.Point(32, 282);
            this.dealButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dealButton.Name = "dealButton";
            this.dealButton.Size = new System.Drawing.Size(92, 36);
            this.dealButton.TabIndex = 0;
            this.dealButton.Text = "Deal";
            this.dealButton.UseVisualStyleBackColor = false;
            this.dealButton.Click += new System.EventHandler(this.dealButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.BackColor = System.Drawing.Color.Gainsboro;
            this.cancelButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cancelButton.Font = new System.Drawing.Font("Comic Sans MS", 10F);
            this.cancelButton.Location = new System.Drawing.Point(393, 282);
            this.cancelButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(92, 36);
            this.cancelButton.TabIndex = 1;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = false;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // standButton
            // 
            this.standButton.BackColor = System.Drawing.Color.Gainsboro;
            this.standButton.Enabled = false;
            this.standButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.standButton.Font = new System.Drawing.Font("Comic Sans MS", 10F);
            this.standButton.Location = new System.Drawing.Point(276, 282);
            this.standButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.standButton.Name = "standButton";
            this.standButton.Size = new System.Drawing.Size(92, 36);
            this.standButton.TabIndex = 2;
            this.standButton.Text = "Stand";
            this.standButton.UseVisualStyleBackColor = false;
            this.standButton.Click += new System.EventHandler(this.standButton_Click);
            // 
            // hitButton
            // 
            this.hitButton.BackColor = System.Drawing.Color.Gainsboro;
            this.hitButton.Enabled = false;
            this.hitButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.hitButton.Font = new System.Drawing.Font("Comic Sans MS", 10F);
            this.hitButton.Location = new System.Drawing.Point(155, 282);
            this.hitButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.hitButton.Name = "hitButton";
            this.hitButton.Size = new System.Drawing.Size(92, 36);
            this.hitButton.TabIndex = 3;
            this.hitButton.Text = "Hit";
            this.hitButton.UseVisualStyleBackColor = false;
            this.hitButton.Click += new System.EventHandler(this.hitButton_Click);
            // 
            // testButton
            // 
            this.testButton.BackColor = System.Drawing.Color.Gainsboro;
            this.testButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.testButton.Font = new System.Drawing.Font("Comic Sans MS", 10F);
            this.testButton.Location = new System.Drawing.Point(512, 282);
            this.testButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.testButton.Name = "testButton";
            this.testButton.Size = new System.Drawing.Size(79, 36);
            this.testButton.TabIndex = 4;
            this.testButton.Text = "Test";
            this.testButton.UseVisualStyleBackColor = false;
            this.testButton.Visible = false;
            this.testButton.Click += new System.EventHandler(this.testButton_Click);
            // 
            // playerBustedLabel
            // 
            this.playerBustedLabel.AutoSize = true;
            this.playerBustedLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.playerBustedLabel.ForeColor = System.Drawing.Color.Red;
            this.playerBustedLabel.Location = new System.Drawing.Point(40, 220);
            this.playerBustedLabel.Name = "playerBustedLabel";
            this.playerBustedLabel.Size = new System.Drawing.Size(91, 24);
            this.playerBustedLabel.TabIndex = 5;
            this.playerBustedLabel.Text = "BUSTED";
            this.playerBustedLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.playerBustedLabel.Visible = false;
            // 
            // playerGamesWonLabel
            // 
            this.playerGamesWonLabel.AutoSize = true;
            this.playerGamesWonLabel.BackColor = System.Drawing.Color.White;
            this.playerGamesWonLabel.Font = new System.Drawing.Font("Comic Sans MS", 8F);
            this.playerGamesWonLabel.Location = new System.Drawing.Point(496, 223);
            this.playerGamesWonLabel.Name = "playerGamesWonLabel";
            this.playerGamesWonLabel.Size = new System.Drawing.Size(18, 19);
            this.playerGamesWonLabel.TabIndex = 6;
            this.playerGamesWonLabel.Text = "0";
            this.playerGamesWonLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Purple;
            this.label3.Location = new System.Drawing.Point(391, 223);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 18);
            this.label3.TabIndex = 7;
            this.label3.Text = "Games won:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // playerTotalPointsLabel
            // 
            this.playerTotalPointsLabel.AutoSize = true;
            this.playerTotalPointsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playerTotalPointsLabel.Location = new System.Drawing.Point(305, 225);
            this.playerTotalPointsLabel.Name = "playerTotalPointsLabel";
            this.playerTotalPointsLabel.Size = new System.Drawing.Size(59, 17);
            this.playerTotalPointsLabel.TabIndex = 8;
            this.playerTotalPointsLabel.Text = "POINTS";
            this.playerTotalPointsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.playerTotalPointsLabel.Visible = false;
            // 
            // label5
            // 
            this.label5.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.DarkBlue;
            this.label5.Location = new System.Drawing.Point(225, 218);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 30);
            this.label5.TabIndex = 9;
            this.label5.Text = "Player:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // playerTableLayoutPanel
            // 
            this.playerTableLayoutPanel.ColumnCount = 8;
            this.playerTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.playerTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.playerTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.playerTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.playerTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.playerTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.playerTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.playerTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.playerTableLayoutPanel.Location = new System.Drawing.Point(9, 138);
            this.playerTableLayoutPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.playerTableLayoutPanel.Name = "playerTableLayoutPanel";
            this.playerTableLayoutPanel.RowCount = 1;
            this.playerTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.playerTableLayoutPanel.Size = new System.Drawing.Size(633, 76);
            this.playerTableLayoutPanel.TabIndex = 10;
            // 
            // dealerTableLayoutPanel
            // 
            this.dealerTableLayoutPanel.ColumnCount = 8;
            this.dealerTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.dealerTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.dealerTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.dealerTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.dealerTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.dealerTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.dealerTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.dealerTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.dealerTableLayoutPanel.Location = new System.Drawing.Point(9, 41);
            this.dealerTableLayoutPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dealerTableLayoutPanel.Name = "dealerTableLayoutPanel";
            this.dealerTableLayoutPanel.RowCount = 1;
            this.dealerTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.dealerTableLayoutPanel.Size = new System.Drawing.Size(633, 76);
            this.dealerTableLayoutPanel.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.DarkBlue;
            this.label6.Location = new System.Drawing.Point(221, 7);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 26);
            this.label6.TabIndex = 16;
            this.label6.Text = "Dealer:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dealerTotalPointsLabel
            // 
            this.dealerTotalPointsLabel.AutoSize = true;
            this.dealerTotalPointsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dealerTotalPointsLabel.Location = new System.Drawing.Point(305, 12);
            this.dealerTotalPointsLabel.Name = "dealerTotalPointsLabel";
            this.dealerTotalPointsLabel.Size = new System.Drawing.Size(50, 18);
            this.dealerTotalPointsLabel.TabIndex = 15;
            this.dealerTotalPointsLabel.Text = "Points";
            this.dealerTotalPointsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.dealerTotalPointsLabel.Visible = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Purple;
            this.label8.Location = new System.Drawing.Point(391, 12);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(93, 18);
            this.label8.TabIndex = 14;
            this.label8.Text = "Games won:";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dealerGamesWonLabel
            // 
            this.dealerGamesWonLabel.AutoSize = true;
            this.dealerGamesWonLabel.BackColor = System.Drawing.Color.White;
            this.dealerGamesWonLabel.Font = new System.Drawing.Font("Comic Sans MS", 8F);
            this.dealerGamesWonLabel.Location = new System.Drawing.Point(496, 12);
            this.dealerGamesWonLabel.Name = "dealerGamesWonLabel";
            this.dealerGamesWonLabel.Size = new System.Drawing.Size(18, 19);
            this.dealerGamesWonLabel.TabIndex = 13;
            this.dealerGamesWonLabel.Text = "0";
            this.dealerGamesWonLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // dealerBustedLabel
            // 
            this.dealerBustedLabel.AutoSize = true;
            this.dealerBustedLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dealerBustedLabel.ForeColor = System.Drawing.Color.Red;
            this.dealerBustedLabel.Location = new System.Drawing.Point(40, 7);
            this.dealerBustedLabel.Name = "dealerBustedLabel";
            this.dealerBustedLabel.Size = new System.Drawing.Size(91, 24);
            this.dealerBustedLabel.TabIndex = 12;
            this.dealerBustedLabel.Text = "BUSTED";
            this.dealerBustedLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.dealerBustedLabel.Visible = false;
            // 
            // numOfAcesLabel
            // 
            this.numOfAcesLabel.AutoSize = true;
            this.numOfAcesLabel.BackColor = System.Drawing.Color.White;
            this.numOfAcesLabel.Font = new System.Drawing.Font("Comic Sans MS", 8F);
            this.numOfAcesLabel.Location = new System.Drawing.Point(199, 252);
            this.numOfAcesLabel.Name = "numOfAcesLabel";
            this.numOfAcesLabel.Size = new System.Drawing.Size(18, 19);
            this.numOfAcesLabel.TabIndex = 17;
            this.numOfAcesLabel.Text = "0";
            this.numOfAcesLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(221, 251);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 22);
            this.label2.TabIndex = 18;
            this.label2.Text = "Aces with value 1";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Twenty_One
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(657, 348);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.numOfAcesLabel);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dealerTotalPointsLabel);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.dealerGamesWonLabel);
            this.Controls.Add(this.dealerBustedLabel);
            this.Controls.Add(this.dealerTableLayoutPanel);
            this.Controls.Add(this.playerTableLayoutPanel);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.playerTotalPointsLabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.playerGamesWonLabel);
            this.Controls.Add(this.playerBustedLabel);
            this.Controls.Add(this.testButton);
            this.Controls.Add(this.hitButton);
            this.Controls.Add(this.standButton);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.dealButton);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Twenty_One";
            this.Text = "Twenty_One";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button dealButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button standButton;
        private System.Windows.Forms.Button hitButton;
        private System.Windows.Forms.Button testButton;
        private System.Windows.Forms.Label playerBustedLabel;
        private System.Windows.Forms.Label playerGamesWonLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label playerTotalPointsLabel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TableLayoutPanel playerTableLayoutPanel;
        private System.Windows.Forms.TableLayoutPanel dealerTableLayoutPanel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label dealerTotalPointsLabel;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label dealerGamesWonLabel;
        private System.Windows.Forms.Label dealerBustedLabel;
        private System.Windows.Forms.Label numOfAcesLabel;
        private System.Windows.Forms.Label label2;
    }
}
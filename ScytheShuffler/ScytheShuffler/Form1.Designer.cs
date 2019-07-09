namespace ScytheShuffler
{
    partial class ScytheShuffler
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
            this.DoItButton = new System.Windows.Forms.Button();
            this.Results = new System.Windows.Forms.TextBox();
            this.Players = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // DoItButton
            // 
            this.DoItButton.AutoSize = true;
            this.DoItButton.Location = new System.Drawing.Point(13, 370);
            this.DoItButton.Name = "DoItButton";
            this.DoItButton.Size = new System.Drawing.Size(75, 23);
            this.DoItButton.TabIndex = 0;
            this.DoItButton.Text = "Do it";
            this.DoItButton.UseVisualStyleBackColor = true;
            this.DoItButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // Results
            // 
            this.Results.Location = new System.Drawing.Point(13, 13);
            this.Results.Multiline = true;
            this.Results.Name = "Results";
            this.Results.Size = new System.Drawing.Size(211, 329);
            this.Results.TabIndex = 1;
            // 
            // Players
            // 
            this.Players.FormattingEnabled = true;
            this.Players.Items.AddRange(new object[] {
            "2",
            "3",
            "4",
            "5"});
            this.Players.Location = new System.Drawing.Point(103, 372);
            this.Players.Name = "Players";
            this.Players.Size = new System.Drawing.Size(121, 21);
            this.Players.TabIndex = 3;
            this.Players.Text = "5";
            // 
            // ScytheShuffler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(257, 450);
            this.Controls.Add(this.Players);
            this.Controls.Add(this.Results);
            this.Controls.Add(this.DoItButton);
            this.Name = "ScytheShuffler";
            this.Text = "Scythe Shuffler";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button DoItButton;
        private System.Windows.Forms.TextBox Results;
        private System.Windows.Forms.ComboBox Players;
    }
}


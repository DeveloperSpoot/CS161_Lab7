namespace CS161_Lab7.Apps
{
    partial class PrimeList
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
            this.primeListBox = new System.Windows.Forms.ListBox();
            this.exitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // primeListBox
            // 
            this.primeListBox.FormattingEnabled = true;
            this.primeListBox.ItemHeight = 19;
            this.primeListBox.Location = new System.Drawing.Point(11, 10);
            this.primeListBox.Name = "primeListBox";
            this.primeListBox.Size = new System.Drawing.Size(205, 308);
            this.primeListBox.TabIndex = 0;
            // 
            // exitButton
            // 
            this.exitButton.BackColor = System.Drawing.Color.IndianRed;
            this.exitButton.ForeColor = System.Drawing.SystemColors.Control;
            this.exitButton.Location = new System.Drawing.Point(11, 324);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(204, 32);
            this.exitButton.TabIndex = 1;
            this.exitButton.Text = "EXIT";
            this.exitButton.UseVisualStyleBackColor = false;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // PrimeList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(227, 365);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.primeListBox);
            this.Name = "PrimeList";
            this.Text = "PrimeList";
            this.Load += new System.EventHandler(this.onLoad_Event);
            this.ResumeLayout(false);

        }

        #endregion

        private ListBox primeListBox;
        private Button exitButton;
    }
}
namespace CS161_Lab7
{
    partial class Main
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.primeNumbersButton = new System.Windows.Forms.Button();
            this.primeListButton = new System.Windows.Forms.Button();
            this.rockPaperButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // primeNumbersButton
            // 
            this.primeNumbersButton.Location = new System.Drawing.Point(12, 12);
            this.primeNumbersButton.Name = "primeNumbersButton";
            this.primeNumbersButton.Size = new System.Drawing.Size(155, 43);
            this.primeNumbersButton.TabIndex = 0;
            this.primeNumbersButton.Text = "Prime Numbers";
            this.primeNumbersButton.UseVisualStyleBackColor = true;
            this.primeNumbersButton.Click += new System.EventHandler(this.primeNumbersButton_Click);
            // 
            // primeListButton
            // 
            this.primeListButton.Location = new System.Drawing.Point(12, 61);
            this.primeListButton.Name = "primeListButton";
            this.primeListButton.Size = new System.Drawing.Size(155, 43);
            this.primeListButton.TabIndex = 1;
            this.primeListButton.Text = "Prime Number List";
            this.primeListButton.UseVisualStyleBackColor = true;
            this.primeListButton.Click += new System.EventHandler(this.primeListButton_Click);
            // 
            // rockPaperButton
            // 
            this.rockPaperButton.Location = new System.Drawing.Point(12, 110);
            this.rockPaperButton.Name = "rockPaperButton";
            this.rockPaperButton.Size = new System.Drawing.Size(155, 43);
            this.rockPaperButton.TabIndex = 2;
            this.rockPaperButton.Text = "Rock, Paper, Scissors ";
            this.rockPaperButton.UseVisualStyleBackColor = true;
            this.rockPaperButton.Click += new System.EventHandler(this.rockPaperButton_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(179, 164);
            this.Controls.Add(this.rockPaperButton);
            this.Controls.Add(this.primeListButton);
            this.Controls.Add(this.primeNumbersButton);
            this.Name = "Main";
            this.Text = "Main";
            this.ResumeLayout(false);

        }

        #endregion

        private Button primeNumbersButton;
        private Button primeListButton;
        private Button rockPaperButton;
    }
}
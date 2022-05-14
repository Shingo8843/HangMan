
namespace Project2
{
    partial class Form1
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.NEWGAME = new System.Windows.Forms.Button();
            this.QUIT = new System.Windows.Forms.Button();
            this.GUESS = new System.Windows.Forms.Button();
            this.GuessTxt = new System.Windows.Forms.TextBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(744, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(305, 197);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // NEWGAME
            // 
            this.NEWGAME.Location = new System.Drawing.Point(801, 349);
            this.NEWGAME.Name = "NEWGAME";
            this.NEWGAME.Size = new System.Drawing.Size(75, 23);
            this.NEWGAME.TabIndex = 1;
            this.NEWGAME.Text = "NEWGAME";
            this.NEWGAME.UseVisualStyleBackColor = true;
            this.NEWGAME.Click += new System.EventHandler(this.NEWGAME_Click);
            // 
            // QUIT
            // 
            this.QUIT.Location = new System.Drawing.Point(930, 349);
            this.QUIT.Name = "QUIT";
            this.QUIT.Size = new System.Drawing.Size(75, 23);
            this.QUIT.TabIndex = 2;
            this.QUIT.Text = "QUIT";
            this.QUIT.UseVisualStyleBackColor = true;
            this.QUIT.Click += new System.EventHandler(this.QUIT_Click);
            // 
            // GUESS
            // 
            this.GUESS.Location = new System.Drawing.Point(862, 308);
            this.GUESS.Name = "GUESS";
            this.GUESS.Size = new System.Drawing.Size(75, 23);
            this.GUESS.TabIndex = 3;
            this.GUESS.Text = "GUESS";
            this.GUESS.UseVisualStyleBackColor = true;
            this.GUESS.Click += new System.EventHandler(this.button1_Click);
            // 
            // GuessTxt
            // 
            this.GuessTxt.BackColor = System.Drawing.SystemColors.Control;
            this.GuessTxt.Location = new System.Drawing.Point(848, 258);
            this.GuessTxt.Name = "GuessTxt";
            this.GuessTxt.Size = new System.Drawing.Size(100, 20);
            this.GuessTxt.TabIndex = 4;
            this.GuessTxt.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(22, 377);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(453, 40);
            this.richTextBox1.TabIndex = 5;
            this.richTextBox1.Text = "";
            this.richTextBox1.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1061, 450);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.GuessTxt);
            this.Controls.Add(this.GUESS);
            this.Controls.Add(this.QUIT);
            this.Controls.Add(this.NEWGAME);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button NEWGAME;
        private System.Windows.Forms.Button QUIT;
        private System.Windows.Forms.Button GUESS;
        private System.Windows.Forms.TextBox GuessTxt;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}


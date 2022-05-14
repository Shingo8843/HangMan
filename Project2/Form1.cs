using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Collections;

namespace Project2
{
    public partial class Form1 : Form
    {
        WordList wordlist;
        Word myword;
        Label[] LabelArray;
        int guesscount = 0;
        string word, word1;

        public Form1()
        {
            InitializeComponent();
            GuessTxt.Focus();
        }
        private void Createlabel()
        {
            for(int i = 0;i< LabelArray.Length; i++)
            {
                LabelArray[i] = new Label();
                LabelArray[i].Name = "LabelLetter" + i;
                LabelArray[i].BorderStyle = BorderStyle.Fixed3D;
                LabelArray[i].Size = new Size(48, 48);
                LabelArray[i].Location = new Point((i + 1) * 56, 50);
                LabelArray[i].Text = "";
                LabelArray[i].TextAlign = ContentAlignment.MiddleCenter;
                LabelArray[i].Font = new Font("Arial Black", 24, FontStyle.Bold);
                this.Controls.Add(LabelArray[i]);
            }
        }
        private void Destroylabel()
        {
            
            if(LabelArray == null)
            {
                return;
            }
            for (int i = 0; i < LabelArray.Length; i++)
            {
                if(LabelArray != null)
                {
                    this.Controls.Remove(LabelArray[i]);
                }
                LabelArray[i] = null;
            }
        }
        private string newgame()
        {
            wordlist = new WordList();
            if (wordlist.failed)
            {
                MessageBox.Show("There was a problem reading a file  ");
                return null;
            }
            else
            {
                myword = new Word();
                word = wordlist.GetRandomWord();
                word1 = myword.Convert(word);
                Destroylabel();
                LabelArray = new Label[word.Length];
                Createlabel();
                return word1;
            }
        }
        private void button1_Click(object sender, EventArgs e)//GuessButton
        {
            try
            {
                
                char[] wordArray;
                wordArray = word1.ToCharArray();
                char[] guessletters = new char[wordArray.Length - 1];
                Char guessletter = GuessTxt.Text.ToCharArray()[0];
                guessletter = char.ToUpper(guessletter);
                richTextBox1.Text += guessletter.ToString();
                for (int i = 0; i < wordArray.Length; i++)
                {
                    if (guessletter == wordArray[i])
                    {
                        if (LabelArray[i].Text != guessletter.ToString())
                        {
                            guesscount++;
                        }
                        LabelArray[i].Text = guessletter.ToString();
                        
                    }
                    if (guesscount == wordArray.Length)
                    {
                        MessageBox.Show("You guessed it, Conguraduration");
                        guesscount = 0;
                        newgame();
                    }
                    GuessTxt.Clear();
                    GuessTxt.Focus();
                }
            }
            catch(Exception exception1)
            {
                MessageBox.Show("Invalid Input\n"+ exception1.Message);
                GuessTxt.Clear();
                GuessTxt.Focus();
            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            GuessTxt.Text.ToUpper();
        }

        private void QUIT_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void NEWGAME_Click(object sender, EventArgs e)
        {
            //pictureBox1.Image = Project2.Properties.Resources.
            newgame();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            newgame();
        }
    }
}

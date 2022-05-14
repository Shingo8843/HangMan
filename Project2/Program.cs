using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project2
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
//WordGuess
//	Open word list
//	Select word from list
//	Display character slots for each character in word
//	Begin gameloop
//		Prompt player for guess
//		Increment guess count
//		Add guessed letter to guessed letters
//		If guess matches a character in word
//			Display matched character
//			If entire word is guessed
//				Display message including number of guesses
//				Exit program
//			Endif
//		Endif
//	End gameloop
//End

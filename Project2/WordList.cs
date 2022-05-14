using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Collections;


namespace Project2
{
    public class WordList
    {
        ArrayList words = new ArrayList();
        public bool failed;
        public WordList()
        {
            failed = false;
            FileStream infile = null;
            StreamReader reader = null;

            try
            {
                infile = new FileStream("Text.txt", FileMode.OpenOrCreate, FileAccess.Read);
                reader = new StreamReader(infile);
                words.Add(reader.ReadLine());
                Console.WriteLine(reader.ReadLine());
                int i = 0;
                while(words[i] != null)
                {
                    words.Add(reader.ReadLine());
                    Console.WriteLine(reader.ReadLine());
                    i++;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                if(reader != null)
                {
                    reader.Close();
                }
                if(infile != null)
                {
                    infile.Close();
                }
            }
        }

        public string GetRandomWord()
        {
            Random rand = new Random();
            string randomword = (string)words[rand.Next(words.Count-1)];
            return randomword;
        }
    }
}

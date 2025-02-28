using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Find_A_Word
{
    public class StringManipulation
    {

        public String AddWord(String InputString, String Inputword)
        {
            String Sentence = InputString;
            String Word = " " + Inputword;
            String NewWord = "";
            Random random = new Random();
            int WordPlace = random.Next(0, Sentence.Length);
            for (int i = WordPlace; i < Sentence.Length; i++)
            {
                if (i == Sentence.Length)
                {
                    Sentence.Concat(Word);

                }
                else
                {
                    if (Sentence[i] == ' ')
                    {
                        NewWord = Sentence.Insert(i, Word);
                        break;
                    }
                    else
                    {

                    }
                }
            }



            return NewWord;
        }

        public string DeleteWord(String InputString, String inputword)
        {
            String ConvertedSentence = "";



            return ConvertedSentence;
        }
    }
}

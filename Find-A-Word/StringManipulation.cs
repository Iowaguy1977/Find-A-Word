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
            String Word =" " + Inputword;
            String NewWord = "";
            Random random = new Random();
            int WordPlace = random.Next(0, Sentence.Length);
            for (int i = WordPlace; i < Sentence.Length; i++)
            {
                if (i == Sentence.Length)
                {
                    NewWord= string.Concat(Sentence,Word);
                    
                }
                else
                {
                    if (Sentence[i] == ' ' )
                    {
                        NewWord = Sentence.Insert(i, Word);
                        break;
                    }
                    else if (Sentence[i]=='.' || Sentence[i] == '?' || Sentence[i] == '!')
                    {
                        NewWord = Sentence.Insert(i, Word);
                        break;
                    }
                }
            }



            return NewWord;
        }

        public string DeleteWord(String InputString, String inputword)
        {
            String ConvertedSentence = InputString;
            String word = "";
            String _substring1 = "";
            string _substring1dump = "";
            String _substring2 = "";

            for (int i = 0; i < ConvertedSentence.Length; i++)
            {
                //Checks to see if there is punctuation in the sentence.
                if (ConvertedSentence[i] != ' ' && ConvertedSentence[i] != '.' && ConvertedSentence[i] != '?' && ConvertedSentence[i] != '!')
                {
                    //Captures the current word and substring.
                    word = word + ConvertedSentence[i];
                    _substring1 = _substring1 + ConvertedSentence[i];

                }
                else
                {
                    //Checks to see if its the end of the string
                    if (i != ConvertedSentence.Length-1)
                    {
                        _substring1 = _substring1 + ConvertedSentence[i];
                    }
                    if (word == inputword)
                    {
                           
                            _substring2= ConvertedSentence.Substring(i, ConvertedSentence.Length - i);
                            string Answer = ConvertedSentence.Remove(i - inputword.Length, inputword.Length);
                            ConvertedSentence = Answer;
                            _substring1 = "";


                        i =i-inputword.Length-1;
                        word = "";

                    }
                    else
                    {
                        word = "";
                    }
                }
            }
            return ConvertedSentence;
        }
    }
}

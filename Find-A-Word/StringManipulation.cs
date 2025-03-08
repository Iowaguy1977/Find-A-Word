using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace FindAWord
{
    public class StringManipulation
    {

        public String AddWord(String InputString, String Inputword, int _randomNum)
        {
            String Sentence = InputString;
            String Word = Inputword;
            String NewWord = "";
            Random random = new Random();
            int WordPlace = _randomNum;
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
                        NewWord = Sentence.Insert(i, " " + Word);
                        break;
                    }
                    else if (Sentence[i]=='.' || Sentence[i] == '?' || Sentence[i] == '!')
                    {
                        NewWord = Sentence.Insert(i," " + Word);
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
                    
                   
                        _substring1 = _substring1 + ConvertedSentence[i];
                    
                    //THis compares the word entered to the words entered in the sentence.
                    if (word == inputword)
                    {
                           
                            _substring2= ConvertedSentence.Substring(i, ConvertedSentence.Length - i);
                            string Answer = ConvertedSentence.Remove(i - inputword.Length, inputword.Length+1);
                            ConvertedSentence = Answer;
                            _substring1 = "";
                            i = i - inputword.Length - 1;
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

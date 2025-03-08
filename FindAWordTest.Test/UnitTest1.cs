
using System.Diagnostics.CodeAnalysis;
using FindAWord;
namespace FindAWordTest.Test
{


    public class FindAWordTest
    {
        StringManipulation _stringManipulation = new StringManipulation();
        [Theory]
        [InlineData("Lets see what this does","Lets see what does","this",13)]
        [InlineData("Lets see what this does.", "Lets see what does.", "this", 13)]
        [InlineData("Lets see what this does", "Lets see what does", "does", 14)]
        public void WordShoudBeAdded(string Expected,string EnteredSentence,String EnteredWord,int Num)
        {
            //Arrange
            String expected = Expected;
            String enteredSentence = EnteredSentence;
            String enteredWord = EnteredWord;
            int num=Num;


            //Act
            String Actual = _stringManipulation.AddWord(enteredSentence, enteredWord, num);

            //Assert
            Assert.Equal(expected, Actual);
        }
    }
}

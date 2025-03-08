namespace FindAWord
{
    public partial class Form1 : Form
    {
        public string ConvertedSentence = "";
        StringManipulation StringMan = new StringManipulation();
        public Form1()
        {
           InitializeComponent();
        }

        private void Addword_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int _addNumber = rnd.Next(0, Sentence.TextLength);
            ConvertedSentence = StringMan.AddWord(Sentence.Text, Word.Text,_addNumber);
            OutputWindow.Text = ConvertedSentence;
        }

        private void Deleteword_Click(object sender, EventArgs e)
        {
            OutputWindow.Text = StringMan.DeleteWord(ConvertedSentence,Word.Text);
            Sentence.Text = "";
            Word.Text = "";
            Sentence.Focus();
        }
    }
}

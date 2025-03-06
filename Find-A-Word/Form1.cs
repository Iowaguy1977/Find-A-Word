namespace Find_A_Word
{
    public partial class FindAWord : Form
    {
        public string ConvertedSentence = "";
        StringManipulation StringMan = new StringManipulation();
        public FindAWord()
        {
            InitializeComponent();
        }

        private void Addword_Click(object sender, EventArgs e)
        {
            ConvertedSentence = StringMan.AddWord(Sentence.Text, Word.Text);
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

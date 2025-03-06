namespace Find_A_Word
{
    partial class FindAWord
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Sentence = new TextBox();
            Word = new TextBox();
            label1 = new Label();
            label2 = new Label();
            Addword = new Button();
            Deleteword = new Button();
            OutputWindow = new TextBox();
            SuspendLayout();
            // 
            // Sentence
            // 
            Sentence.Location = new Point(195, 52);
            Sentence.Name = "Sentence";
            Sentence.Size = new Size(267, 23);
            Sentence.TabIndex = 0;
            // 
            // Word
            // 
            Word.Location = new Point(195, 106);
            Word.Name = "Word";
            Word.Size = new Size(100, 23);
            Word.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(77, 60);
            label1.Name = "label1";
            label1.Size = new Size(98, 15);
            label1.TabIndex = 2;
            label1.Text = "Sentence Textbox";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(96, 106);
            label2.Name = "label2";
            label2.Size = new Size(79, 15);
            label2.TabIndex = 3;
            label2.Text = "Word Textbox";
            // 
            // Addword
            // 
            Addword.Location = new Point(77, 163);
            Addword.Name = "Addword";
            Addword.Size = new Size(75, 23);
            Addword.TabIndex = 5;
            Addword.Text = "Add Word ";
            Addword.UseVisualStyleBackColor = true;
            Addword.Click += Addword_Click;
            // 
            // Deleteword
            // 
            Deleteword.Location = new Point(220, 163);
            Deleteword.Name = "Deleteword";
            Deleteword.Size = new Size(94, 23);
            Deleteword.TabIndex = 6;
            Deleteword.Text = "Delete Word";
            Deleteword.UseVisualStyleBackColor = true;
            Deleteword.Click += Deleteword_Click;
            // 
            // OutputWindow
            // 
            OutputWindow.Location = new Point(557, 52);
            OutputWindow.Multiline = true;
            OutputWindow.Name = "OutputWindow";
            OutputWindow.ReadOnly = true;
            OutputWindow.Size = new Size(144, 168);
            OutputWindow.TabIndex = 7;
            // 
            // FindAWord
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(OutputWindow);
            Controls.Add(Deleteword);
            Controls.Add(Addword);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(Word);
            Controls.Add(Sentence);
            Name = "FindAWord";
            Text = "FindAWord";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox Sentence;
        private TextBox Word;
        private Label label1;
        private Label label2;
        private Button Addword;
        private Button Deleteword;
        private TextBox OutputWindow;
    }
}

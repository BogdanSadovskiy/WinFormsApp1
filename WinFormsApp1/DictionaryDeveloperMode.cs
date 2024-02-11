namespace FirstApp
{
    public partial class DictionaryDeveloperMode : Form
    {
        string errorTextSameALanguage = "Can not be same language";
        string errorTextInputCorrectly = "Input correctly";
        DictionaryBook book;
        private bool isEnglish;
        private bool isUkrainian;
        private bool isEnglishTranslatedWord;
        private bool isUkrainianTranslatedWord;

        public DictionaryDeveloperMode(DictionaryBook book)
        {
            InitializeComponent();
            this.book = book;
            isEnglish = false;
            isUkrainian = false;
            isEnglishTranslatedWord = false;
            isUkrainianTranslatedWord = false;
        }

        private void newWord_TextChanged(object sender, EventArgs e)
        {
            if (RegexExpr.onlyEnglishWord(newWord.Text)) isEnglish = true;
            if (RegexExpr.onlyUkrainianWord(newWord.Text)) isUkrainian = true;
            if (!isEnglish && !isUkrainian) errorNewWordLabel.Visible = true;
            else errorNewWordLabel.Visible = false;
        }
        private bool isActiveError()
        {
            return !errorNewWordLabel.Visible || !errorTranslatedLabel.Visible;
        }
        private void translatedWord_TextChanged(object sender, EventArgs e)
        {
            if (RegexExpr.onlyEnglishWord(newWord.Text)) isEnglishTranslatedWord = true;
            if (RegexExpr.onlyUkrainianWord(newWord.Text)) isUkrainianTranslatedWord = true;
            if (isEnglish == isEnglishTranslatedWord || isUkrainian == isUkrainianTranslatedWord)
            {
                errorTranslatedLabel.Text = errorTextInputCorrectly;
                errorTranslatedLabel.Visible = true;
            }
            else if (!isEnglishTranslatedWord && !isEnglishTranslatedWord)
            {
                errorTranslatedLabel.Text = errorTextInputCorrectly;
                errorTranslatedLabel.Visible = true;
            }
            else errorTranslatedLabel.Visible = false;
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            if(isActiveError() || newWord.Text == null || newWord.Text == "" 
                || translatedWord.Text == null || translatedWord.Text == "")

        }
    }
}

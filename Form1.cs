namespace Pig_Latin
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string word;
            word = Convert.ToString(textBox1.Text);
            string pigWord;
            pigWord = word.Remove(0, 1);
            string final;
            final = word.Remove(1);
            MessageBox.Show(word + " in pig latin is " + pigWord + final + "ay");


        }
    } 
}

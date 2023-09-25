namespace karakterTerstenYazdırmaApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

            private void button1_Click(object sender, EventArgs e)
            {
                if (string.IsNullOrEmpty(textBox1.Text))
                {
                    MessageBox.Show("Lütfen bir kelime girin.");
                    return;
                }

                string reversedText = ReverseText(textBox1.Text);
                richTextBox1.Text = reversedText;
            }

            private string ReverseText(string text)
            {
                char[] charArray = text.ToCharArray();
                Array.Reverse(charArray);
                return new string(charArray);
            }
        }
    }

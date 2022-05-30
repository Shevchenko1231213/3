using Lab3.Contracts;
using Lab3.Services;
using System.Text;
using System.Windows.Forms;

namespace Lab3
{
    public partial class Form1 : Form
    {
        NumberService numbers = new NumberService();
        StringService strings = new StringService();

        public Form1()
        {
            InitializeComponent();
        }

        private void SortNumbers()
        {
            if(comboBox1.SelectedIndex == 0 && comboBox2.SelectedIndex == 0)
            {
                var result = numbers.SortByAscending();
                StringBuilder text = new StringBuilder();
                for(int i = 0; i < result.GetLength(0); i++)
                {
                    text.Append(result[i].ToString("F2").PadLeft(7));
                }
                richTextBox1.Text = "1, 3, 2, 4, 6, 5";
                richTextBox2.Text = text.ToString();
            }
            if (comboBox1.SelectedIndex == 0 && comboBox2.SelectedIndex == 1)
            {
                var result = numbers.SortByDescending();
                StringBuilder text = new StringBuilder();
                for (int i = 0; i < result.GetLength(0); i++)
                {
                    text.Append(result[i].ToString("F2").PadLeft(7));
                }
                richTextBox1.Text = "1, 3, 2, 4, 6, 5";
                richTextBox2.Text = text.ToString();
            }
        }

        private void SortStrings()
        {
            if (comboBox1.SelectedIndex == 1 && comboBox2.SelectedIndex == 0)
            {
                var result = strings.SortByAscending();
                StringBuilder text = new StringBuilder();
                for (int i = 0; i < result.GetLength(0); i++)
                {
                    text.Append(result[i].ToString().PadLeft(7));
                    text.AppendLine();
                }
                richTextBox1.Text = "Tom, Sam, Andrey";
                richTextBox2.Text = text.ToString();
            }
            if (comboBox1.SelectedIndex == 1 && comboBox2.SelectedIndex == 1)
            {
                var result = strings.SortByDescending();
                StringBuilder text = new StringBuilder();
                for (int i = 0; i < result.GetLength(0); i++)
                {
                    text.Append(result[i].ToString().PadLeft(7));
                    text.AppendLine();
                }
                richTextBox1.Text = "Tom, Sam, Andrey";
                richTextBox2.Text = text.ToString();
            }
            if (comboBox1.SelectedIndex == 1 && comboBox2.SelectedIndex == 2)
            {
                var result = strings.SortByAscii();
                StringBuilder text = new StringBuilder();
                for (int i = 0; i < result.Length; i++)
                {
                    text.Append(result[i].ToString().PadLeft(7));
                    text.AppendLine();
                }
                richTextBox1.Text = "Some text";
                richTextBox2.Text = text.ToString();
            }
        }

        private void button1_Click(object sender, System.EventArgs e)
        {
            if(comboBox1.SelectedIndex == 0)
            {
                SortNumbers();
            }
            if (comboBox1.SelectedIndex == 1)
            {
                SortStrings();
            }
        }
    }
}

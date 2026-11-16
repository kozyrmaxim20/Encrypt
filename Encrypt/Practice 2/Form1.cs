namespace Practice_2
{
    public partial class Form1 : Form
    {
        string alphabet = "АБВГДЕЁЖЗИЙКЛМНОПРСТУФХЦЧШЩЪЫЬЭЮЯ";
        string result = "";
        public Form1()
        {
            InitializeComponent();
        }

        //шифрование
        string Encrypt(string text, int shift)
        {
            text = text.ToUpper();
            string result = "";

            for (int i = 0; i < text.Length; i++)
            {
                char letter = text[i];

                if (alphabet.Contains(letter))
                {
                    int pos = alphabet.IndexOf(letter);
                    int newPos = (pos + shift);
                    if (newPos >= 33)
                    {
                        newPos = newPos - 33;
                    }
                    result = result + alphabet[newPos];
                }
                else
                {
                    result = result + letter;
                }
            }
            return result;
        }

        //Сохранение файла
        void SaveToFile(string text)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Текстовые файлы|*.txt";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                File.WriteAllText(saveFileDialog.FileName, text);

                MessageBox.Show("Файл сохранён");

            }
        }

        //Кнопка шифрования
        private void Button1_click(object sender, EventArgs e)
        {
            int shift = (int)numericUpDown1.Value;

            textBox2.Text = Encrypt(textBox1.Text, shift);

            SaveToFile(textBox2.Text);
        }

        //Кнопка выбрать файл
        private void Button2_click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Текстовые файлы|*.txt";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                result = openFileDialog.FileName;
                MessageBox.Show("Выбран файл: " + result);
            }
        }

        //Кнопка дешифрования
        private void button3_Click(object sender, EventArgs e)
        {
            string text = File.ReadAllText(result);
            int key = (int)numericUpDown2.Value;

            textBox3.Text = Encrypt(text,33 - key);

            SaveToFile(textBox3.Text);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }
    }
}

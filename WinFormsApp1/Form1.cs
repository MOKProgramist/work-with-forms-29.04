namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void calculateResult(object sender, EventArgs e)
        {
            if (listBox1.Items.Count != 0) listBox1.Items.Clear();

            double t, y, z, x;
            t = Convert.ToDouble(textBox1.Text);
            y = Convert.ToDouble(textBox3.Text);
            z = Convert.ToDouble(textBox4.Text);

            x = 3 * y * y / (4 * z - 2 * t * t);

            listBox1.Items.Add("При t=" + t);//Items.Add
            listBox1.Items.Add("y=" + y);
            listBox1.Items.Add("z=" + z);
            listBox1.Items.Add("x= " + x);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit(); // Код кнопки Закрыть
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
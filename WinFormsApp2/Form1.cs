namespace WinFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (listBox1.Items.Count != 0) listBox1.Items.Clear();

            double a, b, h, z, p;
            a = Convert.ToDouble(textBox1.Text);
            b = Convert.ToDouble(textBox2.Text);
            h = Convert.ToDouble(textBox3.Text);

            p = (3 * (Math.Pow(a, 2) + Math.Pow(b, 2)));
            z = ((Math.PI * h) / 6) * (p + Math.Pow(h, 2));

            listBox1.Items.Add("При a=" + a);//Items.Add
            listBox1.Items.Add("b=" + b);
            listBox1.Items.Add("h=" + h);
            listBox1.Items.Add("z= " + z);
        }
    }
}
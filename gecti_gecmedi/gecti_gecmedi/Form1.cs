namespace gecti_gecmedi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double test1, test2, test3, average;
            string situation;

            test1 = Convert.ToDouble(textBox1.Text);
            test2 = Convert.ToDouble(textBox2.Text);
            test3 = Convert.ToDouble(textBox3.Text);

            average = (test1 + test2 + test3) / 3;
            
            if (average >= 50) 
            {
                situation = "Successuful";
            }
            else
            {
                situation = "Unsuccessuful";
            }
            textBox4.Text = average.ToString("0.00") + " / " + situation;
        }
    }
}
namespace KvadroYr
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// �������� �����
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("������� ����������?", "Message", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.No)
                e.Cancel = true;
        }

        /// <summary>
        /// �������� ����� �� ����
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void �����ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            double a = Convert.ToDouble(textBox1.Text);
            double b = Convert.ToDouble(textBox2.Text);
            double c = Convert.ToDouble(textBox3.Text);

            double d = b * b - 4 * a * c;


            if (d < 0)
            {
                MessageBox.Show("������������ ������ ����. ������ ���.");
            }



            else if (d == 0)
            {
                double x = (-b / (2 * a));
                MessageBox.Show("������������ ����� ����. ������ ����� " + x + ".");
            }


                else
                {
                    double x1 = ((-b - Math.Sqrt(d)) / (2 * a));
                    double x2 = ((-b + Math.Sqrt(d)) / (2 * a));
                    MessageBox.Show("������������ ����� " + d + ". ������ ������ ����� " + x1 + ". ������ ������ ����� " + x2 + ".");
                }

        }


    }
}
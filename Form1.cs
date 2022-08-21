namespace KvadroYr
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Закрытие формы
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Закрыть приложение?", "Message", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.No)
                e.Cancel = true;
        }

        /// <summary>
        /// Закрытие формы из меню
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
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
                MessageBox.Show("Дискриминант меньше нуля. Корней нет.");
            }



            else if (d == 0)
            {
                double x = (-b / (2 * a));
                MessageBox.Show("Дискриминант равен нулю. Корень равен " + x + ".");
            }


                else
                {
                    double x1 = ((-b - Math.Sqrt(d)) / (2 * a));
                    double x2 = ((-b + Math.Sqrt(d)) / (2 * a));
                    MessageBox.Show("Дискриминант равен " + d + ". Первый корень равен " + x1 + ". Второй корень равен " + x2 + ".");
                }

        }


    }
}
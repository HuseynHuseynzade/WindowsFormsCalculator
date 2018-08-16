using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace WindowsFormsCalculator
{
      

    public partial class Form : System.Windows.Forms.Form
    {
        public Form()
        {
            InitializeComponent();
        }
        private void CharDedector (char simvol)
        {
            symbol = simvol;
            First = Convert.ToDouble(txt_1.Text);
            btn_C_Click(null, null);
        }

        private void AddNumber(int number)
        {
            if (txt_1.Text == "0")
            {
                txt_1.Clear();
            }
            txt_1.Text += number.ToString();
        }

        private static double First;
        private static double Second;
        private static char symbol;

        private void button6_Click(object sender, EventArgs e)
        {
            AddNumber(2);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            AddNumber(3);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            AddNumber(5);
        }

        private void button15_Click(object sender, EventArgs e)
        {
            CharDedector('-');
        }

        private void btn_topla_Click(object sender, EventArgs e)
        {
            CharDedector('+');


        }

        private void btn_9_Click(object sender, EventArgs e)
        {
            AddNumber(9);
        }

        private void btn_1_Click(object sender, EventArgs e)
        {
            AddNumber(1);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn_7_Click(object sender, EventArgs e)
        {
            AddNumber(7);
        }

        private void btn_0_Click(object sender, EventArgs e)
        {
            AddNumber(0);
        }

        private void btn_4_Click(object sender, EventArgs e)
        {
            AddNumber(4);
        }

        private void btn_6_Click(object sender, EventArgs e)
        {
            AddNumber(6);
        }

        private void btn_8_Click(object sender, EventArgs e)
        {
            AddNumber(8);
        }

        private void btn_noqte_Click(object sender, EventArgs e)
        {
            if (!txt_1.Text.Contains(','))

            txt_1.Text += ",";
        }

        private void btn_geri_Click(object sender, EventArgs e)
        {
            if (txt_1.Text.Length > 1)
            {
             txt_1.Text = txt_1.Text.Remove(txt_1.Text.Length - 1, 1);
            }
            else
                txt_1.Text = "0";
        }

        private void btn_C_Click(object sender, EventArgs e)
        {
            txt_1.Clear();
            txt_1.Text = "0";
        }

        private void btn_vurma_Click(object sender, EventArgs e)
        {
            CharDedector('*');
        }

        private void btn_bolme_Click(object sender, EventArgs e)
        {
            CharDedector('/');
        }

        private void btn_cavab_Click(object sender, EventArgs e)
        {
            if (First == default(double))
                return;
            Second = Convert.ToDouble(txt_1.Text);
            switch (symbol)
            {
                case '+': txt_1.Text = (First + Second).ToString() ;break;
                case '-': txt_1.Text = (First - Second).ToString(); break;
                case '*': txt_1.Text = (First * Second).ToString(); break;
                case '/': txt_1.Text = (First / Second).ToString(); break;
            }


        }

        private void menu_file_Click(object sender, EventArgs e)
        {

        }

        private void quitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form.ActiveForm.Close();
        }
    }
}

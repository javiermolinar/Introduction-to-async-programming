using System;
using System.Windows.Forms;

namespace MakeBreakfast
{
    public partial class Form1 : Form
    {
        private static int _counter;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private  void button1_Click(object sender, EventArgs e)
        {
            _counter++;
            Order.MakeOrder(1000000);
            label3.Text = $"Order: {_counter} is in progress";
        }
    }
}

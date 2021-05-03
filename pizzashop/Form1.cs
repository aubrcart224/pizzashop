using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pizzashop
{
    public partial class Form1 : Form
    {
        //global varibales 
        
        double baseprice = 7.00;
        double toppingprice = 1.25;
        double toppingnumber; 
        double total;

        public Form1()
        {
            InitializeComponent();
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {   try
            {
                toppingnumber = Convert.ToDouble(inputText.Text);
                total = toppingprice * toppingnumber + baseprice;
                outputLabel.Text = $"The price of the pizza with {toppingnumber} toppings is ${total} thank you.";
            }
            catch { outputLabel.Text = $"only imnput numbers"; }
        }

        private void toppingText_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

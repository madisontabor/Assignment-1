using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment_1
{
    public partial class Assignment_1 : Form
    {
        private const double pph = 10.50;

        public Assignment_1()
        {
            InitializeComponent();
        }

        private void Assignment_1_Load(object sender, EventArgs e)
        {

        }

        private void Bnsummarize_click(object sender, EventArgs e)
        {
            try
            {
                int hoursworked = int.Parse(tbxHoursworked.Text);

                double totalPay = hoursworked * pph;

                lblSummary.ForeColor = System.Drawing.Color.Black;

                lblSummary.Text = $"{tbxFirstname.Text} {tbxLastname.Text} worked {hoursworked} hours at {pph:C} an hour for a total of {totalPay:C}.";
            }
            catch(Exception)
            {
                lblSummary.ForeColor = System.Drawing.Color.Red;
                lblSummary.Text = "Invalid input";

            }
        }
        private void Bnclear_Click(object sender, EventArgs e)
        {
            tbxFirstname.Clear();
            tbxLastname.Clear();
            tbxHoursworked.Clear();
            lblSummary.Text = string.Empty;

        }
    }
    
}

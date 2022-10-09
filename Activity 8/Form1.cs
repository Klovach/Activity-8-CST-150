using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Activity_8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private static double CarbCalories(double carbGrams)
        {
            return carbGrams * 4;
        }

        private static double FatCalories(double fatGrams)
        {
            return fatGrams * 9;
        }

        private static double TotalCalories(double totalCalories, double carbGrams, double fatGrams)
        {
            return fatGrams * 9 + carbGrams * 4;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            // Clear
            txtCarbGrams.Clear();
            txtFatGrams.Clear();
            txtCarbCalories.Clear();
            txtFatCalories.Clear();
            txtTotalCalories.Clear();
            txtFatGrams.Focus(); 
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            // Exit 
            Application.Exit(); 
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            // Call CarbCalories Method
            double carbGrams = double.Parse(txtCarbGrams.Text);
            txtCarbCalories.Text = Convert.ToString(CarbCalories(carbGrams));
            // Call FatCalories Method
            double fatGrams = double.Parse(txtFatGrams.Text);
            txtFatCalories.Text = Convert.ToString(FatCalories(fatGrams));
            // Call TotalCalories Method
            double totalCalories = TotalCalories(fatGrams, carbGrams, fatGrams);
            txtTotalCalories.Text = Convert.ToString(TotalCalories(totalCalories, carbGrams, fatGrams));
        }
    }
}

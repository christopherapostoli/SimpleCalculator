using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace SimpleCalculator
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public int flgNum = 0; 
        public MainPage()
        {
            InitializeComponent();
        }

        private void BtnAdd_Clicked(object sender, EventArgs e)
        {
            chkForNums();
            if (flgNum == 0)
            {
                double a = Double.Parse(num1.Text);
                double b = Double.Parse(num2.Text);
                res.Text = (a + b).ToString();
            }
 
        }
        private void BtnSub_Clicked(object sender, EventArgs e)
        {
            chkForNums();
            if (flgNum == 0)
            {
                double a = Double.Parse(num1.Text);
                double b = Double.Parse(num2.Text);
                res.Text = (a - b).ToString();
            }
        }

        private void BtnMult_Clicked(object sender, EventArgs e)
        {
            chkForNums();
            if (flgNum == 0)
            {
                double a = Double.Parse(num1.Text);
                double b = Double.Parse(num2.Text);
                res.Text = (a * b).ToString();
            }
        }

        private void BtnDiv_Clicked(object sender, EventArgs e)
        {
            chkForNums();
            if (flgNum == 0)
            {
                double a = Double.Parse(num1.Text);
                double b = Double.Parse(num2.Text);
                res.Text = (a / b).ToString();
            }
        }

        private void BtnRem_Clicked(object sender, EventArgs e)
        {
            chkForNums();
            if (flgNum == 0)
            {
                double a = Double.Parse(num1.Text);
                double b = Double.Parse(num2.Text);
                res.Text = (a % b).ToString();
            }
        }

        private void BtnClear_Clicked(object sender, EventArgs e)
        {
            num1.Text = String.Empty;
            num2.Text = String.Empty;
            res.Text = String.Empty;
        }

        private void chkForNums()
        {
            if (Int32.TryParse(num1.Text.Trim(), out _) && Int32.TryParse(num2.Text.Trim(), out _))
            {
                flgNum = 0;
            }
            else
            {
                res.Text = "Please enter numbers only";
                flgNum = 1;
            }
        }
    }
}

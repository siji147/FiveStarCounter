﻿using System;
using System.Windows.Forms;
using System.Drawing;

namespace FiveStarCounter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //this.Icon = Properties.Resources.FormIcon;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblCopyright.Text = $"© {DateTime.Now.Year} Sijibomi Ajayi";
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        //private 


        private void btnCalculate_Click(object sender, EventArgs e)
        {
            try
            {
                int oneStar = (txtOneStar.Text == "") ? 0 : Convert.ToInt32(txtOneStar.Text);
                int twoStar = (txtTwoStar.Text == "") ? 0 : Convert.ToInt32(txtTwoStar.Text);
                int threeStar = (txtThreeStar.Text == "") ? 0 : Convert.ToInt32(txtThreeStar.Text);
                int fourStar = (txtFourStar.Text == "") ? 0 : Convert.ToInt32(txtFourStar.Text);
                int fiveStar = (txtFiveStar.Text == "") ? 0 : Convert.ToInt32(txtFiveStar.Text);
                decimal target = (txtTarget.Text == "") ? 0 : Convert.ToDecimal(txtTarget.Text);

                if (target == 5)
                {
                    MessageBox.Show("The target can not be 5");
                }


                else
                {
                    int oneFx = oneStar * 1;
                    int twoFx = twoStar * 2;
                    int threeFx = threeStar * 3;
                    int fourFx = fourStar * 4;
                    int fiveFx = fiveStar * 5;

                    int totalFx = oneFx + twoFx + threeFx + fourFx + fiveFx;
                    int totalF = oneStar + twoStar + threeStar + fourStar + fiveStar;



                    decimal requiredFiveStar = (((totalF * target) - totalFx) / (5 - target));

                    lblResult.Text = Math.Ceiling(requiredFiveStar).ToString(); 
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Something happened! \n {ex.Message}");
                
            }
            


        }

        private void lblCopyright_Click(object sender, EventArgs e)
        {
            lblCopyright.Text = $"© {DateTime.Now.Year} Sijibomi Ajayi";
            
        }
    }
}

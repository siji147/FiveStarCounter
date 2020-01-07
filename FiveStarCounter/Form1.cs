using System;
using System.Windows.Forms;

namespace FiveStarCounter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
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

                    decimal average = (decimal) totalFx / totalF;

                    decimal requiredFiveStar = (((totalF * target) - totalFx) / (5 - target));

                    lblAverage.Text = Math.Round(average, 2).ToString();
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

        private void lblResultWithAverage_Click(object sender, EventArgs e)
        {

        }

        private void btnCalculateWithAverage_Click(object sender, EventArgs e)
        {
            try
            {
                decimal average = (txtAverage.Text == "") ? 0.00m : Convert.ToDecimal(txtAverage.Text);
                decimal target = (txtTargetWithAverage.Text == "") ? 0.00m : Convert.ToDecimal(txtTargetWithAverage.Text);
                int totalSurveys = (txtTotalSurveys.Text == "") ? 0 : Convert.ToInt32(txtTotalSurveys.Text);


                if (target == 5)
                {
                    MessageBox.Show("The target can not be 5");
                }

                else
                {
                    decimal requiredFiveStar = ((target * totalSurveys) - (average * totalSurveys)) / (5 - target);
                    lblResultWithAverage.Text = Math.Ceiling(requiredFiveStar).ToString();
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show($"Something happened! \n {ex.Message}");

            }
        }

        private void lblAverage_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void lblResult_Click(object sender, EventArgs e)
        {

        }
    }
}

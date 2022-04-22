using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO; 


namespace BMI_Calculator
{
    public partial class frmBMICalc : Form
    {
        public string name;
        public string email;
        public string address;
        public string phone;
        public int heightFeet, heightInch, convertedFeetToInches, totalInches, heightSum, feetToCmSum, cmSUm, inToCmSum;
        public int weightSumKG, feetSum, inchSum, finalInchSum, weight, weightSumLB, englishBMI, metricBMI;

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            rdbtnEnglishMeasurements.Checked = default;


            int.TryParse(txtWeight.Text, out weight);
            int.TryParse(txtFeet.Text, out heightFeet);
            int.TryParse(txtInches.Text, out heightInch);


            if (rdbtnEnglishMeasurements.Checked == true)
            {
                EnglishBMICalculationWithMetricSwitch();
            }
            else if(rdbtnMetric.Checked == true)
            {
                ChangingLayoutToMetric();

                MetricBMICalculationWithEnglishSwitch();

            }
            //StreamWrite - why wont it work. what Library does it use? 
        }

        private void MetricBMICalculationWithEnglishSwitch()
        {
            metricBMI = weight / (heightFeet * heightFeet);
            txtFeet.Text = metricBMI.ToString();

            if (rdbtnEnglishMeasurements.Checked == true)
            {
                //unhide inches textbox and label
                txtInches.Enabled = true;
                lblInches.Enabled = true;

                //change ft and lbs labels back
                lblFeet.Text = "ft.";
                lblLBS.Text = "lbs.";

                //convert kg to lbs 
                weightSumLB = weight * 2; //rounded to the nearest whole number
                txtWeight.Text = weightSumLB.ToString();

                //convert height. This one sucked
                inchSum = heightFeet / 3;
                feetSum = inchSum / 12;
                finalInchSum = feetSum - inchSum;

                txtFeet.Text = feetSum.ToString();
                txtInches.Text = finalInchSum.ToString();

            }
        }

        private void EnglishBMICalculationWithMetricSwitch()
        {
            //Convert feet to inches and add inches together to do the BMI calculation
            convertedFeetToInches = heightFeet * 12;
            totalInches = convertedFeetToInches + heightInch;

            //BMI calculation
            englishBMI = weight / (totalInches * totalInches) * 703;
            txtYourBMI.Text = englishBMI.ToString();

            if (rdbtnMetric.Checked == true)
            {
                ChangingLayoutToMetric();

                //height conversion to metric
                feetToCmSum = heightFeet * 30; //convert feet to cm (rounded to the nearest whole number)
                inToCmSum = heightInch * 3; //convert in to cm (rounded up to the nearest full number)
                heightSum = feetToCmSum + inToCmSum; //combine to get total cm height
                txtFeet.Text = heightSum.ToString();

                //weight conversion to metric
                weightSumKG = weight / 2; //convert lbs to kg
                txtWeight.Text = weightSumKG.ToString();
            }
        }

        private void ChangingLayoutToMetric()
        {
            //hide inches textbox and label
            txtInches.Enabled = false;
            lblInches.Enabled = false;

            //switching the labels
            lblFeet.Text = "cm.";
            lblLBS.Text = "kg.";
        }

        public frmBMICalc()
        {
            InitializeComponent();
        }

        private void btnPhoneAndAddress_Click(object sender, EventArgs e)
        {
            frmPhoneAndAddress addMoreInfo = new frmPhoneAndAddress();

            addMoreInfo.Show();
        }

        private void frmBMICalc_Load(object sender, EventArgs e)
        {
            //Call action event 
        }

        private void AddPhoneAndAddress(string addPhoneAndAddressToFile)
        {
            //File.AppendAllText(pathToFile, addPhoneAndAddressToFile)
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hospital_Charges
{
    public partial class Form1 : Form
    {
        private const decimal DAILY_BASE_CHARGE = 350;
        private int numDays;
        private decimal medCharge, surgicalCharge, labFee, physicalRehabCharge,
                        stayCharge = 0, subtotal = 0, total = 0;
        public Form1()
        {
            InitializeComponent();
        }
        
        private void tbxPhysicalRehabCharge_TextChanged(object sender, EventArgs e)
        {
            if (tbxPhysicalRehabCharge.Text != "")
                try
                {
                    physicalRehabCharge = decimal.Parse(tbxPhysicalRehabCharge.Text);
                }
                catch (FormatException)
                {
                    MessageBox.Show("You have entered non-numeric characters",
                                     "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
        }
        private void tbxLabFee_TextChanged(object sender, EventArgs e)
        {
            if (tbxLabFee.Text != "")
                try
                {
                    labFee = decimal.Parse(tbxLabFee.Text);
                }
                catch (FormatException)
                {
                    MessageBox.Show("You have entered non-numeric characters",
                                     "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
        }
        private void tbxSurgicalCharge_TextChanged(object sender, EventArgs e)
        {
            if (tbxSurgicalCharge.Text != "")
                try
                {
                    surgicalCharge = decimal.Parse(tbxSurgicalCharge.Text);
                }
                catch (FormatException)
                {
                    MessageBox.Show("You have entered non-numeric characters",
                                     "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
        }
        private void tbxMedCharge_TextChanged(object sender, EventArgs e)
        {
            if (tbxMedCharge.Text != "")
                try
                {
                    medCharge = decimal.Parse(tbxMedCharge.Text);
                }
                catch (FormatException)
                {
                    MessageBox.Show("You have entered non-numeric characters",
                                     "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
        }             

        private void tbxNumDays_TextChanged(object sender, EventArgs e)
        {
            if (tbxNumDays.Text != "")
                try
                {
                    numDays = int.Parse(tbxNumDays.Text);
                }
                catch (FormatException)
                {
                    MessageBox.Show("You have entered non-numeric characters",
                                     "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);                    
                }
        }      

        // Calculates and returns the amount of base charges for the hospital stay
        private decimal calcStayCharges(int days)
        {
            return DAILY_BASE_CHARGE * numDays;
        }

        // Calculates and returns the amount of miscellaneous charges including 
        // medical charges, surgical charges, lab fees, and physical rehabilitation 
        // charges.
        private decimal calcMiscCharges()
        {
            return medCharge + surgicalCharge + labFee + physicalRehabCharge;
        }

        // Calculates and returns the amount of total charges including base hospital
        // stay charges and subtotal.
        private decimal calcTotalCharges()
        {
            return stayCharge + subtotal;
        }

        // Calculate Button 
        private void btnCalculate_Click(object sender, EventArgs e)
        {
            stayCharge = calcStayCharges(numDays);
            subtotal = calcMiscCharges();
            total = calcTotalCharges();

            tbxBaseStayCharge.Text = stayCharge.ToString("n2");
            tbxSubtotal.Text = subtotal.ToString("n2");
            tbxTotal.Text = total.ToString("n2");
        }

        // Clear Button
        private void btnClear_Click(object sender, EventArgs e)
        {
            numDays = 0;
            medCharge = 0;
            surgicalCharge = 0;
            labFee = 0;
            physicalRehabCharge = 0;
            stayCharge = 0;
            subtotal = 0; 
            total = 0;
            tbxNumDays.Text = "";
            tbxMedCharge.Text = "";
            tbxSurgicalCharge.Text = "";
            tbxLabFee.Text = "";
            tbxPhysicalRehabCharge.Text = "";
            tbxBaseStayCharge.Text = "";
            tbxSubtotal.Text = "";
            tbxTotal.Text = "";
        }

        // Exit Button
        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        // Omit this one...
        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}

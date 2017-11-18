using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarPrice
{
    public partial class frmCarCalc : Form
    {
        private double basePrice = 0.0;
        private double newPrice = 0.0;
        private double stereoFactor = 0.0;
        private double clearCoatFactor = 0.0;
        private double cameraFactor = 0.0;
        private double leatherFactor = 0.0;
        private double engineSizeFactor = 0.0;

        public frmCarCalc()
        {
            InitializeComponent();
        }

        private void frmCarCalc_Load(object sender, EventArgs e)
        {

        }

        private void chkPremiumStereo_CheckedChanged(object sender, EventArgs e)
        {
            if (chkPremiumStereo.Checked)
                stereoFactor = 350.00;
            else
                stereoFactor = 0.0;

            updateNewPrice();

        }

        void updateNewPrice()
        {
            basePrice = Double.Parse(txtBasePrice.Text);
            newPrice=basePrice+stereoFactor+clearCoatFactor+cameraFactor+leatherFactor+engineSizeFactor;
            txtNewPrice.Text = newPrice.ToString();

            double Tn=60.0;
            double pv = Double.Parse(txtNewPrice.Text);  	// present value is the amount of the loan
            double rt = .04 / 12; 		// 4% divide by 12 for 12 months to get periodic rate

            
            double payment = pmt(60.0, pv, rt);
            txtPayment.Text = payment.ToString();
        }

        private void chkClearCoat_CheckedChanged(object sender, EventArgs e)
        {
            if (chkClearCoat.Checked)
                clearCoatFactor = 1200.00;
            else
                clearCoatFactor = 0.0;

            updateNewPrice();

        }

        private void chkBackupCamera_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void rdoSM_CheckedChanged(object sender, EventArgs e)
        {
            //0, 1500, 2000
            if (rdoSM.Checked)
            {
                engineSizeFactor = 0;

            }
            updateNewPrice();

        }

        private void rdoMED_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoMED.Checked)
            {
                engineSizeFactor = 1500;

            }
            updateNewPrice();

        }
        
        private void rdoLRG_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoLRG.Checked)
            {
                engineSizeFactor = 2000;

            }
            updateNewPrice();

        }

        public static double iPmt(double Tn, double n, double pv, double rt)
        {
            
            double iPmt = (pv * rt *
                    ((Math.Pow((rt + 1), (Tn + 1)))
                        - Math.Pow((rt + 1), n))) / ((rt + 1) *
                        ((Math.Pow((rt + 1), Tn) - 1)));
            return iPmt;
        }

        public static double pmt(double Tn, double pv, double rt)
        {
            double pmt = (pv * rt) / (1 - Math.Pow((1 + rt), (-Tn)));
            return pmt;
        }

        public static double pPmt(double Tn, double n, double pv, double rt)
        {
            return pmt(Tn, pv, rt) - iPmt(Tn, n, pv, rt);
        }
	
    }
}

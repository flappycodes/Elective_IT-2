using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quiz1_Algabre
{
    public partial class frmPlus : Form
    {
        public frmPlus()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                frmMain main = new frmMain();
                int plus = Convert.ToInt32(main.btnPlus.Text);
                int sub = Convert.ToInt32(lbsub.Text);
                plus += Convert.ToInt32(txtplus.Text);
                int result = plus + sub;
                lbsub.Text = result.ToString();
                //MessageBox.Show(main.btnPlus.Text + " and " + result.ToString());
                main.btnPlus.Text = result.ToString();
                main.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Only number Accpept in Text Box!" + ex.Message);
            }
      
        }
        
        #region close button .
        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
        #endregion
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kenjhi
{
    public partial class frmVersion : Form
    {
        public frmVersion()
        {
            InitializeComponent();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void btnOpinion_Click(object sender, EventArgs e)
        {
            frmEnviarOpinion opinion = new frmEnviarOpinion();
            opinion.Show();
            
        }
    }
}

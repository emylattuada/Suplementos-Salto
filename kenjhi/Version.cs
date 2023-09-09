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
    public partial class Version : Form
    {
        public Version()
        {
            InitializeComponent();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void btnOpinion_Click(object sender, EventArgs e)
        {
            Enviar_Opinion opinion = new Enviar_Opinion();
            opinion.Show();
            
        }
    }
}

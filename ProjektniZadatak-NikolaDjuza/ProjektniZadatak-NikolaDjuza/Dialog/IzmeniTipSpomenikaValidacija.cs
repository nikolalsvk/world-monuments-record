using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjektniZadatak_NikolaDjuza.Dialog
{
    public partial class IzmeniTipSpomenikaValidacija : Form
    {
        public IzmeniTipSpomenikaValidacija()
        {
            InitializeComponent();
        }

        private void IzmeniTipSpomenikaValidacija_Load(object sender, EventArgs e)
        {
            
        }

        private void OkButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void CancelMyButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}

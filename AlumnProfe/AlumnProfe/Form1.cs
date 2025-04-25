using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AlumnProfe
{
    public partial class FormInicio : Form
    {
        FormAgregarPersona AgregarPersona;
        public FormInicio()
        {
            InitializeComponent();
            AgregarPersona = new FormAgregarPersona();
        }

        private void FrmAluProf_Click(object sender, EventArgs e)
        {
            AgregarPersona.Show();
        }

        private void FormInicio_Load(object sender, EventArgs e)
        {

        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Music_Manager
{
    public partial class frm_ConectarBD : Form
    {
        public frm_ConectarBD()
        {
            InitializeComponent();
        }
        
        //Botones
        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
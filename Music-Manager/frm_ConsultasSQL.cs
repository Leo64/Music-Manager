using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Music_Manager
{
    public partial class frm_ConsultasSQL : Form
    {
        public frm_ConsultasSQL()
        {
            InitializeComponent();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lst1_SelectedIndexChanged(object sender, EventArgs e)
        {
            /*
             * Aqui se van a mostrar todas las consultas utilizadas
             */
        }
    }
}
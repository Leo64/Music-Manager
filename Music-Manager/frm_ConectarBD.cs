using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace Music_Manager
{
    public partial class frm_ConectarBaseDeDatos : Form
    {
        const int MF_BYPOSITION = 0x400;
        [DllImport("User32")]
        private static extern int RemoveMenu(IntPtr hMenu, int nPosition, int wFlags);
        [DllImport("User32")]
        private static extern IntPtr GetSystemMenu(IntPtr hWnd, bool bRevert);
        [DllImport("User32")]
        private static extern int GetMenuItemCount(IntPtr hWnd);

        private int tipoAutenticacion;
        private string bd;
        private string servidor;
        private string usuario;
        private string contrasenia;

        public int TipoAutenticacion
        {
            set { tipoAutenticacion = value; }
            get { return tipoAutenticacion; }
        }

        public string Bd
        {
            set { bd = value; }
            get { return bd; }
        }

        public string Servidor
        {
            set { servidor = value; }
            get { return servidor; }
        }

        public string Usuario
        {
            set { usuario = value; }
            get { return usuario; }
        }

        public string Contrasenia
        {
            set { contrasenia = value; }
            get { return contrasenia; }
        }

        public frm_ConectarBaseDeDatos ()
        {
            InitializeComponent();

            IntPtr hMenu = GetSystemMenu(this.Handle, false);
            int menuItemCount = GetMenuItemCount(hMenu);
            RemoveMenu(hMenu, menuItemCount - 1, MF_BYPOSITION);
        }

        private void frm_ConectarBaseDeDatos_Load (object sender, EventArgs e)
        {
            EnableBoxes(false);

            cbx_Autenticacion.SelectedIndex = 0;
            cbx_Servidor.SelectedIndex = 0;
        }

        private void btn_Cancelar_Click (object sender, EventArgs e)
        {
            this.Close();
        }

        private void cbx_Autenticacion_SelectedIndexChanged (object sender, EventArgs e)
        {
            if (cbx_Autenticacion.SelectedIndex == 1) 
            {
                EnableBoxes(true);
            }
            else 
            {
                EnableBoxes(false);
                cbx_Servidor.SelectedIndex = 0;
            }
        }

        private void btn_Conectar_Click (object sender, EventArgs e)
        {
            TipoAutenticacion = cbx_Autenticacion.SelectedIndex;
            Bd = cbx_BaseDeDatos.SelectedItem.ToString();
            Servidor = cbx_Servidor.SelectedItem.ToString().ToLower();
            Usuario = tbx_Usuario.Text;
            Contrasenia = tbx_Contrasenia.Text;
        }

        /* NAME: EnableBoxes 
         * DESCRIPTION: habilita o deshabilita controles
         * PARAMETERS: bool
         * RETURNS: void
         */
        private void EnableBoxes (bool b)
        {
            foreach (Control obj in this.gbx_autenticacionSqlServer.Controls) {
                if (obj is TextBox || obj is ComboBox)
                    obj.Enabled = b;
            }

            foreach (Control obj in this.gbx_Servidor.Controls) {
                if (obj is TextBox || obj is ComboBox)
                    obj.Enabled = b;
            }
        }
    }
}
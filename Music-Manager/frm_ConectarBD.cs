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

        Sql oSql;

        public frm_ConectarBaseDeDatos ()
        {
            InitializeComponent();

            IntPtr hMenu = GetSystemMenu(this.Handle, false);
            int menuItemCount = GetMenuItemCount(hMenu);
            RemoveMenu(hMenu, menuItemCount - 1, MF_BYPOSITION);

            oSql = new Sql();
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
            if (!oSql.Conectar(cbx_Autenticacion.SelectedIndex, cbx_BaseDeDatos.SelectedItem.ToString().ToLower(), cbx_Servidor.SelectedItem.ToString(), tbx_Usuario.Text, tbx_Contrasenia.Text)) 
            {
                MessageBox.Show("Error en la conexión", "Conectar", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } 
            else 
            {
                if (MessageBox.Show("Exito en la conexión", "Conectar", MessageBoxButtons.OK, MessageBoxIcon.Information) == DialogResult.OK) 
                {
                    frm_Principal.tsslConexion.Image = global::Music_Manager.Properties.Resources.WebDatabase;
                    frm_Principal.tsslConexion.Text = "Conectado";

                    if (!oSql.sp_SeleccionNombreConjunto_Solista()) 
                    {
                        MessageBox.Show("Error en la consulta", "Consulta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    } 
                    else 
                    {
                        TreeNode rn_Conjuntos = frm_Principal.tv_Grupo.Nodes.Add("Conjuntos");
                        TreeNode rn_Solistas = frm_Principal.tv_Grupo.Nodes.Add("Solistas");

                        while (oSql.DataReader.Read()) 
                        {
                            if (Convert.ToString(oSql.DataReader["solista_conjunto"]) == "0")
                                rn_Conjuntos.Nodes.Add(Convert.ToString(oSql.DataReader.GetValue(1)));
                            else
                                rn_Solistas.Nodes.Add(Convert.ToString(oSql.DataReader.GetValue(1)));
                        }
                    }

                    this.Close();
                }
            }
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
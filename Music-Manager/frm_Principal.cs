using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace Music_Manager
{
    public partial class frm_Principal : Form
    {
        const int MF_BYPOSITION = 0x400;
        [DllImport("User32")]
        private static extern int RemoveMenu(IntPtr hMenu, int nPosition, int wFlags);
        [DllImport("User32")]
        private static extern IntPtr GetSystemMenu(IntPtr hWnd, bool bRevert);
        [DllImport("User32")]
        private static extern int GetMenuItemCount(IntPtr hWnd);

        Sql oSql;

        public frm_Principal ()
        {
            InitializeComponent();

            IntPtr hMenu = GetSystemMenu(this.Handle, false);
            int menuItemCount = GetMenuItemCount(hMenu);
            RemoveMenu(hMenu, menuItemCount - 1, MF_BYPOSITION);

            oSql = new Sql();
        }

        private void tsbAcercaDe_Click(object sender, EventArgs e)
        {
            frm_About ofrm_AcercaDe = new frm_About();
            ofrm_AcercaDe.Show();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        { 
            frm_ConsultasSQL frm_consultasSQL = new frm_ConsultasSQL();
            frm_consultasSQL.Show();
        }

        private void tsddbABD_Conectar_Click (object sender, EventArgs e)
        {
            frm_ConectarBaseDeDatos ofrm_ConectarBaseDeDatos = new frm_ConectarBaseDeDatos();
            ofrm_ConectarBaseDeDatos.ShowDialog();

            DialogResult respuesta = ofrm_ConectarBaseDeDatos.DialogResult;
            
            if (respuesta == DialogResult.OK)
            {
                if (!oSql.Conectar(ofrm_ConectarBaseDeDatos.TipoAutenticacion, ofrm_ConectarBaseDeDatos.Bd,
                ofrm_ConectarBaseDeDatos.Servidor, ofrm_ConectarBaseDeDatos.Usuario, ofrm_ConectarBaseDeDatos.Contrasenia))
                {
                    MessageBox.Show("Error en la conexión", "Conectar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if (MessageBox.Show("Exito en la conexión", "Conectar", MessageBoxButtons.OK, MessageBoxIcon.Information) == DialogResult.OK)
                    {
                        tsslConexion.Image = global::Music_Manager.Properties.Resources.WebDatabase;
                        tsslConexion.Text = "Conectado";

                        if (!oSql.sp_SeleccionNombreGrupo())
                        {
                            MessageBox.Show("Error en la consulta", "Consulta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            TreeNode rn_Conjuntos = tv_Grupo.Nodes.Add("Conjuntos");
                            TreeNode rn_Solistas = tv_Grupo.Nodes.Add("Solistas");

                            while (oSql.DataReader.Read())
                            {
                                if (Convert.ToString(oSql.DataReader["solista_conjunto"]) == "0")
                                {
                                    rn_Conjuntos.Nodes.Add(Convert.ToString(oSql.DataReader.GetValue(1)));
                                }
                                else
                                {
                                    rn_Solistas.Nodes.Add(Convert.ToString(oSql.DataReader.GetValue(1)));
                                }
                            }
                            oSql.DataReader.Close();
                        }
                    }
                }
            }
        }

        private void cerrarToolStripMenuItem_Click (object sender, EventArgs e)
        {
            this.Close();
        }

        private void tv_Grupo_AfterSelect (object sender, TreeViewEventArgs e)
        {
            tv_Grupo.SelectedNode = e.Node;

            oSql.sp_SeleccionAlbumPorGrupo(tv_Grupo.SelectedNode.Text);

            while (oSql.DataReader.Read())
                cbx_Titulo.Items.Add(Convert.ToString(oSql.DataReader.GetValue(0)));

            oSql.DataReader.Close();
        }
    }
}
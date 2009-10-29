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

        public frm_Principal ()
        {
            InitializeComponent();

            IntPtr hMenu = GetSystemMenu(this.Handle, false);
            int menuItemCount = GetMenuItemCount(hMenu);
            RemoveMenu(hMenu, menuItemCount - 1, MF_BYPOSITION);
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
        }   /* Aqui se Imprimiran las consultas que utilizemos */

        private void tsddbABD_Conectar_Click(object sender, EventArgs e)
        {
            frm_ConectarBaseDeDatos ofrm_ConectarBaseDeDatos = new frm_ConectarBaseDeDatos();
            ofrm_ConectarBaseDeDatos.Show();
        }

        private void lblComentario_Click(object sender, EventArgs e)
        {

        }   /* Muestra un resultado en la busqueda */

        private void label3_Click(object sender, EventArgs e)
        {

        }    /* Este label  muestra informacion extra */

        private void lstTemas_SelectedIndexChanged(object sender, EventArgs e)
        {

        }   /* Aqui se encontraran todos los temas del lo seleccionado en la lista anterior */

        // Arbol
        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            /* http://msdn.microsoft.com/es-es/library/t5yh0hs4.aspx */
        }

        private void cerrarToolStripMenuItem_Click (object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
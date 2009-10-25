using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace Music_Manager
{
    public partial class frm_ConsultasSQL : Form
    {
        const int MF_BYPOSITION = 0x400;

        [DllImport("User32")]
        private static extern int RemoveMenu(IntPtr hMenu, int nPosition, int wFlags);
        [DllImport("User32")]
        private static extern IntPtr GetSystemMenu(IntPtr hWnd, bool bRevert);
        [DllImport("User32")]
        private static extern int GetMenuItemCount(IntPtr hWnd);

        public frm_ConsultasSQL()
        {
            InitializeComponent();

            IntPtr hMenu = GetSystemMenu(this.Handle, false);
            int menuItemCount = GetMenuItemCount(hMenu);
            RemoveMenu(hMenu, menuItemCount - 1, MF_BYPOSITION);
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
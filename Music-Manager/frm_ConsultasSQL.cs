using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
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

        private SqlConnection conexion;
        private SqlCommand command;
        private SqlDataAdapter dataReader;
        private DataSet dataSet;
        private string stringConexion;

        public frm_ConsultasSQL()
        {
            InitializeComponent();

            IntPtr hMenu = GetSystemMenu(this.Handle, false);
            int menuItemCount = GetMenuItemCount(hMenu);
            RemoveMenu(hMenu, menuItemCount - 1, MF_BYPOSITION);

            conexion = new SqlConnection();
            command = new SqlCommand();
            dataReader = null;
            dataSet = new DataSet();
            stringConexion = @"Server=.\SQLExpress;"
                + @"AttachDbFilename=C:\Archivos de programa\Microsoft SQL Server\MSSQL.1\MSSQL\Data\libreria.mdf;"//C:\Archivos de programa\Microsoft SQL Server\MSSQL.1\MSSQL\Data\libreria.mdf;"
                + "Database=libreria;Trusted_Connection=Yes;";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;

            conexion.ConnectionString = stringConexion;
            conexion.Open();

            command.CommandText = textBox1.Text;
            command.Connection = conexion;

            SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
            dataAdapter.Fill(dataSet);

            conexion.Close();

            dataGridView1.DataSource = dataSet.Tables[0];
        }

        private void btn_Cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
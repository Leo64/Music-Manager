using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Music_Manager
{
    public partial class Form1 : Form
    {
        bool error;
        public Form1 ()
        {
            InitializeComponent();
            error = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        // Elementos de la Barra de Tareas
            // Botones menu
        private void tsbAcercaDe_Click(object sender, EventArgs e)
        {  
            frmAbout frmAbout = new frmAbout();
            frmAbout.Show();
        }   /* Informacion Sobre Nosotros */

        private void toolStripButton1_Click(object sender, EventArgs e)
        { 
            frm_ConsultasSQL frm_consultasSQL = new frm_ConsultasSQL();
            frm_consultasSQL.Show();
        }   /* Aqui se Imprimiran las consultas que utilizemos */

            // Boton Menu Conectar con BD
        private void tsddbABD_Conectar_Click(object sender, EventArgs e)
        {
            frm_ConectarBD frm_ConectarBD = new frm_ConectarBD();
            frm_ConectarBD.Show();
        }   /* Se establesera la conexion con la base de datos a utilizar */

            // Boton Menu Archivo
        private void cerrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }   /* Cierra el Formulario Principal */

        // Botones
            // Pestaña Informacion
        private void btnSuiguiente_Click(object sender, EventArgs e)
        {
            TabControl.SelectTab(1);
        }   /* Salta a la pestaña siguiente (Temas) */

        private void cmbBuscarPor_SelectedIndexChanged(object sender, EventArgs e)
        {

        }   /* Hay que colocar por que categoria se va abuscar */

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (txtValue.Text == "" || cmbBuscarPor.SelectedIndex == -1)
            {
                lblComentario.ForeColor = Color.Red;
                lblComentario.Text = "Faltan datos nesesarios para la busqueda";
            }
        }   /* Inicia la busqueda */

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            txtValue.Text = null;
            cmbBuscarPor.SelectedIndex = -1;
            lblComentario.ForeColor = Color.Black;
            lblComentario.Text = "Ingrese los datos para realizar la busqueda";
        }   /* Borra todo */

        private void lblComentario_Click(object sender, EventArgs e)
        {

        }   /* Muestra un resultado en la busqueda */

            // Pestaña Temas
        private void btnAnterior1_Click(object sender, EventArgs e)
        {
            TabControl.SelectTab(0);
        }   /* Hacia la pestaña Anterior (info)*/

        private void btnSuiguiente1_Click(object sender, EventArgs e)
        {
            TabControl.SelectTab(2);
        }   /* Hacia la pestaña siguiente (Agregar Modificar)*/

        private void label3_Click(object sender, EventArgs e)
        {

        }    /* Este label  muestra informacion extra */

        private void lstTemas_SelectedIndexChanged(object sender, EventArgs e)
        {

        }   /* Aqui se encontraran todos los temas del lo seleccionado en la lista anterior */

            // Pestaña Agregar, Modificar
        private void btnSiguiente2_Click(object sender, EventArgs e)
        {
            TabControl.SelectTab(1);
        }   /* Hacia la pestaña Anterior (temas)*/


        private void btnAnterior2_Click(object sender, EventArgs e)
        {
            TabControl.SelectTab(3);
        }   /* Hacia la pestaña siguiente (Estadistica)*/

        // Barra estado
        private void tsslConexion_Click(object sender, EventArgs e)
        {
            /* Cuando la conexion se establece se debe cambiar el icono*/

            tsslConexion.Image = Image.FromFile(@"C:\Users\Leonardo\Documents\Tecnicatura\Intergrador Lab-Prog\Music-manager\Music-Manager\Resources\Web Database.png");
        }

        // Arbol
        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            /* http://msdn.microsoft.com/es-es/library/t5yh0hs4.aspx */
        }

        //vacios
            //No Utilizado
        private void tssbArchivo_Salir_Click(object sender, EventArgs e)
        {
           
        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
        //Nuevos elememtos Generados


    }
}
namespace Music_Manager
{
    partial class frm_Principal
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario, false.</param>
        protected override void Dispose (bool disposing)
        {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent ()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Principal));
            this.tv_Grupo = new System.Windows.Forms.TreeView();
            this.ToolStrip = new System.Windows.Forms.ToolStrip();
            this.tsddb_Archivo = new System.Windows.Forms.ToolStripDropDownButton();
            this.tsmi_Archivo_Cerrar = new System.Windows.Forms.ToolStripMenuItem();
            this.tsddb_AdministradorDatos = new System.Windows.Forms.ToolStripDropDownButton();
            this.tsmi_AdministradorDatos_Conectar = new System.Windows.Forms.ToolStripMenuItem();
            this.tsl_Consultas = new System.Windows.Forms.ToolStripButton();
            this.tsl_Buscar = new System.Windows.Forms.ToolStripLabel();
            this.tsl_AcercaDe = new System.Windows.Forms.ToolStripButton();
            this.StatusStrip = new System.Windows.Forms.StatusStrip();
            this.tsslConexion = new System.Windows.Forms.ToolStripStatusLabel();
            this.tabAgregar = new System.Windows.Forms.TabPage();
            this.tabTemas = new System.Windows.Forms.TabPage();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.tabInfo = new System.Windows.Forms.TabPage();
            this.gbx_Album = new System.Windows.Forms.GroupBox();
            this.cbx_Titulo = new System.Windows.Forms.ComboBox();
            this.lbl_Observaciones = new System.Windows.Forms.Label();
            this.lbl_DuracionAlbum = new System.Windows.Forms.Label();
            this.lbl_CantidadTemas = new System.Windows.Forms.Label();
            this.lbl_FechaLanzamiento = new System.Windows.Forms.Label();
            this.lbl_FechaTerminado = new System.Windows.Forms.Label();
            this.rtbx_Observaciones = new System.Windows.Forms.RichTextBox();
            this.tbx_Duracion = new System.Windows.Forms.TextBox();
            this.tbx_CantidadTemas = new System.Windows.Forms.TextBox();
            this.dtp_FechaLanzamiento = new System.Windows.Forms.DateTimePicker();
            this.dtp_FechaTerminado = new System.Windows.Forms.DateTimePicker();
            this.lbl_Genero = new System.Windows.Forms.Label();
            this.lbl_Titulo = new System.Windows.Forms.Label();
            this.cbx_Genero = new System.Windows.Forms.ComboBox();
            this.gbx_Grupo = new System.Windows.Forms.GroupBox();
            this.lbl_CantidadIntegrantes = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.tbx_Grupo_Nombre = new System.Windows.Forms.TextBox();
            this.lbl_Grupo_Nombre = new System.Windows.Forms.Label();
            this.tc_Agregar = new System.Windows.Forms.TabControl();
            this.ToolStrip.SuspendLayout();
            this.StatusStrip.SuspendLayout();
            this.tabTemas.SuspendLayout();
            this.tabInfo.SuspendLayout();
            this.gbx_Album.SuspendLayout();
            this.gbx_Grupo.SuspendLayout();
            this.tc_Agregar.SuspendLayout();
            this.SuspendLayout();
            // 
            // tv_Grupo
            // 
            this.tv_Grupo.Location = new System.Drawing.Point(0, 28);
            this.tv_Grupo.Name = "tv_Grupo";
            this.tv_Grupo.Size = new System.Drawing.Size(199, 542);
            this.tv_Grupo.TabIndex = 1;
            this.tv_Grupo.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.tv_Grupo_AfterSelect);
            // 
            // ToolStrip
            // 
            this.ToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsddb_Archivo,
            this.tsddb_AdministradorDatos,
            this.tsl_Consultas,
            this.tsl_Buscar,
            this.tsl_AcercaDe});
            this.ToolStrip.Location = new System.Drawing.Point(0, 0);
            this.ToolStrip.Name = "ToolStrip";
            this.ToolStrip.Size = new System.Drawing.Size(825, 25);
            this.ToolStrip.TabIndex = 0;
            this.ToolStrip.Text = "ts";
            // 
            // tsddb_Archivo
            // 
            this.tsddb_Archivo.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmi_Archivo_Cerrar});
            this.tsddb_Archivo.Image = global::Music_Manager.Properties.Resources.Clipboard;
            this.tsddb_Archivo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsddb_Archivo.Name = "tsddb_Archivo";
            this.tsddb_Archivo.Size = new System.Drawing.Size(72, 22);
            this.tsddb_Archivo.Text = "Archivo";
            // 
            // tsmi_Archivo_Cerrar
            // 
            this.tsmi_Archivo_Cerrar.Image = global::Music_Manager.Properties.Resources.Exit;
            this.tsmi_Archivo_Cerrar.Name = "tsmi_Archivo_Cerrar";
            this.tsmi_Archivo_Cerrar.Size = new System.Drawing.Size(105, 22);
            this.tsmi_Archivo_Cerrar.Text = "Salir";
            this.tsmi_Archivo_Cerrar.Click += new System.EventHandler(this.cerrarToolStripMenuItem_Click);
            // 
            // tsddb_AdministradorDatos
            // 
            this.tsddb_AdministradorDatos.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmi_AdministradorDatos_Conectar});
            this.tsddb_AdministradorDatos.Image = global::Music_Manager.Properties.Resources.Database;
            this.tsddb_AdministradorDatos.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsddb_AdministradorDatos.Name = "tsddb_AdministradorDatos";
            this.tsddb_AdministradorDatos.Size = new System.Drawing.Size(148, 22);
            this.tsddb_AdministradorDatos.Text = "Administrador de Datos";
            // 
            // tsmi_AdministradorDatos_Conectar
            // 
            this.tsmi_AdministradorDatos_Conectar.Image = global::Music_Manager.Properties.Resources.NewDatabase;
            this.tsmi_AdministradorDatos_Conectar.Name = "tsmi_AdministradorDatos_Conectar";
            this.tsmi_AdministradorDatos_Conectar.Size = new System.Drawing.Size(221, 22);
            this.tsmi_AdministradorDatos_Conectar.Text = "Conectar con Base de Datos";
            this.tsmi_AdministradorDatos_Conectar.Click += new System.EventHandler(this.tsddbABD_Conectar_Click);
            // 
            // tsl_Consultas
            // 
            this.tsl_Consultas.Image = global::Music_Manager.Properties.Resources.Edit;
            this.tsl_Consultas.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsl_Consultas.Name = "tsl_Consultas";
            this.tsl_Consultas.Size = new System.Drawing.Size(74, 22);
            this.tsl_Consultas.Text = "Consultas";
            this.tsl_Consultas.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // tsl_Buscar
            // 
            this.tsl_Buscar.Image = global::Music_Manager.Properties.Resources.Search;
            this.tsl_Buscar.Name = "tsl_Buscar";
            this.tsl_Buscar.Size = new System.Drawing.Size(55, 22);
            this.tsl_Buscar.Text = "Buscar";
            // 
            // tsl_AcercaDe
            // 
            this.tsl_AcercaDe.Image = global::Music_Manager.Properties.Resources.HelpAndSupport;
            this.tsl_AcercaDe.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsl_AcercaDe.Name = "tsl_AcercaDe";
            this.tsl_AcercaDe.Size = new System.Drawing.Size(75, 22);
            this.tsl_AcercaDe.Text = "Acerca de";
            this.tsl_AcercaDe.Click += new System.EventHandler(this.tsbAcercaDe_Click);
            // 
            // StatusStrip
            // 
            this.StatusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsslConexion});
            this.StatusStrip.Location = new System.Drawing.Point(0, 577);
            this.StatusStrip.Name = "StatusStrip";
            this.StatusStrip.Size = new System.Drawing.Size(825, 22);
            this.StatusStrip.TabIndex = 3;
            this.StatusStrip.Text = "statusStrip1";
            // 
            // tsslConexion
            // 
            this.tsslConexion.Image = global::Music_Manager.Properties.Resources.DeleteDatabase;
            this.tsslConexion.Name = "tsslConexion";
            this.tsslConexion.Size = new System.Drawing.Size(91, 17);
            this.tsslConexion.Text = "Desconectado";
            // 
            // tabAgregar
            // 
            this.tabAgregar.Location = new System.Drawing.Point(4, 22);
            this.tabAgregar.Name = "tabAgregar";
            this.tabAgregar.Padding = new System.Windows.Forms.Padding(3);
            this.tabAgregar.Size = new System.Drawing.Size(610, 520);
            this.tabAgregar.TabIndex = 2;
            this.tabAgregar.Text = "Agregar";
            this.tabAgregar.UseVisualStyleBackColor = true;
            // 
            // tabTemas
            // 
            this.tabTemas.Controls.Add(this.listBox1);
            this.tabTemas.Location = new System.Drawing.Point(4, 22);
            this.tabTemas.Name = "tabTemas";
            this.tabTemas.Padding = new System.Windows.Forms.Padding(3);
            this.tabTemas.Size = new System.Drawing.Size(610, 520);
            this.tabTemas.TabIndex = 1;
            this.tabTemas.Text = "Temas";
            this.tabTemas.UseVisualStyleBackColor = true;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(95, 160);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(367, 95);
            this.listBox1.TabIndex = 0;
            // 
            // tabInfo
            // 
            this.tabInfo.Controls.Add(this.gbx_Album);
            this.tabInfo.Controls.Add(this.gbx_Grupo);
            this.tabInfo.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.tabInfo.Location = new System.Drawing.Point(4, 22);
            this.tabInfo.Name = "tabInfo";
            this.tabInfo.Padding = new System.Windows.Forms.Padding(3);
            this.tabInfo.Size = new System.Drawing.Size(610, 520);
            this.tabInfo.TabIndex = 0;
            this.tabInfo.Text = "Informacion";
            this.tabInfo.UseVisualStyleBackColor = true;
            // 
            // gbx_Album
            // 
            this.gbx_Album.Controls.Add(this.cbx_Titulo);
            this.gbx_Album.Controls.Add(this.lbl_Observaciones);
            this.gbx_Album.Controls.Add(this.lbl_DuracionAlbum);
            this.gbx_Album.Controls.Add(this.lbl_CantidadTemas);
            this.gbx_Album.Controls.Add(this.lbl_FechaLanzamiento);
            this.gbx_Album.Controls.Add(this.lbl_FechaTerminado);
            this.gbx_Album.Controls.Add(this.rtbx_Observaciones);
            this.gbx_Album.Controls.Add(this.tbx_Duracion);
            this.gbx_Album.Controls.Add(this.tbx_CantidadTemas);
            this.gbx_Album.Controls.Add(this.dtp_FechaLanzamiento);
            this.gbx_Album.Controls.Add(this.dtp_FechaTerminado);
            this.gbx_Album.Controls.Add(this.lbl_Genero);
            this.gbx_Album.Controls.Add(this.lbl_Titulo);
            this.gbx_Album.Controls.Add(this.cbx_Genero);
            this.gbx_Album.Location = new System.Drawing.Point(6, 95);
            this.gbx_Album.Name = "gbx_Album";
            this.gbx_Album.Size = new System.Drawing.Size(598, 419);
            this.gbx_Album.TabIndex = 11;
            this.gbx_Album.TabStop = false;
            this.gbx_Album.Text = "Album";
            // 
            // cbx_Titulo
            // 
            this.cbx_Titulo.FormattingEnabled = true;
            this.cbx_Titulo.Location = new System.Drawing.Point(129, 19);
            this.cbx_Titulo.Name = "cbx_Titulo";
            this.cbx_Titulo.Size = new System.Drawing.Size(358, 21);
            this.cbx_Titulo.TabIndex = 14;
            // 
            // lbl_Observaciones
            // 
            this.lbl_Observaciones.AutoSize = true;
            this.lbl_Observaciones.Location = new System.Drawing.Point(45, 179);
            this.lbl_Observaciones.Name = "lbl_Observaciones";
            this.lbl_Observaciones.Size = new System.Drawing.Size(78, 13);
            this.lbl_Observaciones.TabIndex = 13;
            this.lbl_Observaciones.Text = "Observaciones";
            // 
            // lbl_DuracionAlbum
            // 
            this.lbl_DuracionAlbum.AutoSize = true;
            this.lbl_DuracionAlbum.Location = new System.Drawing.Point(41, 153);
            this.lbl_DuracionAlbum.Name = "lbl_DuracionAlbum";
            this.lbl_DuracionAlbum.Size = new System.Drawing.Size(82, 13);
            this.lbl_DuracionAlbum.TabIndex = 12;
            this.lbl_DuracionAlbum.Text = "Duración Album";
            // 
            // lbl_CantidadTemas
            // 
            this.lbl_CantidadTemas.AutoSize = true;
            this.lbl_CantidadTemas.Location = new System.Drawing.Point(39, 127);
            this.lbl_CantidadTemas.Name = "lbl_CantidadTemas";
            this.lbl_CantidadTemas.Size = new System.Drawing.Size(84, 13);
            this.lbl_CantidadTemas.TabIndex = 11;
            this.lbl_CantidadTemas.Text = "Cantidad Temas";
            // 
            // lbl_FechaLanzamiento
            // 
            this.lbl_FechaLanzamiento.AutoSize = true;
            this.lbl_FechaLanzamiento.Location = new System.Drawing.Point(23, 102);
            this.lbl_FechaLanzamiento.Name = "lbl_FechaLanzamiento";
            this.lbl_FechaLanzamiento.Size = new System.Drawing.Size(100, 13);
            this.lbl_FechaLanzamiento.TabIndex = 10;
            this.lbl_FechaLanzamiento.Text = "Fecha Lanzamiento";
            // 
            // lbl_FechaTerminado
            // 
            this.lbl_FechaTerminado.AutoSize = true;
            this.lbl_FechaTerminado.Location = new System.Drawing.Point(33, 76);
            this.lbl_FechaTerminado.Name = "lbl_FechaTerminado";
            this.lbl_FechaTerminado.Size = new System.Drawing.Size(90, 13);
            this.lbl_FechaTerminado.TabIndex = 9;
            this.lbl_FechaTerminado.Text = "Fecha Terminado";
            // 
            // rtbx_Observaciones
            // 
            this.rtbx_Observaciones.Location = new System.Drawing.Point(129, 176);
            this.rtbx_Observaciones.Name = "rtbx_Observaciones";
            this.rtbx_Observaciones.Size = new System.Drawing.Size(358, 91);
            this.rtbx_Observaciones.TabIndex = 8;
            this.rtbx_Observaciones.Text = "";
            // 
            // tbx_Duracion
            // 
            this.tbx_Duracion.Location = new System.Drawing.Point(129, 150);
            this.tbx_Duracion.Name = "tbx_Duracion";
            this.tbx_Duracion.Size = new System.Drawing.Size(100, 20);
            this.tbx_Duracion.TabIndex = 7;
            // 
            // tbx_CantidadTemas
            // 
            this.tbx_CantidadTemas.Location = new System.Drawing.Point(129, 124);
            this.tbx_CantidadTemas.Name = "tbx_CantidadTemas";
            this.tbx_CantidadTemas.Size = new System.Drawing.Size(56, 20);
            this.tbx_CantidadTemas.TabIndex = 6;
            // 
            // dtp_FechaLanzamiento
            // 
            this.dtp_FechaLanzamiento.Location = new System.Drawing.Point(129, 98);
            this.dtp_FechaLanzamiento.Name = "dtp_FechaLanzamiento";
            this.dtp_FechaLanzamiento.Size = new System.Drawing.Size(200, 20);
            this.dtp_FechaLanzamiento.TabIndex = 5;
            // 
            // dtp_FechaTerminado
            // 
            this.dtp_FechaTerminado.Location = new System.Drawing.Point(129, 72);
            this.dtp_FechaTerminado.Name = "dtp_FechaTerminado";
            this.dtp_FechaTerminado.Size = new System.Drawing.Size(200, 20);
            this.dtp_FechaTerminado.TabIndex = 4;
            // 
            // lbl_Genero
            // 
            this.lbl_Genero.AutoSize = true;
            this.lbl_Genero.Location = new System.Drawing.Point(81, 48);
            this.lbl_Genero.Name = "lbl_Genero";
            this.lbl_Genero.Size = new System.Drawing.Size(42, 13);
            this.lbl_Genero.TabIndex = 3;
            this.lbl_Genero.Text = "Genero";
            // 
            // lbl_Titulo
            // 
            this.lbl_Titulo.AutoSize = true;
            this.lbl_Titulo.Location = new System.Drawing.Point(90, 22);
            this.lbl_Titulo.Name = "lbl_Titulo";
            this.lbl_Titulo.Size = new System.Drawing.Size(33, 13);
            this.lbl_Titulo.TabIndex = 2;
            this.lbl_Titulo.Text = "Titulo";
            // 
            // cbx_Genero
            // 
            this.cbx_Genero.FormattingEnabled = true;
            this.cbx_Genero.Location = new System.Drawing.Point(129, 45);
            this.cbx_Genero.Name = "cbx_Genero";
            this.cbx_Genero.Size = new System.Drawing.Size(174, 21);
            this.cbx_Genero.TabIndex = 1;
            // 
            // gbx_Grupo
            // 
            this.gbx_Grupo.Controls.Add(this.lbl_CantidadIntegrantes);
            this.gbx_Grupo.Controls.Add(this.textBox1);
            this.gbx_Grupo.Controls.Add(this.tbx_Grupo_Nombre);
            this.gbx_Grupo.Controls.Add(this.lbl_Grupo_Nombre);
            this.gbx_Grupo.Location = new System.Drawing.Point(6, 6);
            this.gbx_Grupo.Name = "gbx_Grupo";
            this.gbx_Grupo.Size = new System.Drawing.Size(598, 83);
            this.gbx_Grupo.TabIndex = 10;
            this.gbx_Grupo.TabStop = false;
            this.gbx_Grupo.Text = "Conjunto / Solista";
            // 
            // lbl_CantidadIntegrantes
            // 
            this.lbl_CantidadIntegrantes.AutoSize = true;
            this.lbl_CantidadIntegrantes.Location = new System.Drawing.Point(19, 48);
            this.lbl_CantidadIntegrantes.Name = "lbl_CantidadIntegrantes";
            this.lbl_CantidadIntegrantes.Size = new System.Drawing.Size(105, 13);
            this.lbl_CantidadIntegrantes.TabIndex = 11;
            this.lbl_CantidadIntegrantes.Text = "Cantidad Integrantes";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(130, 45);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(211, 20);
            this.textBox1.TabIndex = 10;
            // 
            // tbx_Grupo_Nombre
            // 
            this.tbx_Grupo_Nombre.Location = new System.Drawing.Point(130, 19);
            this.tbx_Grupo_Nombre.Name = "tbx_Grupo_Nombre";
            this.tbx_Grupo_Nombre.Size = new System.Drawing.Size(211, 20);
            this.tbx_Grupo_Nombre.TabIndex = 9;
            // 
            // lbl_Grupo_Nombre
            // 
            this.lbl_Grupo_Nombre.AutoSize = true;
            this.lbl_Grupo_Nombre.Location = new System.Drawing.Point(80, 22);
            this.lbl_Grupo_Nombre.Name = "lbl_Grupo_Nombre";
            this.lbl_Grupo_Nombre.Size = new System.Drawing.Size(44, 13);
            this.lbl_Grupo_Nombre.TabIndex = 0;
            this.lbl_Grupo_Nombre.Text = "Nombre";
            // 
            // tc_Agregar
            // 
            this.tc_Agregar.Controls.Add(this.tabInfo);
            this.tc_Agregar.Controls.Add(this.tabTemas);
            this.tc_Agregar.Controls.Add(this.tabAgregar);
            this.tc_Agregar.Location = new System.Drawing.Point(205, 24);
            this.tc_Agregar.Name = "tc_Agregar";
            this.tc_Agregar.SelectedIndex = 0;
            this.tc_Agregar.Size = new System.Drawing.Size(618, 546);
            this.tc_Agregar.TabIndex = 2;
            // 
            // frm_Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(825, 599);
            this.Controls.Add(this.StatusStrip);
            this.Controls.Add(this.ToolStrip);
            this.Controls.Add(this.tv_Grupo);
            this.Controls.Add(this.tc_Agregar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon) (resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frm_Principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Music Manager";
            this.ToolStrip.ResumeLayout(false);
            this.ToolStrip.PerformLayout();
            this.StatusStrip.ResumeLayout(false);
            this.StatusStrip.PerformLayout();
            this.tabTemas.ResumeLayout(false);
            this.tabInfo.ResumeLayout(false);
            this.gbx_Album.ResumeLayout(false);
            this.gbx_Album.PerformLayout();
            this.gbx_Grupo.ResumeLayout(false);
            this.gbx_Grupo.PerformLayout();
            this.tc_Agregar.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip ToolStrip;
        private System.Windows.Forms.StatusStrip StatusStrip;
        private System.Windows.Forms.ToolStripButton tsl_AcercaDe;
        private System.Windows.Forms.ToolStripDropDownButton tsddb_AdministradorDatos;
        private System.Windows.Forms.ToolStripMenuItem tsmi_AdministradorDatos_Conectar;
        private System.Windows.Forms.ToolStripButton tsl_Consultas;
        private System.Windows.Forms.ToolStripDropDownButton tsddb_Archivo;
        private System.Windows.Forms.ToolStripMenuItem tsmi_Archivo_Cerrar;
        private System.Windows.Forms.ToolStripLabel tsl_Buscar;
        private System.Windows.Forms.TabPage tabAgregar;
        private System.Windows.Forms.TabPage tabTemas;
        private System.Windows.Forms.TabPage tabInfo;
        private System.Windows.Forms.GroupBox gbx_Grupo;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox tbx_Grupo_Nombre;
        private System.Windows.Forms.Label lbl_Grupo_Nombre;
        private System.Windows.Forms.TabControl tc_Agregar;
        private System.Windows.Forms.GroupBox gbx_Album;
        private System.Windows.Forms.Label lbl_Titulo;
        private System.Windows.Forms.ComboBox cbx_Genero;
        private System.Windows.Forms.Label lbl_Genero;
        private System.Windows.Forms.Label lbl_FechaTerminado;
        private System.Windows.Forms.RichTextBox rtbx_Observaciones;
        private System.Windows.Forms.TextBox tbx_Duracion;
        private System.Windows.Forms.TextBox tbx_CantidadTemas;
        private System.Windows.Forms.DateTimePicker dtp_FechaLanzamiento;
        private System.Windows.Forms.DateTimePicker dtp_FechaTerminado;
        private System.Windows.Forms.Label lbl_FechaLanzamiento;
        private System.Windows.Forms.Label lbl_Observaciones;
        private System.Windows.Forms.Label lbl_DuracionAlbum;
        private System.Windows.Forms.Label lbl_CantidadTemas;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label lbl_CantidadIntegrantes;
        private System.Windows.Forms.ComboBox cbx_Titulo;
        public System.Windows.Forms.TreeView tv_Grupo;
        public System.Windows.Forms.ToolStripStatusLabel tsslConexion;
    }
}


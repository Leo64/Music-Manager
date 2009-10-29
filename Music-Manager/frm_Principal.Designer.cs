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
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Conjuntos");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Solistas");
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Principal));
            this.tc_Agregar = new System.Windows.Forms.TabControl();
            this.tabInfo = new System.Windows.Forms.TabPage();
            this.lbl_Grupo_Nombre = new System.Windows.Forms.Label();
            this.tabTemas = new System.Windows.Forms.TabPage();
            this.lblInformacion = new System.Windows.Forms.Label();
            this.lstTemas = new System.Windows.Forms.ListBox();
            this.tabAgregar = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.lbl = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.tabEstadistica = new System.Windows.Forms.TabPage();
            tv_Grupo = new System.Windows.Forms.TreeView();
            this.ToolStrip = new System.Windows.Forms.ToolStrip();
            this.StatusStrip = new System.Windows.Forms.StatusStrip();
            tsslConexion = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsddb_Archivo = new System.Windows.Forms.ToolStripDropDownButton();
            this.tsmi_Archivo_Cerrar = new System.Windows.Forms.ToolStripMenuItem();
            this.tsddb_AdministradorDatos = new System.Windows.Forms.ToolStripDropDownButton();
            this.tsmi_AdministradorDatos_Conectar = new System.Windows.Forms.ToolStripMenuItem();
            this.tsl_Buscar = new System.Windows.Forms.ToolStripLabel();
            this.tsl_Consultas = new System.Windows.Forms.ToolStripButton();
            this.tsl_AcercaDe = new System.Windows.Forms.ToolStripButton();
            this.gbx_Grupo = new System.Windows.Forms.GroupBox();
            this.tbx_Grupo_Nombre = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.tc_Agregar.SuspendLayout();
            this.tabInfo.SuspendLayout();
            this.tabTemas.SuspendLayout();
            this.tabAgregar.SuspendLayout();
            this.panel2.SuspendLayout();
            this.ToolStrip.SuspendLayout();
            this.StatusStrip.SuspendLayout();
            this.gbx_Grupo.SuspendLayout();
            this.SuspendLayout();
            // 
            // tc_Agregar
            // 
            this.tc_Agregar.Controls.Add(this.tabInfo);
            this.tc_Agregar.Controls.Add(this.tabTemas);
            this.tc_Agregar.Controls.Add(this.tabAgregar);
            this.tc_Agregar.Controls.Add(this.tabEstadistica);
            this.tc_Agregar.Location = new System.Drawing.Point(205, 24);
            this.tc_Agregar.Name = "tc_Agregar";
            this.tc_Agregar.SelectedIndex = 0;
            this.tc_Agregar.Size = new System.Drawing.Size(618, 546);
            this.tc_Agregar.TabIndex = 2;
            // 
            // tabInfo
            // 
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
            // lbl_Grupo_Nombre
            // 
            this.lbl_Grupo_Nombre.AutoSize = true;
            this.lbl_Grupo_Nombre.Location = new System.Drawing.Point(54, 22);
            this.lbl_Grupo_Nombre.Name = "lbl_Grupo_Nombre";
            this.lbl_Grupo_Nombre.Size = new System.Drawing.Size(44, 13);
            this.lbl_Grupo_Nombre.TabIndex = 0;
            this.lbl_Grupo_Nombre.Text = "Nombre";
            // 
            // tabTemas
            // 
            this.tabTemas.Controls.Add(this.lblInformacion);
            this.tabTemas.Controls.Add(this.lstTemas);
            this.tabTemas.Location = new System.Drawing.Point(4, 22);
            this.tabTemas.Name = "tabTemas";
            this.tabTemas.Padding = new System.Windows.Forms.Padding(3);
            this.tabTemas.Size = new System.Drawing.Size(610, 520);
            this.tabTemas.TabIndex = 1;
            this.tabTemas.Text = "Temas";
            this.tabTemas.UseVisualStyleBackColor = true;
            // 
            // lblInformacion
            // 
            this.lblInformacion.AutoSize = true;
            this.lblInformacion.Location = new System.Drawing.Point(6, 12);
            this.lblInformacion.Name = "lblInformacion";
            this.lblInformacion.Size = new System.Drawing.Size(211, 13);
            this.lblInformacion.TabIndex = 1;
            this.lblInformacion.Text = "No se a seleccionado ningun: Autor, Album";
            this.lblInformacion.Click += new System.EventHandler(this.label3_Click);
            // 
            // lstTemas
            // 
            this.lstTemas.FormattingEnabled = true;
            this.lstTemas.Location = new System.Drawing.Point(6, 61);
            this.lstTemas.Name = "lstTemas";
            this.lstTemas.Size = new System.Drawing.Size(596, 407);
            this.lstTemas.TabIndex = 0;
            this.lstTemas.SelectedIndexChanged += new System.EventHandler(this.lstTemas_SelectedIndexChanged);
            // 
            // tabAgregar
            // 
            this.tabAgregar.Controls.Add(this.panel2);
            this.tabAgregar.Location = new System.Drawing.Point(4, 22);
            this.tabAgregar.Name = "tabAgregar";
            this.tabAgregar.Padding = new System.Windows.Forms.Padding(3);
            this.tabAgregar.Size = new System.Drawing.Size(610, 520);
            this.tabAgregar.TabIndex = 2;
            this.tabAgregar.Text = "Agregar, Modificar";
            this.tabAgregar.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.listBox2);
            this.panel2.Controls.Add(this.textBox5);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.textBox6);
            this.panel2.Controls.Add(this.lbl);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.textBox7);
            this.panel2.Controls.Add(this.textBox8);
            this.panel2.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.panel2.Location = new System.Drawing.Point(6, 18);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(572, 292);
            this.panel2.TabIndex = 13;
            // 
            // listBox2
            // 
            this.listBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listBox2.FormattingEnabled = true;
            this.listBox2.Location = new System.Drawing.Point(24, 168);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(524, 106);
            this.listBox2.TabIndex = 11;
            // 
            // textBox5
            // 
            this.textBox5.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.textBox5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox5.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBox5.Location = new System.Drawing.Point(87, 26);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(254, 20);
            this.textBox5.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 102);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 145);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Descripcion:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(42, 66);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "Grupo:";
            // 
            // textBox6
            // 
            this.textBox6.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.textBox6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox6.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBox6.Location = new System.Drawing.Point(87, 100);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(100, 20);
            this.textBox6.TabIndex = 10;
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.Location = new System.Drawing.Point(42, 28);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(39, 13);
            this.lbl.TabIndex = 0;
            this.lbl.Text = "Artista:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(397, 28);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(45, 13);
            this.label8.TabIndex = 3;
            this.label8.Text = "Genero:";
            // 
            // textBox7
            // 
            this.textBox7.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.textBox7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox7.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBox7.Location = new System.Drawing.Point(448, 26);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(100, 20);
            this.textBox7.TabIndex = 9;
            // 
            // textBox8
            // 
            this.textBox8.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.textBox8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox8.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBox8.Location = new System.Drawing.Point(87, 64);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(254, 20);
            this.textBox8.TabIndex = 8;
            // 
            // tabEstadistica
            // 
            this.tabEstadistica.Location = new System.Drawing.Point(4, 22);
            this.tabEstadistica.Name = "tabEstadistica";
            this.tabEstadistica.Padding = new System.Windows.Forms.Padding(3);
            this.tabEstadistica.Size = new System.Drawing.Size(610, 520);
            this.tabEstadistica.TabIndex = 3;
            this.tabEstadistica.Text = "Estadisticas";
            this.tabEstadistica.UseVisualStyleBackColor = true;
            // 
            // tv_Grupo
            // 
            tv_Grupo.Location = new System.Drawing.Point(0, 28);
            tv_Grupo.Name = "tv_Grupo";
            treeNode1.Name = "Conjuntos";
            treeNode1.Text = "Conjuntos";
            treeNode2.Name = "Solistas";
            treeNode2.Text = "Solistas";
            tv_Grupo.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2});
            tv_Grupo.Size = new System.Drawing.Size(199, 542);
            tv_Grupo.TabIndex = 1;
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
            // StatusStrip
            // 
            this.StatusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            tsslConexion});
            this.StatusStrip.Location = new System.Drawing.Point(0, 577);
            this.StatusStrip.Name = "StatusStrip";
            this.StatusStrip.Size = new System.Drawing.Size(825, 22);
            this.StatusStrip.TabIndex = 3;
            this.StatusStrip.Text = "statusStrip1";
            // 
            // tsslConexion
            // 
            tsslConexion.Image = global::Music_Manager.Properties.Resources.DeleteDatabase;
            tsslConexion.Name = "tsslConexion";
            tsslConexion.Size = new System.Drawing.Size(91, 16);
            tsslConexion.Text = "Desconectado";
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
            this.tsmi_Archivo_Cerrar.Size = new System.Drawing.Size(152, 22);
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
            // tsl_Buscar
            // 
            this.tsl_Buscar.Image = global::Music_Manager.Properties.Resources.Search;
            this.tsl_Buscar.Name = "tsl_Buscar";
            this.tsl_Buscar.Size = new System.Drawing.Size(55, 22);
            this.tsl_Buscar.Text = "Buscar";
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
            // tsl_AcercaDe
            // 
            this.tsl_AcercaDe.Image = global::Music_Manager.Properties.Resources.HelpAndSupport;
            this.tsl_AcercaDe.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsl_AcercaDe.Name = "tsl_AcercaDe";
            this.tsl_AcercaDe.Size = new System.Drawing.Size(75, 22);
            this.tsl_AcercaDe.Text = "Acerca de";
            this.tsl_AcercaDe.Click += new System.EventHandler(this.tsbAcercaDe_Click);
            // 
            // gbx_Grupo
            // 
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
            // tbx_Grupo_Nombre
            // 
            this.tbx_Grupo_Nombre.Location = new System.Drawing.Point(104, 19);
            this.tbx_Grupo_Nombre.Name = "tbx_Grupo_Nombre";
            this.tbx_Grupo_Nombre.Size = new System.Drawing.Size(211, 20);
            this.tbx_Grupo_Nombre.TabIndex = 9;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(104, 46);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(211, 20);
            this.textBox1.TabIndex = 10;
            // 
            // frm_Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(825, 599);
            this.Controls.Add(this.StatusStrip);
            this.Controls.Add(this.ToolStrip);
            this.Controls.Add(tv_Grupo);
            this.Controls.Add(this.tc_Agregar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon) (resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frm_Principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Music Manager";
            this.tc_Agregar.ResumeLayout(false);
            this.tabInfo.ResumeLayout(false);
            this.tabTemas.ResumeLayout(false);
            this.tabTemas.PerformLayout();
            this.tabAgregar.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ToolStrip.ResumeLayout(false);
            this.ToolStrip.PerformLayout();
            this.StatusStrip.ResumeLayout(false);
            this.StatusStrip.PerformLayout();
            this.gbx_Grupo.ResumeLayout(false);
            this.gbx_Grupo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tc_Agregar;
        private System.Windows.Forms.TabPage tabInfo;
        private System.Windows.Forms.TabPage tabTemas;
        public static System.Windows.Forms.TreeView tv_Grupo;
        private System.Windows.Forms.ToolStrip ToolStrip;
        private System.Windows.Forms.StatusStrip StatusStrip;
        private System.Windows.Forms.TabPage tabAgregar;
        private System.Windows.Forms.TabPage tabEstadistica;
        private System.Windows.Forms.ToolStripButton tsl_AcercaDe;
        private System.Windows.Forms.ToolStripDropDownButton tsddb_AdministradorDatos;
        private System.Windows.Forms.ToolStripMenuItem tsmi_AdministradorDatos_Conectar;
        private System.Windows.Forms.Label lbl_Grupo_Nombre;
        private System.Windows.Forms.ToolStripButton tsl_Consultas;
        private System.Windows.Forms.ToolStripDropDownButton tsddb_Archivo;
        private System.Windows.Forms.ToolStripMenuItem tsmi_Archivo_Cerrar;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Label lbl;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.Label lblInformacion;
        private System.Windows.Forms.ListBox lstTemas;
        public static System.Windows.Forms.ToolStripStatusLabel tsslConexion;
        private System.Windows.Forms.ToolStripLabel tsl_Buscar;
        private System.Windows.Forms.GroupBox gbx_Grupo;
        private System.Windows.Forms.TextBox tbx_Grupo_Nombre;
        private System.Windows.Forms.TextBox textBox1;
    }
}


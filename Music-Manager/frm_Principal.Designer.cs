namespace Music_Manager
{
    partial class Form1
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
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Artista");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Album");
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.TabControl = new System.Windows.Forms.TabControl();
            this.tabInfo = new System.Windows.Forms.TabPage();
            this.grpBuscar = new System.Windows.Forms.GroupBox();
            this.lblComentario = new System.Windows.Forms.Label();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.txtValue = new System.Windows.Forms.TextBox();
            this.lblPor = new System.Windows.Forms.Label();
            this.cmbBuscarPor = new System.Windows.Forms.ComboBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSiguiente = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblGrupo = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.lblArtista = new System.Windows.Forms.Label();
            this.lblGenero = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.tabTemas = new System.Windows.Forms.TabPage();
            this.btnAnterior1 = new System.Windows.Forms.Button();
            this.btnSuiguiente1 = new System.Windows.Forms.Button();
            this.lblInformacion = new System.Windows.Forms.Label();
            this.lstTemas = new System.Windows.Forms.ListBox();
            this.tabAgregar = new System.Windows.Forms.TabPage();
            this.btnAnterior2 = new System.Windows.Forms.Button();
            this.btnSiguiente2 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.lbl = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.tabEstadistica = new System.Windows.Forms.TabPage();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsddbArchivo = new System.Windows.Forms.ToolStripDropDownButton();
            this.tsddbArchivo_Cerrar = new System.Windows.Forms.ToolStripMenuItem();
            this.tsddbAdminBD = new System.Windows.Forms.ToolStripDropDownButton();
            this.tsddbABD_Conectar = new System.Windows.Forms.ToolStripMenuItem();
            this.tsbConsultas = new System.Windows.Forms.ToolStripButton();
            this.tsbAcercaDe = new System.Windows.Forms.ToolStripButton();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tsslConexion = new System.Windows.Forms.ToolStripStatusLabel();
            this.TabControl.SuspendLayout();
            this.tabInfo.SuspendLayout();
            this.grpBuscar.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tabTemas.SuspendLayout();
            this.tabAgregar.SuspendLayout();
            this.panel2.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // TabControl
            // 
            this.TabControl.Controls.Add(this.tabInfo);
            this.TabControl.Controls.Add(this.tabTemas);
            this.TabControl.Controls.Add(this.tabAgregar);
            this.TabControl.Controls.Add(this.tabEstadistica);
            this.TabControl.Location = new System.Drawing.Point(205, 54);
            this.TabControl.Name = "TabControl";
            this.TabControl.SelectedIndex = 0;
            this.TabControl.Size = new System.Drawing.Size(618, 546);
            this.TabControl.TabIndex = 2;
            // 
            // tabInfo
            // 
            this.tabInfo.Controls.Add(this.grpBuscar);
            this.tabInfo.Controls.Add(this.panel1);
            this.tabInfo.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.tabInfo.Location = new System.Drawing.Point(4, 22);
            this.tabInfo.Name = "tabInfo";
            this.tabInfo.Padding = new System.Windows.Forms.Padding(3);
            this.tabInfo.Size = new System.Drawing.Size(610, 520);
            this.tabInfo.TabIndex = 0;
            this.tabInfo.Text = "Informacion";
            this.tabInfo.UseVisualStyleBackColor = true;
            // 
            // grpBuscar
            // 
            this.grpBuscar.Controls.Add(this.lblComentario);
            this.grpBuscar.Controls.Add(this.btnNuevo);
            this.grpBuscar.Controls.Add(this.txtValue);
            this.grpBuscar.Controls.Add(this.lblPor);
            this.grpBuscar.Controls.Add(this.cmbBuscarPor);
            this.grpBuscar.Controls.Add(this.btnBuscar);
            this.grpBuscar.Location = new System.Drawing.Point(17, 6);
            this.grpBuscar.Name = "grpBuscar";
            this.grpBuscar.Size = new System.Drawing.Size(572, 210);
            this.grpBuscar.TabIndex = 0;
            this.grpBuscar.TabStop = false;
            this.grpBuscar.Text = "Buscar";
            // 
            // lblComentario
            // 
            this.lblComentario.AutoSize = true;
            this.lblComentario.Location = new System.Drawing.Point(9, 90);
            this.lblComentario.Name = "lblComentario";
            this.lblComentario.Size = new System.Drawing.Size(208, 13);
            this.lblComentario.TabIndex = 3;
            this.lblComentario.Text = "Ingrese los datos para realizar la busqueda";
            this.lblComentario.Click += new System.EventHandler(this.lblComentario_Click);
            // 
            // btnNuevo
            // 
            this.btnNuevo.Location = new System.Drawing.Point(93, 172);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(75, 23);
            this.btnNuevo.TabIndex = 5;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // txtValue
            // 
            this.txtValue.Location = new System.Drawing.Point(41, 38);
            this.txtValue.Name = "txtValue";
            this.txtValue.Size = new System.Drawing.Size(165, 20);
            this.txtValue.TabIndex = 0;
            // 
            // lblPor
            // 
            this.lblPor.AutoSize = true;
            this.lblPor.Location = new System.Drawing.Point(212, 41);
            this.lblPor.Name = "lblPor";
            this.lblPor.Size = new System.Drawing.Size(26, 13);
            this.lblPor.TabIndex = 2;
            this.lblPor.Text = "Por:";
            this.lblPor.Click += new System.EventHandler(this.label5_Click);
            // 
            // cmbBuscarPor
            // 
            this.cmbBuscarPor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBuscarPor.FormattingEnabled = true;
            this.cmbBuscarPor.Location = new System.Drawing.Point(244, 38);
            this.cmbBuscarPor.Name = "cmbBuscarPor";
            this.cmbBuscarPor.Size = new System.Drawing.Size(198, 21);
            this.cmbBuscarPor.TabIndex = 1;
            this.cmbBuscarPor.SelectedIndexChanged += new System.EventHandler(this.cmbBuscarPor_SelectedIndexChanged);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(12, 172);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 4;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnSiguiente);
            this.panel1.Controls.Add(this.listBox1);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.lblDescripcion);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.lblGrupo);
            this.panel1.Controls.Add(this.textBox4);
            this.panel1.Controls.Add(this.lblArtista);
            this.panel1.Controls.Add(this.lblGenero);
            this.panel1.Controls.Add(this.textBox3);
            this.panel1.Controls.Add(this.textBox2);
            this.panel1.Cursor = System.Windows.Forms.Cursors.No;
            this.panel1.Location = new System.Drawing.Point(17, 222);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(593, 292);
            this.panel1.TabIndex = 1;
            // 
            // btnSiguiente
            // 
            this.btnSiguiente.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.btnSiguiente.Location = new System.Drawing.Point(510, 269);
            this.btnSiguiente.Name = "btnSiguiente";
            this.btnSiguiente.Size = new System.Drawing.Size(75, 23);
            this.btnSiguiente.TabIndex = 10;
            this.btnSiguiente.Text = "Siguiente";
            this.btnSiguiente.UseVisualStyleBackColor = true;
            this.btnSiguiente.Click += new System.EventHandler(this.btnSuiguiente_Click);
            // 
            // listBox1
            // 
            this.listBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(24, 168);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(524, 80);
            this.listBox1.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(46, 102);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "label4";
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Location = new System.Drawing.Point(21, 145);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(66, 13);
            this.lblDescripcion.TabIndex = 8;
            this.lblDescripcion.Text = "Descripcion:";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Cursor = System.Windows.Forms.Cursors.No;
            this.textBox1.Location = new System.Drawing.Point(87, 26);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(254, 20);
            this.textBox1.TabIndex = 3;
            // 
            // lblGrupo
            // 
            this.lblGrupo.AutoSize = true;
            this.lblGrupo.Location = new System.Drawing.Point(42, 66);
            this.lblGrupo.Name = "lblGrupo";
            this.lblGrupo.Size = new System.Drawing.Size(39, 13);
            this.lblGrupo.TabIndex = 1;
            this.lblGrupo.Text = "Grupo:";
            // 
            // textBox4
            // 
            this.textBox4.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.textBox4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox4.Cursor = System.Windows.Forms.Cursors.No;
            this.textBox4.Location = new System.Drawing.Point(87, 100);
            this.textBox4.Name = "textBox4";
            this.textBox4.ReadOnly = true;
            this.textBox4.Size = new System.Drawing.Size(100, 20);
            this.textBox4.TabIndex = 5;
            // 
            // lblArtista
            // 
            this.lblArtista.AutoSize = true;
            this.lblArtista.Location = new System.Drawing.Point(42, 28);
            this.lblArtista.Name = "lblArtista";
            this.lblArtista.Size = new System.Drawing.Size(39, 13);
            this.lblArtista.TabIndex = 0;
            this.lblArtista.Text = "Artista:";
            // 
            // lblGenero
            // 
            this.lblGenero.AutoSize = true;
            this.lblGenero.Location = new System.Drawing.Point(397, 28);
            this.lblGenero.Name = "lblGenero";
            this.lblGenero.Size = new System.Drawing.Size(45, 13);
            this.lblGenero.TabIndex = 6;
            this.lblGenero.Text = "Genero:";
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox3.Cursor = System.Windows.Forms.Cursors.No;
            this.textBox3.Location = new System.Drawing.Point(448, 26);
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 7;
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox2.Cursor = System.Windows.Forms.Cursors.No;
            this.textBox2.Location = new System.Drawing.Point(87, 64);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(254, 20);
            this.textBox2.TabIndex = 4;
            // 
            // tabTemas
            // 
            this.tabTemas.Controls.Add(this.btnAnterior1);
            this.tabTemas.Controls.Add(this.btnSuiguiente1);
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
            // btnAnterior1
            // 
            this.btnAnterior1.Location = new System.Drawing.Point(446, 491);
            this.btnAnterior1.Name = "btnAnterior1";
            this.btnAnterior1.Size = new System.Drawing.Size(75, 23);
            this.btnAnterior1.TabIndex = 3;
            this.btnAnterior1.Text = "Anterior";
            this.btnAnterior1.UseVisualStyleBackColor = true;
            this.btnAnterior1.Click += new System.EventHandler(this.btnAnterior1_Click);
            // 
            // btnSuiguiente1
            // 
            this.btnSuiguiente1.Location = new System.Drawing.Point(527, 491);
            this.btnSuiguiente1.Name = "btnSuiguiente1";
            this.btnSuiguiente1.Size = new System.Drawing.Size(75, 23);
            this.btnSuiguiente1.TabIndex = 2;
            this.btnSuiguiente1.Text = "Siguiente";
            this.btnSuiguiente1.UseVisualStyleBackColor = true;
            this.btnSuiguiente1.Click += new System.EventHandler(this.btnSuiguiente1_Click);
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
            this.tabAgregar.Controls.Add(this.btnAnterior2);
            this.tabAgregar.Controls.Add(this.btnSiguiente2);
            this.tabAgregar.Controls.Add(this.panel2);
            this.tabAgregar.Location = new System.Drawing.Point(4, 22);
            this.tabAgregar.Name = "tabAgregar";
            this.tabAgregar.Padding = new System.Windows.Forms.Padding(3);
            this.tabAgregar.Size = new System.Drawing.Size(610, 520);
            this.tabAgregar.TabIndex = 2;
            this.tabAgregar.Text = "Agregar, Modificar";
            this.tabAgregar.UseVisualStyleBackColor = true;
            // 
            // btnAnterior2
            // 
            this.btnAnterior2.Location = new System.Drawing.Point(446, 491);
            this.btnAnterior2.Name = "btnAnterior2";
            this.btnAnterior2.Size = new System.Drawing.Size(75, 23);
            this.btnAnterior2.TabIndex = 15;
            this.btnAnterior2.Text = "Anterior";
            this.btnAnterior2.UseVisualStyleBackColor = true;
            this.btnAnterior2.Click += new System.EventHandler(this.btnAnterior2_Click);
            // 
            // btnSiguiente2
            // 
            this.btnSiguiente2.Location = new System.Drawing.Point(527, 491);
            this.btnSiguiente2.Name = "btnSiguiente2";
            this.btnSiguiente2.Size = new System.Drawing.Size(75, 23);
            this.btnSiguiente2.TabIndex = 14;
            this.btnSiguiente2.Text = "Suiguiente";
            this.btnSiguiente2.UseVisualStyleBackColor = true;
            this.btnSiguiente2.Click += new System.EventHandler(this.btnSiguiente2_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.listBox2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.textBox5);
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
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(0, 54);
            this.treeView1.Name = "treeView1";
            treeNode1.ForeColor = System.Drawing.Color.Blue;
            treeNode1.Name = "NodeArtista";
            treeNode1.Text = "Artista";
            treeNode2.ForeColor = System.Drawing.Color.Blue;
            treeNode2.Name = "NodeAlbum";
            treeNode2.Text = "Album";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2});
            this.treeView1.Size = new System.Drawing.Size(199, 542);
            this.treeView1.TabIndex = 1;
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsddbArchivo,
            this.tsddbAdminBD,
            this.tsbConsultas,
            this.tsbAcercaDe});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(823, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            this.toolStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.toolStrip1_ItemClicked);
            // 
            // tsddbArchivo
            // 
            this.tsddbArchivo.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsddbArchivo_Cerrar});
            this.tsddbArchivo.Image = global::Music_Manager.Properties.Resources.Clipboard;
            this.tsddbArchivo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsddbArchivo.Name = "tsddbArchivo";
            this.tsddbArchivo.Size = new System.Drawing.Size(72, 22);
            this.tsddbArchivo.Text = "Archivo";
            // 
            // tsddbArchivo_Cerrar
            // 
            this.tsddbArchivo_Cerrar.Name = "tsddbArchivo_Cerrar";
            this.tsddbArchivo_Cerrar.Size = new System.Drawing.Size(116, 22);
            this.tsddbArchivo_Cerrar.Text = "Cerrar";
            this.tsddbArchivo_Cerrar.Click += new System.EventHandler(this.cerrarToolStripMenuItem_Click);
            // 
            // tsddbAdminBD
            // 
            this.tsddbAdminBD.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsddbABD_Conectar});
            this.tsddbAdminBD.Image = global::Music_Manager.Properties.Resources.Database_3;
            this.tsddbAdminBD.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsddbAdminBD.Name = "tsddbAdminBD";
            this.tsddbAdminBD.Size = new System.Drawing.Size(148, 22);
            this.tsddbAdminBD.Text = "Administrador de Datos";
            // 
            // tsddbABD_Conectar
            // 
            this.tsddbABD_Conectar.Image = global::Music_Manager.Properties.Resources.New_Database;
            this.tsddbABD_Conectar.Name = "tsddbABD_Conectar";
            this.tsddbABD_Conectar.Size = new System.Drawing.Size(221, 22);
            this.tsddbABD_Conectar.Text = "Conectar con Base de Datos";
            this.tsddbABD_Conectar.Click += new System.EventHandler(this.tsddbABD_Conectar_Click);
            // 
            // tsbConsultas
            // 
            this.tsbConsultas.Image = global::Music_Manager.Properties.Resources.Edit;
            this.tsbConsultas.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbConsultas.Name = "tsbConsultas";
            this.tsbConsultas.Size = new System.Drawing.Size(74, 22);
            this.tsbConsultas.Text = "Consultas";
            this.tsbConsultas.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // tsbAcercaDe
            // 
            this.tsbAcercaDe.Image = global::Music_Manager.Properties.Resources.Help_and_Support;
            this.tsbAcercaDe.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbAcercaDe.Name = "tsbAcercaDe";
            this.tsbAcercaDe.Size = new System.Drawing.Size(75, 22);
            this.tsbAcercaDe.Text = "Acerca de";
            this.tsbAcercaDe.Click += new System.EventHandler(this.tsbAcercaDe_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsslConexion});
            this.statusStrip1.Location = new System.Drawing.Point(0, 603);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(823, 22);
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // tsslConexion
            // 
            this.tsslConexion.Image = global::Music_Manager.Properties.Resources.Delete_Database;
            this.tsslConexion.Name = "tsslConexion";
            this.tsslConexion.Size = new System.Drawing.Size(91, 17);
            this.tsslConexion.Text = "Desconectado";
            this.tsslConexion.Click += new System.EventHandler(this.tsslConexion_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(823, 625);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.treeView1);
            this.Controls.Add(this.TabControl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Music-Manager";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.TabControl.ResumeLayout(false);
            this.tabInfo.ResumeLayout(false);
            this.grpBuscar.ResumeLayout(false);
            this.grpBuscar.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabTemas.ResumeLayout(false);
            this.tabTemas.PerformLayout();
            this.tabAgregar.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl TabControl;
        private System.Windows.Forms.TabPage tabInfo;
        private System.Windows.Forms.TabPage tabTemas;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.TabPage tabAgregar;
        private System.Windows.Forms.TabPage tabEstadistica;
        private System.Windows.Forms.ToolStripButton tsbAcercaDe;
        private System.Windows.Forms.ToolStripDropDownButton tsddbAdminBD;
        private System.Windows.Forms.ToolStripMenuItem tsddbABD_Conectar;
        private System.Windows.Forms.Label lblArtista;
        private System.Windows.Forms.ToolStripButton tsbConsultas;
        private System.Windows.Forms.ToolStripDropDownButton tsddbArchivo;
        private System.Windows.Forms.ToolStripMenuItem tsddbArchivo_Cerrar;
        private System.Windows.Forms.Label lblGrupo;
        private System.Windows.Forms.Label lblPor;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblGenero;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListBox listBox1;
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
        private System.Windows.Forms.TextBox txtValue;
        private System.Windows.Forms.ComboBox cmbBuscarPor;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.GroupBox grpBuscar;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Label lblComentario;
        private System.Windows.Forms.Button btnSiguiente;
        private System.Windows.Forms.Button btnAnterior1;
        private System.Windows.Forms.Button btnSuiguiente1;
        private System.Windows.Forms.Label lblInformacion;
        private System.Windows.Forms.ListBox lstTemas;
        private System.Windows.Forms.Button btnAnterior2;
        private System.Windows.Forms.Button btnSiguiente2;
        private System.Windows.Forms.ToolStripStatusLabel tsslConexion;
    }
}


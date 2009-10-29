namespace Music_Manager
{
    partial class frm_ConectarBaseDeDatos
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_ConectarBaseDeDatos));
            this.lbl_Usuario = new System.Windows.Forms.Label();
            this.lbl_Contrasena = new System.Windows.Forms.Label();
            this.lbl_BaseDeDatos = new System.Windows.Forms.Label();
            this.tbx_Usuario = new System.Windows.Forms.TextBox();
            this.tbx_Contrasenia = new System.Windows.Forms.TextBox();
            this.btn_Cancelar = new System.Windows.Forms.Button();
            this.btn_Conectar = new System.Windows.Forms.Button();
            this.cbx_BaseDeDatos = new System.Windows.Forms.ComboBox();
            this.lbl_Autenticacion = new System.Windows.Forms.Label();
            this.cbx_Autenticacion = new System.Windows.Forms.ComboBox();
            this.gbx_autenticacionBd = new System.Windows.Forms.GroupBox();
            this.cbx_Servidor = new System.Windows.Forms.ComboBox();
            this.lbl_Servidor = new System.Windows.Forms.Label();
            this.gbx_autenticacionSqlServer = new System.Windows.Forms.GroupBox();
            this.gbx_Servidor = new System.Windows.Forms.GroupBox();
            this.gbx_autenticacionBd.SuspendLayout();
            this.gbx_autenticacionSqlServer.SuspendLayout();
            this.gbx_Servidor.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_Usuario
            // 
            this.lbl_Usuario.AutoSize = true;
            this.lbl_Usuario.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Usuario.Location = new System.Drawing.Point(45, 22);
            this.lbl_Usuario.Name = "lbl_Usuario";
            this.lbl_Usuario.Size = new System.Drawing.Size(43, 13);
            this.lbl_Usuario.TabIndex = 0;
            this.lbl_Usuario.Text = "Usuario";
            // 
            // lbl_Contrasena
            // 
            this.lbl_Contrasena.AutoSize = true;
            this.lbl_Contrasena.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Contrasena.Location = new System.Drawing.Point(27, 48);
            this.lbl_Contrasena.Name = "lbl_Contrasena";
            this.lbl_Contrasena.Size = new System.Drawing.Size(61, 13);
            this.lbl_Contrasena.TabIndex = 1;
            this.lbl_Contrasena.Text = "Contraseña";
            // 
            // lbl_BaseDeDatos
            // 
            this.lbl_BaseDeDatos.AutoSize = true;
            this.lbl_BaseDeDatos.BackColor = System.Drawing.Color.Transparent;
            this.lbl_BaseDeDatos.Location = new System.Drawing.Point(11, 49);
            this.lbl_BaseDeDatos.Name = "lbl_BaseDeDatos";
            this.lbl_BaseDeDatos.Size = new System.Drawing.Size(77, 13);
            this.lbl_BaseDeDatos.TabIndex = 2;
            this.lbl_BaseDeDatos.Text = "Base de Datos";
            // 
            // tbx_Usuario
            // 
            this.tbx_Usuario.Location = new System.Drawing.Point(94, 19);
            this.tbx_Usuario.Name = "tbx_Usuario";
            this.tbx_Usuario.Size = new System.Drawing.Size(164, 20);
            this.tbx_Usuario.TabIndex = 0;
            // 
            // tbx_Contrasenia
            // 
            this.tbx_Contrasenia.Location = new System.Drawing.Point(94, 45);
            this.tbx_Contrasenia.Name = "tbx_Contrasenia";
            this.tbx_Contrasenia.PasswordChar = '*';
            this.tbx_Contrasenia.Size = new System.Drawing.Size(164, 20);
            this.tbx_Contrasenia.TabIndex = 1;
            // 
            // btn_Cancelar
            // 
            this.btn_Cancelar.Location = new System.Drawing.Point(211, 248);
            this.btn_Cancelar.Name = "btn_Cancelar";
            this.btn_Cancelar.Size = new System.Drawing.Size(75, 23);
            this.btn_Cancelar.TabIndex = 7;
            this.btn_Cancelar.Text = "Cancelar";
            this.btn_Cancelar.UseVisualStyleBackColor = true;
            this.btn_Cancelar.Click += new System.EventHandler(this.btn_Cancelar_Click);
            // 
            // btn_Conectar
            // 
            this.btn_Conectar.Location = new System.Drawing.Point(130, 248);
            this.btn_Conectar.Name = "btn_Conectar";
            this.btn_Conectar.Size = new System.Drawing.Size(75, 23);
            this.btn_Conectar.TabIndex = 8;
            this.btn_Conectar.Text = "Conectar";
            this.btn_Conectar.UseVisualStyleBackColor = true;
            this.btn_Conectar.Click += new System.EventHandler(this.btn_Conectar_Click);
            // 
            // cbx_BaseDeDatos
            // 
            this.cbx_BaseDeDatos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx_BaseDeDatos.FormattingEnabled = true;
            this.cbx_BaseDeDatos.Items.AddRange(new object[] {
            "Cd"});
            this.cbx_BaseDeDatos.Location = new System.Drawing.Point(94, 46);
            this.cbx_BaseDeDatos.Name = "cbx_BaseDeDatos";
            this.cbx_BaseDeDatos.Size = new System.Drawing.Size(164, 21);
            this.cbx_BaseDeDatos.TabIndex = 1;
            // 
            // lbl_Autenticacion
            // 
            this.lbl_Autenticacion.AutoSize = true;
            this.lbl_Autenticacion.Location = new System.Drawing.Point(16, 22);
            this.lbl_Autenticacion.Name = "lbl_Autenticacion";
            this.lbl_Autenticacion.Size = new System.Drawing.Size(72, 13);
            this.lbl_Autenticacion.TabIndex = 10;
            this.lbl_Autenticacion.Text = "Autenticación";
            // 
            // cbx_Autenticacion
            // 
            this.cbx_Autenticacion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx_Autenticacion.FormattingEnabled = true;
            this.cbx_Autenticacion.Items.AddRange(new object[] {
            "Autenticación de Windows",
            "Autenticación de Sql Server"});
            this.cbx_Autenticacion.Location = new System.Drawing.Point(94, 19);
            this.cbx_Autenticacion.Name = "cbx_Autenticacion";
            this.cbx_Autenticacion.Size = new System.Drawing.Size(164, 21);
            this.cbx_Autenticacion.TabIndex = 0;
            this.cbx_Autenticacion.SelectedIndexChanged += new System.EventHandler(this.cbx_Autenticacion_SelectedIndexChanged);
            // 
            // gbx_autenticacionBd
            // 
            this.gbx_autenticacionBd.Controls.Add(this.cbx_Autenticacion);
            this.gbx_autenticacionBd.Controls.Add(this.cbx_BaseDeDatos);
            this.gbx_autenticacionBd.Controls.Add(this.lbl_Autenticacion);
            this.gbx_autenticacionBd.Controls.Add(this.lbl_BaseDeDatos);
            this.gbx_autenticacionBd.Location = new System.Drawing.Point(12, 12);
            this.gbx_autenticacionBd.Name = "gbx_autenticacionBd";
            this.gbx_autenticacionBd.Size = new System.Drawing.Size(275, 81);
            this.gbx_autenticacionBd.TabIndex = 12;
            this.gbx_autenticacionBd.TabStop = false;
            this.gbx_autenticacionBd.Text = "Autenticación y BD";
            // 
            // cbx_Servidor
            // 
            this.cbx_Servidor.FormattingEnabled = true;
            this.cbx_Servidor.Items.AddRange(new object[] {
            "SQLEXPRESS",
            "SNOWBALL"});
            this.cbx_Servidor.Location = new System.Drawing.Point(94, 19);
            this.cbx_Servidor.Name = "cbx_Servidor";
            this.cbx_Servidor.Size = new System.Drawing.Size(164, 21);
            this.cbx_Servidor.TabIndex = 2;
            // 
            // lbl_Servidor
            // 
            this.lbl_Servidor.AutoSize = true;
            this.lbl_Servidor.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Servidor.Location = new System.Drawing.Point(42, 22);
            this.lbl_Servidor.Name = "lbl_Servidor";
            this.lbl_Servidor.Size = new System.Drawing.Size(46, 13);
            this.lbl_Servidor.TabIndex = 14;
            this.lbl_Servidor.Text = "Servidor";
            // 
            // gbx_autenticacionSqlServer
            // 
            this.gbx_autenticacionSqlServer.Controls.Add(this.tbx_Usuario);
            this.gbx_autenticacionSqlServer.Controls.Add(this.lbl_Usuario);
            this.gbx_autenticacionSqlServer.Controls.Add(this.lbl_Contrasena);
            this.gbx_autenticacionSqlServer.Controls.Add(this.tbx_Contrasenia);
            this.gbx_autenticacionSqlServer.Location = new System.Drawing.Point(12, 162);
            this.gbx_autenticacionSqlServer.Name = "gbx_autenticacionSqlServer";
            this.gbx_autenticacionSqlServer.Size = new System.Drawing.Size(275, 80);
            this.gbx_autenticacionSqlServer.TabIndex = 15;
            this.gbx_autenticacionSqlServer.TabStop = false;
            this.gbx_autenticacionSqlServer.Text = "Autenticacion de Sql Server";
            // 
            // gbx_Servidor
            // 
            this.gbx_Servidor.Controls.Add(this.cbx_Servidor);
            this.gbx_Servidor.Controls.Add(this.lbl_Servidor);
            this.gbx_Servidor.Location = new System.Drawing.Point(12, 100);
            this.gbx_Servidor.Name = "gbx_Servidor";
            this.gbx_Servidor.Size = new System.Drawing.Size(274, 56);
            this.gbx_Servidor.TabIndex = 16;
            this.gbx_Servidor.TabStop = false;
            this.gbx_Servidor.Text = "Servidor";
            // 
            // frm_ConectarBaseDeDatos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(298, 280);
            this.Controls.Add(this.gbx_Servidor);
            this.Controls.Add(this.gbx_autenticacionSqlServer);
            this.Controls.Add(this.gbx_autenticacionBd);
            this.Controls.Add(this.btn_Conectar);
            this.Controls.Add(this.btn_Cancelar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon) (resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_ConectarBaseDeDatos";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Conectar";
            this.Load += new System.EventHandler(this.frm_ConectarBaseDeDatos_Load);
            this.gbx_autenticacionBd.ResumeLayout(false);
            this.gbx_autenticacionBd.PerformLayout();
            this.gbx_autenticacionSqlServer.ResumeLayout(false);
            this.gbx_autenticacionSqlServer.PerformLayout();
            this.gbx_Servidor.ResumeLayout(false);
            this.gbx_Servidor.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbl_Usuario;
        private System.Windows.Forms.Label lbl_Contrasena;
        private System.Windows.Forms.Label lbl_BaseDeDatos;
        private System.Windows.Forms.TextBox tbx_Usuario;
        private System.Windows.Forms.TextBox tbx_Contrasenia;
        private System.Windows.Forms.Button btn_Cancelar;
        private System.Windows.Forms.Button btn_Conectar;
        private System.Windows.Forms.ComboBox cbx_BaseDeDatos;
        private System.Windows.Forms.Label lbl_Autenticacion;
        private System.Windows.Forms.ComboBox cbx_Autenticacion;
        private System.Windows.Forms.GroupBox gbx_autenticacionBd;
        private System.Windows.Forms.ComboBox cbx_Servidor;
        private System.Windows.Forms.Label lbl_Servidor;
        private System.Windows.Forms.GroupBox gbx_autenticacionSqlServer;
        private System.Windows.Forms.GroupBox gbx_Servidor;
    }
}
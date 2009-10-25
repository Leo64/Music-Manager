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
            this.tbx_Contrasena = new System.Windows.Forms.TextBox();
            this.btn_Cancelar = new System.Windows.Forms.Button();
            this.btn_Conectar = new System.Windows.Forms.Button();
            this.cbx_Bd = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lbl_Usuario
            // 
            this.lbl_Usuario.AutoSize = true;
            this.lbl_Usuario.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Usuario.Location = new System.Drawing.Point(38, 15);
            this.lbl_Usuario.Name = "lbl_Usuario";
            this.lbl_Usuario.Size = new System.Drawing.Size(43, 13);
            this.lbl_Usuario.TabIndex = 0;
            this.lbl_Usuario.Text = "Usuario";
            // 
            // lbl_Contrasena
            // 
            this.lbl_Contrasena.AutoSize = true;
            this.lbl_Contrasena.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Contrasena.Location = new System.Drawing.Point(20, 41);
            this.lbl_Contrasena.Name = "lbl_Contrasena";
            this.lbl_Contrasena.Size = new System.Drawing.Size(61, 13);
            this.lbl_Contrasena.TabIndex = 1;
            this.lbl_Contrasena.Text = "Contraseña";
            // 
            // lbl_BaseDeDatos
            // 
            this.lbl_BaseDeDatos.AutoSize = true;
            this.lbl_BaseDeDatos.BackColor = System.Drawing.Color.Transparent;
            this.lbl_BaseDeDatos.Location = new System.Drawing.Point(4, 67);
            this.lbl_BaseDeDatos.Name = "lbl_BaseDeDatos";
            this.lbl_BaseDeDatos.Size = new System.Drawing.Size(77, 13);
            this.lbl_BaseDeDatos.TabIndex = 2;
            this.lbl_BaseDeDatos.Text = "Base de Datos";
            // 
            // tbx_Usuario
            // 
            this.tbx_Usuario.Location = new System.Drawing.Point(87, 12);
            this.tbx_Usuario.Name = "tbx_Usuario";
            this.tbx_Usuario.Size = new System.Drawing.Size(164, 20);
            this.tbx_Usuario.TabIndex = 3;
            // 
            // tbx_Contrasena
            // 
            this.tbx_Contrasena.Location = new System.Drawing.Point(87, 38);
            this.tbx_Contrasena.Name = "tbx_Contrasena";
            this.tbx_Contrasena.PasswordChar = '*';
            this.tbx_Contrasena.Size = new System.Drawing.Size(164, 20);
            this.tbx_Contrasena.TabIndex = 4;
            // 
            // btn_Cancelar
            // 
            this.btn_Cancelar.Location = new System.Drawing.Point(177, 91);
            this.btn_Cancelar.Name = "btn_Cancelar";
            this.btn_Cancelar.Size = new System.Drawing.Size(75, 23);
            this.btn_Cancelar.TabIndex = 7;
            this.btn_Cancelar.Text = "Cancelar";
            this.btn_Cancelar.UseVisualStyleBackColor = true;
            this.btn_Cancelar.Click += new System.EventHandler(this.btn_Cancelar_Click);
            // 
            // btn_Conectar
            // 
            this.btn_Conectar.Location = new System.Drawing.Point(96, 91);
            this.btn_Conectar.Name = "btn_Conectar";
            this.btn_Conectar.Size = new System.Drawing.Size(75, 23);
            this.btn_Conectar.TabIndex = 8;
            this.btn_Conectar.Text = "Conectar";
            this.btn_Conectar.UseVisualStyleBackColor = true;
            // 
            // cbx_Bd
            // 
            this.cbx_Bd.FormattingEnabled = true;
            this.cbx_Bd.Location = new System.Drawing.Point(87, 64);
            this.cbx_Bd.Name = "cbx_Bd";
            this.cbx_Bd.Size = new System.Drawing.Size(164, 21);
            this.cbx_Bd.TabIndex = 9;
            // 
            // frm_ConectarBaseDeDatos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(263, 119);
            this.Controls.Add(this.cbx_Bd);
            this.Controls.Add(this.btn_Conectar);
            this.Controls.Add(this.btn_Cancelar);
            this.Controls.Add(this.tbx_Contrasena);
            this.Controls.Add(this.tbx_Usuario);
            this.Controls.Add(this.lbl_BaseDeDatos);
            this.Controls.Add(this.lbl_Contrasena);
            this.Controls.Add(this.lbl_Usuario);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_ConectarBaseDeDatos";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Conectar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Usuario;
        private System.Windows.Forms.Label lbl_Contrasena;
        private System.Windows.Forms.Label lbl_BaseDeDatos;
        private System.Windows.Forms.TextBox tbx_Usuario;
        private System.Windows.Forms.TextBox tbx_Contrasena;
        private System.Windows.Forms.Button btn_Cancelar;
        private System.Windows.Forms.Button btn_Conectar;
        private System.Windows.Forms.ComboBox cbx_Bd;
    }
}
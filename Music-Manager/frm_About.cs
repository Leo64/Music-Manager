using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using System.Reflection;

namespace Music_Manager
{
    partial class frm_About : Form
    {
        public frm_About()
        {
            InitializeComponent();

            //  Inicializar AboutBox para mostrar la información del producto desde la información del ensamblado.
            //  Cambiar la configuración de la información del ensamblado correspondiente a su aplicación desde:
            //  - Proyecto->Propiedades->Aplicación->Información del ensamblado
            //  - AssemblyInfo.cs
            this.Text = String.Format("Acerca de {0}", AssemblyTitle);
            this.labelProductName.Text = AssemblyProduct;
            this.labelVersion.Text = String.Format("Versión {0}", AssemblyVersion);
            this.labelCopyright.Text = AssemblyCopyright;
            this.labelCompanyName.Text = AssemblyCompany;
            this.textBoxDescription.Text = AssemblyDescription;
            textBoxDescription.Multiline = true;
        }

        #region Descriptores de acceso de atributos de ensamblado

        public string AssemblyTitle
        {
            get
            {
                // Obtener todos los atributos Title en este ensamblado
                object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyTitleAttribute), false);
                // Si hay al menos un atributo Title
                if (attributes.Length > 0)
                {
                    // Seleccione el primero
                    AssemblyTitleAttribute titleAttribute = (AssemblyTitleAttribute)attributes[0];
                    // Si no es una cadena vacía, devuélvalo
                    if (titleAttribute.Title != "")
                        return titleAttribute.Title;
                }
                // Si no había ningún atributo Title, o si el atributo Title era una cadena vacía, devuelva el nombre del archivo .exe
                return System.IO.Path.GetFileNameWithoutExtension(Assembly.GetExecutingAssembly().CodeBase);
            }
        }

        public string AssemblyVersion
        {
            get
            {
                return Assembly.GetExecutingAssembly().GetName().Version.ToString();
            }
        }

        public string AssemblyDescription
        {
            get
            {
                // Obtener todos los atributos de descripción de este ensamblado
                object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyDescriptionAttribute), false);
                // Si no hay ningún atributo de descripción, devuelva una cadena vacía
                if (attributes.Length == 0)
                    return "";
                // Si hay un atributo de descripción, devuelva su valor
                return ((AssemblyDescriptionAttribute)attributes[0]).Description;
            }
        }

        public string AssemblyProduct
        {
            get
            {
                // Obtenga todos los atributos del producto de este ensamblado
                object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyProductAttribute), false);
                // Si no hay atributos del producto, devuelva una cadena vacía
                if (attributes.Length == 0)
                    return "";
                // Si hay un atributo de producto, devuelva su valor
                return ((AssemblyProductAttribute)attributes[0]).Product;
            }
        }

        public string AssemblyCopyright
        {
            get
            {
                // Obtenga todos los atributos de copyright de este ensamblado
                object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyCopyrightAttribute), false);
                // Si no hay atributos de copyright, devuelva una cadena vacía
                if (attributes.Length == 0)
                    return "";
                // Si hay un atributo de copyright, devuelva su valor
                return ((AssemblyCopyrightAttribute)attributes[0]).Copyright;
            }
        }

        public string AssemblyCompany
        {
            get
            {
                // Obtenga todos los atributos de compañía en este ensamblado
                object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyCompanyAttribute), false);
                // Si no hay ningún atributo de compañía, devuelva una cadena vacía
                if (attributes.Length == 0)
                    return "";
                // Si hay un atributo de compañía, devuelva su valor
                return ((AssemblyCompanyAttribute)attributes[0]).Company;
            }
        }
        #endregion

        private void okButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBoxDescription_TextChanged(object sender, EventArgs e)
        {
            //textBoxDescription.Lines = 
            textBoxDescription.Text = "Integrantes del grupo:" +
                Environment.NewLine + " • Back, Leonardo" +
                Environment.NewLine + " • Fassi, Claudio" +
                Environment.NewLine + " • Mastroviti, Nicolas";
        }
    }
}

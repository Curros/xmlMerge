using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Xml;

namespace xmlMerge
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        #region Acciones Botones
        private void btnOrg_Click(object sender, EventArgs e)
        {
            // Create an instance of the open file dialog box.
            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            // Set filter options and filter index.
            openFileDialog1.Filter = "XML Files (.xml)|*.xml|All Files (*.*)|*.*";
            openFileDialog1.FilterIndex = 1;
            openFileDialog1.Multiselect = false;

            // Process input if the user clicked OK.
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                this.txtOriginal.Text = openFileDialog1.FileName;
            }
        }

        private void btnTraducido_Click(object sender, EventArgs e)
        {
            // Create an instance of the open file dialog box.
            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            // Set filter options and filter index.
            openFileDialog1.Filter = "XML Files (.xml)|*.xml|All Files (*.*)|*.*";
            openFileDialog1.FilterIndex = 1;
            openFileDialog1.Multiselect = false;

            // Process input if the user clicked OK.
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                this.txtTraducido.Text = openFileDialog1.FileName;
            }

        }

        private void btnRuta_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();

            saveFileDialog1.Filter = "XML Files (.xml)|*.xml|All Files (*.*)|*.*";
            saveFileDialog1.FilterIndex = 1;
            saveFileDialog1.RestoreDirectory = true;

            // Process input if the user clicked OK.
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                this.txtRuta.Text = saveFileDialog1.FileName;
            }

        }

        
        private void btnGenerar_Click(object sender, EventArgs e)
        {
            if ( validaciones() )
            {
                generarXml();
            } else {
                MessageBox.Show("Faltan datos para poder generar el xml.","Faltan datos!");
            }
        }

        private void rbStrings_CheckedChanged(object sender, EventArgs e)
        {
            if (this.rbStrings.Checked)
            {
                this.gprConfig.Enabled = true;
            }
            else
            {
                this.gprConfig.Enabled = false;
            }
        }


        #endregion

        private void generarXml() {
            int contador = 0;
            if (File.Exists(this.txtOriginal.Text)
                && File.Exists(this.txtTraducido.Text))
            {

                // Se crean los objetos del os xml
                XmlDocument OriginalDoc = new XmlDocument();
                XmlDocument TraducidoDoc = new XmlDocument();

                // Se cargan los xml
                OriginalDoc.Load(this.txtOriginal.Text);
                TraducidoDoc.Load(this.txtTraducido.Text);

                if (this.rbStrings.Checked)
                {
                    contador = xmlString(OriginalDoc, TraducidoDoc);
                }
                else if (this.rbPlurals.Checked) {
                    contador = xmlPlurals(OriginalDoc, TraducidoDoc);
                }
                else if (this.rbArrays.Checked)
                {
                    contador = xmlArrays(OriginalDoc, TraducidoDoc);
                }

                if (contador > 0)
                {
                    this.lblContRes.Text = contador.ToString();
                    MessageBox.Show("Merge completado, se realizaron " + contador.ToString() + " cambios.", "Finalizado!");
                }
                else {
                    MessageBox.Show("No se realizaron cambios en los XML.", "Sin cambios!");
                }
            }

            
        }

        /// <summary>
        /// Validaciones necesarias antes de generar el archivo.
        /// </summary>
        /// <returns></returns>
        private bool validaciones()
        {
            bool val = true;

            if (this.txtOriginal.Text.Length < 1 || this.txtTraducido.Text.Length < 1)
            {
                return false;
            }

            if (!this.rbArrays.Checked && !this.rbPlurals.Checked && !this.rbStrings.Checked)
            {
                return false;
            }

            if (this.txtRuta.Text.Length < 1)
            {
                //return false;
                string filepath = this.txtOriginal.Text;
                this.txtRuta.Text = filepath.Substring(0, filepath.Length - 4) + "_Merged.xml"; 
            }

            // Si llega es que paso todas las validaciones.
            return val;
        }

        /// <summary>
        /// Se crea el xml a guardar.
        /// </summary>
        /// <param name="OriginalDoc"></param>
        /// <param name="TraducidoDoc"></param>
        /// <returns></returns>
        private int xmlString(XmlDocument OriginalDoc, XmlDocument TraducidoDoc)
        {
            int contador = 0;

            string strNode = this.txtNodo.Text;
            string strAtributo = this.txtAtributo.Text;

            // Verificamos si se seteo un nodo.
            if (this.txtNodo.Text.Length > 1)
            {
                strNode = this.txtNodo.Text;
            }
            else
            {
                strNode = @"/resources/string";
            }

            // Verificamos si se seteo un atributo.
            if (this.txtAtributo.Text.Length > 1)
            {
                strAtributo = this.txtAtributo.Text;
            }
            else
            {
                strAtributo = "name";
            }

            XmlNodeList stringOrgNode = OriginalDoc.SelectNodes(strNode);
            XmlNodeList stringTrgNode = TraducidoDoc.SelectNodes(strNode);

            //Se crea el formulario.
            frmNewString frmNString = new frmNewString();

            // Se recorren los nodos del archivo Original
            foreach (XmlNode xnOrg in stringOrgNode)
            {
                string orgName = xnOrg.Attributes[strAtributo].Value; // Valor del atributo del nodo.
                string orgValue = xnOrg.InnerText;  // Contenido del Nodo

                // Se recorren los nodos del archivo Traducido para remplazar.
                foreach (XmlNode xnTrad in stringTrgNode)
                {
                    string trName = xnTrad.Attributes[strAtributo].Value; // Valor del atributo del nodo.
                    string trValue = xnTrad.InnerText;  // Contenido del primer Nodo

                    if (orgName == trName
                        && orgValue != xnTrad.InnerText)
                    {
                        if (this.chkMostrarCambios.Checked && !frmNString.neverAsk)
                        {
                            // Paso el texto a comparar
                            frmNString.nuevosTextos(orgValue, trValue);

                            frmNString.ShowDialog();

                            if (frmNString.Status == true)
                            {
                                xnOrg.InnerText = frmNString.newText;
                                ++contador; //Suma la cantidad de remplazos
                            }

                        }
                        else
                        {
                            xnOrg.InnerText = xnTrad.InnerText;
                            ++contador; //Suma la cantidad de remplazos
                        }
                    }
                }

                //frmNString.Dispose();
            }

            if(contador > 0){
                // Se guarda el archivo xml nuevo.
                OriginalDoc.Save(this.txtRuta.Text);
            }

            return contador;

        }

        private int xmlArrays(XmlDocument OriginalDoc, XmlDocument TraducidoDoc)
        {
            int contador = 0;
            string strNode = @"/resources/string-array";
            string strAtributo = "name";

            XmlNodeList stringOrgNode = OriginalDoc.SelectNodes(strNode);
            XmlNodeList stringTrgNode = TraducidoDoc.SelectNodes(strNode);

            // Recorremos el conjunto de nodos en el archivo original.
            foreach (XmlNode xnOrg in stringOrgNode)
            {
                string orgName = xnOrg.Attributes[strAtributo].Value; // Valor del atributo del nodo.

            }

            return contador;
        }

        private int xmlPlurals(XmlDocument OriginalDoc, XmlDocument TraducidoDoc)
        {
            int contador = 0;

            return contador;
        }


        

    }
}
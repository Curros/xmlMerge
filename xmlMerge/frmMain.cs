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
            string strNode = "", atributo = "" ;
            int contador = 0;
            
            if ( this.txtOriginal.Text != null && this.txtTraducido.Text != null )
            {

                if ( File.Exists(this.txtOriginal.Text)
                    && File.Exists(this.txtTraducido.Text) ) {

                    // Se crean los objetos del os xml
                    XmlDocument OriginalDoc = new XmlDocument();
                    XmlDocument TraducidoDoc = new XmlDocument();
                    
                    // Se cargan los xml
                    OriginalDoc.Load(this.txtOriginal.Text);
                    TraducidoDoc.Load(this.txtTraducido.Text);

                    if (this.txtNodo.Text.Length > 1)
                    {
                        strNode = this.txtNodo.Text;
                    }
                    else {
                        strNode = @"/resources/string";
                    }


                    XmlNodeList stringOrgNode = OriginalDoc.SelectNodes(strNode);
                    XmlNodeList stringTrgNode = TraducidoDoc.SelectNodes(strNode);

                    if (this.txtAtributo.Text.Length > 1)
                    {
                        atributo = this.txtAtributo.Text;
                    }
                    else
                    {
                        atributo = "name";
                    }

                    foreach ( XmlNode xnOrg in stringOrgNode  ) {
                        string temp = xnOrg.InnerText;
                        string orgName = xnOrg.Attributes["name"].Value;

                        foreach (XmlNode xnTrad in stringTrgNode) {
                            string trName = xnTrad.Attributes["name"].Value;

                            if (orgName == trName
                                && xnOrg.InnerText != xnTrad.InnerText)
                            {

                                xnOrg.InnerText = xnTrad.InnerText;
                                ++contador; //Suma la cantidad de remplazos
                            }
                        }

                    }

                    // Verificamos si proporciona una ruta para salvar el archivo.
                    string filepath;
                    if (this.txtRuta.Text != null && this.txtRuta.Text.Length > 1){
                        filepath = this.txtRuta.Text;
                    } else {
                        filepath = this.txtOriginal.Text;
                        filepath = filepath.Substring(0, filepath.Length - 4);
                        filepath = filepath + "2.xml";
                    }

                    OriginalDoc.Save( filepath );

                }

            }

            this.lblContRes.Text = contador.ToString();
            MessageBox.Show("Merge completado, se realizaron " + contador.ToString() + " cambios.", "Finalizado!");
        }

    }
}
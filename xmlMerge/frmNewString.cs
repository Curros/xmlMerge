using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace xmlMerge
{
    public partial class frmNewString : Form
    {
        private bool _neverAsk = false;
        private bool _status = false;
        private string _newText;
        private string _txtOrg;

        /// <summary>
        /// Evita que se vuelva a mostrar este control.
        /// </summary>
        public bool neverAsk {
            get
            {
                return _neverAsk;
            }
            set
            {
                _neverAsk = value;
            }
        }

        public bool Status
        {
            get
            {
                return _status;
            }
            //set
            //{
            //    _status = value;
            //}
        }

        public string newText
        {
            get
            {
                return _newText;
            }
            //set
            //{
            //    _newText = value;
            //}
        }

        public frmNewString()
        {
            InitializeComponent();
        }

        public void nuevosTextos(string txtOrg, string txtNew)
        {
            // Se almacena y estable el texto original.
            _txtOrg = txtOrg;
            this.txtOriginal.Text = txtOrg;
            // Se establece el texto nuevo.
            this.txtNuevo.Text = txtNew;
        }

        #region Botones
        private void btnOriginal_Click(object sender, EventArgs e)
        {
            comprobarEnvio(false, this.txtOriginal.Text);
            //_status = false;
            //_newText = this.txtOriginal.Text;
            this.Close();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            comprobarEnvio(true, this.txtNuevo.Text);
            //_status = true;
            //_newText = this.txtNuevo.Text;
            this.Close();
        }

        private void chkShow_CheckedChanged(object sender, EventArgs e)
        {
            // Solo comprueba cuando clickamos.
            if (this.chkShow.Checked)
            {
                DialogResult dialogResult =  MessageBox.Show("Esto evitara que se vuelva a pedir una edición y se realicen los cambios automaticamente."
                    + Environment.NewLine
                    + "- Aún debe elegir que hacer con esta comprobación."
                    + Environment.NewLine + Environment.NewLine
                    + "¿Esta seguro de que desea no volver a mostrar este formulario?", "Aviso!", MessageBoxButtons.YesNo);

                if (dialogResult == DialogResult.Yes) {
                    _neverAsk = true;
                    this.chkShow.Checked = true;
                }
                else
                {
                    _neverAsk = false;
                    this.chkShow.Checked = false;
                }
            }

        }
        #endregion

        #region Funciones Privadas
        private void comprobarEnvio(bool newBtn, string text) {
            
            if (newBtn)
            {
                _status = true;
                _newText = text;
            }
            else if (newBtn == false && _txtOrg != text)
            {
                _status = true;
                _newText = text;
            }

        }
        #endregion

    }
}

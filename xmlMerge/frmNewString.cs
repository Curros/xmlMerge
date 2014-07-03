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

        private bool _status;
        private string _newText;

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

        public frmNewString(string txtOrg, string txtNew)
        {
            InitializeComponent();

            this.txtOriginal.Text = txtOrg;
            this.txtNuevo.Text = txtNew;
        }

        private void btnOriginal_Click(object sender, EventArgs e)
        {
            _status = false;
            _newText = this.txtOriginal.Text;
            this.Close();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            _status = true;
            _newText = this.txtNuevo.Text;
            this.Close();
        }

    }
}

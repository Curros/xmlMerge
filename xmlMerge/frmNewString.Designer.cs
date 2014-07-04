namespace xmlMerge
{
    partial class frmNewString
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblStrOrg = new System.Windows.Forms.Label();
            this.lblFrm = new System.Windows.Forms.Label();
            this.txtOriginal = new System.Windows.Forms.TextBox();
            this.txtNuevo = new System.Windows.Forms.TextBox();
            this.lblNuevo = new System.Windows.Forms.Label();
            this.btnOriginal = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.chkShow = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // lblStrOrg
            // 
            this.lblStrOrg.AutoSize = true;
            this.lblStrOrg.Location = new System.Drawing.Point(12, 61);
            this.lblStrOrg.Name = "lblStrOrg";
            this.lblStrOrg.Size = new System.Drawing.Size(42, 13);
            this.lblStrOrg.TabIndex = 0;
            this.lblStrOrg.Text = "Original";
            // 
            // lblFrm
            // 
            this.lblFrm.AutoSize = true;
            this.lblFrm.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFrm.Location = new System.Drawing.Point(12, 9);
            this.lblFrm.Name = "lblFrm";
            this.lblFrm.Size = new System.Drawing.Size(189, 37);
            this.lblFrm.TabIndex = 16;
            this.lblFrm.Text = "XML Merge";
            // 
            // txtOriginal
            // 
            this.txtOriginal.Location = new System.Drawing.Point(15, 78);
            this.txtOriginal.Multiline = true;
            this.txtOriginal.Name = "txtOriginal";
            this.txtOriginal.Size = new System.Drawing.Size(233, 106);
            this.txtOriginal.TabIndex = 17;
            // 
            // txtNuevo
            // 
            this.txtNuevo.Location = new System.Drawing.Point(268, 78);
            this.txtNuevo.Multiline = true;
            this.txtNuevo.Name = "txtNuevo";
            this.txtNuevo.Size = new System.Drawing.Size(233, 106);
            this.txtNuevo.TabIndex = 19;
            // 
            // lblNuevo
            // 
            this.lblNuevo.AutoSize = true;
            this.lblNuevo.Location = new System.Drawing.Point(265, 61);
            this.lblNuevo.Name = "lblNuevo";
            this.lblNuevo.Size = new System.Drawing.Size(39, 13);
            this.lblNuevo.TabIndex = 18;
            this.lblNuevo.Text = "Nuevo";
            // 
            // btnOriginal
            // 
            this.btnOriginal.Location = new System.Drawing.Point(173, 190);
            this.btnOriginal.Name = "btnOriginal";
            this.btnOriginal.Size = new System.Drawing.Size(75, 23);
            this.btnOriginal.TabIndex = 20;
            this.btnOriginal.Text = "Seleccionar";
            this.btnOriginal.UseVisualStyleBackColor = true;
            this.btnOriginal.Click += new System.EventHandler(this.btnOriginal_Click);
            // 
            // btnNuevo
            // 
            this.btnNuevo.Location = new System.Drawing.Point(426, 190);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(75, 23);
            this.btnNuevo.TabIndex = 21;
            this.btnNuevo.Text = "Seleccionar";
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // chkShow
            // 
            this.chkShow.AutoSize = true;
            this.chkShow.Location = new System.Drawing.Point(300, 12);
            this.chkShow.Name = "chkShow";
            this.chkShow.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.chkShow.Size = new System.Drawing.Size(201, 17);
            this.chkShow.TabIndex = 22;
            this.chkShow.Text = "¿No volver a mostrar este formulario?";
            this.chkShow.UseVisualStyleBackColor = true;
            this.chkShow.CheckedChanged += new System.EventHandler(this.chkShow_CheckedChanged);
            // 
            // frmNewString
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(513, 220);
            this.Controls.Add(this.chkShow);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.btnOriginal);
            this.Controls.Add(this.txtNuevo);
            this.Controls.Add(this.lblNuevo);
            this.Controls.Add(this.txtOriginal);
            this.Controls.Add(this.lblFrm);
            this.Controls.Add(this.lblStrOrg);
            this.Name = "frmNewString";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Texto a editar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblStrOrg;
        private System.Windows.Forms.Label lblFrm;
        private System.Windows.Forms.TextBox txtOriginal;
        private System.Windows.Forms.TextBox txtNuevo;
        private System.Windows.Forms.Label lblNuevo;
        private System.Windows.Forms.Button btnOriginal;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.CheckBox chkShow;
    }
}
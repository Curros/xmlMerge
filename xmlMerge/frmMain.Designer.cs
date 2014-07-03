namespace xmlMerge
{
    partial class frmMain
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
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btnOrg = new System.Windows.Forms.Button();
            this.lblOriginal = new System.Windows.Forms.Label();
            this.txtOriginal = new System.Windows.Forms.TextBox();
            this.txtTraducido = new System.Windows.Forms.TextBox();
            this.lblTraducido = new System.Windows.Forms.Label();
            this.btnTraducido = new System.Windows.Forms.Button();
            this.btnGenerar = new System.Windows.Forms.Button();
            this.lblCount = new System.Windows.Forms.Label();
            this.lblContRes = new System.Windows.Forms.Label();
            this.lblOrgInfo = new System.Windows.Forms.Label();
            this.lblTrInfo = new System.Windows.Forms.Label();
            this.txtRuta = new System.Windows.Forms.TextBox();
            this.btnRuta = new System.Windows.Forms.Button();
            this.lblRuta = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblMain = new System.Windows.Forms.Label();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // btnOrg
            // 
            this.btnOrg.Location = new System.Drawing.Point(422, 61);
            this.btnOrg.Name = "btnOrg";
            this.btnOrg.Size = new System.Drawing.Size(31, 23);
            this.btnOrg.TabIndex = 0;
            this.btnOrg.Text = "...";
            this.btnOrg.UseVisualStyleBackColor = true;
            this.btnOrg.Click += new System.EventHandler(this.btnOrg_Click);
            // 
            // lblOriginal
            // 
            this.lblOriginal.AutoSize = true;
            this.lblOriginal.Location = new System.Drawing.Point(13, 66);
            this.lblOriginal.Name = "lblOriginal";
            this.lblOriginal.Size = new System.Drawing.Size(113, 13);
            this.lblOriginal.TabIndex = 1;
            this.lblOriginal.Text = "XML original (Plantilla):";
            // 
            // txtOriginal
            // 
            this.txtOriginal.Location = new System.Drawing.Point(131, 63);
            this.txtOriginal.Name = "txtOriginal";
            this.txtOriginal.ReadOnly = true;
            this.txtOriginal.Size = new System.Drawing.Size(285, 20);
            this.txtOriginal.TabIndex = 2;
            // 
            // txtTraducido
            // 
            this.txtTraducido.Location = new System.Drawing.Point(131, 107);
            this.txtTraducido.Name = "txtTraducido";
            this.txtTraducido.ReadOnly = true;
            this.txtTraducido.Size = new System.Drawing.Size(285, 20);
            this.txtTraducido.TabIndex = 5;
            // 
            // lblTraducido
            // 
            this.lblTraducido.AutoSize = true;
            this.lblTraducido.Location = new System.Drawing.Point(13, 110);
            this.lblTraducido.Name = "lblTraducido";
            this.lblTraducido.Size = new System.Drawing.Size(88, 13);
            this.lblTraducido.TabIndex = 4;
            this.lblTraducido.Text = "XML a comparar:";
            // 
            // btnTraducido
            // 
            this.btnTraducido.Location = new System.Drawing.Point(422, 105);
            this.btnTraducido.Name = "btnTraducido";
            this.btnTraducido.Size = new System.Drawing.Size(31, 23);
            this.btnTraducido.TabIndex = 3;
            this.btnTraducido.Text = "...";
            this.btnTraducido.UseVisualStyleBackColor = true;
            this.btnTraducido.Click += new System.EventHandler(this.btnTraducido_Click);
            // 
            // btnGenerar
            // 
            this.btnGenerar.Location = new System.Drawing.Point(328, 216);
            this.btnGenerar.Name = "btnGenerar";
            this.btnGenerar.Size = new System.Drawing.Size(125, 23);
            this.btnGenerar.TabIndex = 6;
            this.btnGenerar.Text = "Generar Merge";
            this.btnGenerar.UseVisualStyleBackColor = true;
            this.btnGenerar.Click += new System.EventHandler(this.btnGenerar_Click);
            // 
            // lblCount
            // 
            this.lblCount.AutoSize = true;
            this.lblCount.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.lblCount.Location = new System.Drawing.Point(11, 225);
            this.lblCount.Name = "lblCount";
            this.lblCount.Size = new System.Drawing.Size(50, 13);
            this.lblCount.TabIndex = 7;
            this.lblCount.Text = "Cambios:";
            // 
            // lblContRes
            // 
            this.lblContRes.AutoSize = true;
            this.lblContRes.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.lblContRes.Location = new System.Drawing.Point(66, 226);
            this.lblContRes.Name = "lblContRes";
            this.lblContRes.Size = new System.Drawing.Size(13, 13);
            this.lblContRes.TabIndex = 8;
            this.lblContRes.Text = "0";
            // 
            // lblOrgInfo
            // 
            this.lblOrgInfo.AutoSize = true;
            this.lblOrgInfo.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.lblOrgInfo.Location = new System.Drawing.Point(162, 86);
            this.lblOrgInfo.Name = "lblOrgInfo";
            this.lblOrgInfo.Size = new System.Drawing.Size(291, 13);
            this.lblOrgInfo.TabIndex = 9;
            this.lblOrgInfo.Text = "Archivo que se tomara como base para crear el nuevo XML.";
            // 
            // lblTrInfo
            // 
            this.lblTrInfo.AutoSize = true;
            this.lblTrInfo.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.lblTrInfo.Location = new System.Drawing.Point(182, 130);
            this.lblTrInfo.Name = "lblTrInfo";
            this.lblTrInfo.Size = new System.Drawing.Size(271, 13);
            this.lblTrInfo.TabIndex = 10;
            this.lblTrInfo.Text = "Archivo traducido para comparar/añadir con el de base.";
            // 
            // txtRuta
            // 
            this.txtRuta.Location = new System.Drawing.Point(131, 159);
            this.txtRuta.Name = "txtRuta";
            this.txtRuta.ReadOnly = true;
            this.txtRuta.Size = new System.Drawing.Size(285, 20);
            this.txtRuta.TabIndex = 11;
            // 
            // btnRuta
            // 
            this.btnRuta.Location = new System.Drawing.Point(422, 157);
            this.btnRuta.Name = "btnRuta";
            this.btnRuta.Size = new System.Drawing.Size(31, 23);
            this.btnRuta.TabIndex = 12;
            this.btnRuta.Text = "...";
            this.btnRuta.UseVisualStyleBackColor = true;
            this.btnRuta.Click += new System.EventHandler(this.btnRuta_Click);
            // 
            // lblRuta
            // 
            this.lblRuta.AutoSize = true;
            this.lblRuta.Location = new System.Drawing.Point(13, 162);
            this.lblRuta.Name = "lblRuta";
            this.lblRuta.Size = new System.Drawing.Size(96, 13);
            this.lblRuta.TabIndex = 13;
            this.lblRuta.Text = "Ruta para guardar:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label1.Location = new System.Drawing.Point(184, 182);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(269, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Sitio donde se guardara el archivo resultante (opcional).";
            // 
            // lblMain
            // 
            this.lblMain.AutoSize = true;
            this.lblMain.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMain.Location = new System.Drawing.Point(9, 12);
            this.lblMain.Name = "lblMain";
            this.lblMain.Size = new System.Drawing.Size(189, 37);
            this.lblMain.TabIndex = 15;
            this.lblMain.Text = "XML Merge";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(465, 247);
            this.Controls.Add(this.lblMain);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblRuta);
            this.Controls.Add(this.btnRuta);
            this.Controls.Add(this.txtRuta);
            this.Controls.Add(this.lblTrInfo);
            this.Controls.Add(this.lblOrgInfo);
            this.Controls.Add(this.lblContRes);
            this.Controls.Add(this.lblCount);
            this.Controls.Add(this.btnGenerar);
            this.Controls.Add(this.txtTraducido);
            this.Controls.Add(this.lblTraducido);
            this.Controls.Add(this.btnTraducido);
            this.Controls.Add(this.txtOriginal);
            this.Controls.Add(this.lblOriginal);
            this.Controls.Add(this.btnOrg);
            this.Name = "frmMain";
            this.Text = "Añadir valores traducidos al XML";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button btnOrg;
        private System.Windows.Forms.Label lblOriginal;
        private System.Windows.Forms.TextBox txtOriginal;
        private System.Windows.Forms.TextBox txtTraducido;
        private System.Windows.Forms.Label lblTraducido;
        private System.Windows.Forms.Button btnTraducido;
        private System.Windows.Forms.Button btnGenerar;
        private System.Windows.Forms.Label lblCount;
        private System.Windows.Forms.Label lblContRes;
        private System.Windows.Forms.Label lblOrgInfo;
        private System.Windows.Forms.Label lblTrInfo;
        private System.Windows.Forms.TextBox txtRuta;
        private System.Windows.Forms.Button btnRuta;
        private System.Windows.Forms.Label lblRuta;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblMain;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}


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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
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
            this.txtNodo = new System.Windows.Forms.TextBox();
            this.lblNodo = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.gprConfig = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtAtributo = new System.Windows.Forms.TextBox();
            this.lblAtributo = new System.Windows.Forms.Label();
            this.chkMostrarCambios = new System.Windows.Forms.CheckBox();
            this.lblMostrarCambios = new System.Windows.Forms.Label();
            this.grpFiles = new System.Windows.Forms.GroupBox();
            this.gprType = new System.Windows.Forms.GroupBox();
            this.rbStrings = new System.Windows.Forms.RadioButton();
            this.rbPlurals = new System.Windows.Forms.RadioButton();
            this.rbArrays = new System.Windows.Forms.RadioButton();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.gprConfig.SuspendLayout();
            this.grpFiles.SuspendLayout();
            this.gprType.SuspendLayout();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // btnOrg
            // 
            this.btnOrg.Location = new System.Drawing.Point(548, 20);
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
            this.lblOriginal.Location = new System.Drawing.Point(6, 25);
            this.lblOriginal.Name = "lblOriginal";
            this.lblOriginal.Size = new System.Drawing.Size(113, 13);
            this.lblOriginal.TabIndex = 1;
            this.lblOriginal.Text = "XML original (Plantilla):";
            // 
            // txtOriginal
            // 
            this.txtOriginal.Location = new System.Drawing.Point(119, 22);
            this.txtOriginal.Name = "txtOriginal";
            this.txtOriginal.ReadOnly = true;
            this.txtOriginal.Size = new System.Drawing.Size(423, 20);
            this.txtOriginal.TabIndex = 2;
            // 
            // txtTraducido
            // 
            this.txtTraducido.Location = new System.Drawing.Point(119, 68);
            this.txtTraducido.Name = "txtTraducido";
            this.txtTraducido.ReadOnly = true;
            this.txtTraducido.Size = new System.Drawing.Size(423, 20);
            this.txtTraducido.TabIndex = 5;
            // 
            // lblTraducido
            // 
            this.lblTraducido.AutoSize = true;
            this.lblTraducido.Location = new System.Drawing.Point(6, 71);
            this.lblTraducido.Name = "lblTraducido";
            this.lblTraducido.Size = new System.Drawing.Size(88, 13);
            this.lblTraducido.TabIndex = 4;
            this.lblTraducido.Text = "XML a comparar:";
            // 
            // btnTraducido
            // 
            this.btnTraducido.Location = new System.Drawing.Point(548, 66);
            this.btnTraducido.Name = "btnTraducido";
            this.btnTraducido.Size = new System.Drawing.Size(31, 23);
            this.btnTraducido.TabIndex = 3;
            this.btnTraducido.Text = "...";
            this.btnTraducido.UseVisualStyleBackColor = true;
            this.btnTraducido.Click += new System.EventHandler(this.btnTraducido_Click);
            // 
            // btnGenerar
            // 
            this.btnGenerar.Location = new System.Drawing.Point(479, 421);
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
            this.lblCount.Location = new System.Drawing.Point(11, 431);
            this.lblCount.Name = "lblCount";
            this.lblCount.Size = new System.Drawing.Size(50, 13);
            this.lblCount.TabIndex = 7;
            this.lblCount.Text = "Cambios:";
            // 
            // lblContRes
            // 
            this.lblContRes.AutoSize = true;
            this.lblContRes.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.lblContRes.Location = new System.Drawing.Point(67, 431);
            this.lblContRes.Name = "lblContRes";
            this.lblContRes.Size = new System.Drawing.Size(13, 13);
            this.lblContRes.TabIndex = 8;
            this.lblContRes.Text = "0";
            // 
            // lblOrgInfo
            // 
            this.lblOrgInfo.AutoSize = true;
            this.lblOrgInfo.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.lblOrgInfo.Location = new System.Drawing.Point(297, 45);
            this.lblOrgInfo.Name = "lblOrgInfo";
            this.lblOrgInfo.Size = new System.Drawing.Size(291, 13);
            this.lblOrgInfo.TabIndex = 9;
            this.lblOrgInfo.Text = "Archivo que se tomara como base para crear el nuevo XML.";
            // 
            // lblTrInfo
            // 
            this.lblTrInfo.AutoSize = true;
            this.lblTrInfo.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.lblTrInfo.Location = new System.Drawing.Point(317, 91);
            this.lblTrInfo.Name = "lblTrInfo";
            this.lblTrInfo.Size = new System.Drawing.Size(271, 13);
            this.lblTrInfo.TabIndex = 10;
            this.lblTrInfo.Text = "Archivo traducido para comparar/añadir con el de base.";
            // 
            // txtRuta
            // 
            this.txtRuta.Location = new System.Drawing.Point(131, 365);
            this.txtRuta.Name = "txtRuta";
            this.txtRuta.ReadOnly = true;
            this.txtRuta.Size = new System.Drawing.Size(421, 20);
            this.txtRuta.TabIndex = 11;
            // 
            // btnRuta
            // 
            this.btnRuta.Location = new System.Drawing.Point(558, 363);
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
            this.lblRuta.Location = new System.Drawing.Point(13, 368);
            this.lblRuta.Name = "lblRuta";
            this.lblRuta.Size = new System.Drawing.Size(96, 13);
            this.lblRuta.TabIndex = 13;
            this.lblRuta.Text = "Ruta para guardar:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label1.Location = new System.Drawing.Point(329, 389);
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
            // txtNodo
            // 
            this.txtNodo.Location = new System.Drawing.Point(121, 25);
            this.txtNodo.Name = "txtNodo";
            this.txtNodo.Size = new System.Drawing.Size(271, 20);
            this.txtNodo.TabIndex = 17;
            // 
            // lblNodo
            // 
            this.lblNodo.AutoSize = true;
            this.lblNodo.Location = new System.Drawing.Point(6, 28);
            this.lblNodo.Name = "lblNodo";
            this.lblNodo.Size = new System.Drawing.Size(92, 13);
            this.lblNodo.TabIndex = 16;
            this.lblNodo.Text = "Nodo a comparar:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label2.Location = new System.Drawing.Point(129, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(268, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "Nodo del XML que desea comparar (/resources/string).";
            // 
            // gprConfig
            // 
            this.gprConfig.Controls.Add(this.label3);
            this.gprConfig.Controls.Add(this.label2);
            this.gprConfig.Controls.Add(this.txtAtributo);
            this.gprConfig.Controls.Add(this.lblAtributo);
            this.gprConfig.Controls.Add(this.txtNodo);
            this.gprConfig.Controls.Add(this.lblNodo);
            this.gprConfig.Location = new System.Drawing.Point(10, 170);
            this.gprConfig.Name = "gprConfig";
            this.gprConfig.Size = new System.Drawing.Size(407, 117);
            this.gprConfig.TabIndex = 19;
            this.gprConfig.TabStop = false;
            this.gprConfig.Text = "Configuración";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label3.Location = new System.Drawing.Point(148, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(244, 13);
            this.label3.TabIndex = 20;
            this.label3.Text = "Copie el nombre del strAtributo a comparar (name).";
            // 
            // txtAtributo
            // 
            this.txtAtributo.Location = new System.Drawing.Point(121, 67);
            this.txtAtributo.Name = "txtAtributo";
            this.txtAtributo.Size = new System.Drawing.Size(271, 20);
            this.txtAtributo.TabIndex = 19;
            // 
            // lblAtributo
            // 
            this.lblAtributo.AutoSize = true;
            this.lblAtributo.Location = new System.Drawing.Point(6, 70);
            this.lblAtributo.Name = "lblAtributo";
            this.lblAtributo.Size = new System.Drawing.Size(102, 13);
            this.lblAtributo.TabIndex = 18;
            this.lblAtributo.Text = "Atributo a comparar:";
            // 
            // chkMostrarCambios
            // 
            this.chkMostrarCambios.Location = new System.Drawing.Point(129, 301);
            this.chkMostrarCambios.Name = "chkMostrarCambios";
            this.chkMostrarCambios.Size = new System.Drawing.Size(287, 17);
            this.chkMostrarCambios.TabIndex = 22;
            this.chkMostrarCambios.Text = "Marque si desea mostrar los textos antes de aceptarlos.";
            this.chkMostrarCambios.UseVisualStyleBackColor = true;
            // 
            // lblMostrarCambios
            // 
            this.lblMostrarCambios.AutoSize = true;
            this.lblMostrarCambios.Location = new System.Drawing.Point(14, 301);
            this.lblMostrarCambios.Name = "lblMostrarCambios";
            this.lblMostrarCambios.Size = new System.Drawing.Size(87, 13);
            this.lblMostrarCambios.TabIndex = 21;
            this.lblMostrarCambios.Text = "Mostrar cambios:";
            // 
            // grpFiles
            // 
            this.grpFiles.Controls.Add(this.txtTraducido);
            this.grpFiles.Controls.Add(this.lblTraducido);
            this.grpFiles.Controls.Add(this.btnTraducido);
            this.grpFiles.Controls.Add(this.txtOriginal);
            this.grpFiles.Controls.Add(this.lblOriginal);
            this.grpFiles.Controls.Add(this.btnOrg);
            this.grpFiles.Controls.Add(this.lblTrInfo);
            this.grpFiles.Controls.Add(this.lblOrgInfo);
            this.grpFiles.Location = new System.Drawing.Point(10, 52);
            this.grpFiles.Name = "grpFiles";
            this.grpFiles.Size = new System.Drawing.Size(594, 112);
            this.grpFiles.TabIndex = 20;
            this.grpFiles.TabStop = false;
            this.grpFiles.Text = "Archivos";
            // 
            // gprType
            // 
            this.gprType.Controls.Add(this.rbStrings);
            this.gprType.Controls.Add(this.rbPlurals);
            this.gprType.Controls.Add(this.rbArrays);
            this.gprType.Controls.Add(this.label6);
            this.gprType.Controls.Add(this.label5);
            this.gprType.Controls.Add(this.label4);
            this.gprType.Location = new System.Drawing.Point(424, 171);
            this.gprType.Name = "gprType";
            this.gprType.Size = new System.Drawing.Size(180, 158);
            this.gprType.TabIndex = 21;
            this.gprType.TabStop = false;
            this.gprType.Text = "Tipo";
            // 
            // rbStrings
            // 
            this.rbStrings.AutoSize = true;
            this.rbStrings.Checked = true;
            this.rbStrings.Location = new System.Drawing.Point(10, 117);
            this.rbStrings.Name = "rbStrings";
            this.rbStrings.Size = new System.Drawing.Size(57, 17);
            this.rbStrings.TabIndex = 28;
            this.rbStrings.TabStop = true;
            this.rbStrings.Text = "Strings";
            this.rbStrings.UseVisualStyleBackColor = true;
            this.rbStrings.CheckedChanged += new System.EventHandler(this.rbStrings_CheckedChanged);
            // 
            // rbPlurals
            // 
            this.rbPlurals.AutoSize = true;
            this.rbPlurals.Location = new System.Drawing.Point(10, 69);
            this.rbPlurals.Name = "rbPlurals";
            this.rbPlurals.Size = new System.Drawing.Size(56, 17);
            this.rbPlurals.TabIndex = 27;
            this.rbPlurals.Text = "Plurals";
            this.rbPlurals.UseVisualStyleBackColor = true;
            // 
            // rbArrays
            // 
            this.rbArrays.AutoSize = true;
            this.rbArrays.Location = new System.Drawing.Point(10, 25);
            this.rbArrays.Name = "rbArrays";
            this.rbArrays.Size = new System.Drawing.Size(54, 17);
            this.rbArrays.TabIndex = 26;
            this.rbArrays.Text = "Arrays";
            this.rbArrays.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label6.Location = new System.Drawing.Point(12, 131);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 13);
            this.label6.TabIndex = 25;
            this.label6.Text = "strings.xml";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label5.Location = new System.Drawing.Point(11, 89);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 13);
            this.label5.TabIndex = 24;
            this.label5.Text = "plurals.xml";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label4.Location = new System.Drawing.Point(11, 44);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 23;
            this.label4.Text = "arrays.xml";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblTitle.Location = new System.Drawing.Point(204, 25);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(197, 20);
            this.lblTitle.TabIndex = 23;
            this.lblTitle.Text = "Para la traducción de MIUI";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(616, 456);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.chkMostrarCambios);
            this.Controls.Add(this.lblMostrarCambios);
            this.Controls.Add(this.gprType);
            this.Controls.Add(this.lblMain);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblRuta);
            this.Controls.Add(this.btnRuta);
            this.Controls.Add(this.txtRuta);
            this.Controls.Add(this.lblContRes);
            this.Controls.Add(this.lblCount);
            this.Controls.Add(this.btnGenerar);
            this.Controls.Add(this.grpFiles);
            this.Controls.Add(this.gprConfig);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Añadir valores traducidos al XML";
            this.gprConfig.ResumeLayout(false);
            this.gprConfig.PerformLayout();
            this.grpFiles.ResumeLayout(false);
            this.grpFiles.PerformLayout();
            this.gprType.ResumeLayout(false);
            this.gprType.PerformLayout();
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
        private System.Windows.Forms.TextBox txtNodo;
        private System.Windows.Forms.Label lblNodo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox gprConfig;
        private System.Windows.Forms.GroupBox grpFiles;
        private System.Windows.Forms.TextBox txtAtributo;
        private System.Windows.Forms.Label lblAtributo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox chkMostrarCambios;
        private System.Windows.Forms.Label lblMostrarCambios;
        private System.Windows.Forms.GroupBox gprType;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton rbStrings;
        private System.Windows.Forms.RadioButton rbPlurals;
        private System.Windows.Forms.RadioButton rbArrays;
        private System.Windows.Forms.Label lblTitle;
    }
}


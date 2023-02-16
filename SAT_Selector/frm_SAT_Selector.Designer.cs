namespace SAT_Selector
{
    partial class frm_SAT_Selector
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
            this.btnSelCert = new System.Windows.Forms.Button();
            this.tbxCertFile = new System.Windows.Forms.TextBox();
            this.ofdCerFile = new System.Windows.Forms.OpenFileDialog();
            this.tbxCerData = new System.Windows.Forms.TextBox();
            this.btnSelKey = new System.Windows.Forms.Button();
            this.ofdKeyFile = new System.Windows.Forms.OpenFileDialog();
            this.tbxKey = new System.Windows.Forms.TextBox();
            this.tbxCont = new System.Windows.Forms.TextBox();
            this.gbCert = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.gbCert.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSelCert
            // 
            this.btnSelCert.Location = new System.Drawing.Point(305, 19);
            this.btnSelCert.Name = "btnSelCert";
            this.btnSelCert.Size = new System.Drawing.Size(89, 23);
            this.btnSelCert.TabIndex = 1;
            this.btnSelCert.Text = "&Seleccionar...";
            this.btnSelCert.UseVisualStyleBackColor = true;
            this.btnSelCert.Click += new System.EventHandler(this.btnSelCert_Click);
            // 
            // tbxCertFile
            // 
            this.tbxCertFile.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tbxCertFile.ForeColor = System.Drawing.Color.Black;
            this.tbxCertFile.Location = new System.Drawing.Point(6, 21);
            this.tbxCertFile.Name = "tbxCertFile";
            this.tbxCertFile.ReadOnly = true;
            this.tbxCertFile.Size = new System.Drawing.Size(293, 20);
            this.tbxCertFile.TabIndex = 2;
            // 
            // ofdCerFile
            // 
            this.ofdCerFile.Filter = "Certificado (.cer)|*.cer";
            // 
            // tbxCerData
            // 
            this.tbxCerData.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tbxCerData.Enabled = false;
            this.tbxCerData.Location = new System.Drawing.Point(6, 47);
            this.tbxCerData.Multiline = true;
            this.tbxCerData.Name = "tbxCerData";
            this.tbxCerData.Size = new System.Drawing.Size(388, 60);
            this.tbxCerData.TabIndex = 3;
            // 
            // btnSelKey
            // 
            this.btnSelKey.Location = new System.Drawing.Point(305, 19);
            this.btnSelKey.Name = "btnSelKey";
            this.btnSelKey.Size = new System.Drawing.Size(89, 23);
            this.btnSelKey.TabIndex = 5;
            this.btnSelKey.Text = "S&eleccionar...";
            this.btnSelKey.UseVisualStyleBackColor = true;
            this.btnSelKey.Click += new System.EventHandler(this.btnSelKey_Click);
            // 
            // ofdKeyFile
            // 
            this.ofdKeyFile.Filter = "Clave Privada (.key)|*.key";
            // 
            // tbxKey
            // 
            this.tbxKey.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tbxKey.Location = new System.Drawing.Point(6, 22);
            this.tbxKey.Name = "tbxKey";
            this.tbxKey.ReadOnly = true;
            this.tbxKey.Size = new System.Drawing.Size(293, 20);
            this.tbxKey.TabIndex = 6;
            // 
            // tbxCont
            // 
            this.tbxCont.BackColor = System.Drawing.Color.MistyRose;
            this.tbxCont.Location = new System.Drawing.Point(6, 19);
            this.tbxCont.Name = "tbxCont";
            this.tbxCont.PasswordChar = '*';
            this.tbxCont.Size = new System.Drawing.Size(388, 20);
            this.tbxCont.TabIndex = 8;
            // 
            // gbCert
            // 
            this.gbCert.Controls.Add(this.btnSelCert);
            this.gbCert.Controls.Add(this.tbxCertFile);
            this.gbCert.Controls.Add(this.tbxCerData);
            this.gbCert.Location = new System.Drawing.Point(22, 27);
            this.gbCert.Name = "gbCert";
            this.gbCert.Size = new System.Drawing.Size(400, 124);
            this.gbCert.TabIndex = 9;
            this.gbCert.TabStop = false;
            this.gbCert.Text = "Certificado (.cer)";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnSelKey);
            this.groupBox2.Controls.Add(this.tbxKey);
            this.groupBox2.Location = new System.Drawing.Point(22, 157);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(400, 62);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Clave Privada (.key)";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbxCont);
            this.groupBox1.Location = new System.Drawing.Point(22, 225);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(400, 56);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Contraseña de Clave privada";
            // 
            // btnOK
            // 
            this.btnOK.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnOK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOK.Location = new System.Drawing.Point(266, 287);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 12;
            this.btnOK.Text = "&Aceptar";
            this.btnOK.UseVisualStyleBackColor = false;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.LightCoral;
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Location = new System.Drawing.Point(347, 287);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 13;
            this.btnCancel.Text = "&Cancelar";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // frm_SAT_Selector
            // 
            this.AcceptButton = this.btnOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(444, 336);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.gbCert);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_SAT_Selector";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Selección de eFirma";
            this.gbCert.ResumeLayout(false);
            this.gbCert.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnSelCert;
        private System.Windows.Forms.TextBox tbxCertFile;
        private System.Windows.Forms.OpenFileDialog ofdCerFile;
        private System.Windows.Forms.TextBox tbxCerData;
        private System.Windows.Forms.Button btnSelKey;
        private System.Windows.Forms.OpenFileDialog ofdKeyFile;
        private System.Windows.Forms.TextBox tbxKey;
        private System.Windows.Forms.TextBox tbxCont;
        private System.Windows.Forms.GroupBox gbCert;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancel;
    }
}
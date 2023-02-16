using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography.X509Certificates;
using System.Windows.Forms.VisualStyles;

namespace SAT_Selector
{
    public partial class frm_SAT_Selector : Form
    {

        string _rfc;
        string _nombre;
        string _huella;
        string _b64Cer;
        string _b64Key;
        string _b64Pwd;

        public string RFC { get { return this._rfc; } }
        public string Nombre { get { return this._nombre; } }
        public string Huella { get { return this._huella; } }
        public string Certificado { get { return this._b64Cer; } }
        public string Clave { get { return this._b64Key; } }
        public string Password { get { return this._b64Pwd; } }

        public frm_SAT_Selector()
        {
            InitializeComponent();
        }

        private void btnSelCert_Click(object sender, EventArgs e)
        {
            if(this.ofdCerFile.ShowDialog()== DialogResult.OK){
                this.tbxCertFile.Text = this.ofdCerFile.FileName;
                var cert = new X509Certificate2(this.tbxCertFile.Text);
                this._huella = cert.Thumbprint;
                foreach (string info in cert.Subject.Split(','))
                {
                    //Console.WriteLine(info);
                    switch (info.Split('=')[0].Trim())
                    {
                        case "OID.2.5.4.45":
                            this._rfc = info.Split('=')[1].Trim();
                            break;
                        case "OID.2.5.4.41":
                            this._nombre = info.Split('=')[1].Trim();
                            break;
                    }
                }
                this.tbxCerData.Text = "RFC: " + this._rfc + System.Environment.NewLine +
                    "Nombre: " + this._nombre + System.Environment.NewLine +
                    "Huella: " + this._huella;
                //this.gbCert.Enabled= false;
            }
            else
            {
                this.tbxCertFile.Text = "";
                this.tbxCerData.Text = "";
            }
        }

        private void btnSelKey_Click(object sender, EventArgs e)
        {
            this.tbxKey.Text =
                (this.ofdKeyFile.ShowDialog() == DialogResult.OK) ?
                this.ofdKeyFile.FileName : "";
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult= DialogResult.Cancel;
            this.Close();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if(
                string.IsNullOrEmpty(this.tbxCertFile.Text)
                || string.IsNullOrEmpty(this.tbxKey.Text)
                || string.IsNullOrEmpty(this.tbxCont.Text)
                )
            { return; }

            this._b64Cer = Convert.ToBase64String(System.IO.File.ReadAllBytes(this.tbxCertFile.Text));
            this._b64Key = Convert.ToBase64String(System.IO.File.ReadAllBytes(this.tbxKey.Text));
            this._b64Pwd = Convert.ToBase64String(System.Text.Encoding.UTF8.GetBytes(this.tbxCont.Text));

            this.DialogResult= DialogResult.OK;
            this.Close();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Microsoft.WindowsAPICodePack.Shell.PropertySystem.SystemProperties.System;

namespace Navegador_CPD
{
    public partial class frmPassword : Form
    {
        private frmMain frmMain;

        public frmPassword(frmMain frm)
        {
            InitializeComponent();
            this.frmMain = frm;
        }

        private void buttonValidarSenha_Click(object sender, EventArgs e)
        {
            String password = "farias@1987";
            String txtPassword = textBoxPassword.Text;

            if (password.Equals(txtPassword))
            {
                MessageBox.Show("Senha correta", "Acesso Confirmado", MessageBoxButtons.OK, MessageBoxIcon.Information);

                
                frmMain.addressBar.Enabled = true;
                frmMain.btn_Fav.Enabled = true;
                frmMain.btn_RemovFav.Enabled = true;

                this.Close(); 
            }
            else
            {
                MessageBox.Show("Senha incorreta", "Acesso Negado", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxPassword.Text = "";
                textBoxPassword.Focus();
            }
        }


        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            this.Close(); 
        }
    }
}

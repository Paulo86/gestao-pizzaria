using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gestor.UI.Principal
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLogar_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            FrmHome formPrincipal = new  FrmHome();
            formPrincipal.ShowDialog();
            //
            this.cbbUsuario.SelectedIndex = -1;
            this.cbbUsuario.Text = "";
            this.txtSenha.Text = "";
            this.Visible = true;
            this.cbbUsuario.Focus();
            this.Update();     
        }
    }
}

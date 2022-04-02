using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab02_01
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            string[] Usuario = { "user1", "user2", "user3" };
            string[] Password = { "12345", "123456", "1234567" };

            if (Usuario[0] == txtUsuario.Text && Password[0] == txtPassword.Text)
            {
                PrincipalMDI principal = new PrincipalMDI();
                principal.Show();
                this.Hide();
            }
            else
                MessageBox.Show("Enter valid username and/or password");
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

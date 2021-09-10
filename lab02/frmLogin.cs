using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab02
{
    public partial class frmLogin : Form
    {

        String[] users = { "Raul", "Jose", "Kevin" };
        String[] pass = { "raul123", "jose123", "kevin123" };

        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            //TODO - CREAR FORMULARIO MDI PARA ENLAZAR

            String user = txtUsuario.Text;
            String password = txtPassword.Text;

            for (int i = 0; i < users.Length; i++) {

                if (users[i] == user) {

                    if (pass[i] == password) {

                        PrincipalMDI principal = new PrincipalMDI();
                        principal.Show();
                        this.Hide();

                    }

                }

            }
            
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

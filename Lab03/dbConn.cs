using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Lab03
{
    public partial class dbConn : Form
    {
        SqlConnection conn;
        public dbConn()
        {
            InitializeComponent();
        }

        private void dbConn_Load(object sender, EventArgs e)
        {

        }

        private void btnConectar_Click(object sender, EventArgs e)
        {
            String servidor = txtServidor.Text;
            String bd = txtBaseDatos.Text;
            String user = txtUsuario.Text;
            String pwd = txtPassword.Text;

            String str = "Server=" + servidor + ";DataBase=" + bd + ";";

            if (chkAutenticacion.Checked)
            {
                str += "Integrated Security=true";
            }
            else {
                str += "User Id=" + user + ";Password=" + pwd + ";";
            }

            try
            {
                conn = new SqlConnection(str);
                conn.Open();
                MessageBox.Show("Conectado satisfactoriamente");
                btnDesconectar.Enabled = true;
            }
            catch (Exception ex) {
                MessageBox.Show("Error al conectar el servidor: \n" + ex.ToString());
            }

        }

        private void btnEstado_Click(object sender, EventArgs e)
        {
            try
            {
                if (conn.State == ConnectionState.Open)
                {
                    MessageBox.Show("Estado del servidor: " + conn.State + "\nVersion del servidor: " + conn.ServerVersion + "\nBase de datos: " + conn.Database);
                }
                else {
                    MessageBox.Show("Estado del servidor: " + conn.State);
                }
            }
            catch (Exception ex) {
                MessageBox.Show("Imposible determinar el estado del servidor: \n" + ex.ToString());
            }
        }

        private void btnDesconectar_Click(object sender, EventArgs e)
        {
            try
            {
                if (conn.State != ConnectionState.Closed)
                {
                    conn.Close();
                    MessageBox.Show("Conexion cerrada satisfactoriamente");
                }
                else {
                    MessageBox.Show("La conexion ya esta cerrada");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrio un error al cerrar la conexion: \n" + ex.ToString());
            }
        }

        private void chkAutenticacion_CheckedChanged(object sender, EventArgs e)
        {
            if (chkAutenticacion.Checked)
            {
                txtUsuario.Enabled = false;
                txtPassword.Enabled = false;
            }
            else {
                txtUsuario.Enabled = true;
                txtPassword.Enabled = true;
            }
        }
    }
}

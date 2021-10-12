using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace Lab06
{
    public partial class ManPersona : Form
    {

        SqlConnection con;
        DataSet ds = new DataSet();
        DataTable tablePerson = new DataTable();

        public ManPersona()
        {
            InitializeComponent();
        }

        private void ManPersona_Load(object sender, EventArgs e)
        {
            String str = "Server=DESKTOP-N7M7D7H\\LOCAL;Database=School;Integrated Security=true;";
            con = new SqlConnection(str);

            txtPersonID.Enabled = false;
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            String sql = "SELECT * FROM Person";
            SqlCommand cmd = new SqlCommand(sql, con);

            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = cmd;
            adapter.Fill(ds, "Person");

            tablePerson = ds.Tables["Person"];

            dgvListado.DataSource = "";
            dgvListado.Refresh();
            dgvListado.DataSource = tablePerson;
            dgvListado.Refresh();
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("InsertPerson", con);

            cmd.Parameters.Add("@LastName", SqlDbType.VarChar, 50, "LastName");
            cmd.Parameters.Add("@FirstName", SqlDbType.VarChar, 50, "FirstName");
            cmd.Parameters.Add("@HireDate", SqlDbType.Date).SourceColumn = "HireDate";
            cmd.Parameters.Add("@EnrollmentDate", SqlDbType.Date).SourceColumn = "EnrollmentDate";

            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.InsertCommand = cmd;
            adapter.InsertCommand.CommandType = CommandType.StoredProcedure;

            DataRow fila = tablePerson.NewRow();
            fila["LastName"] = txtLastName.Text;
            fila["FirstName"] = txtLastName.Text;
            fila["HireDate"] = txtLastName.Text;
            fila["EnrollmentDate"] = txtLastName.Text;

            tablePerson.Rows.Add(fila);

            adapter.Update(tablePerson);
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("UpdatePerson", con);

            cmd.Parameters.Add("@PersonID", SqlDbType.VarChar).SourceColumn = "PersonID";
            cmd.Parameters.Add("@LastName", SqlDbType.VarChar).SourceColumn = "LastName";
            cmd.Parameters.Add("@FirstName", SqlDbType.VarChar).SourceColumn = "FirstName";
            cmd.Parameters.Add("@HireDate", SqlDbType.Date).SourceColumn = "HireDate";
            cmd.Parameters.Add("@EnrollmentDate", SqlDbType.Date).SourceColumn = "EnrollmentDate";

            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.UpdateCommand = cmd;
            adapter.UpdateCommand.CommandType = CommandType.StoredProcedure;


            DataRow[] fila = tablePerson.Select("PersonID = '" + txtPersonID.Text + "'");
            fila[0]["LastName"] = txtLastName.Text;
            fila[0]["FirstName"] = txtLastName.Text;
            fila[0]["HireDate"] = txtLastName.Text;
            fila[0]["EnrollmentDate"] = txtLastName.Text;

            adapter.Update(tablePerson);
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("DeletePerson", con);
            cmd.Parameters.Add("@PersonID", SqlDbType.VarChar).SourceColumn = "PersonID";

            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.DeleteCommand = cmd;
            adapter.DeleteCommand.CommandType = CommandType.StoredProcedure;

            DataRow[] fila = tablePerson.Select("PersonID = '" + txtPersonID.Text + "'");

            tablePerson.Rows.Remove(fila[0]);

            adapter.Update(tablePerson);
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            DataView dv = new DataView(tablePerson);
            dv.RowFilter = "PersonID = '" + txtPersonID.Text + "'";
            dgvListado.DataSource = dv;
        }

        private void dgvListado_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvListado.SelectedRows.Count > 0)
            {
                txtPersonID.Text = dgvListado.SelectedRows[0].Cells[0].Value.ToString();
                txtLastName.Text = dgvListado.SelectedRows[0].Cells[1].Value.ToString();
                txtFirstName.Text = dgvListado.SelectedRows[0].Cells[2].Value.ToString();

                string hiredate = dgvListado.SelectedRows[0].Cells[3].Value.ToString();
                if (String.IsNullOrEmpty(hiredate))
                    txtHireDate.Checked = false;
                else
                    txtHireDate.Text = hiredate;

                string enrollmentDate = dgvListado.SelectedRows[0].Cells[4].Value.ToString();
                if (String.IsNullOrEmpty(enrollmentDate))
                    txtEnrollmentDate.Checked = false;
                else
                    txtEnrollmentDate.Text = enrollmentDate;

            }
        }

        private void btnNombre_Click(object sender, EventArgs e)
        {
            DataView dv = new DataView(tablePerson);
            dv.RowFilter = "FirstName = '" + txtFirstName.Text + "'";
            dgvListado.DataSource = dv;
        }

        private void btnApellidos_Click(object sender, EventArgs e)
        {
            DataView dv = new DataView(tablePerson);
            dv.RowFilter = "LastName = '" + txtLastName.Text + "'";
            dgvListado.DataSource = dv;
        }
    }
}

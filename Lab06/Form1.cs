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
    public partial class Form1 : Form
    {

        SqlConnection con;
        DataSet ds = new DataSet();
        DataTable tablePerson = new DataTable();

        public Form1()
        {
            InitializeComponent();
        }

    }
}

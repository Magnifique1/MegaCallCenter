using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MegaCallCenter
{
    public partial class Dashboard : Form
    {
        SqlConnection cn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        MWDBCon dbcon = new MWDBCon();

        public Dashboard()
        {
            InitializeComponent();
            cn = new SqlConnection(dbcon.MyConnection());
        }
    }
}

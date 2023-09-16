using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ComponentFactory.Krypton.Toolkit;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;

namespace ISyncAssessmentContactApplication.Forms
{
    public partial class CreateContact : KryptonForm
    {
        string connStr = ConfigurationManager.ConnectionStrings["ApplicationConnectionString"].ConnectionString;

        public CreateContact()
        {
            InitializeComponent();
            PopulateCategoryComboBox();
        }

        private void CreateContact_Load(object sender, EventArgs e)
        {

        }

        public void PopulateCategoryComboBox()
        {
            SqlConnection conn = new SqlConnection(connStr);
            conn.Open();

            SqlCommand cmd = new SqlCommand("SELECT * FROM dbo.Category", conn);
            SqlDataAdapter sdr = new SqlDataAdapter(cmd);

            DataSet ds = new DataSet();

            sdr.Fill(ds);
            cmd.ExecuteNonQuery();
            conn.Close();

            categoryDropdownBox.DataSource = ds.Tables[0];
            categoryDropdownBox.DisplayMember = "CategoryName";
            categoryDropdownBox.ValueMember = "Id";
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}

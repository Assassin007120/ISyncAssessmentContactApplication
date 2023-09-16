using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ComponentFactory.Krypton.Toolkit;
using ISyncAssessmentContactApplication.Forms;

namespace ISyncAssessmentContactApplication
{
    public partial class Form1 : KryptonForm
    {
        string connStr = ConfigurationManager.ConnectionStrings["ApplicationConnectionString"].ConnectionString;

        public Form1()
        {
            SqlConnection conn = new SqlConnection(connStr);
            conn.Open();

            InitializeComponent();
        }

        private void createCategoryBtn_Click(object sender, EventArgs e)
        {
            var createCategoryFrm = new CreateCategoryFrm();

            createCategoryFrm.ShowDialog();
        }

        private void kryptonButton1_Click(object sender, EventArgs e)
        {
            var createContactFrm = new CreateContact();

            createContactFrm.ShowDialog();
        }
    }
}

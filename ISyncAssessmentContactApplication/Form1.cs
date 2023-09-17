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
        //Connection String
        string connStr = ConfigurationManager.ConnectionStrings["ApplicationConnectionString"].ConnectionString;

        public Form1()
        {
            InitializeComponent();
        }

        private void createCategoryBtn_Click(object sender, EventArgs e)
        {
            //Instance of CreateCategoryForm
            var createCategoryFrm = new CreateCategoryFrm();

            //Show Dialog on button click
            createCategoryFrm.ShowDialog();
        }

        private void kryptonButton1_Click(object sender, EventArgs e)
        {
            //Instance of CreateCategoryForm
            var contactListFrm = new ContactList();

            //Show Dialog on button click
            contactListFrm.ShowDialog();
        }
    }
}

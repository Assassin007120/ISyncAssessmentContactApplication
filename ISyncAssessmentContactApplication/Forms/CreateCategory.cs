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
using System.Data.SqlClient;
using System.Configuration;
using ISyncAssessmentContactApplication.DTOs;

namespace ISyncAssessmentContactApplication.Forms
{
    public partial class CreateCategoryFrm : KryptonForm
    {
        string connStr = ConfigurationManager.ConnectionStrings["ApplicationConnectionString"].ConnectionString;
        EditCategoryDTO editCategoryDTO = new EditCategoryDTO();
        public CreateCategoryFrm()
        {
            InitializeComponent();
            CategoryDataItems();
        }
        private void kryptonTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void isActiveCheckBox_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void createCategoryBtn_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(connStr);
            conn.Open();

            try
            {
                string categoryText = categoryTextBox.Text;
                int isActive = Convert.ToInt32(isActiveCheckBox.Checked);

                if (categoryText == null)
                {
                    MessageBox.Show("Invalid User Input. Category cannot be left blank.");
                };

                SqlCommand cmd = new SqlCommand("INSERT INTO dbo.Category (CategoryName, IsActive) VALUES ('" + categoryText + "', " + isActive + ");", conn);

                int i = cmd.ExecuteNonQuery();

                if (i != 0)
                {
                    MessageBox.Show("Category saved!", "Success");
                    CategoryDataItems();
                }
                else
                {
                    MessageBox.Show("Failed to Save!", "Error");
                }

                conn.Close();
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }

        public void CategoryDataItems()
        {
            try
            {
                SqlConnection conn = new SqlConnection(connStr);

                string queryCategoryData = "SELECT * FROM dbo.Category";
                SqlCommand cmd = new SqlCommand(queryCategoryData, conn);

                SqlDataAdapter sdr = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();

                conn.Open();

                sdr.Fill(dt);
                categoryDataGridView.DataSource = dt;

                conn.Close();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Exception");
            }
        }

        private void CreateCategoryFrm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'iSyncContactdBDataSet2.Category' table. You can move, or remove it, as needed.
            this.categoryTableAdapter1.Fill(this.iSyncContactdBDataSet2.Category);
            // TODO: This line of code loads data into the 'iSyncContactdBDataSet.Category' table. You can move, or remove it, as needed.
            this.categoryTableAdapter.Fill(this.iSyncContactdBDataSet.Category);

        }

        private void categorySearchTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                SqlConnection conn = new SqlConnection(connStr);

                string queryCategoryData = "SELECT * FROM dbo.Category WHERE CategoryName LIKE '" + categorySearchTextBox.Text + "%'";
                SqlCommand cmd = new SqlCommand(queryCategoryData, conn);

                SqlDataAdapter sdr = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();

                conn.Open();

                sdr.Fill(dt);
                categoryDataGridView.DataSource = dt;

                conn.Close();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Exception");
            }
        }

        private void kryptonLabel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void categoryDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (categoryDataGridView.CurrentCell.ColumnIndex.Equals(3) && e.RowIndex != -1)
                {
                    editCategoryDTO.Id = Convert.ToInt32(categoryDataGridView.Rows[e.RowIndex].Cells[0].Value);
                    editCategoryDTO.CategoryName = categoryDataGridView.Rows[e.RowIndex].Cells[1].Value.ToString();
                    editCategoryDTO.isActive = Convert.ToInt32(categoryDataGridView.Rows[e.RowIndex].Cells[2].Value);

                    EditCategory(editCategoryDTO);
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Exception");
            }
        }

        private void EditCategory(EditCategoryDTO editCategoryDTO)
        {
            try
            {
                SqlConnection conn = new SqlConnection(connStr);

                string queryCategoryToEdited = "UPDATE dbo.Category SET CategoryName = '" + editCategoryDTO.CategoryName + "', IsActive = " + editCategoryDTO.isActive + " WHERE Id = " + editCategoryDTO.Id + "";

                SqlCommand cmd = new SqlCommand(queryCategoryToEdited, conn);

                conn.Open();

                int i = cmd.ExecuteNonQuery();

                if (i != 0)
                {
                    MessageBox.Show("Category Updated!", "Success");
                    CategoryDataItems();
                }
                else
                {
                    MessageBox.Show("Category failed to update!", "Error");
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Exception");
            }
        }
    }
}

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
            //Open connection
            conn.Open();

            try
            {
                //Collect data from form fields
                string categoryText = categoryTextBox.Text;
                int isActive = Convert.ToInt32(isActiveCheckBox.Checked);

                //Check if category name field is not empty
                if (categoryText == null)
                {
                    //Return Message to the user to input a valid string
                    MessageBox.Show("Invalid User Input. Category cannot be left blank.", "Error");
                };

                //Create INSERT string to Db
                string insert = "INSERT INTO dbo.Category (CategoryName, IsActive) VALUES ('" + categoryText + "', " + isActive + ");";

                //Send insert command to database
                SqlCommand cmd = new SqlCommand(insert, conn);

                //Run SQL Statement, return result value to i variable
                int i = cmd.ExecuteNonQuery();

                //If statement to check success of the command execution
                if (i != 0)
                {
                    //Show messagebox of success to user
                    MessageBox.Show("Category saved!", "Success");

                    //Refresh DateGridView
                    CategoryDataItems();
                }
                else
                {
                    //Show failure messagebox
                    MessageBox.Show("Failed to Save!", "Error");
                }

                //Close SQL connection
                conn.Close();
            }
            catch (Exception error)
            {
                //Handle any exceptions that get may occur and return result to user
                MessageBox.Show(error.Message);
            }
        }

        //Get all Category records currently in the db
        public void CategoryDataItems()
        {
            try
            {
                SqlConnection conn = new SqlConnection(connStr);

                //query string
                string queryCategoryData = "SELECT * FROM dbo.Category";

                //Send query command to db
                SqlCommand cmd = new SqlCommand(queryCategoryData, conn);

                SqlDataAdapter sdr = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();

                //Open Connection
                conn.Open();

                //Insert and set data from db into DataTable
                sdr.Fill(dt);
                categoryDataGridView.DataSource = dt;

                //Close connection
                conn.Close();
            }
            catch (Exception exception)
            {
                //Handle any exceptions that get may occur and return result to user
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

        //Search Box Functionality
        private void categorySearchTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                SqlConnection conn = new SqlConnection(connStr);

                //Query string with textbox data
                string queryCategoryData = "SELECT * FROM dbo.Category WHERE CategoryName LIKE '" + categorySearchTextBox.Text + "%'";
                SqlCommand cmd = new SqlCommand(queryCategoryData, conn);

                SqlDataAdapter sdr = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();

                //Open connection
                conn.Open();

                //Insert and set data from db into DataTable based on text from searchBox
                sdr.Fill(dt);
                categoryDataGridView.DataSource = dt;

                //Close connection
                conn.Close();
            }
            catch (Exception exception)
            {
                //Handle any exceptions that get may occur and return result to user
                MessageBox.Show(exception.Message, "Exception");
            }
        }

        private void kryptonLabel1_Paint(object sender, PaintEventArgs e)
        {

        }

        //Edit Btn
        private void categoryDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                //Check for button click in correct column (Edit)
                if (categoryDataGridView.CurrentCell.ColumnIndex.Equals(3) && e.RowIndex != -1)
                {
                    //Collect data from cells
                    editCategoryDTO.Id = Convert.ToInt32(categoryDataGridView.Rows[e.RowIndex].Cells[0].Value);
                    editCategoryDTO.CategoryName = categoryDataGridView.Rows[e.RowIndex].Cells[1].Value.ToString();
                    editCategoryDTO.isActive = Convert.ToInt32(categoryDataGridView.Rows[e.RowIndex].Cells[2].Value);

                    //Pass DTO to edit method
                    EditCategory(editCategoryDTO);
                }
            }
            catch (Exception exception)
            {
                //Handle any exceptions that get may occur and return result to user
                MessageBox.Show(exception.Message, "Exception");
            }
        }

        //Edit Function
        private void EditCategory(EditCategoryDTO editCategoryDTO)
        {
            try
            {
                SqlConnection conn = new SqlConnection(connStr);

                //Update string with edited data from datagridView
                string queryCategoryToEdited = "UPDATE dbo.Category SET CategoryName = '" + editCategoryDTO.CategoryName + "', IsActive = " + editCategoryDTO.isActive + " WHERE Id = " + editCategoryDTO.Id + "";

                SqlCommand cmd = new SqlCommand(queryCategoryToEdited, conn);

                //Open connection
                conn.Open();

                //Run SQL Statement, return rsult value to i variable
                int i = cmd.ExecuteNonQuery();

                //If statement to check success of the command execution
                if (i != 0)
                {
                    //Show messagebox of success to user
                    MessageBox.Show("Category Updated!", "Success");

                    //Refresh DateGridView
                    CategoryDataItems();
                }
                else
                {
                    //Show failure messagebox
                    MessageBox.Show("Category failed to update!", "Error");
                }
            }
            catch (Exception exception)
            {
                //Handle any exceptions that get may occur and return result to user
                MessageBox.Show(exception.Message, "Exception");
            }
        }
    }
}

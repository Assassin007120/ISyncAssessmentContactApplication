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
using ISyncAssessmentContactApplication.DTOs;

namespace ISyncAssessmentContactApplication.Forms
{
    public partial class ContactList : KryptonForm
    {
        //Global variables
        string connStr = ConfigurationManager.ConnectionStrings["ApplicationConnectionString"].ConnectionString;
        EditContactDTO editContactDTO = new EditContactDTO();
        public ContactList()
        {
            InitializeComponent();
            GetContacts();
        }

        //Get all contacts currently in the database to populate DataGridView
        public void GetContacts()
        {
            try
            {
                SqlConnection conn = new SqlConnection(connStr);

                //string query of contact data
                string queryContactsData = "SELECT * FROM dbo.Contact";
                SqlCommand cmd = new SqlCommand(queryContactsData, conn);

                SqlDataAdapter sdr = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();

                //Open connection
                conn.Open();

                //Insert and set data from db into DataTable
                sdr.Fill(dt);
                contactDataGridView.DataSource = dt;

                //Close connection
                conn.Close();
            }
            catch (Exception ex)
            {
                //Handle any exceptions that get may occur and return result to user
                MessageBox.Show(ex.Message);
            }
        }

        private void ContactList_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'iSyncContactdBDataSet1.Contact' table. You can move, or remove it, as needed.
            this.contactTableAdapter.Fill(this.iSyncContactdBDataSet1.Contact);

        }

        //Search Function
        private void contactSearchTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                SqlConnection conn = new SqlConnection(connStr);

                //Query string with textbox data
                string queryContactData = "SELECT * FROM dbo.Contact WHERE FirstName LIKE '" + contactSearchTextBox.Text + "%'";
                SqlCommand cmd = new SqlCommand(queryContactData, conn);

                SqlDataAdapter sdr = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                BindingSource bs = new BindingSource();

                //Open connection
                conn.Open();

                sdr.Fill(dt);
                bs.DataSource = contactDataGridView.DataSource;
                contactDataGridView.DataSource = dt;

                //Close connection
                conn.Close();
            }
            catch (Exception exception)
            {
                //Handle any exceptions that get may occur and return result to user
                MessageBox.Show(exception.Message, "Exception");
            }
        }

        //Btn click to CreateContactFrm
        private void createContactBtn_Click(object sender, EventArgs e)
        {
            var createContactFrm = new CreateContact();

            createContactFrm.ShowDialog();
        }

        //Is Active Filter Btn
        private void isActiveFilterBtn_Click(object sender, EventArgs e)
        {
            try
            {
                //Call isActiveFilter method
                isActiveFilter();
            }
            catch (Exception exception)
            {
                //Handle any exceptions that get may occur and return result to user
                MessageBox.Show(exception.Message, "Exception");
            }
        }

        //Active Filter Function
        public void isActiveFilter()
        {
            try
            {
                SqlConnection conn = new SqlConnection(connStr);

                //query to select all where the contacts are active
                string queryContactFilteredDate = "SELECT * FROM dbo.Contact WHERE ACTIVE = 1";

                SqlCommand cmd = new SqlCommand(queryContactFilteredDate, conn);

                SqlDataAdapter sdr = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                BindingSource bs = new BindingSource();

                //Open Connection
                conn.Open();

                //Insert and set filtered data
                sdr.Fill(dt);
                bs.DataSource = contactDataGridView.DataSource;
                contactDataGridView.DataSource = dt;

                //Close Connection
                conn.Close();
            }
            catch (Exception exception)
            {
                //Handle any exceptions that get may occur and return result to user
                MessageBox.Show(exception.Message, "Exception");
            }
        }

        //Is Inactive Filter Btn
        private void inactiveFilterBtn_Click(object sender, EventArgs e)
        {
            try
            {
                //Call IsInActive Filter method
                isInactiveFilter();
            }
            catch (Exception exception)
            {
                //Handle any exceptions that get may occur and return result to user
                MessageBox.Show(exception.Message, "Exception");
            }
        }

        //Inactive filter function
        public void isInactiveFilter()
        {
            try
            {
                SqlConnection conn = new SqlConnection(connStr);

                //query to select all contacts that are not active
                string queryContactFilteredData = "SELECT * FROM dbo.Contact WHERE ACTIVE = 0";

                SqlCommand cmd = new SqlCommand(queryContactFilteredData, conn);

                SqlDataAdapter sdr = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                BindingSource bs = new BindingSource();

                //Open Connection
                conn.Open();

                //Insert and set filtered data into datatable
                sdr.Fill(dt);
                bs.DataSource = contactDataGridView.DataSource;
                contactDataGridView.DataSource = dt;

                //Close Connection
                conn.Close();
            }
            catch (Exception exception)
            {
                //Handle any exceptions that get may occur and return result to user
                MessageBox.Show(exception.Message, "Exception");
            }
        }

        //Cell Button Clicks
        private void contactDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                //Edit Contact - check if the edit cell has been selected
                if (contactDataGridView.CurrentCell.ColumnIndex.Equals(9) && e.RowIndex != -1)
                {
                    //Get all data from each cell on that row
                    editContactDTO.Id = Convert.ToInt32(contactDataGridView.Rows[e.RowIndex].Cells[0].Value); //Convert value to int
                    editContactDTO.CategoryId = Convert.ToInt32(contactDataGridView.Rows[e.RowIndex].Cells[1].Value); //Convert value to int

                    editContactDTO.FirstName = contactDataGridView.Rows[e.RowIndex].Cells[2].Value.ToString(); //Convert value to string
                    editContactDTO.LastName = contactDataGridView.Rows[e.RowIndex].Cells[3].Value.ToString(); //Convert value to string
                    editContactDTO.DateOfBirth = Convert.ToDateTime(contactDataGridView.Rows[e.RowIndex].Cells[4].Value); //Convert Value to DateTime

                    editContactDTO.CellNumber = contactDataGridView.Rows[e.RowIndex].Cells[5].Value.ToString(); //Convert value to string
                    editContactDTO.Email = contactDataGridView.Rows[e.RowIndex].Cells[6].Value.ToString(); //Convert value to string
                    editContactDTO.IsActive = Convert.ToInt32(contactDataGridView.Rows[e.RowIndex].Cells[8].Value); //Convert value to int

                    //Pass DTO to edit method
                    EditContact(editContactDTO);
                }

                //Delete Contact - check if the delete cell has been selected
                if (contactDataGridView.CurrentCell.ColumnIndex.Equals(10) && e.RowIndex != -1)
                {
                    //Get contactId of row selected
                    int contactId = Convert.ToInt32(contactDataGridView.Rows[e.RowIndex].Cells[0].Value);

                    //Pass contactId to Delete method
                    DeleteContact(contactId);
                }
            }
            catch (Exception exception)
            {
                //Handle any exceptions that get may occur and return result to user
                MessageBox.Show(exception.Message, "Exception");
            }
        }

        //Edit Contact Function
        private void EditContact(EditContactDTO editContactDTO)
        {
            try
            {
                SqlConnection conn = new SqlConnection(connStr);

                //Update statement with DTO data foreach table column
                string queryContactToBeEdited = "UPDATE dbo.Contact SET CategoryId = " + editContactDTO.CategoryId + ", FirstName = '" + editContactDTO.FirstName + "', LastName = '" + editContactDTO.LastName + "', DateOfBirth = '" + editContactDTO.DateOfBirth + "', CellNumber = '" + editContactDTO.CellNumber + "', Email = '" + editContactDTO.Email + "', ACTIVE = " + editContactDTO.IsActive + " WHERE Id = " + editContactDTO.Id + "";

                SqlCommand cmd = new SqlCommand(queryContactToBeEdited, conn);

                //Open connection
                conn.Open();

                //Run SQL Statement, return result value to i variable
                int i = cmd.ExecuteNonQuery();

                //If statement to check success of the command execution
                if (i != 0)
                {
                    //Show messagebox of success to user
                    MessageBox.Show("Contact Updated!", "Success");

                    //Refresh DataGridView
                    GetContacts();
                }
                else
                {
                    //Show failure messagebox
                    MessageBox.Show("Contact Failed to update!", "Error");
                }

                //Close connection
                conn.Close();
            }
            catch (Exception exception)
            {
                //Handle any exceptions that get may occur and return result to user
                MessageBox.Show(exception.Message, "Exception");
            }
        }

        //Delete Contact Function
        private void DeleteContact(int contactId)
        {
            try
            {
                SqlConnection conn = new SqlConnection(connStr);

                //Delete statement for contact where contactId matches
                string queryContactToBeDeleted = "DELETE FROM dbo.Contact WHERE Id = " + contactId + "";

                SqlCommand cmd = new SqlCommand(queryContactToBeDeleted, conn);

                //Open connection
                conn.Open();

                //Run SQL Statement, return result value to i variable
                int i = cmd.ExecuteNonQuery();

                //If statement to check success of the command execution
                if (i != 0)
                {
                    //Show messagebox of success to user
                    MessageBox.Show("Contact deleted!", "Success");

                    //Refresh DataGridView
                    GetContacts();
                }
                else
                {
                    //Show failure messagebox
                    MessageBox.Show("Contact to delete", "Error");
                }

                //Close connection
                conn.Close();
            }
            catch (Exception exception)
            {
                //Handle any exceptions that get may occur and return result to user
                MessageBox.Show(exception.Message, "Exception");
            }
        }

        //Filter All Contacts Button
        private void filterAllBtn_Click(object sender, EventArgs e)
        {
            try
            {
                //Call FilterAllContacts() method
                FilterAllContacts();
            }
            catch (Exception exception)
            {
                //Handle any exceptions that get may occur and return result to user
                MessageBox.Show(exception.Message, "Exception");
            }
        }
        
        //Filter All Contacts Method
        private void FilterAllContacts()
        {
            try
            {
                SqlConnection conn = new SqlConnection(connStr);

                //query to select all contacts
                string queryContactFilteredData = "SELECT * FROM dbo.Contact";

                SqlCommand cmd = new SqlCommand(queryContactFilteredData, conn);

                SqlDataAdapter sdr = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                BindingSource bs = new BindingSource();

                //Open Connection
                conn.Open();

                //Insert and set filtered data into datatable
                sdr.Fill(dt);
                bs.DataSource = contactDataGridView.DataSource;
                contactDataGridView.DataSource = dt;

                //Close Connection
                conn.Close();
            }
            catch (Exception exception)
            {
                //Handle any exceptions that get may occur and return result to user
                MessageBox.Show(exception.Message, "Exception");
            }
        }
    }
}

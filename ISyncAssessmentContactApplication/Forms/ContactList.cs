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
        string connStr = ConfigurationManager.ConnectionStrings["ApplicationConnectionString"].ConnectionString;
        EditContactDTO editContactDTO = new EditContactDTO();
        public ContactList()
        {
            InitializeComponent();
            GetContacts();
        }

        public void GetContacts()
        {
            try
            {
                SqlConnection conn = new SqlConnection(connStr);

                string queryContactsData = "SELECT * FROM dbo.Contact";
                SqlCommand cmd = new SqlCommand(queryContactsData, conn);

                SqlDataAdapter sdr = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();

                conn.Open();

                sdr.Fill(dt);
                contactDataGridView.DataSource = dt;

                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ContactList_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'iSyncContactdBDataSet1.Contact' table. You can move, or remove it, as needed.
            this.contactTableAdapter.Fill(this.iSyncContactdBDataSet1.Contact);

        }

        private void contactSearchTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                SqlConnection conn = new SqlConnection(connStr);

                string queryContactData = "SELECT * FROM dbo.Contact WHERE FirstName LIKE '" + contactSearchTextBox.Text + "%'";
                SqlCommand cmd = new SqlCommand(queryContactData, conn);

                SqlDataAdapter sdr = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                BindingSource bs = new BindingSource();

                conn.Open();

                sdr.Fill(dt);
                bs.DataSource = contactDataGridView.DataSource;
                contactDataGridView.DataSource = dt;

                conn.Close();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Exception");
            }
        }

        private void createContactBtn_Click(object sender, EventArgs e)
        {
            var createContactFrm = new CreateContact();

            createContactFrm.ShowDialog();
        }

        private void isActiveFilterBtn_Click(object sender, EventArgs e)
        {
            try
            {
                isActiveFilter();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Exception");
            }
        }

        public void isActiveFilter()
        {
            try
            {
                SqlConnection conn = new SqlConnection(connStr);

                string queryContactFilteredDate = "SELECT * FROM dbo.Contact WHERE ACTIVE = 1";

                SqlCommand cmd = new SqlCommand(queryContactFilteredDate, conn);

                SqlDataAdapter sdr = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                BindingSource bs = new BindingSource();

                conn.Open();

                sdr.Fill(dt);
                bs.DataSource = contactDataGridView.DataSource;
                contactDataGridView.DataSource = dt;

                conn.Close();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Exception");
            }
        }

        private void inactiveFilterBtn_Click(object sender, EventArgs e)
        {
            try
            {
                isInactiveFilter();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Exception");
            }
        }

        public void isInactiveFilter()
        {
            try
            {
                SqlConnection conn = new SqlConnection(connStr);

                string queryContactFilteredData = "SELECT * FROM dbo.Contact WHERE ACTIVE = 0";

                SqlCommand cmd = new SqlCommand(queryContactFilteredData, conn);

                SqlDataAdapter sdr = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                BindingSource bs = new BindingSource();

                conn.Open();

                sdr.Fill(dt);
                bs.DataSource = contactDataGridView.DataSource;
                contactDataGridView.DataSource = dt;

                conn.Close();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Exception");
            }
        }

        private void contactDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                //Delete Contact
                if (contactDataGridView.CurrentCell.ColumnIndex.Equals(9) && e.RowIndex != -1)
                {
                    int contactId = Convert.ToInt32(contactDataGridView.Rows[e.RowIndex].Cells[0].Value);

                    DeleteContact(contactId);
                }

                //Edit Contact
                if (contactDataGridView.CurrentCell.ColumnIndex.Equals(10) && e.RowIndex != -1)
                {
                    editContactDTO.Id = Convert.ToInt32(contactDataGridView.Rows[e.RowIndex].Cells[0].Value);
                    editContactDTO.CategoryId = Convert.ToInt32(contactDataGridView.Rows[e.RowIndex].Cells[1].Value);
                    editContactDTO.FirstName = contactDataGridView.Rows[e.RowIndex].Cells[2].Value.ToString();
                    editContactDTO.LastName = contactDataGridView.Rows[e.RowIndex].Cells[3].Value.ToString();
                    editContactDTO.DateOfBirth = Convert.ToDateTime(contactDataGridView.Rows[e.RowIndex].Cells[4].Value);
                    editContactDTO.CellNumber = contactDataGridView.Rows[e.RowIndex].Cells[5].Value.ToString();
                    editContactDTO.Email = contactDataGridView.Rows[e.RowIndex].Cells[6].Value.ToString();
                    editContactDTO.IsActive = Convert.ToInt32(contactDataGridView.Rows[e.RowIndex].Cells[8].Value);

                    EditContact(editContactDTO);
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Exception");
            }
        }

        private void EditContact(EditContactDTO editContactDTO)
        {
            try
            {
                SqlConnection conn = new SqlConnection(connStr);

                string queryContactToBeEdited = "UPDATE dbo.Contact SET CategoryId = " + editContactDTO.CategoryId + ", FirstName = '" + editContactDTO.FirstName + "', LastName = '" + editContactDTO.LastName + "', DateOfBirth = '" + editContactDTO.DateOfBirth + "', CellNumber = '" + editContactDTO.CellNumber + "', Email = '" + editContactDTO.Email + "', ACTIVE = " + editContactDTO.IsActive + " WHERE Id = " + editContactDTO.Id + "";

                SqlCommand cmd = new SqlCommand(queryContactToBeEdited, conn);

                conn.Open();

                int i = cmd.ExecuteNonQuery();

                if (i != 0)
                {
                    MessageBox.Show("Contact Updated!", "Success");
                    GetContacts();
                }
                else
                {
                    MessageBox.Show("Contact Failed to update!", "Error");
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Exception");
            }
        }

        private void DeleteContact(int contactId)
        {
            try
            {
                SqlConnection conn = new SqlConnection(connStr);

                string queryContactToBeDeleted = "DELETE FROM dbo.Contact WHERE Id = " + contactId + "";

                SqlCommand cmd = new SqlCommand(queryContactToBeDeleted, conn);

                conn.Open();

                int i = cmd.ExecuteNonQuery();

                if (i != 0)
                {
                    MessageBox.Show("Contact deleted!", "Success");
                    GetContacts();
                }
                else
                {
                    MessageBox.Show("Contact to delete", "Error");
                }

                conn.Close();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Exception");
            }
        }
    }
}

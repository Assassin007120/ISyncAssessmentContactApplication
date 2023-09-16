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
using System.IO;
using ISyncAssessmentContactApplication.DTOs;
using System.Text.RegularExpressions;

namespace ISyncAssessmentContactApplication.Forms
{
    public partial class CreateContact : KryptonForm
    {
        string connStr = ConfigurationManager.ConnectionStrings["ApplicationConnectionString"].ConnectionString;
        ValidationMessageDTO messageDTO = new ValidationMessageDTO();
        ImageDTO imageDTO = new ImageDTO();
        int categoryId;

        public CreateContact()
        {
            SqlConnection conn = new SqlConnection(connStr);
            InitializeComponent();
            PopulateCategoryComboBox();
        }

        private void CreateContact_Load(object sender, EventArgs e)
        {

        }

        public void PopulateCategoryComboBox()
        {
            try
            {
                SqlConnection conn = new SqlConnection(connStr);
                conn.Open();

                string query = "SELECT * FROM dbo.Category WHERE IsActive = '1'";

                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    categoryDropdownBox.Items.Add(reader["CategoryName"].ToString());
                    categoryDropdownBox.DisplayMember = (reader["CategoryName"].ToString());
                    categoryDropdownBox.ValueMember = (reader["Id"].ToString());
                }

                conn.Close();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Exception");
            }
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void categoryDropdownBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                SqlConnection conn = new SqlConnection(connStr);
                conn.Open();

                string categoryQuery = "SELECT Id FROM dbo.Category WHERE CategoryName = '" + categoryDropdownBox.SelectedItem + "'";
                SqlCommand cmd = new SqlCommand(categoryQuery, conn);

                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    categoryId = Convert.ToInt32(reader[0]);
                }

                conn.Close();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Exception");
            }
        }

        private void createContactBtn_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection conn = new SqlConnection(connStr);
                conn.Open();

                string email = contactEmailTxtBox.Text;
                string fname = contactFirstNameTxtBox.Text;
                string lname = contactLastNameTxtbox.Text;

                messageDTO = ValidateEmailAddress(email);

                if (messageDTO.IsValid == false)
                {
                    MessageBox.Show(messageDTO.Message, "Error");
                }

                messageDTO = ValidateRequiredFormFields(email, fname, lname);

                if (messageDTO.IsValid == false)
                {
                    MessageBox.Show(messageDTO.Message, "Error");
                }

                string cellNumber = contactCellTxtBox.Text;
                DateTime dateOfBirth = Convert.ToDateTime(contactDateTimePicker.Value.ToShortDateString());
                bool isActive = isActiveContactCheckBox.Checked;
                DateTime dateCreated = DateTime.Now;
                byte[] image = imageDTO.imageByte;

                string contactInsert = "INSERT INTO dbo.Contact (CategoryId, FirstName, LastName, DateOfBirth, CellNumber, Email, ContactImage, DateCreated, ACTIVE) VALUES (@CategoryId, @FirstName, @LastName, @DateOfBirth, @CellNumber, @Email, @ContactImage, @DateCreated, @ACTIVE)";

                SqlCommand cmd = new SqlCommand(contactInsert, conn);

                cmd.Parameters.AddWithValue("@CategoryId", categoryId);
                cmd.Parameters.AddWithValue("@FirstName", fname);
                cmd.Parameters.AddWithValue("@LastName", lname);
                cmd.Parameters.AddWithValue("@DateOfBirth", dateOfBirth);
                cmd.Parameters.AddWithValue("@CellNumber", cellNumber);
                cmd.Parameters.AddWithValue("@Email", email);
                cmd.Parameters.AddWithValue("@ContactImage", image);
                cmd.Parameters.AddWithValue("@DateCreated", dateCreated);
                cmd.Parameters.AddWithValue("@ACTIVE", isActive);

                int i = cmd.ExecuteNonQuery();

                if (i != 0)
                {
                    MessageBox.Show("Contact Created!", "Success");

                    var contactListFrm = new ContactList();

                    contactListFrm.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Contact Failed to create!", "Error");
                }

                conn.Close();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Exception");
            }
        }

        private void uploadBtn_Click(object sender, EventArgs e)
        {
            try
            {
                GetImage();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Exception");
            }
        }

        private byte[] GetImage()
        {
            try
            {
                string sFile;
                OpenFileDialog openFileDialogBox = new OpenFileDialog();

                byte[] imgByte = null;

                openFileDialogBox.Filter = "Image File (*.jpg;*.bmp;*.gif)|*.jpg;*.bmp;*.gif";

                if (openFileDialogBox.ShowDialog() == DialogResult.OK)
                {
                    sFile = openFileDialogBox.FileName;
                    imageBox.Image = System.Drawing.Bitmap.FromFile(sFile);
                    imageBox.SizeMode = PictureBoxSizeMode.CenterImage;

                    using (MemoryStream mStream = new MemoryStream())
                    {
                        imageBox.Image.Save(mStream, imageBox.Image.RawFormat);
                        imgByte = mStream.ToArray();
                    }
                }

                imageDTO.imageByte = imgByte;

                return imgByte;
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Exception");
            }

            return null;
        }

        private void contactLastNameTxtbox_TextChanged(object sender, EventArgs e)
        {

        }

        private ValidationMessageDTO ValidateEmailAddress(string email)
        {
            ValidationMessageDTO validationDTO = new ValidationMessageDTO();
            try
            {
                if (email != null)
                {
                    Regex regex = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");

                    Match match = regex.Match(email);

                    if (match.Success)
                    {
                        validationDTO.IsValid = true;
                        validationDTO.Message = "Email Address is valid";

                        return validationDTO;
                    }
                    else
                    {
                        validationDTO.IsValid = false;
                        validationDTO.Message = "Email Address is failed validation";
                    }
                }

                return validationDTO;
            }
            catch (Exception exception)
            {
                validationDTO.IsValid = false;
                validationDTO.Message = exception.Message;

                return validationDTO;
            }
        }

        private ValidationMessageDTO ValidateRequiredFormFields(string email, string fname, string lname)
        {
            try
            {
                if (email == "")
                {
                    messageDTO.IsValid = false;
                    messageDTO.Message = "Invalid User Input. Email cannot be empty.";

                    return messageDTO;
                }

                if (fname == "")
                {
                    messageDTO.IsValid = false;
                    messageDTO.Message = "Invalid User Input. First Name cannot be empty.";

                    return messageDTO;
                }

                if (lname == "")
                {
                    messageDTO.IsValid = false;
                    messageDTO.Message = "Invalid User Input. Last Name cannot be empty.";

                    return messageDTO;
                }

                messageDTO.IsValid = true;
                messageDTO.Message = "Validation Successful";

                return messageDTO;
            }
            catch (Exception exception)
            {
                messageDTO.IsValid = false;
                messageDTO.Message = exception.Message;

                return messageDTO;
            }  
        }
    }
}

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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Xml.Linq;
using System.Diagnostics.Tracing;

namespace ISyncAssessmentContactApplication.Forms
{
    public partial class CreateContact : KryptonForm
    {
        //Global Variables
        string connStr = ConfigurationManager.ConnectionStrings["ApplicationConnectionString"].ConnectionString;
        ValidationMessageDTO messageDTO = new ValidationMessageDTO();
        ImageDTO imageDTO = new ImageDTO();
        int categoryId;

        public CreateContact()
        {
            InitializeComponent();
            PopulateCategoryComboBox();
        }

        private void CreateContact_Load(object sender, EventArgs e)
        {

        }

        //Populate Category Combo Box
        public void PopulateCategoryComboBox()
        {
            try
            {
                SqlConnection conn = new SqlConnection(connStr);

                //Open Connection
                conn.Open();

                //query select for categories that are active
                string query = "SELECT * FROM dbo.Category WHERE IsActive = '1'";

                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataReader reader = cmd.ExecuteReader();

                //While loop for all records
                while (reader.Read())
                {
                    //Insert data to dropdown box
                    categoryDropdownBox.Items.Add(reader["CategoryName"].ToString());
                    categoryDropdownBox.DisplayMember = (reader["CategoryName"].ToString());
                    categoryDropdownBox.ValueMember = (reader["Id"].ToString());
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

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void categoryDropdownBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                SqlConnection conn = new SqlConnection(connStr);

                //Open Connection
                conn.Open();

                //Select query where the categoryName selected matches
                string categoryQuery = "SELECT Id FROM dbo.Category WHERE CategoryName = '" + categoryDropdownBox.SelectedItem + "'";
                SqlCommand cmd = new SqlCommand(categoryQuery, conn);

                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    //Convert read value to int and equate to categoryId variable
                    categoryId = Convert.ToInt32(reader[0]);
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

        private void createContactBtn_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection conn = new SqlConnection(connStr);

                //Open Connection
                conn.Open();

                //Get text values from each text field
                string email = contactEmailTxtBox.Text;
                string fname = contactFirstNameTxtBox.Text;
                string lname = contactLastNameTxtbox.Text;
                byte[] image = imageDTO.imageByte;

                //Validate all required fields
                var validationResult = Validate(email, fname, lname, image);

                if (validationResult != false)
                {
                    //Get remaining values from form fields
                    string cellNumber = contactCellTxtBox.Text;
                    DateTime dateOfBirth = Convert.ToDateTime(contactDateTimePicker.Value.ToShortDateString()); //Convert value to ShortDateTimeString
                    bool isActive = isActiveContactCheckBox.Checked;
                    DateTime dateCreated = DateTime.Now;


                    //Create Insert SQL string
                    string contactInsert = "INSERT INTO dbo.Contact (CategoryId, FirstName, LastName, DateOfBirth, CellNumber, Email, ContactImage, DateCreated, ACTIVE) VALUES (@CategoryId, @FirstName, @LastName, @DateOfBirth, @CellNumber, @Email, @ContactImage, @DateCreated, @ACTIVE)";

                    SqlCommand cmd = new SqlCommand(contactInsert, conn);
                
                    //Add parameters with their corresponding values
                    cmd.Parameters.AddWithValue("@CategoryId", categoryId);
                    cmd.Parameters.AddWithValue("@FirstName", fname);
                    cmd.Parameters.AddWithValue("@LastName", lname);
                    cmd.Parameters.AddWithValue("@DateOfBirth", dateOfBirth);
                    cmd.Parameters.AddWithValue("@CellNumber", cellNumber);
                    cmd.Parameters.AddWithValue("@Email", email);
                    cmd.Parameters.AddWithValue("@ContactImage", image);
                    cmd.Parameters.AddWithValue("@DateCreated", dateCreated);
                    cmd.Parameters.AddWithValue("@ACTIVE", isActive);

                    //Run SQL Statement, return result value to i variable
                    int i = cmd.ExecuteNonQuery();

                    //If statement to check success of the command execution
                    if (i != 0)
                    {
                        //Show messagebox of success to user
                        MessageBox.Show("Contact Created!", "Success");

                        var contactListFrm = new ContactList();

                        //Redirect User to ContactListFrm
                        contactListFrm.ShowDialog();
                    }
                    else
                    {
                        //Show failure messagebox
                        MessageBox.Show("Contact Failed to create!", "Error");
                    }

                    //Close connection
                    conn.Close();

                    //Close dialogBox
                    this.Close();
                }

            }
            catch (Exception exception)
            {
                //Handle any exceptions that get may occur and return result to user
                MessageBox.Show(exception.Message, "Exception");
            }
        }

        private void uploadBtn_Click(object sender, EventArgs e)
        {
            try
            {
                //Save Image Method
                GetImage();
            }
            catch (Exception exception)
            {
                //Handle any exceptions that get may occur and return result to user
                MessageBox.Show(exception.Message, "Exception");
            }
        }

        private byte[] GetImage()
        {
            try
            {
                //Create file string variable
                string sFile;
                OpenFileDialog openFileDialogBox = new OpenFileDialog(); //Open File Explorer Dialog Box

                //Create byte variable
                byte[] imgByte = null;

                //Filter out for specific file types
                openFileDialogBox.Filter = "Image File (*.jpg;*.bmp;*.gif;*.png;*.jpeg)|*.jpg;*.bmp;*.gif*.png;*.jpeg";

                //If user clicks ok on explorer
                if (openFileDialogBox.ShowDialog() == DialogResult.OK)
                {
                    //Set image fileName to sFile variable
                    sFile = openFileDialogBox.FileName;
                    //Create Image from File
                    imageBox.Image = System.Drawing.Bitmap.FromFile(sFile);
                    imageBox.SizeMode = PictureBoxSizeMode.CenterImage;

                    //Use MemoryStream class
                    using (MemoryStream mStream = new MemoryStream())
                    {
                        //Save image to the memoryStream in the raw format
                        imageBox.Image.Save(mStream, imageBox.Image.RawFormat);
                        //Write the contents into a byte Array
                        imgByte = mStream.ToArray();
                    }
                }

                imageDTO.imageByte = imgByte;

                //Return image as bytes variable
                return imgByte;
            }
            catch (Exception exception)
            {
                //Handle any exceptions that get may occur and return result to user
                MessageBox.Show(exception.Message, "Exception");

                return null;
            }
        }

        private void contactLastNameTxtbox_TextChanged(object sender, EventArgs e)
        {

        }

        //Validate
        private bool Validate(string email, string fname, string lname, byte[] image)
        {
            try
            {
                //Validate email address is a valid email, return result to DTO
                messageDTO = ValidateEmailAddress(email);

                //Check IsValid result from method
                if (messageDTO.IsValid == false)
                {
                    //Show validation message to user on validation failure
                    MessageBox.Show(messageDTO.Message, "Validation Error");

                    return false;
                }

                //Validate variables for nulls/empty strings
                messageDTO = ValidateRequiredFormFields(email, fname, lname, image);

                //Check IsValid result from method
                if (messageDTO.IsValid == false)
                {
                    //Show validation message to user on validation failure
                    MessageBox.Show(messageDTO.Message, "Validation Error");

                    return false;
                }

                return true;
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Exception");

                return false;
            }
        }

        //Validate Email Address
        private ValidationMessageDTO ValidateEmailAddress(string email)
        {
            ValidationMessageDTO validationDTO = new ValidationMessageDTO();
            try
            {
                //Check if email is not null
                if (email != null)
                {
                    //Create Regular expression
                    Regex regex = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");

                    //Email address match
                    Match match = regex.Match(email);

                    //Check if the email match is successful
                    if (match.Success)
                    {
                        //Create bool result and message
                        validationDTO.IsValid = true;
                        validationDTO.Message = "Email Address is valid";

                        //Return DTO
                        return validationDTO;
                    }
                    else
                    {
                        //Create bool and message result on validation Fail
                        validationDTO.IsValid = false;
                        validationDTO.Message = "Email Address is not valid. Please enter a valid email address";

                        //Return DTO
                        return validationDTO;
                    }
                }

                //Create bool and message result if email variable is null
                validationDTO.IsValid = false;
                validationDTO.Message = "Invalid User Input. Email is empty";

                //Return DTO
                return validationDTO;
            }
            catch (Exception exception)
            {
                //Create exception messages
                validationDTO.IsValid = false;
                validationDTO.Message = exception.Message;

                //return ValidationDTO
                return validationDTO;
            }
        }

        //Validate null or empty
        private ValidationMessageDTO ValidateRequiredFormFields(string email, string fname, string lname, byte[] image)
        {
            try
            {
                //Check if email is null or emotyString
                if (email == "" || email == null)
                {
                    //Create bool and message result
                    messageDTO.IsValid = false;
                    messageDTO.Message = "Invalid User Input. Email cannot be empty.";

                    //Return DTO
                    return messageDTO;
                }

                //Check if firstName is null or emotyString
                if (fname == "" || fname == null)
                {
                    //Create bool and message result
                    messageDTO.IsValid = false;
                    messageDTO.Message = "Invalid User Input. First Name cannot be empty.";

                    //Return DTO
                    return messageDTO;
                }

                //Check if lastName is null or emotyString
                if (lname == "" || lname == null)
                {
                    //Create bool and message result
                    messageDTO.IsValid = false;
                    messageDTO.Message = "Invalid User Input. Last Name cannot be empty.";

                    //Return DTO
                    return messageDTO;
                }

                if (image == null)
                {
                    //Create bool and message result
                    messageDTO.IsValid = false;
                    messageDTO.Message = "Invalid User Input. Please upload a contact image";

                    //Return DTO
                    return messageDTO;
                }

                //Create bool and message result
                messageDTO.IsValid = true;
                messageDTO.Message = "Validation Successful";

                //Return DTO
                return messageDTO;
            }
            catch (Exception exception)
            {
                //Create exception result nessage
                messageDTO.IsValid = false;
                messageDTO.Message = exception.Message;

                //Return DTO
                return messageDTO;
            }  
        }
    }
}

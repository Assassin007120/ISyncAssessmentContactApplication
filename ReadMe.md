<h1>PLEASE FOLLOW THE BELOW INSTRUCTIONS:</h1>

<h3>STEP 1:</h3>

<p>Please run the below scripts in the following order</p>

-- Create Database
CREATE DATABASE ISyncContactdB
GO;

-- Create tables of Category and Contact
CREATE TABLE Category(
	Id INT PRIMARY KEY IDENTITY(1,1),
	CategoryName VARCHAR(50) NOT NULL,
	IsActive BIT NOT NULL DEFAULT 1
);

CREATE TABLE Contact(
	Id INT PRIMARY KEY IDENTITY(1,1),
	CategoryId INT NOT NULL REFERENCES Category(Id),
	FirstName VARCHAR(50) NOT NULL,
	LastName VARCHAR(50) NOT NULL,
	DateOfBirth DATE, 
	CellNumber NVARCHAR(10),
	Email VARCHAR(50) NOT NULL UNIQUE,
	ContactImage IMAGE, 
	DateCreated DATETIME,
	Active BIT NOT NULL
);

-- Insert default record into Category table
INSERT INTO dbo.Category (CategoryName, IsActive)
VALUES ('None', 1);

<p>Create a connection string in the App.config like below:</p>

	<connectionStrings>
		<add name="ApplicationConnectionString" connectionString="Server=LAPTOP-1MM4UVCE\SQLEXPRESS;Database=ISyncContactdB;Trusted_Connection=true;MultipleActiveResultSets=true;" />
		<add name="ISyncAssessmentContactApplication.Properties.Settings.ISyncContactdBConnectionString"
		  connectionString="Data Source=LAPTOP-1MM4UVCE\SQLEXPRESS;Initial Catalog=ISyncContactdB;Integrated Security=True"
		  providerName="System.Data.SqlClient" />
	</connectionStrings>

<h3>STEP 2:</h3>

<p>A .zip file named 'Poppins' should be included, please install these fonts into your system</p>

<h3>STEP 3:</h3>

<p>A folder named 'KrpytonMasterFolder' should be included, we are going to install this Toolkit for the UI elements. Please do the following</p>

<ul>
	<li>Open Visual Studio</li>
	<li>Click on 'Toolbox'</li>
	<li>Right-click on General, then click on 'Add Tab'</li>
	<li>A textbox at the top should be appear, please type in 'Krypton Toolkit'</li>
	<li>Right-click on this new tab and select the option 'Choose Items'</li>
	<li>A new window will pop up called 'Choose ToolBox Items', wait it to load</li>
	<li>Once it has loaded, click on 'Browse'</li>
	<li>File Explorer will appear, please then select all the files in the KrytonMasterFolder and click 'Open'</li>
	<li>Wait for the files to load in</li>
	<li>Once it has then click 'Ok'</li>
	<li>Krypton ToolKit Set up complete</li>
</ul>

<h2>Set Up Complete</h2>

<h5>Notes:</h5>
<ul>
	<li>Required field for Category are CategoryName</li>
	<li>Required Fields for Contact are Email, First Name, Last Name and Contact Image</li>
</ul>

<p>----------------------------------------------------------------------------</p>
namespace ISyncAssessmentContactApplication.Forms
{
    partial class CreateContact
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lblCreateContact = new System.Windows.Forms.Label();
            this.lblCreateContactSubLabel = new System.Windows.Forms.Label();
            this.contactFirstNameTxtBox = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.contactLastNameTxtbox = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.contactCellTxtBox = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.contactEmailTxtBox = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.createContactBtn = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.categoryDropdownBox = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.kryptonPalette1 = new ComponentFactory.Krypton.Toolkit.KryptonPalette(this.components);
            this.isActiveContactCheckBox = new ComponentFactory.Krypton.Toolkit.KryptonCheckBox();
            this.contactDateTimePicker = new ComponentFactory.Krypton.Toolkit.KryptonDateTimePicker();
            this.uploadBtn = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.imageBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.categoryDropdownBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageBox)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCreateContact
            // 
            this.lblCreateContact.AutoSize = true;
            this.lblCreateContact.Font = new System.Drawing.Font("Poppins", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCreateContact.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblCreateContact.Location = new System.Drawing.Point(332, 9);
            this.lblCreateContact.Name = "lblCreateContact";
            this.lblCreateContact.Size = new System.Drawing.Size(172, 36);
            this.lblCreateContact.TabIndex = 2;
            this.lblCreateContact.Text = "Create Contact";
            // 
            // lblCreateContactSubLabel
            // 
            this.lblCreateContactSubLabel.AutoSize = true;
            this.lblCreateContactSubLabel.Font = new System.Drawing.Font("Poppins", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCreateContactSubLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblCreateContactSubLabel.Location = new System.Drawing.Point(231, 45);
            this.lblCreateContactSubLabel.Name = "lblCreateContactSubLabel";
            this.lblCreateContactSubLabel.Size = new System.Drawing.Size(376, 25);
            this.lblCreateContactSubLabel.TabIndex = 3;
            this.lblCreateContactSubLabel.Text = "Please fill in the fields below to create a new contact";
            // 
            // contactFirstNameTxtBox
            // 
            this.contactFirstNameTxtBox.Location = new System.Drawing.Point(30, 178);
            this.contactFirstNameTxtBox.Name = "contactFirstNameTxtBox";
            this.contactFirstNameTxtBox.Size = new System.Drawing.Size(379, 37);
            this.contactFirstNameTxtBox.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.contactFirstNameTxtBox.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.contactFirstNameTxtBox.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.contactFirstNameTxtBox.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.contactFirstNameTxtBox.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.contactFirstNameTxtBox.StateCommon.Border.Rounding = 20;
            this.contactFirstNameTxtBox.StateCommon.Border.Width = 1;
            this.contactFirstNameTxtBox.StateCommon.Content.Color1 = System.Drawing.Color.Gray;
            this.contactFirstNameTxtBox.StateCommon.Content.Font = new System.Drawing.Font("Poppins", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contactFirstNameTxtBox.StateCommon.Content.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.contactFirstNameTxtBox.TabIndex = 2;
            // 
            // contactLastNameTxtbox
            // 
            this.contactLastNameTxtbox.Location = new System.Drawing.Point(30, 252);
            this.contactLastNameTxtbox.Name = "contactLastNameTxtbox";
            this.contactLastNameTxtbox.Size = new System.Drawing.Size(379, 37);
            this.contactLastNameTxtbox.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.contactLastNameTxtbox.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.contactLastNameTxtbox.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.contactLastNameTxtbox.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.contactLastNameTxtbox.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.contactLastNameTxtbox.StateCommon.Border.Rounding = 20;
            this.contactLastNameTxtbox.StateCommon.Border.Width = 1;
            this.contactLastNameTxtbox.StateCommon.Content.Color1 = System.Drawing.Color.Gray;
            this.contactLastNameTxtbox.StateCommon.Content.Font = new System.Drawing.Font("Poppins", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contactLastNameTxtbox.StateCommon.Content.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.contactLastNameTxtbox.TabIndex = 3;
            this.contactLastNameTxtbox.TextChanged += new System.EventHandler(this.contactLastNameTxtbox_TextChanged);
            // 
            // contactCellTxtBox
            // 
            this.contactCellTxtBox.Location = new System.Drawing.Point(465, 178);
            this.contactCellTxtBox.Name = "contactCellTxtBox";
            this.contactCellTxtBox.Size = new System.Drawing.Size(379, 37);
            this.contactCellTxtBox.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.contactCellTxtBox.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.contactCellTxtBox.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.contactCellTxtBox.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.contactCellTxtBox.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.contactCellTxtBox.StateCommon.Border.Rounding = 20;
            this.contactCellTxtBox.StateCommon.Border.Width = 1;
            this.contactCellTxtBox.StateCommon.Content.Color1 = System.Drawing.Color.Gray;
            this.contactCellTxtBox.StateCommon.Content.Font = new System.Drawing.Font("Poppins", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contactCellTxtBox.StateCommon.Content.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.contactCellTxtBox.TabIndex = 6;
            // 
            // contactEmailTxtBox
            // 
            this.contactEmailTxtBox.Location = new System.Drawing.Point(30, 101);
            this.contactEmailTxtBox.Name = "contactEmailTxtBox";
            this.contactEmailTxtBox.Size = new System.Drawing.Size(379, 37);
            this.contactEmailTxtBox.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.contactEmailTxtBox.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.contactEmailTxtBox.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.contactEmailTxtBox.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.contactEmailTxtBox.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.contactEmailTxtBox.StateCommon.Border.Rounding = 20;
            this.contactEmailTxtBox.StateCommon.Border.Width = 1;
            this.contactEmailTxtBox.StateCommon.Content.Color1 = System.Drawing.Color.Gray;
            this.contactEmailTxtBox.StateCommon.Content.Font = new System.Drawing.Font("Poppins", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contactEmailTxtBox.StateCommon.Content.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.contactEmailTxtBox.TabIndex = 1;
            // 
            // createContactBtn
            // 
            this.createContactBtn.Location = new System.Drawing.Point(338, 398);
            this.createContactBtn.Name = "createContactBtn";
            this.createContactBtn.OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.createContactBtn.OverrideDefault.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.createContactBtn.OverrideDefault.Back.ColorAngle = 45F;
            this.createContactBtn.OverrideDefault.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.createContactBtn.OverrideDefault.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.createContactBtn.OverrideDefault.Border.ColorAngle = 45F;
            this.createContactBtn.OverrideDefault.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.createContactBtn.OverrideDefault.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.createContactBtn.OverrideDefault.Border.Rounding = 20;
            this.createContactBtn.OverrideDefault.Border.Width = 1;
            this.createContactBtn.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.createContactBtn.Size = new System.Drawing.Size(171, 43);
            this.createContactBtn.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.createContactBtn.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.createContactBtn.StateCommon.Back.ColorAngle = 45F;
            this.createContactBtn.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.createContactBtn.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.createContactBtn.StateCommon.Border.ColorAngle = 45F;
            this.createContactBtn.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.createContactBtn.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.createContactBtn.StateCommon.Border.Rounding = 20;
            this.createContactBtn.StateCommon.Border.Width = 1;
            this.createContactBtn.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.createContactBtn.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.createContactBtn.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createContactBtn.StatePressed.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(145)))), ((int)(((byte)(198)))));
            this.createContactBtn.StatePressed.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(121)))), ((int)(((byte)(206)))));
            this.createContactBtn.StatePressed.Back.ColorAngle = 135F;
            this.createContactBtn.StatePressed.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(145)))), ((int)(((byte)(198)))));
            this.createContactBtn.StatePressed.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(121)))), ((int)(((byte)(206)))));
            this.createContactBtn.StatePressed.Border.ColorAngle = 135F;
            this.createContactBtn.StatePressed.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.createContactBtn.StatePressed.Border.Rounding = 20;
            this.createContactBtn.StatePressed.Border.Width = 1;
            this.createContactBtn.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.createContactBtn.StateTracking.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.createContactBtn.StateTracking.Back.ColorAngle = 45F;
            this.createContactBtn.StateTracking.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.createContactBtn.StateTracking.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.createContactBtn.StateTracking.Border.ColorAngle = 45F;
            this.createContactBtn.StateTracking.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.createContactBtn.StateTracking.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.createContactBtn.StateTracking.Border.Rounding = 20;
            this.createContactBtn.StateTracking.Border.Width = 1;
            this.createContactBtn.TabIndex = 10;
            this.createContactBtn.Values.Text = "Create";
            this.createContactBtn.Click += new System.EventHandler(this.createContactBtn_Click);
            // 
            // categoryDropdownBox
            // 
            this.categoryDropdownBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.categoryDropdownBox.DropDownWidth = 367;
            this.categoryDropdownBox.Location = new System.Drawing.Point(465, 249);
            this.categoryDropdownBox.Name = "categoryDropdownBox";
            this.categoryDropdownBox.Palette = this.kryptonPalette1;
            this.categoryDropdownBox.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom;
            this.categoryDropdownBox.Size = new System.Drawing.Size(379, 40);
            this.categoryDropdownBox.StateCommon.ComboBox.Back.Color1 = System.Drawing.Color.White;
            this.categoryDropdownBox.StateCommon.ComboBox.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.categoryDropdownBox.StateCommon.ComboBox.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.categoryDropdownBox.StateCommon.ComboBox.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.categoryDropdownBox.StateCommon.ComboBox.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.categoryDropdownBox.StateCommon.ComboBox.Border.Rounding = 20;
            this.categoryDropdownBox.StateCommon.ComboBox.Border.Width = 1;
            this.categoryDropdownBox.StateCommon.ComboBox.Content.Color1 = System.Drawing.Color.Transparent;
            this.categoryDropdownBox.StateCommon.ComboBox.Content.Font = new System.Drawing.Font("Poppins", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.categoryDropdownBox.StateCommon.ComboBox.Content.Padding = new System.Windows.Forms.Padding(10, -1, 10, -1);
            this.categoryDropdownBox.StateCommon.DropBack.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.categoryDropdownBox.StateCommon.DropBack.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.categoryDropdownBox.StateCommon.DropBack.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.categoryDropdownBox.StateCommon.Item.Content.ShortText.Color1 = System.Drawing.Color.Black;
            this.categoryDropdownBox.StateCommon.Item.Content.ShortText.Color2 = System.Drawing.Color.Black;
            this.categoryDropdownBox.StateCommon.Item.Content.ShortText.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.categoryDropdownBox.TabIndex = 7;
            this.categoryDropdownBox.SelectedIndexChanged += new System.EventHandler(this.categoryDropdownBox_SelectedIndexChanged);
            // 
            // kryptonPalette1
            // 
            this.kryptonPalette1.ButtonStyles.ButtonForm.StateNormal.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.kryptonPalette1.ButtonStyles.ButtonForm.StateNormal.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.kryptonPalette1.ButtonStyles.ButtonForm.StateNormal.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonPalette1.ButtonStyles.ButtonForm.StateNormal.Border.Width = 0;
            this.kryptonPalette1.ButtonStyles.ButtonForm.StatePressed.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.kryptonPalette1.ButtonStyles.ButtonForm.StatePressed.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.kryptonPalette1.ButtonStyles.ButtonForm.StatePressed.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonPalette1.ButtonStyles.ButtonForm.StatePressed.Border.Width = 0;
            this.kryptonPalette1.ButtonStyles.ButtonForm.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.kryptonPalette1.ButtonStyles.ButtonForm.StateTracking.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.kryptonPalette1.ButtonStyles.ButtonForm.StateTracking.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonPalette1.ButtonStyles.ButtonForm.StateTracking.Border.Width = 0;
            this.kryptonPalette1.FormStyles.FormCommon.StateActive.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.kryptonPalette1.FormStyles.FormCommon.StateActive.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.kryptonPalette1.FormStyles.FormCommon.StateActive.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonPalette1.FormStyles.FormCommon.StateActive.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.kryptonPalette1.FormStyles.FormCommon.StateActive.Border.Rounding = 12;
            this.kryptonPalette1.FormStyles.FormMain.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.kryptonPalette1.FormStyles.FormMain.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.kryptonPalette1.FormStyles.FormMain.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonPalette1.FormStyles.FormMain.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.None;
            this.kryptonPalette1.FormStyles.FormMain.StateCommon.Border.Rounding = 12;
            this.kryptonPalette1.HeaderStyles.HeaderForm.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.kryptonPalette1.HeaderStyles.HeaderForm.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.kryptonPalette1.HeaderStyles.HeaderForm.StateCommon.ButtonEdgeInset = 10;
            this.kryptonPalette1.HeaderStyles.HeaderForm.StateCommon.Content.Padding = new System.Windows.Forms.Padding(10, -1, -1, -1);
            // 
            // isActiveContactCheckBox
            // 
            this.isActiveContactCheckBox.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.SuperTip;
            this.isActiveContactCheckBox.Location = new System.Drawing.Point(475, 309);
            this.isActiveContactCheckBox.Name = "isActiveContactCheckBox";
            this.isActiveContactCheckBox.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.isActiveContactCheckBox.Size = new System.Drawing.Size(102, 43);
            this.isActiveContactCheckBox.StateCommon.Padding = new System.Windows.Forms.Padding(10);
            this.isActiveContactCheckBox.StateCommon.ShortText.Color1 = System.Drawing.Color.Gray;
            this.isActiveContactCheckBox.StateCommon.ShortText.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.isActiveContactCheckBox.StateCommon.ShortText.ColorAngle = 45F;
            this.isActiveContactCheckBox.StateCommon.ShortText.Font = new System.Drawing.Font("Poppins", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.isActiveContactCheckBox.TabIndex = 9;
            this.isActiveContactCheckBox.Values.Text = "Is Active";
            // 
            // contactDateTimePicker
            // 
            this.contactDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.contactDateTimePicker.Location = new System.Drawing.Point(465, 101);
            this.contactDateTimePicker.Name = "contactDateTimePicker";
            this.contactDateTimePicker.Palette = this.kryptonPalette1;
            this.contactDateTimePicker.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom;
            this.contactDateTimePicker.Size = new System.Drawing.Size(379, 43);
            this.contactDateTimePicker.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.contactDateTimePicker.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.contactDateTimePicker.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.contactDateTimePicker.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.contactDateTimePicker.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.contactDateTimePicker.StateCommon.Border.Rounding = 20;
            this.contactDateTimePicker.StateCommon.Border.Width = 1;
            this.contactDateTimePicker.StateCommon.Content.Color1 = System.Drawing.Color.Gray;
            this.contactDateTimePicker.StateCommon.Content.Font = new System.Drawing.Font("Poppins", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contactDateTimePicker.StateCommon.Content.Padding = new System.Windows.Forms.Padding(10);
            this.contactDateTimePicker.TabIndex = 5;
            // 
            // uploadBtn
            // 
            this.uploadBtn.Location = new System.Drawing.Point(40, 327);
            this.uploadBtn.Name = "uploadBtn";
            this.uploadBtn.OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.uploadBtn.OverrideDefault.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.uploadBtn.OverrideDefault.Back.ColorAngle = 45F;
            this.uploadBtn.OverrideDefault.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.uploadBtn.OverrideDefault.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.uploadBtn.OverrideDefault.Border.ColorAngle = 45F;
            this.uploadBtn.OverrideDefault.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.uploadBtn.OverrideDefault.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.uploadBtn.OverrideDefault.Border.Rounding = 20;
            this.uploadBtn.OverrideDefault.Border.Width = 1;
            this.uploadBtn.Size = new System.Drawing.Size(90, 25);
            this.uploadBtn.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.uploadBtn.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.uploadBtn.StateCommon.Back.ColorAngle = 45F;
            this.uploadBtn.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.uploadBtn.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.uploadBtn.StateCommon.Border.ColorAngle = 45F;
            this.uploadBtn.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.uploadBtn.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.uploadBtn.StateCommon.Border.Rounding = 1;
            this.uploadBtn.StateCommon.Border.Width = 1;
            this.uploadBtn.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.uploadBtn.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Poppins", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uploadBtn.StatePressed.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(145)))), ((int)(((byte)(198)))));
            this.uploadBtn.StatePressed.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(121)))), ((int)(((byte)(206)))));
            this.uploadBtn.StatePressed.Back.ColorAngle = 135F;
            this.uploadBtn.StatePressed.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(145)))), ((int)(((byte)(198)))));
            this.uploadBtn.StatePressed.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(121)))), ((int)(((byte)(206)))));
            this.uploadBtn.StatePressed.Border.ColorAngle = 135F;
            this.uploadBtn.StatePressed.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.uploadBtn.StatePressed.Border.Rounding = 1;
            this.uploadBtn.StatePressed.Border.Width = 1;
            this.uploadBtn.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.uploadBtn.StateTracking.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(254)))));
            this.uploadBtn.StateTracking.Back.ColorAngle = 45F;
            this.uploadBtn.StateTracking.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.uploadBtn.StateTracking.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.uploadBtn.StateTracking.Border.ColorAngle = 45F;
            this.uploadBtn.StateTracking.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.uploadBtn.StateTracking.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.uploadBtn.StateTracking.Border.Rounding = 1;
            this.uploadBtn.StateTracking.Border.Width = 1;
            this.uploadBtn.StateTracking.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.uploadBtn.StateTracking.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.uploadBtn.StateTracking.Content.ShortText.ColorAngle = 45F;
            this.uploadBtn.TabIndex = 8;
            this.uploadBtn.Values.Text = "Upload";
            this.uploadBtn.Click += new System.EventHandler(this.uploadBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Poppins", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(461, 227);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 19);
            this.label1.TabIndex = 13;
            this.label1.Text = "Select Category";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Poppins", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(36, 156);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 19);
            this.label2.TabIndex = 14;
            this.label2.Text = "First Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Poppins", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label3.Location = new System.Drawing.Point(36, 230);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 19);
            this.label3.TabIndex = 15;
            this.label3.Text = "Last Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Poppins", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label4.Location = new System.Drawing.Point(471, 79);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 19);
            this.label4.TabIndex = 16;
            this.label4.Text = "Date of Birth";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Poppins", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label5.Location = new System.Drawing.Point(471, 156);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 19);
            this.label5.TabIndex = 17;
            this.label5.Text = "Cell Number";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Poppins", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label6.Location = new System.Drawing.Point(36, 79);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 19);
            this.label6.TabIndex = 18;
            this.label6.Text = "Email Address";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Poppins", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label7.Location = new System.Drawing.Point(36, 305);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(85, 19);
            this.label7.TabIndex = 19;
            this.label7.Text = "Upload Image";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // imageBox
            // 
            this.imageBox.Location = new System.Drawing.Point(145, 309);
            this.imageBox.Name = "imageBox";
            this.imageBox.Size = new System.Drawing.Size(100, 100);
            this.imageBox.TabIndex = 20;
            this.imageBox.TabStop = false;
            // 
            // CreateContact
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.ClientSize = new System.Drawing.Size(884, 474);
            this.Controls.Add(this.imageBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.uploadBtn);
            this.Controls.Add(this.contactDateTimePicker);
            this.Controls.Add(this.isActiveContactCheckBox);
            this.Controls.Add(this.categoryDropdownBox);
            this.Controls.Add(this.createContactBtn);
            this.Controls.Add(this.contactEmailTxtBox);
            this.Controls.Add(this.contactCellTxtBox);
            this.Controls.Add(this.contactLastNameTxtbox);
            this.Controls.Add(this.contactFirstNameTxtBox);
            this.Controls.Add(this.lblCreateContactSubLabel);
            this.Controls.Add(this.lblCreateContact);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CreateContact";
            this.Palette = this.kryptonPalette1;
            this.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom;
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CreateContact";
            this.Load += new System.EventHandler(this.CreateContact_Load);
            ((System.ComponentModel.ISupportInitialize)(this.categoryDropdownBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCreateContact;
        private System.Windows.Forms.Label lblCreateContactSubLabel;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox contactFirstNameTxtBox;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox contactLastNameTxtbox;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox contactCellTxtBox;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox contactEmailTxtBox;
        private ComponentFactory.Krypton.Toolkit.KryptonButton createContactBtn;
        private ComponentFactory.Krypton.Toolkit.KryptonComboBox categoryDropdownBox;
        private ComponentFactory.Krypton.Toolkit.KryptonCheckBox isActiveContactCheckBox;
        private ComponentFactory.Krypton.Toolkit.KryptonPalette kryptonPalette1;
        private ComponentFactory.Krypton.Toolkit.KryptonDateTimePicker contactDateTimePicker;
        private ComponentFactory.Krypton.Toolkit.KryptonButton uploadBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox imageBox;
    }
}
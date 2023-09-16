namespace ISyncAssessmentContactApplication.Forms
{
    partial class CreateCategoryFrm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.categoryTextBox = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.isActiveCheckBox = new ComponentFactory.Krypton.Toolkit.KryptonCheckBox();
            this.createCategoryBtn = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.kryptonPalette1 = new ComponentFactory.Krypton.Toolkit.KryptonPalette(this.components);
            this.categoryDataGridView = new ComponentFactory.Krypton.Toolkit.KryptonDataGridView();
            this.categoryNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isActiveDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.categoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.iSyncContactdBDataSet = new ISyncAssessmentContactApplication.ISyncContactdBDataSet();
            this.categoryTableAdapter = new ISyncAssessmentContactApplication.ISyncContactdBDataSetTableAdapters.CategoryTableAdapter();
            this.categorySearchTextBox = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.categoryDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iSyncContactdBDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Poppins", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(123, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(187, 36);
            this.label1.TabIndex = 1;
            this.label1.Text = "Create Category";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Poppins", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(40, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(384, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Please fill in the fields below to create a new category";
            // 
            // categoryTextBox
            // 
            this.categoryTextBox.Location = new System.Drawing.Point(45, 133);
            this.categoryTextBox.Name = "categoryTextBox";
            this.categoryTextBox.Size = new System.Drawing.Size(379, 37);
            this.categoryTextBox.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.categoryTextBox.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.categoryTextBox.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.categoryTextBox.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.categoryTextBox.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.categoryTextBox.StateCommon.Border.Rounding = 20;
            this.categoryTextBox.StateCommon.Border.Width = 1;
            this.categoryTextBox.StateCommon.Content.Color1 = System.Drawing.Color.Gray;
            this.categoryTextBox.StateCommon.Content.Font = new System.Drawing.Font("Poppins", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.categoryTextBox.StateCommon.Content.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.categoryTextBox.TabIndex = 3;
            this.categoryTextBox.TextChanged += new System.EventHandler(this.kryptonTextBox1_TextChanged);
            // 
            // isActiveCheckBox
            // 
            this.isActiveCheckBox.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.SuperTip;
            this.isActiveCheckBox.Location = new System.Drawing.Point(55, 179);
            this.isActiveCheckBox.Name = "isActiveCheckBox";
            this.isActiveCheckBox.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.isActiveCheckBox.Size = new System.Drawing.Size(102, 43);
            this.isActiveCheckBox.StateCommon.Padding = new System.Windows.Forms.Padding(10);
            this.isActiveCheckBox.StateCommon.ShortText.Color1 = System.Drawing.Color.Gray;
            this.isActiveCheckBox.StateCommon.ShortText.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.isActiveCheckBox.StateCommon.ShortText.ColorAngle = 45F;
            this.isActiveCheckBox.StateCommon.ShortText.Font = new System.Drawing.Font("Poppins", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.isActiveCheckBox.TabIndex = 4;
            this.isActiveCheckBox.Values.Text = "Is Active";
            this.isActiveCheckBox.CheckedChanged += new System.EventHandler(this.isActiveCheckBox_CheckedChanged);
            // 
            // createCategoryBtn
            // 
            this.createCategoryBtn.Location = new System.Drawing.Point(139, 233);
            this.createCategoryBtn.Name = "createCategoryBtn";
            this.createCategoryBtn.OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.createCategoryBtn.OverrideDefault.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.createCategoryBtn.OverrideDefault.Back.ColorAngle = 45F;
            this.createCategoryBtn.OverrideDefault.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.createCategoryBtn.OverrideDefault.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.createCategoryBtn.OverrideDefault.Border.ColorAngle = 45F;
            this.createCategoryBtn.OverrideDefault.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.createCategoryBtn.OverrideDefault.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.createCategoryBtn.OverrideDefault.Border.Rounding = 20;
            this.createCategoryBtn.OverrideDefault.Border.Width = 1;
            this.createCategoryBtn.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.createCategoryBtn.Size = new System.Drawing.Size(171, 43);
            this.createCategoryBtn.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.createCategoryBtn.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.createCategoryBtn.StateCommon.Back.ColorAngle = 45F;
            this.createCategoryBtn.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.createCategoryBtn.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.createCategoryBtn.StateCommon.Border.ColorAngle = 45F;
            this.createCategoryBtn.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.createCategoryBtn.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.createCategoryBtn.StateCommon.Border.Rounding = 20;
            this.createCategoryBtn.StateCommon.Border.Width = 1;
            this.createCategoryBtn.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.createCategoryBtn.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.createCategoryBtn.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createCategoryBtn.StatePressed.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(145)))), ((int)(((byte)(198)))));
            this.createCategoryBtn.StatePressed.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(121)))), ((int)(((byte)(206)))));
            this.createCategoryBtn.StatePressed.Back.ColorAngle = 135F;
            this.createCategoryBtn.StatePressed.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(145)))), ((int)(((byte)(198)))));
            this.createCategoryBtn.StatePressed.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(121)))), ((int)(((byte)(206)))));
            this.createCategoryBtn.StatePressed.Border.ColorAngle = 135F;
            this.createCategoryBtn.StatePressed.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.createCategoryBtn.StatePressed.Border.Rounding = 20;
            this.createCategoryBtn.StatePressed.Border.Width = 1;
            this.createCategoryBtn.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.createCategoryBtn.StateTracking.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.createCategoryBtn.StateTracking.Back.ColorAngle = 45F;
            this.createCategoryBtn.StateTracking.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.createCategoryBtn.StateTracking.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.createCategoryBtn.StateTracking.Border.ColorAngle = 45F;
            this.createCategoryBtn.StateTracking.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.createCategoryBtn.StateTracking.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.createCategoryBtn.StateTracking.Border.Rounding = 20;
            this.createCategoryBtn.StateTracking.Border.Width = 1;
            this.createCategoryBtn.TabIndex = 5;
            this.createCategoryBtn.Values.Text = "Create";
            this.createCategoryBtn.Click += new System.EventHandler(this.createCategoryBtn_Click);
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
            this.kryptonPalette1.FormStyles.FormCommon.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.kryptonPalette1.FormStyles.FormCommon.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.kryptonPalette1.FormStyles.FormCommon.StateCommon.Back.ImageAlign = ComponentFactory.Krypton.Toolkit.PaletteRectangleAlign.Control;
            this.kryptonPalette1.FormStyles.FormCommon.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonPalette1.FormStyles.FormCommon.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.None;
            this.kryptonPalette1.FormStyles.FormCommon.StateCommon.Border.Rounding = 12;
            this.kryptonPalette1.HeaderStyles.HeaderForm.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.kryptonPalette1.HeaderStyles.HeaderForm.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.kryptonPalette1.HeaderStyles.HeaderForm.StateCommon.ButtonEdgeInset = 10;
            this.kryptonPalette1.HeaderStyles.HeaderForm.StateCommon.Content.Padding = new System.Windows.Forms.Padding(10, -1, -1, -1);
            // 
            // categoryDataGridView
            // 
            this.categoryDataGridView.AllowUserToAddRows = false;
            this.categoryDataGridView.AllowUserToDeleteRows = false;
            this.categoryDataGridView.AutoGenerateColumns = false;
            this.categoryDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.categoryDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.categoryNameDataGridViewTextBoxColumn,
            this.isActiveDataGridViewCheckBoxColumn});
            this.categoryDataGridView.DataSource = this.categoryBindingSource;
            this.categoryDataGridView.Location = new System.Drawing.Point(473, 65);
            this.categoryDataGridView.Name = "categoryDataGridView";
            this.categoryDataGridView.Palette = this.kryptonPalette1;
            this.categoryDataGridView.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom;
            this.categoryDataGridView.ReadOnly = true;
            this.categoryDataGridView.Size = new System.Drawing.Size(242, 185);
            this.categoryDataGridView.StateCommon.Background.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.categoryDataGridView.StateCommon.Background.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.categoryDataGridView.StateCommon.Background.ColorAngle = 45F;
            this.categoryDataGridView.StateCommon.BackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundList;
            this.categoryDataGridView.StateCommon.HeaderColumn.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.categoryDataGridView.StateCommon.HeaderColumn.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.categoryDataGridView.StateCommon.HeaderColumn.Back.ColorAngle = 45F;
            this.categoryDataGridView.StateCommon.HeaderColumn.Back.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.categoryDataGridView.StateCommon.HeaderColumn.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.categoryDataGridView.StateCommon.HeaderColumn.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.categoryDataGridView.StateCommon.HeaderColumn.Border.ColorAngle = 45F;
            this.categoryDataGridView.StateCommon.HeaderColumn.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.categoryDataGridView.StateCommon.HeaderColumn.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.categoryDataGridView.StateCommon.HeaderColumn.Border.Rounding = 1;
            this.categoryDataGridView.StateCommon.HeaderColumn.Border.Width = 1;
            this.categoryDataGridView.StateCommon.HeaderColumn.Content.Color1 = System.Drawing.Color.White;
            this.categoryDataGridView.StateCommon.HeaderColumn.Content.Color2 = System.Drawing.Color.White;
            this.categoryDataGridView.StateCommon.HeaderColumn.Content.ColorAngle = 45F;
            this.categoryDataGridView.StateCommon.HeaderColumn.Content.Font = new System.Drawing.Font("Poppins", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.categoryDataGridView.StateCommon.HeaderRow.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.categoryDataGridView.StateCommon.HeaderRow.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.categoryDataGridView.StateCommon.HeaderRow.Back.ColorAngle = 45F;
            this.categoryDataGridView.StateCommon.HeaderRow.Back.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.categoryDataGridView.StateCommon.HeaderRow.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.categoryDataGridView.StateCommon.HeaderRow.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.categoryDataGridView.StateCommon.HeaderRow.Border.ColorAngle = 45F;
            this.categoryDataGridView.StateCommon.HeaderRow.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.categoryDataGridView.StateCommon.HeaderRow.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.categoryDataGridView.StateCommon.HeaderRow.Border.Rounding = 1;
            this.categoryDataGridView.StateCommon.HeaderRow.Border.Width = 1;
            this.categoryDataGridView.StateCommon.HeaderRow.Content.Color1 = System.Drawing.Color.White;
            this.categoryDataGridView.StateCommon.HeaderRow.Content.Color2 = System.Drawing.Color.White;
            this.categoryDataGridView.StateCommon.HeaderRow.Content.ColorAngle = 45F;
            this.categoryDataGridView.TabIndex = 8;
            // 
            // categoryNameDataGridViewTextBoxColumn
            // 
            this.categoryNameDataGridViewTextBoxColumn.DataPropertyName = "CategoryName";
            this.categoryNameDataGridViewTextBoxColumn.HeaderText = "CategoryName";
            this.categoryNameDataGridViewTextBoxColumn.Name = "categoryNameDataGridViewTextBoxColumn";
            this.categoryNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // isActiveDataGridViewCheckBoxColumn
            // 
            this.isActiveDataGridViewCheckBoxColumn.DataPropertyName = "IsActive";
            this.isActiveDataGridViewCheckBoxColumn.HeaderText = "IsActive";
            this.isActiveDataGridViewCheckBoxColumn.Name = "isActiveDataGridViewCheckBoxColumn";
            this.isActiveDataGridViewCheckBoxColumn.ReadOnly = true;
            // 
            // categoryBindingSource
            // 
            this.categoryBindingSource.DataMember = "Category";
            this.categoryBindingSource.DataSource = this.iSyncContactdBDataSet;
            // 
            // iSyncContactdBDataSet
            // 
            this.iSyncContactdBDataSet.DataSetName = "ISyncContactdBDataSet";
            this.iSyncContactdBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // categoryTableAdapter
            // 
            this.categoryTableAdapter.ClearBeforeFill = true;
            // 
            // categorySearchTextBox
            // 
            this.categorySearchTextBox.Location = new System.Drawing.Point(528, 24);
            this.categorySearchTextBox.Name = "categorySearchTextBox";
            this.categorySearchTextBox.Size = new System.Drawing.Size(187, 33);
            this.categorySearchTextBox.StateActive.Back.Color1 = System.Drawing.Color.White;
            this.categorySearchTextBox.StateActive.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.categorySearchTextBox.StateActive.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.categorySearchTextBox.StateActive.Border.ColorAngle = 45F;
            this.categorySearchTextBox.StateActive.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.categorySearchTextBox.StateActive.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.categorySearchTextBox.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.categorySearchTextBox.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.categorySearchTextBox.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.categorySearchTextBox.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.categorySearchTextBox.StateCommon.Border.Rounding = 20;
            this.categorySearchTextBox.StateCommon.Content.Color1 = System.Drawing.Color.Gray;
            this.categorySearchTextBox.StateCommon.Content.Font = new System.Drawing.Font("Poppins", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.categorySearchTextBox.StateCommon.Content.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.categorySearchTextBox.TabIndex = 9;
            this.categorySearchTextBox.Text = "Search";
            this.categorySearchTextBox.TextChanged += new System.EventHandler(this.categorySearchTextBox_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Poppins", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label6.Location = new System.Drawing.Point(51, 111);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(136, 19);
            this.label6.TabIndex = 19;
            this.label6.Text = "Enter a Category Name";
            // 
            // CreateCategoryFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.ClientSize = new System.Drawing.Size(770, 284);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.categorySearchTextBox);
            this.Controls.Add(this.categoryDataGridView);
            this.Controls.Add(this.createCategoryBtn);
            this.Controls.Add(this.isActiveCheckBox);
            this.Controls.Add(this.categoryTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CreateCategoryFrm";
            this.Palette = this.kryptonPalette1;
            this.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom;
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Create Category";
            this.Load += new System.EventHandler(this.CreateCategoryFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.categoryDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iSyncContactdBDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox categoryTextBox;
        private ComponentFactory.Krypton.Toolkit.KryptonCheckBox isActiveCheckBox;
        private ComponentFactory.Krypton.Toolkit.KryptonButton createCategoryBtn;
        private ComponentFactory.Krypton.Toolkit.KryptonPalette kryptonPalette1;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridView categoryDataGridView;
        private ISyncContactdBDataSet iSyncContactdBDataSet;
        private System.Windows.Forms.BindingSource categoryBindingSource;
        private ISyncContactdBDataSetTableAdapters.CategoryTableAdapter categoryTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoryNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn isActiveDataGridViewCheckBoxColumn;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox categorySearchTextBox;
        private System.Windows.Forms.Label label6;
    }
}
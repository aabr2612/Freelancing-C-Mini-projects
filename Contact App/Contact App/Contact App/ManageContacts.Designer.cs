namespace Contact_App
{
    partial class ManageContacts
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
            this.MainPanel = new System.Windows.Forms.Panel();
            this.BottomContainer = new Guna.UI2.WinForms.Guna2Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ContactViews = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ButtonsContainer = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.AddBtn = new Guna.UI2.WinForms.Guna2Button();
            this.UpdateBtn = new Guna.UI2.WinForms.Guna2Button();
            this.DeleteBtn = new Guna.UI2.WinForms.Guna2Button();
            this.LoadBtn = new Guna.UI2.WinForms.Guna2Button();
            this.SaveBtn = new Guna.UI2.WinForms.Guna2Button();
            this.InputsManagement = new System.Windows.Forms.Panel();
            this.Inputs = new System.Windows.Forms.TableLayoutPanel();
            this.ContactName = new System.Windows.Forms.Label();
            this.ContactNumber = new System.Windows.Forms.Label();
            this.Address = new System.Windows.Forms.Label();
            this.Email = new System.Windows.Forms.Label();
            this.ContactInput = new Guna.UI2.WinForms.Guna2TextBox();
            this.EmailInput = new Guna.UI2.WinForms.Guna2TextBox();
            this.PhoneInput = new Guna.UI2.WinForms.Guna2TextBox();
            this.AddressInput = new Guna.UI2.WinForms.Guna2TextBox();
            this.TopContainer = new Guna.UI2.WinForms.Guna2Panel();
            this.Header = new System.Windows.Forms.Label();
            this.MainPanel.SuspendLayout();
            this.BottomContainer.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ContactViews)).BeginInit();
            this.ButtonsContainer.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.InputsManagement.SuspendLayout();
            this.Inputs.SuspendLayout();
            this.TopContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainPanel
            // 
            this.MainPanel.Controls.Add(this.BottomContainer);
            this.MainPanel.Controls.Add(this.TopContainer);
            this.MainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainPanel.Location = new System.Drawing.Point(0, 0);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(884, 561);
            this.MainPanel.TabIndex = 0;
            // 
            // BottomContainer
            // 
            this.BottomContainer.Controls.Add(this.panel1);
            this.BottomContainer.Controls.Add(this.ButtonsContainer);
            this.BottomContainer.Controls.Add(this.InputsManagement);
            this.BottomContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BottomContainer.Location = new System.Drawing.Point(0, 120);
            this.BottomContainer.Name = "BottomContainer";
            this.BottomContainer.Size = new System.Drawing.Size(884, 441);
            this.BottomContainer.TabIndex = 5;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.ContactViews);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 259);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(884, 182);
            this.panel1.TabIndex = 2;
            // 
            // ContactViews
            // 
            this.ContactViews.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ContactViews.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ContactViews.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.ContactViews.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ContactViews.Location = new System.Drawing.Point(0, 0);
            this.ContactViews.Name = "ContactViews";
            this.ContactViews.Size = new System.Drawing.Size(884, 182);
            this.ContactViews.TabIndex = 0;
            this.ContactViews.SelectionChanged += new System.EventHandler(this.ContactViews_SelectionChanged);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Contact Name";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Phone Number";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Email";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Address";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // ButtonsContainer
            // 
            this.ButtonsContainer.Controls.Add(this.tableLayoutPanel1);
            this.ButtonsContainer.Dock = System.Windows.Forms.DockStyle.Top;
            this.ButtonsContainer.Location = new System.Drawing.Point(0, 159);
            this.ButtonsContainer.Name = "ButtonsContainer";
            this.ButtonsContainer.Size = new System.Drawing.Size(884, 100);
            this.ButtonsContainer.TabIndex = 1;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 11;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            this.tableLayoutPanel1.Controls.Add(this.AddBtn, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.UpdateBtn, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.DeleteBtn, 5, 1);
            this.tableLayoutPanel1.Controls.Add(this.LoadBtn, 7, 1);
            this.tableLayoutPanel1.Controls.Add(this.SaveBtn, 9, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 28.57143F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 42.85715F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 28.57143F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(884, 100);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // AddBtn
            // 
            this.AddBtn.BorderRadius = 15;
            this.AddBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.AddBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.AddBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.AddBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.AddBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AddBtn.FillColor = System.Drawing.Color.DimGray;
            this.AddBtn.FocusedColor = System.Drawing.Color.Black;
            this.AddBtn.Font = new System.Drawing.Font("Sitka Display", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddBtn.ForeColor = System.Drawing.Color.White;
            this.AddBtn.HoverState.BorderColor = System.Drawing.Color.Orange;
            this.AddBtn.HoverState.FillColor = System.Drawing.Color.Blue;
            this.AddBtn.Location = new System.Drawing.Point(23, 31);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.Size = new System.Drawing.Size(146, 36);
            this.AddBtn.TabIndex = 1;
            this.AddBtn.Text = "Add";
            this.AddBtn.Click += new System.EventHandler(this.AddBtn_Click);
            // 
            // UpdateBtn
            // 
            this.UpdateBtn.BorderRadius = 15;
            this.UpdateBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.UpdateBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.UpdateBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.UpdateBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.UpdateBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.UpdateBtn.FillColor = System.Drawing.Color.DimGray;
            this.UpdateBtn.FocusedColor = System.Drawing.Color.Black;
            this.UpdateBtn.Font = new System.Drawing.Font("Sitka Display", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UpdateBtn.ForeColor = System.Drawing.Color.White;
            this.UpdateBtn.HoverState.BorderColor = System.Drawing.Color.Orange;
            this.UpdateBtn.HoverState.FillColor = System.Drawing.Color.Blue;
            this.UpdateBtn.Location = new System.Drawing.Point(195, 31);
            this.UpdateBtn.Name = "UpdateBtn";
            this.UpdateBtn.Size = new System.Drawing.Size(146, 36);
            this.UpdateBtn.TabIndex = 2;
            this.UpdateBtn.Text = "Update";
            this.UpdateBtn.Click += new System.EventHandler(this.UpdateBtn_Click);
            // 
            // DeleteBtn
            // 
            this.DeleteBtn.BorderRadius = 15;
            this.DeleteBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.DeleteBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.DeleteBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.DeleteBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.DeleteBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DeleteBtn.FillColor = System.Drawing.Color.DimGray;
            this.DeleteBtn.FocusedColor = System.Drawing.Color.Black;
            this.DeleteBtn.Font = new System.Drawing.Font("Sitka Display", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteBtn.ForeColor = System.Drawing.Color.White;
            this.DeleteBtn.HoverState.BorderColor = System.Drawing.Color.Orange;
            this.DeleteBtn.HoverState.FillColor = System.Drawing.Color.Blue;
            this.DeleteBtn.Location = new System.Drawing.Point(367, 31);
            this.DeleteBtn.Name = "DeleteBtn";
            this.DeleteBtn.Size = new System.Drawing.Size(146, 36);
            this.DeleteBtn.TabIndex = 3;
            this.DeleteBtn.Text = "Delete";
            this.DeleteBtn.Click += new System.EventHandler(this.DeleteBtn_Click);
            // 
            // LoadBtn
            // 
            this.LoadBtn.BorderRadius = 15;
            this.LoadBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.LoadBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.LoadBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.LoadBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.LoadBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LoadBtn.FillColor = System.Drawing.Color.DimGray;
            this.LoadBtn.FocusedColor = System.Drawing.Color.Black;
            this.LoadBtn.Font = new System.Drawing.Font("Sitka Display", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoadBtn.ForeColor = System.Drawing.Color.White;
            this.LoadBtn.HoverState.BorderColor = System.Drawing.Color.Orange;
            this.LoadBtn.HoverState.FillColor = System.Drawing.Color.Blue;
            this.LoadBtn.Location = new System.Drawing.Point(539, 31);
            this.LoadBtn.Name = "LoadBtn";
            this.LoadBtn.Size = new System.Drawing.Size(146, 36);
            this.LoadBtn.TabIndex = 4;
            this.LoadBtn.Text = "Load";
            this.LoadBtn.Click += new System.EventHandler(this.LoadBtn_Click);
            // 
            // SaveBtn
            // 
            this.SaveBtn.BorderRadius = 15;
            this.SaveBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.SaveBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.SaveBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.SaveBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.SaveBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SaveBtn.FillColor = System.Drawing.Color.DimGray;
            this.SaveBtn.FocusedColor = System.Drawing.Color.Black;
            this.SaveBtn.Font = new System.Drawing.Font("Sitka Display", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaveBtn.ForeColor = System.Drawing.Color.White;
            this.SaveBtn.HoverState.BorderColor = System.Drawing.Color.Orange;
            this.SaveBtn.HoverState.FillColor = System.Drawing.Color.Blue;
            this.SaveBtn.Location = new System.Drawing.Point(711, 31);
            this.SaveBtn.Name = "SaveBtn";
            this.SaveBtn.Size = new System.Drawing.Size(146, 36);
            this.SaveBtn.TabIndex = 5;
            this.SaveBtn.Text = "Save";
            this.SaveBtn.Click += new System.EventHandler(this.SaveBtn_Click);
            // 
            // InputsManagement
            // 
            this.InputsManagement.Controls.Add(this.Inputs);
            this.InputsManagement.Dock = System.Windows.Forms.DockStyle.Top;
            this.InputsManagement.Location = new System.Drawing.Point(0, 0);
            this.InputsManagement.Name = "InputsManagement";
            this.InputsManagement.Size = new System.Drawing.Size(884, 159);
            this.InputsManagement.TabIndex = 0;
            // 
            // Inputs
            // 
            this.Inputs.ColumnCount = 7;
            this.Inputs.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.Inputs.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.Inputs.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.Inputs.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.Inputs.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.Inputs.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.Inputs.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.Inputs.Controls.Add(this.ContactName, 1, 1);
            this.Inputs.Controls.Add(this.ContactNumber, 4, 1);
            this.Inputs.Controls.Add(this.Address, 4, 3);
            this.Inputs.Controls.Add(this.Email, 1, 3);
            this.Inputs.Controls.Add(this.ContactInput, 2, 1);
            this.Inputs.Controls.Add(this.EmailInput, 2, 3);
            this.Inputs.Controls.Add(this.PhoneInput, 5, 1);
            this.Inputs.Controls.Add(this.AddressInput, 5, 3);
            this.Inputs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Inputs.Location = new System.Drawing.Point(0, 0);
            this.Inputs.Name = "Inputs";
            this.Inputs.RowCount = 5;
            this.Inputs.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.Inputs.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.Inputs.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.Inputs.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.Inputs.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.Inputs.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.Inputs.Size = new System.Drawing.Size(884, 159);
            this.Inputs.TabIndex = 0;
            // 
            // ContactName
            // 
            this.ContactName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ContactName.Font = new System.Drawing.Font("Sitka Heading", 14.25F, System.Drawing.FontStyle.Bold);
            this.ContactName.Location = new System.Drawing.Point(103, 20);
            this.ContactName.Name = "ContactName";
            this.ContactName.Size = new System.Drawing.Size(140, 49);
            this.ContactName.TabIndex = 1;
            this.ContactName.Text = "Contact Name";
            this.ContactName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ContactNumber
            // 
            this.ContactNumber.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ContactNumber.Font = new System.Drawing.Font("Sitka Heading", 14.25F, System.Drawing.FontStyle.Bold);
            this.ContactNumber.Location = new System.Drawing.Point(495, 20);
            this.ContactNumber.Name = "ContactNumber";
            this.ContactNumber.Size = new System.Drawing.Size(140, 49);
            this.ContactNumber.TabIndex = 2;
            this.ContactNumber.Text = "Ph. Number";
            this.ContactNumber.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Address
            // 
            this.Address.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Address.Font = new System.Drawing.Font("Sitka Heading", 14.25F, System.Drawing.FontStyle.Bold);
            this.Address.Location = new System.Drawing.Point(495, 89);
            this.Address.Name = "Address";
            this.Address.Size = new System.Drawing.Size(140, 49);
            this.Address.TabIndex = 3;
            this.Address.Text = "Address";
            this.Address.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Email
            // 
            this.Email.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Email.Font = new System.Drawing.Font("Sitka Heading", 14.25F, System.Drawing.FontStyle.Bold);
            this.Email.Location = new System.Drawing.Point(103, 89);
            this.Email.Name = "Email";
            this.Email.Size = new System.Drawing.Size(140, 49);
            this.Email.TabIndex = 0;
            this.Email.Text = "Email";
            this.Email.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ContactInput
            // 
            this.ContactInput.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.ContactInput.DefaultText = "";
            this.ContactInput.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.ContactInput.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.ContactInput.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.ContactInput.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.ContactInput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ContactInput.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ContactInput.Font = new System.Drawing.Font("Sitka Display", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ContactInput.ForeColor = System.Drawing.Color.Black;
            this.ContactInput.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ContactInput.Location = new System.Drawing.Point(250, 26);
            this.ContactInput.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.ContactInput.Name = "ContactInput";
            this.ContactInput.PasswordChar = '\0';
            this.ContactInput.PlaceholderText = "";
            this.ContactInput.SelectedText = "";
            this.ContactInput.Size = new System.Drawing.Size(138, 37);
            this.ContactInput.TabIndex = 4;
            // 
            // EmailInput
            // 
            this.EmailInput.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.EmailInput.DefaultText = "";
            this.EmailInput.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.EmailInput.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.EmailInput.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.EmailInput.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.EmailInput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.EmailInput.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.EmailInput.Font = new System.Drawing.Font("Sitka Display", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmailInput.ForeColor = System.Drawing.Color.Black;
            this.EmailInput.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.EmailInput.Location = new System.Drawing.Point(250, 95);
            this.EmailInput.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.EmailInput.Name = "EmailInput";
            this.EmailInput.PasswordChar = '\0';
            this.EmailInput.PlaceholderText = "";
            this.EmailInput.SelectedText = "";
            this.EmailInput.Size = new System.Drawing.Size(138, 37);
            this.EmailInput.TabIndex = 5;
            // 
            // PhoneInput
            // 
            this.PhoneInput.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.PhoneInput.DefaultText = "";
            this.PhoneInput.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.PhoneInput.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.PhoneInput.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.PhoneInput.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.PhoneInput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PhoneInput.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.PhoneInput.Font = new System.Drawing.Font("Sitka Display", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PhoneInput.ForeColor = System.Drawing.Color.Black;
            this.PhoneInput.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.PhoneInput.Location = new System.Drawing.Point(642, 26);
            this.PhoneInput.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.PhoneInput.Name = "PhoneInput";
            this.PhoneInput.PasswordChar = '\0';
            this.PhoneInput.PlaceholderText = "";
            this.PhoneInput.SelectedText = "";
            this.PhoneInput.Size = new System.Drawing.Size(138, 37);
            this.PhoneInput.TabIndex = 7;
            // 
            // AddressInput
            // 
            this.AddressInput.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.AddressInput.DefaultText = "";
            this.AddressInput.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.AddressInput.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.AddressInput.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.AddressInput.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.AddressInput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AddressInput.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.AddressInput.Font = new System.Drawing.Font("Sitka Display", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddressInput.ForeColor = System.Drawing.Color.Black;
            this.AddressInput.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.AddressInput.Location = new System.Drawing.Point(642, 95);
            this.AddressInput.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.AddressInput.Name = "AddressInput";
            this.AddressInput.PasswordChar = '\0';
            this.AddressInput.PlaceholderText = "";
            this.AddressInput.SelectedText = "";
            this.AddressInput.Size = new System.Drawing.Size(138, 37);
            this.AddressInput.TabIndex = 6;
            // 
            // TopContainer
            // 
            this.TopContainer.BackColor = System.Drawing.Color.Transparent;
            this.TopContainer.Controls.Add(this.Header);
            this.TopContainer.Dock = System.Windows.Forms.DockStyle.Top;
            this.TopContainer.Location = new System.Drawing.Point(0, 0);
            this.TopContainer.Name = "TopContainer";
            this.TopContainer.Size = new System.Drawing.Size(884, 120);
            this.TopContainer.TabIndex = 4;
            // 
            // Header
            // 
            this.Header.BackColor = System.Drawing.Color.MidnightBlue;
            this.Header.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Header.Font = new System.Drawing.Font("Sitka Heading", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Header.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.Header.Location = new System.Drawing.Point(0, 0);
            this.Header.Name = "Header";
            this.Header.Size = new System.Drawing.Size(884, 120);
            this.Header.TabIndex = 2;
            this.Header.Text = "Manage Contacts";
            this.Header.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ManageContacts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 561);
            this.Controls.Add(this.MainPanel);
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "ManageContacts";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ManageContacts";
            this.MainPanel.ResumeLayout(false);
            this.BottomContainer.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ContactViews)).EndInit();
            this.ButtonsContainer.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.InputsManagement.ResumeLayout(false);
            this.Inputs.ResumeLayout(false);
            this.TopContainer.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel MainPanel;
        private Guna.UI2.WinForms.Guna2Panel TopContainer;
        private System.Windows.Forms.Label Header;
        private Guna.UI2.WinForms.Guna2Panel BottomContainer;
        private System.Windows.Forms.Panel InputsManagement;
        private System.Windows.Forms.TableLayoutPanel Inputs;
        private System.Windows.Forms.Label Email;
        private System.Windows.Forms.Label ContactName;
        private System.Windows.Forms.Label ContactNumber;
        private System.Windows.Forms.Label Address;
        private Guna.UI2.WinForms.Guna2TextBox EmailInput;
        private Guna.UI2.WinForms.Guna2TextBox ContactInput;
        private Guna.UI2.WinForms.Guna2TextBox PhoneInput;
        private Guna.UI2.WinForms.Guna2TextBox AddressInput;
        private System.Windows.Forms.Panel ButtonsContainer;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private Guna.UI2.WinForms.Guna2Button AddBtn;
        private Guna.UI2.WinForms.Guna2Button UpdateBtn;
        private Guna.UI2.WinForms.Guna2Button DeleteBtn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView ContactViews;
        private Guna.UI2.WinForms.Guna2Button LoadBtn;
        private Guna.UI2.WinForms.Guna2Button SaveBtn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
    }
}
namespace Bus_Schedule_Management
{
    partial class ViewSchedules
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
            this.TopContainer = new Guna.UI2.WinForms.Guna2Panel();
            this.Header = new System.Windows.Forms.Label();
            this.Logo = new System.Windows.Forms.Label();
            this.BottomContainer = new System.Windows.Forms.Panel();
            this.SearchBtn = new System.Windows.Forms.Panel();
            this.BtnContainer = new System.Windows.Forms.Panel();
            this.Btns = new System.Windows.Forms.TableLayoutPanel();
            this.BackBtn = new Guna.UI2.WinForms.Guna2Button();
            this.DataPanel = new System.Windows.Forms.Panel();
            this.BusesTimeTable = new System.Windows.Forms.DataGridView();
            this.SearchSchedule = new System.Windows.Forms.TableLayoutPanel();
            this.SearchBar = new Guna.UI2.WinForms.Guna2TextBox();
            this.SearchBtnn = new Guna.UI2.WinForms.Guna2Button();
            this.label1 = new System.Windows.Forms.Label();
            this.TopContainer.SuspendLayout();
            this.BottomContainer.SuspendLayout();
            this.SearchBtn.SuspendLayout();
            this.BtnContainer.SuspendLayout();
            this.Btns.SuspendLayout();
            this.DataPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BusesTimeTable)).BeginInit();
            this.SearchSchedule.SuspendLayout();
            this.SuspendLayout();
            // 
            // TopContainer
            // 
            this.TopContainer.BackColor = System.Drawing.Color.Transparent;
            this.TopContainer.Controls.Add(this.Header);
            this.TopContainer.Controls.Add(this.Logo);
            this.TopContainer.Dock = System.Windows.Forms.DockStyle.Top;
            this.TopContainer.Location = new System.Drawing.Point(0, 0);
            this.TopContainer.Name = "TopContainer";
            this.TopContainer.Size = new System.Drawing.Size(984, 150);
            this.TopContainer.TabIndex = 1;
            // 
            // Header
            // 
            this.Header.BackColor = System.Drawing.Color.MidnightBlue;
            this.Header.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Header.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Bold);
            this.Header.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.Header.Location = new System.Drawing.Point(0, 0);
            this.Header.Name = "Header";
            this.Header.Size = new System.Drawing.Size(984, 150);
            this.Header.TabIndex = 2;
            this.Header.Text = "View Schedule";
            this.Header.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Logo
            // 
            this.Logo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Logo.Font = new System.Drawing.Font("Sitka Heading", 72F, System.Drawing.FontStyle.Bold);
            this.Logo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(144)))), ((int)(((byte)(231)))));
            this.Logo.Location = new System.Drawing.Point(0, 0);
            this.Logo.Name = "Logo";
            this.Logo.Size = new System.Drawing.Size(984, 150);
            this.Logo.TabIndex = 1;
            this.Logo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BottomContainer
            // 
            this.BottomContainer.Controls.Add(this.DataPanel);
            this.BottomContainer.Controls.Add(this.BtnContainer);
            this.BottomContainer.Controls.Add(this.SearchBtn);
            this.BottomContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BottomContainer.Location = new System.Drawing.Point(0, 150);
            this.BottomContainer.Name = "BottomContainer";
            this.BottomContainer.Size = new System.Drawing.Size(984, 599);
            this.BottomContainer.TabIndex = 2;
            // 
            // SearchBtn
            // 
            this.SearchBtn.Controls.Add(this.SearchSchedule);
            this.SearchBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.SearchBtn.Location = new System.Drawing.Point(0, 0);
            this.SearchBtn.Name = "SearchBtn";
            this.SearchBtn.Size = new System.Drawing.Size(984, 100);
            this.SearchBtn.TabIndex = 0;
            // 
            // BtnContainer
            // 
            this.BtnContainer.Controls.Add(this.Btns);
            this.BtnContainer.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.BtnContainer.Location = new System.Drawing.Point(0, 499);
            this.BtnContainer.Name = "BtnContainer";
            this.BtnContainer.Size = new System.Drawing.Size(984, 100);
            this.BtnContainer.TabIndex = 1;
            // 
            // Btns
            // 
            this.Btns.ColumnCount = 7;
            this.Btns.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.Btns.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.Btns.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.Btns.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.Btns.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.Btns.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.Btns.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.Btns.Controls.Add(this.BackBtn, 1, 0);
            this.Btns.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Btns.Location = new System.Drawing.Point(0, 0);
            this.Btns.Name = "Btns";
            this.Btns.RowCount = 2;
            this.Btns.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.Btns.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.Btns.Size = new System.Drawing.Size(984, 100);
            this.Btns.TabIndex = 0;
            // 
            // BackBtn
            // 
            this.BackBtn.BorderRadius = 20;
            this.BackBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BackBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BackBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BackBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BackBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BackBtn.FillColor = System.Drawing.Color.DimGray;
            this.BackBtn.FocusedColor = System.Drawing.Color.Black;
            this.BackBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BackBtn.ForeColor = System.Drawing.Color.White;
            this.BackBtn.HoverState.BorderColor = System.Drawing.Color.Orange;
            this.BackBtn.HoverState.FillColor = System.Drawing.Color.Blue;
            this.BackBtn.Location = new System.Drawing.Point(143, 3);
            this.BackBtn.Name = "BackBtn";
            this.BackBtn.Size = new System.Drawing.Size(134, 44);
            this.BackBtn.TabIndex = 3;
            this.BackBtn.Text = "Back";
            this.BackBtn.Click += new System.EventHandler(this.BackBtn_Click);
            // 
            // DataPanel
            // 
            this.DataPanel.Controls.Add(this.BusesTimeTable);
            this.DataPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DataPanel.Location = new System.Drawing.Point(0, 100);
            this.DataPanel.Name = "DataPanel";
            this.DataPanel.Size = new System.Drawing.Size(984, 399);
            this.DataPanel.TabIndex = 2;
            // 
            // BusesTimeTable
            // 
            this.BusesTimeTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.BusesTimeTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.BusesTimeTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BusesTimeTable.Location = new System.Drawing.Point(0, 0);
            this.BusesTimeTable.Name = "BusesTimeTable";
            this.BusesTimeTable.ReadOnly = true;
            this.BusesTimeTable.Size = new System.Drawing.Size(984, 399);
            this.BusesTimeTable.TabIndex = 0;
            // 
            // SearchSchedule
            // 
            this.SearchSchedule.ColumnCount = 5;
            this.SearchSchedule.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.SearchSchedule.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.29675F));
            this.SearchSchedule.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 34.45122F));
            this.SearchSchedule.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 13.10976F));
            this.SearchSchedule.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.SearchSchedule.Controls.Add(this.SearchBar, 2, 0);
            this.SearchSchedule.Controls.Add(this.SearchBtnn, 3, 0);
            this.SearchSchedule.Controls.Add(this.label1, 1, 0);
            this.SearchSchedule.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SearchSchedule.Location = new System.Drawing.Point(0, 0);
            this.SearchSchedule.Name = "SearchSchedule";
            this.SearchSchedule.RowCount = 2;
            this.SearchSchedule.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.SearchSchedule.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.SearchSchedule.Size = new System.Drawing.Size(984, 100);
            this.SearchSchedule.TabIndex = 0;
            // 
            // SearchBar
            // 
            this.SearchBar.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.SearchBar.DefaultText = "";
            this.SearchBar.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.SearchBar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.SearchBar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.SearchBar.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.SearchBar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SearchBar.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.SearchBar.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.SearchBar.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.SearchBar.Location = new System.Drawing.Point(322, 4);
            this.SearchBar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.SearchBar.Name = "SearchBar";
            this.SearchBar.PasswordChar = '\0';
            this.SearchBar.PlaceholderText = "Enter bus number for searching";
            this.SearchBar.SelectedText = "";
            this.SearchBar.Size = new System.Drawing.Size(331, 42);
            this.SearchBar.TabIndex = 0;
            // 
            // SearchBtnn
            // 
            this.SearchBtnn.BorderRadius = 20;
            this.SearchBtnn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.SearchBtnn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.SearchBtnn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.SearchBtnn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.SearchBtnn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SearchBtnn.FillColor = System.Drawing.Color.DimGray;
            this.SearchBtnn.FocusedColor = System.Drawing.Color.Black;
            this.SearchBtnn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchBtnn.ForeColor = System.Drawing.Color.White;
            this.SearchBtnn.HoverState.BorderColor = System.Drawing.Color.Orange;
            this.SearchBtnn.HoverState.FillColor = System.Drawing.Color.Blue;
            this.SearchBtnn.Location = new System.Drawing.Point(660, 3);
            this.SearchBtnn.Name = "SearchBtnn";
            this.SearchBtnn.Size = new System.Drawing.Size(123, 44);
            this.SearchBtnn.TabIndex = 4;
            this.SearchBtnn.Text = "Search";
            this.SearchBtnn.Click += new System.EventHandler(this.SearchBtnn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(200, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 50);
            this.label1.TabIndex = 6;
            this.label1.Text = "Bus Number";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ViewSchedules
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 749);
            this.Controls.Add(this.BottomContainer);
            this.Controls.Add(this.TopContainer);
            this.Name = "ViewSchedules";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ViewSchedules";
            this.TopContainer.ResumeLayout(false);
            this.BottomContainer.ResumeLayout(false);
            this.SearchBtn.ResumeLayout(false);
            this.BtnContainer.ResumeLayout(false);
            this.Btns.ResumeLayout(false);
            this.DataPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.BusesTimeTable)).EndInit();
            this.SearchSchedule.ResumeLayout(false);
            this.SearchSchedule.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel TopContainer;
        private System.Windows.Forms.Label Header;
        private System.Windows.Forms.Label Logo;
        private System.Windows.Forms.Panel BottomContainer;
        private System.Windows.Forms.Panel SearchBtn;
        private System.Windows.Forms.Panel BtnContainer;
        private System.Windows.Forms.TableLayoutPanel Btns;
        private Guna.UI2.WinForms.Guna2Button BackBtn;
        private System.Windows.Forms.Panel DataPanel;
        private System.Windows.Forms.DataGridView BusesTimeTable;
        private System.Windows.Forms.TableLayoutPanel SearchSchedule;
        private Guna.UI2.WinForms.Guna2TextBox SearchBar;
        private Guna.UI2.WinForms.Guna2Button SearchBtnn;
        private System.Windows.Forms.Label label1;
    }
}
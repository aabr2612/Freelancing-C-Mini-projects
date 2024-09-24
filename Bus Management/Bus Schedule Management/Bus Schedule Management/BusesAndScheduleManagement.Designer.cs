﻿namespace Bus_Schedule_Management
{
    partial class BusesAndScheduleManagement
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
            this.Inputs = new System.Windows.Forms.TableLayoutPanel();
            this.ManageScheduleBtn = new Guna.UI2.WinForms.Guna2Button();
            this.AddAdminsBtn = new Guna.UI2.WinForms.Guna2Button();
            this.BackBtn = new Guna.UI2.WinForms.Guna2Button();
            this.Logo = new System.Windows.Forms.Label();
            this.BottomContainer = new Guna.UI2.WinForms.Guna2Panel();
            this.TopContainer = new Guna.UI2.WinForms.Guna2Panel();
            this.Header = new System.Windows.Forms.Label();
            this.MainPanel = new Guna.UI2.WinForms.Guna2Panel();
            this.AddRoutes = new Guna.UI2.WinForms.Guna2Button();
            this.Inputs.SuspendLayout();
            this.BottomContainer.SuspendLayout();
            this.TopContainer.SuspendLayout();
            this.MainPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // Inputs
            // 
            this.Inputs.BackColor = System.Drawing.Color.GhostWhite;
            this.Inputs.ColumnCount = 5;
            this.Inputs.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18.56357F));
            this.Inputs.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18.56357F));
            this.Inputs.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.74572F));
            this.Inputs.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18.56357F));
            this.Inputs.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18.56357F));
            this.Inputs.Controls.Add(this.ManageScheduleBtn, 2, 1);
            this.Inputs.Controls.Add(this.BackBtn, 2, 7);
            this.Inputs.Controls.Add(this.AddAdminsBtn, 2, 5);
            this.Inputs.Controls.Add(this.AddRoutes, 2, 3);
            this.Inputs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Inputs.ForeColor = System.Drawing.Color.Black;
            this.Inputs.Location = new System.Drawing.Point(0, 0);
            this.Inputs.Name = "Inputs";
            this.Inputs.RowCount = 9;
            this.Inputs.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.Inputs.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.Inputs.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.Inputs.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.Inputs.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.Inputs.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.Inputs.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.Inputs.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.Inputs.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.Inputs.Size = new System.Drawing.Size(784, 411);
            this.Inputs.TabIndex = 0;
            // 
            // ManageScheduleBtn
            // 
            this.ManageScheduleBtn.BorderRadius = 20;
            this.ManageScheduleBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.ManageScheduleBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.ManageScheduleBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.ManageScheduleBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.ManageScheduleBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ManageScheduleBtn.FillColor = System.Drawing.Color.DimGray;
            this.ManageScheduleBtn.FocusedColor = System.Drawing.Color.Black;
            this.ManageScheduleBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ManageScheduleBtn.ForeColor = System.Drawing.Color.White;
            this.ManageScheduleBtn.HoverState.BorderColor = System.Drawing.Color.Orange;
            this.ManageScheduleBtn.HoverState.FillColor = System.Drawing.Color.Blue;
            this.ManageScheduleBtn.Location = new System.Drawing.Point(293, 33);
            this.ManageScheduleBtn.Name = "ManageScheduleBtn";
            this.ManageScheduleBtn.Size = new System.Drawing.Size(195, 59);
            this.ManageScheduleBtn.TabIndex = 0;
            this.ManageScheduleBtn.Text = "Add Bus";
            this.ManageScheduleBtn.Click += new System.EventHandler(this.ManageScheduleBtn_Click);
            // 
            // AddAdminsBtn
            // 
            this.AddAdminsBtn.BorderRadius = 20;
            this.AddAdminsBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.AddAdminsBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.AddAdminsBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.AddAdminsBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.AddAdminsBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AddAdminsBtn.FillColor = System.Drawing.Color.DimGray;
            this.AddAdminsBtn.FocusedColor = System.Drawing.Color.Black;
            this.AddAdminsBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddAdminsBtn.ForeColor = System.Drawing.Color.White;
            this.AddAdminsBtn.HoverState.BorderColor = System.Drawing.Color.Orange;
            this.AddAdminsBtn.HoverState.FillColor = System.Drawing.Color.Blue;
            this.AddAdminsBtn.Location = new System.Drawing.Point(293, 223);
            this.AddAdminsBtn.Name = "AddAdminsBtn";
            this.AddAdminsBtn.Size = new System.Drawing.Size(195, 59);
            this.AddAdminsBtn.TabIndex = 1;
            this.AddAdminsBtn.Text = "Manage Schedule";
            this.AddAdminsBtn.Click += new System.EventHandler(this.AddAdminsBtn_Click);
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
            this.BackBtn.Location = new System.Drawing.Point(293, 318);
            this.BackBtn.Name = "BackBtn";
            this.BackBtn.Size = new System.Drawing.Size(195, 59);
            this.BackBtn.TabIndex = 2;
            this.BackBtn.Text = "Back";
            this.BackBtn.Click += new System.EventHandler(this.BackBtn_Click);
            // 
            // Logo
            // 
            this.Logo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Logo.Font = new System.Drawing.Font("Sitka Heading", 72F, System.Drawing.FontStyle.Bold);
            this.Logo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(144)))), ((int)(((byte)(231)))));
            this.Logo.Location = new System.Drawing.Point(0, 0);
            this.Logo.Name = "Logo";
            this.Logo.Size = new System.Drawing.Size(784, 150);
            this.Logo.TabIndex = 1;
            this.Logo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BottomContainer
            // 
            this.BottomContainer.Controls.Add(this.Inputs);
            this.BottomContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BottomContainer.Location = new System.Drawing.Point(0, 150);
            this.BottomContainer.Name = "BottomContainer";
            this.BottomContainer.Size = new System.Drawing.Size(784, 411);
            this.BottomContainer.TabIndex = 1;
            // 
            // TopContainer
            // 
            this.TopContainer.BackColor = System.Drawing.Color.Transparent;
            this.TopContainer.Controls.Add(this.Header);
            this.TopContainer.Controls.Add(this.Logo);
            this.TopContainer.Dock = System.Windows.Forms.DockStyle.Top;
            this.TopContainer.Location = new System.Drawing.Point(0, 0);
            this.TopContainer.Name = "TopContainer";
            this.TopContainer.Size = new System.Drawing.Size(784, 150);
            this.TopContainer.TabIndex = 0;
            // 
            // Header
            // 
            this.Header.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Header.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Bold);
            this.Header.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.Header.Location = new System.Drawing.Point(0, 0);
            this.Header.Name = "Header";
            this.Header.Size = new System.Drawing.Size(784, 150);
            this.Header.TabIndex = 2;
            this.Header.Text = "Buses and Schedule";
            this.Header.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MainPanel
            // 
            this.MainPanel.Controls.Add(this.BottomContainer);
            this.MainPanel.Controls.Add(this.TopContainer);
            this.MainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainPanel.FillColor = System.Drawing.Color.MidnightBlue;
            this.MainPanel.Location = new System.Drawing.Point(0, 0);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(784, 561);
            this.MainPanel.TabIndex = 4;
            // 
            // AddRoutes
            // 
            this.AddRoutes.BorderRadius = 20;
            this.AddRoutes.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.AddRoutes.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.AddRoutes.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.AddRoutes.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.AddRoutes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AddRoutes.FillColor = System.Drawing.Color.DimGray;
            this.AddRoutes.FocusedColor = System.Drawing.Color.Black;
            this.AddRoutes.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddRoutes.ForeColor = System.Drawing.Color.White;
            this.AddRoutes.HoverState.BorderColor = System.Drawing.Color.Orange;
            this.AddRoutes.HoverState.FillColor = System.Drawing.Color.Blue;
            this.AddRoutes.Location = new System.Drawing.Point(293, 128);
            this.AddRoutes.Name = "AddRoutes";
            this.AddRoutes.Size = new System.Drawing.Size(195, 59);
            this.AddRoutes.TabIndex = 3;
            this.AddRoutes.Text = "Add Route";
            this.AddRoutes.Click += new System.EventHandler(this.AddRoutes_Click);
            // 
            // BusesAndScheduleManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.MainPanel);
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "BusesAndScheduleManagement";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BusesAndScheduleManagement";
            this.Inputs.ResumeLayout(false);
            this.BottomContainer.ResumeLayout(false);
            this.TopContainer.ResumeLayout(false);
            this.MainPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel Inputs;
        private Guna.UI2.WinForms.Guna2Button ManageScheduleBtn;
        private Guna.UI2.WinForms.Guna2Button AddAdminsBtn;
        private Guna.UI2.WinForms.Guna2Button BackBtn;
        private System.Windows.Forms.Label Logo;
        private Guna.UI2.WinForms.Guna2Panel BottomContainer;
        private Guna.UI2.WinForms.Guna2Panel TopContainer;
        private System.Windows.Forms.Label Header;
        private Guna.UI2.WinForms.Guna2Panel MainPanel;
        private Guna.UI2.WinForms.Guna2Button AddRoutes;
    }
}
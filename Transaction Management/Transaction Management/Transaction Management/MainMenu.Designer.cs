namespace Transaction_Management
{
    partial class MainMenu
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            MainPanel = new Panel();
            BottomContainer = new Panel();
            ButtonsContainer = new TableLayoutPanel();
            BtnManageTransaction = new Guna.UI2.WinForms.Guna2Button();
            BtnExit = new Guna.UI2.WinForms.Guna2Button();
            TopContainer = new Panel();
            Header = new Label();
            MainPanel.SuspendLayout();
            BottomContainer.SuspendLayout();
            ButtonsContainer.SuspendLayout();
            TopContainer.SuspendLayout();
            SuspendLayout();
            // 
            // MainPanel
            // 
            MainPanel.Controls.Add(BottomContainer);
            MainPanel.Controls.Add(TopContainer);
            MainPanel.Dock = DockStyle.Fill;
            MainPanel.Location = new Point(0, 0);
            MainPanel.Name = "MainPanel";
            MainPanel.Size = new Size(784, 461);
            MainPanel.TabIndex = 1;
            // 
            // BottomContainer
            // 
            BottomContainer.Controls.Add(ButtonsContainer);
            BottomContainer.Dock = DockStyle.Fill;
            BottomContainer.Location = new Point(0, 119);
            BottomContainer.Name = "BottomContainer";
            BottomContainer.Size = new Size(784, 342);
            BottomContainer.TabIndex = 2;
            // 
            // ButtonsContainer
            // 
            ButtonsContainer.BackColor = SystemColors.Menu;
            ButtonsContainer.ColumnCount = 5;
            ButtonsContainer.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 19.04762F));
            ButtonsContainer.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 19.0476189F));
            ButtonsContainer.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 23.8095245F));
            ButtonsContainer.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 19.0476189F));
            ButtonsContainer.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 19.0476189F));
            ButtonsContainer.Controls.Add(BtnManageTransaction, 2, 1);
            ButtonsContainer.Controls.Add(BtnExit, 2, 3);
            ButtonsContainer.Dock = DockStyle.Fill;
            ButtonsContainer.Location = new Point(0, 0);
            ButtonsContainer.Name = "ButtonsContainer";
            ButtonsContainer.RowCount = 5;
            ButtonsContainer.RowStyles.Add(new RowStyle(SizeType.Percent, 14.2857141F));
            ButtonsContainer.RowStyles.Add(new RowStyle(SizeType.Percent, 14.2857141F));
            ButtonsContainer.RowStyles.Add(new RowStyle(SizeType.Percent, 14.2857141F));
            ButtonsContainer.RowStyles.Add(new RowStyle(SizeType.Percent, 14.2857141F));
            ButtonsContainer.RowStyles.Add(new RowStyle(SizeType.Percent, 14.2857141F));
            ButtonsContainer.Size = new Size(784, 342);
            ButtonsContainer.TabIndex = 0;
            // 
            // BtnManageTransaction
            // 
            BtnManageTransaction.BorderRadius = 25;
            BtnManageTransaction.CustomizableEdges = customizableEdges1;
            BtnManageTransaction.DisabledState.BorderColor = Color.DarkGray;
            BtnManageTransaction.DisabledState.CustomBorderColor = Color.DarkGray;
            BtnManageTransaction.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            BtnManageTransaction.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            BtnManageTransaction.Dock = DockStyle.Fill;
            BtnManageTransaction.FillColor = SystemColors.InactiveCaption;
            BtnManageTransaction.Font = new Font("Sitka Display", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BtnManageTransaction.ForeColor = Color.White;
            BtnManageTransaction.HoverState.BorderColor = Color.Black;
            BtnManageTransaction.HoverState.FillColor = Color.FromArgb(94, 148, 255);
            BtnManageTransaction.HoverState.Font = new Font("Sitka Display", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnManageTransaction.Location = new Point(301, 71);
            BtnManageTransaction.Name = "BtnManageTransaction";
            BtnManageTransaction.ShadowDecoration.CustomizableEdges = customizableEdges2;
            BtnManageTransaction.Size = new Size(180, 62);
            BtnManageTransaction.TabIndex = 2;
            BtnManageTransaction.Text = "Manage Transactions";
            BtnManageTransaction.Click += BtnManageTransaction_Click;
            // 
            // BtnExit
            // 
            BtnExit.BorderRadius = 25;
            BtnExit.CustomizableEdges = customizableEdges3;
            BtnExit.DisabledState.BorderColor = Color.DarkGray;
            BtnExit.DisabledState.CustomBorderColor = Color.DarkGray;
            BtnExit.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            BtnExit.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            BtnExit.Dock = DockStyle.Fill;
            BtnExit.FillColor = SystemColors.InactiveCaption;
            BtnExit.Font = new Font("Sitka Display", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BtnExit.ForeColor = Color.White;
            BtnExit.HoverState.BorderColor = Color.Black;
            BtnExit.HoverState.FillColor = Color.FromArgb(94, 148, 255);
            BtnExit.HoverState.Font = new Font("Sitka Display", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnExit.Location = new Point(301, 207);
            BtnExit.Name = "BtnExit";
            BtnExit.ShadowDecoration.CustomizableEdges = customizableEdges4;
            BtnExit.Size = new Size(180, 62);
            BtnExit.TabIndex = 3;
            BtnExit.Text = "Exit";
            BtnExit.Click += BtnExit_Click;
            // 
            // TopContainer
            // 
            TopContainer.Controls.Add(Header);
            TopContainer.Dock = DockStyle.Top;
            TopContainer.Location = new Point(0, 0);
            TopContainer.Name = "TopContainer";
            TopContainer.Size = new Size(784, 119);
            TopContainer.TabIndex = 1;
            // 
            // Header
            // 
            Header.BackColor = Color.FromArgb(94, 148, 255);
            Header.Dock = DockStyle.Fill;
            Header.Font = new Font("Sitka Heading", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Header.ForeColor = SystemColors.Menu;
            Header.Location = new Point(0, 0);
            Header.Name = "Header";
            Header.Size = new Size(784, 119);
            Header.TabIndex = 0;
            Header.Text = "Personal Finance Tracker";
            Header.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // MainMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(784, 461);
            Controls.Add(MainPanel);
            MinimumSize = new Size(800, 500);
            Name = "MainMenu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MainMenu";
            MainPanel.ResumeLayout(false);
            BottomContainer.ResumeLayout(false);
            ButtonsContainer.ResumeLayout(false);
            TopContainer.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel MainPanel;
        private Panel BottomContainer;
        private TableLayoutPanel ButtonsContainer;
        private Guna.UI2.WinForms.Guna2Button BtnManageTransaction;
        private Guna.UI2.WinForms.Guna2Button BtnExit;
        private Panel TopContainer;
        private Label Header;
    }
}
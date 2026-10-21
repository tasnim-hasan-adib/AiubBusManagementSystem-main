namespace AiubBusManagementSystem.UserControls.Driver
{
    partial class DriverDashboardControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            buttonManagePickupConfirmation = new Button();
            buttonViewAssignedRoutes = new Button();
            panelHeader = new Panel();
            buttonLogout = new Button();
            labelDriver = new Label();
            labelAiubBusManagement = new Label();
            tableLayoutPanelMenu = new TableLayoutPanel();
            panelViewAssignedRoutes = new Panel();
            dgvVARLocations = new DataGridView();
            panelVARHeader = new Panel();
            labelVARTodaysAssignedBuses = new Label();
            buttonVARRefresh = new Button();
            buttonMRCreateRoute = new Button();
            dgvVARRoutes = new DataGridView();
            panelConfirmPickups = new Panel();
            dgvCPViewConfirmStudent = new DataGridView();
            panelCPHeader = new Panel();
            buttonCPConfirm = new Button();
            comboBoxCPTimeSlot = new ComboBox();
            labelCPSlot = new Label();
            dgvCpLocationAndCounts = new DataGridView();
            panelHeader.SuspendLayout();
            tableLayoutPanelMenu.SuspendLayout();
            panelViewAssignedRoutes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvVARLocations).BeginInit();
            panelVARHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvVARRoutes).BeginInit();
            panelConfirmPickups.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCPViewConfirmStudent).BeginInit();
            panelCPHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCpLocationAndCounts).BeginInit();
            SuspendLayout();
            // 
            // buttonManagePickupConfirmation
            // 
            buttonManagePickupConfirmation.Anchor = AnchorStyles.None;
            buttonManagePickupConfirmation.BackColor = Color.SteelBlue;
            buttonManagePickupConfirmation.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonManagePickupConfirmation.ForeColor = SystemColors.ControlLightLight;
            buttonManagePickupConfirmation.Location = new Point(472, 3);
            buttonManagePickupConfirmation.Name = "buttonManagePickupConfirmation";
            buttonManagePickupConfirmation.Size = new Size(460, 44);
            buttonManagePickupConfirmation.TabIndex = 2;
            buttonManagePickupConfirmation.Text = "Confirm Pickup's";
            buttonManagePickupConfirmation.UseVisualStyleBackColor = false;
            buttonManagePickupConfirmation.Click += buttonManagePickupConfirmation_Click;
            // 
            // buttonViewAssignedRoutes
            // 
            buttonViewAssignedRoutes.Anchor = AnchorStyles.None;
            buttonViewAssignedRoutes.BackColor = Color.SteelBlue;
            buttonViewAssignedRoutes.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonViewAssignedRoutes.ForeColor = SystemColors.ControlLightLight;
            buttonViewAssignedRoutes.Location = new Point(3, 3);
            buttonViewAssignedRoutes.Name = "buttonViewAssignedRoutes";
            buttonViewAssignedRoutes.Size = new Size(462, 44);
            buttonViewAssignedRoutes.TabIndex = 1;
            buttonViewAssignedRoutes.Text = "View Assigned Routes";
            buttonViewAssignedRoutes.UseVisualStyleBackColor = false;
            buttonViewAssignedRoutes.Click += buttonViewAssignedRoutes_Click;
            // 
            // panelHeader
            // 
            panelHeader.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panelHeader.BackColor = Color.SteelBlue;
            panelHeader.Controls.Add(buttonLogout);
            panelHeader.Controls.Add(labelDriver);
            panelHeader.Controls.Add(labelAiubBusManagement);
            panelHeader.Location = new Point(0, 2);
            panelHeader.Name = "panelHeader";
            panelHeader.Size = new Size(937, 58);
            panelHeader.TabIndex = 22;
            // 
            // buttonLogout
            // 
            buttonLogout.Anchor = AnchorStyles.None;
            buttonLogout.BackColor = Color.DodgerBlue;
            buttonLogout.BackgroundImageLayout = ImageLayout.None;
            buttonLogout.Cursor = Cursors.Hand;
            buttonLogout.FlatStyle = FlatStyle.Popup;
            buttonLogout.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonLogout.ForeColor = SystemColors.ControlLightLight;
            buttonLogout.Location = new Point(830, 7);
            buttonLogout.Margin = new Padding(5);
            buttonLogout.Name = "buttonLogout";
            buttonLogout.Size = new Size(93, 38);
            buttonLogout.TabIndex = 12;
            buttonLogout.Text = "Logout";
            buttonLogout.UseVisualStyleBackColor = false;
            buttonLogout.Click += buttonLogout_Click_1;
            // 
            // labelDriver
            // 
            labelDriver.Anchor = AnchorStyles.None;
            labelDriver.AutoSize = true;
            labelDriver.Font = new Font("Arial Narrow", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelDriver.ForeColor = SystemColors.ControlLightLight;
            labelDriver.Location = new Point(447, 9);
            labelDriver.Margin = new Padding(5, 0, 5, 0);
            labelDriver.Name = "labelDriver";
            labelDriver.Size = new Size(78, 31);
            labelDriver.TabIndex = 11;
            labelDriver.Text = "Driver";
            // 
            // labelAiubBusManagement
            // 
            labelAiubBusManagement.Anchor = AnchorStyles.None;
            labelAiubBusManagement.AutoSize = true;
            labelAiubBusManagement.Font = new Font("Arial Narrow", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelAiubBusManagement.ForeColor = SystemColors.ControlLightLight;
            labelAiubBusManagement.Location = new Point(5, 9);
            labelAiubBusManagement.Margin = new Padding(5, 0, 5, 0);
            labelAiubBusManagement.Name = "labelAiubBusManagement";
            labelAiubBusManagement.Size = new Size(341, 31);
            labelAiubBusManagement.TabIndex = 10;
            labelAiubBusManagement.Text = "AIUB Bus Management System";
            // 
            // tableLayoutPanelMenu
            // 
            tableLayoutPanelMenu.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanelMenu.BackColor = Color.DodgerBlue;
            tableLayoutPanelMenu.ColumnCount = 2;
            tableLayoutPanelMenu.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanelMenu.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanelMenu.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanelMenu.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanelMenu.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanelMenu.Controls.Add(buttonManagePickupConfirmation, 1, 0);
            tableLayoutPanelMenu.Controls.Add(buttonViewAssignedRoutes, 0, 0);
            tableLayoutPanelMenu.Location = new Point(0, 59);
            tableLayoutPanelMenu.Margin = new Padding(1);
            tableLayoutPanelMenu.Name = "tableLayoutPanelMenu";
            tableLayoutPanelMenu.RowCount = 1;
            tableLayoutPanelMenu.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanelMenu.Size = new Size(937, 50);
            tableLayoutPanelMenu.TabIndex = 23;
            // 
            // panelViewAssignedRoutes
            // 
            panelViewAssignedRoutes.Controls.Add(dgvVARLocations);
            panelViewAssignedRoutes.Controls.Add(panelVARHeader);
            panelViewAssignedRoutes.Controls.Add(dgvVARRoutes);
            panelViewAssignedRoutes.Location = new Point(3, 113);
            panelViewAssignedRoutes.Name = "panelViewAssignedRoutes";
            panelViewAssignedRoutes.Size = new Size(937, 480);
            panelViewAssignedRoutes.TabIndex = 24;
            // 
            // dgvVARLocations
            // 
            dgvVARLocations.AllowUserToAddRows = false;
            dgvVARLocations.AllowUserToDeleteRows = false;
            dgvVARLocations.AllowUserToResizeColumns = false;
            dgvVARLocations.AllowUserToResizeRows = false;
            dgvVARLocations.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dgvVARLocations.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvVARLocations.BackgroundColor = SystemColors.ControlLightLight;
            dgvVARLocations.ClipboardCopyMode = DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            dgvVARLocations.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvVARLocations.Location = new Point(585, 64);
            dgvVARLocations.MultiSelect = false;
            dgvVARLocations.Name = "dgvVARLocations";
            dgvVARLocations.ReadOnly = true;
            dgvVARLocations.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvVARLocations.Size = new Size(341, 413);
            dgvVARLocations.TabIndex = 19;
            // 
            // panelVARHeader
            // 
            panelVARHeader.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panelVARHeader.Controls.Add(labelVARTodaysAssignedBuses);
            panelVARHeader.Controls.Add(buttonVARRefresh);
            panelVARHeader.Controls.Add(buttonMRCreateRoute);
            panelVARHeader.Location = new Point(1, 5);
            panelVARHeader.Name = "panelVARHeader";
            panelVARHeader.Size = new Size(925, 53);
            panelVARHeader.TabIndex = 17;
            // 
            // labelVARTodaysAssignedBuses
            // 
            labelVARTodaysAssignedBuses.Anchor = AnchorStyles.None;
            labelVARTodaysAssignedBuses.AutoSize = true;
            labelVARTodaysAssignedBuses.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelVARTodaysAssignedBuses.ForeColor = SystemColors.ActiveCaptionText;
            labelVARTodaysAssignedBuses.Location = new Point(212, 10);
            labelVARTodaysAssignedBuses.Margin = new Padding(5, 0, 5, 0);
            labelVARTodaysAssignedBuses.Name = "labelVARTodaysAssignedBuses";
            labelVARTodaysAssignedBuses.Size = new Size(266, 32);
            labelVARTodaysAssignedBuses.TabIndex = 26;
            labelVARTodaysAssignedBuses.Text = "Today's Assigned Buses";
            // 
            // buttonVARRefresh
            // 
            buttonVARRefresh.Anchor = AnchorStyles.None;
            buttonVARRefresh.BackColor = Color.Ivory;
            buttonVARRefresh.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonVARRefresh.ForeColor = SystemColors.Desktop;
            buttonVARRefresh.Location = new Point(744, 10);
            buttonVARRefresh.Name = "buttonVARRefresh";
            buttonVARRefresh.Size = new Size(131, 31);
            buttonVARRefresh.TabIndex = 25;
            buttonVARRefresh.Text = "Refresh";
            buttonVARRefresh.UseVisualStyleBackColor = false;
            buttonVARRefresh.Click += buttonVARRefresh_Click;
            // 
            // buttonMRCreateRoute
            // 
            buttonMRCreateRoute.Anchor = AnchorStyles.None;
            buttonMRCreateRoute.BackColor = Color.Ivory;
            buttonMRCreateRoute.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonMRCreateRoute.ForeColor = SystemColors.Desktop;
            buttonMRCreateRoute.Location = new Point(1026, -20);
            buttonMRCreateRoute.Name = "buttonMRCreateRoute";
            buttonMRCreateRoute.Size = new Size(131, 31);
            buttonMRCreateRoute.TabIndex = 4;
            buttonMRCreateRoute.Text = "Create Route";
            buttonMRCreateRoute.UseVisualStyleBackColor = false;
            // 
            // dgvVARRoutes
            // 
            dgvVARRoutes.AllowUserToAddRows = false;
            dgvVARRoutes.AllowUserToDeleteRows = false;
            dgvVARRoutes.AllowUserToResizeColumns = false;
            dgvVARRoutes.AllowUserToResizeRows = false;
            dgvVARRoutes.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dgvVARRoutes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvVARRoutes.BackgroundColor = SystemColors.ControlLightLight;
            dgvVARRoutes.ClipboardCopyMode = DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            dgvVARRoutes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvVARRoutes.Location = new Point(0, 64);
            dgvVARRoutes.MultiSelect = false;
            dgvVARRoutes.Name = "dgvVARRoutes";
            dgvVARRoutes.ReadOnly = true;
            dgvVARRoutes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvVARRoutes.Size = new Size(576, 413);
            dgvVARRoutes.TabIndex = 18;
            dgvVARRoutes.SelectionChanged += dgvVARRoutes_SelectionChanged;
            // 
            // panelConfirmPickups
            // 
            panelConfirmPickups.Controls.Add(dgvCPViewConfirmStudent);
            panelConfirmPickups.Controls.Add(panelCPHeader);
            panelConfirmPickups.Controls.Add(dgvCpLocationAndCounts);
            panelConfirmPickups.Location = new Point(0, 107);
            panelConfirmPickups.Name = "panelConfirmPickups";
            panelConfirmPickups.Size = new Size(937, 480);
            panelConfirmPickups.TabIndex = 25;
            // 
            // dgvCPViewConfirmStudent
            // 
            dgvCPViewConfirmStudent.AllowUserToAddRows = false;
            dgvCPViewConfirmStudent.AllowUserToDeleteRows = false;
            dgvCPViewConfirmStudent.AllowUserToResizeColumns = false;
            dgvCPViewConfirmStudent.AllowUserToResizeRows = false;
            dgvCPViewConfirmStudent.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dgvCPViewConfirmStudent.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvCPViewConfirmStudent.BackgroundColor = SystemColors.ControlLightLight;
            dgvCPViewConfirmStudent.ClipboardCopyMode = DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            dgvCPViewConfirmStudent.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCPViewConfirmStudent.Location = new Point(585, 64);
            dgvCPViewConfirmStudent.MultiSelect = false;
            dgvCPViewConfirmStudent.Name = "dgvCPViewConfirmStudent";
            dgvCPViewConfirmStudent.ReadOnly = true;
            dgvCPViewConfirmStudent.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCPViewConfirmStudent.Size = new Size(347, 416);
            dgvCPViewConfirmStudent.TabIndex = 19;
            // 
            // panelCPHeader
            // 
            panelCPHeader.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panelCPHeader.Controls.Add(buttonCPConfirm);
            panelCPHeader.Controls.Add(comboBoxCPTimeSlot);
            panelCPHeader.Controls.Add(labelCPSlot);
            panelCPHeader.Location = new Point(1, 5);
            panelCPHeader.Name = "panelCPHeader";
            panelCPHeader.Size = new Size(931, 53);
            panelCPHeader.TabIndex = 17;
            // 
            // buttonCPConfirm
            // 
            buttonCPConfirm.Anchor = AnchorStyles.None;
            buttonCPConfirm.BackColor = Color.Ivory;
            buttonCPConfirm.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonCPConfirm.ForeColor = SystemColors.Desktop;
            buttonCPConfirm.Location = new Point(747, 13);
            buttonCPConfirm.Name = "buttonCPConfirm";
            buttonCPConfirm.Size = new Size(131, 31);
            buttonCPConfirm.TabIndex = 30;
            buttonCPConfirm.Text = "Confirm";
            buttonCPConfirm.UseVisualStyleBackColor = false;
            buttonCPConfirm.Click += buttonCPConfirm_Click_1;
            // 
            // comboBoxCPTimeSlot
            // 
            comboBoxCPTimeSlot.Anchor = AnchorStyles.None;
            comboBoxCPTimeSlot.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            comboBoxCPTimeSlot.FormattingEnabled = true;
            comboBoxCPTimeSlot.Location = new Point(172, 16);
            comboBoxCPTimeSlot.Name = "comboBoxCPTimeSlot";
            comboBoxCPTimeSlot.Size = new Size(186, 28);
            comboBoxCPTimeSlot.TabIndex = 29;
            comboBoxCPTimeSlot.Text = "Select Time Slot";
            comboBoxCPTimeSlot.SelectedIndexChanged += comboBoxCPTimeSlot_SelectedIndexChanged;
            comboBoxCPTimeSlot.Format += comboBoxCPTimeSlot_Format;
            // 
            // labelCPSlot
            // 
            labelCPSlot.Anchor = AnchorStyles.None;
            labelCPSlot.AutoSize = true;
            labelCPSlot.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelCPSlot.ForeColor = SystemColors.ActiveCaptionText;
            labelCPSlot.Location = new Point(81, 17);
            labelCPSlot.Margin = new Padding(5, 0, 5, 0);
            labelCPSlot.Name = "labelCPSlot";
            labelCPSlot.Size = new Size(83, 21);
            labelCPSlot.TabIndex = 27;
            labelCPSlot.Text = "Time Slot:";
            // 
            // dgvCpLocationAndCounts
            // 
            dgvCpLocationAndCounts.AllowUserToAddRows = false;
            dgvCpLocationAndCounts.AllowUserToDeleteRows = false;
            dgvCpLocationAndCounts.AllowUserToResizeColumns = false;
            dgvCpLocationAndCounts.AllowUserToResizeRows = false;
            dgvCpLocationAndCounts.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dgvCpLocationAndCounts.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvCpLocationAndCounts.BackgroundColor = SystemColors.ControlLightLight;
            dgvCpLocationAndCounts.ClipboardCopyMode = DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            dgvCpLocationAndCounts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCpLocationAndCounts.Location = new Point(0, 64);
            dgvCpLocationAndCounts.MultiSelect = false;
            dgvCpLocationAndCounts.Name = "dgvCpLocationAndCounts";
            dgvCpLocationAndCounts.ReadOnly = true;
            dgvCpLocationAndCounts.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCpLocationAndCounts.Size = new Size(579, 416);
            dgvCpLocationAndCounts.TabIndex = 18;
            dgvCpLocationAndCounts.SelectionChanged += dgvCpLocationAndCounts_SelectionChanged_1;
            // 
            // DriverDashboardControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panelConfirmPickups);
            Controls.Add(panelHeader);
            Controls.Add(tableLayoutPanelMenu);
            Controls.Add(panelViewAssignedRoutes);
            Name = "DriverDashboardControl";
            Size = new Size(940, 590);
            panelHeader.ResumeLayout(false);
            panelHeader.PerformLayout();
            tableLayoutPanelMenu.ResumeLayout(false);
            panelViewAssignedRoutes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvVARLocations).EndInit();
            panelVARHeader.ResumeLayout(false);
            panelVARHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvVARRoutes).EndInit();
            panelConfirmPickups.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvCPViewConfirmStudent).EndInit();
            panelCPHeader.ResumeLayout(false);
            panelCPHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCpLocationAndCounts).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Button buttonManagePickupConfirmation;
        private Button buttonViewAssignedRoutes;
        private Panel panelHeader;
        private Button buttonLogout;
        private Label labelDriver;
        private Label labelAiubBusManagement;
        private TableLayoutPanel tableLayoutPanelMenu;
        private Panel panelViewAssignedRoutes;
        private DataGridView dgvVARLocations;
        private Panel panelVARHeader;
        private Button buttonVARRefresh;
        private Button buttonMRCreateRoute;
        private DataGridView dgvVARRoutes;
        private Label labelVARTodaysAssignedBuses;
        private Panel panelConfirmPickups;
        private DataGridView dgvCPViewConfirmStudent;
        private Panel panelCPHeader;
        private Button button2;
        private DataGridView dgvCpLocationAndCounts;
        private Label labelCPSlot;
        private ComboBox comboBoxCPTimeSlot;
        private Button buttonCPConfirm;
    }
}

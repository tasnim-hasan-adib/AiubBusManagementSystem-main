namespace AiubBusManagementSystem.UserControls.Admin
{
    partial class AdminDashboardControl
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
            buttonManageRoutes = new Button();
            buttonManageStudent = new Button();
            buttonReports = new Button();
            buttonManageDriver = new Button();
            panelHeader = new Panel();
            buttonLogout = new Button();
            labelAdmin = new Label();
            labelAiubBusManagement = new Label();
            tableLayoutPanelMenu = new TableLayoutPanel();
            buttonAssignBus = new Button();
            panelManageRoutes = new Panel();
            dgvMRLocations = new DataGridView();
            panelMRHeader = new Panel();
            buttonMRAddLocation = new Button();
            textBoxMRLocationName = new TextBox();
            comboBoxMRDirection = new ComboBox();
            textBoxMRRouteName = new TextBox();
            buttonMRCreateRoute = new Button();
            dgvMRRoutes = new DataGridView();
            panelManageStudents = new Panel();
            panelMSHeader = new Panel();
            buttonMSBlock = new Button();
            buttonMSActive = new Button();
            buttonMSSearch = new Button();
            labelMSSearch = new Label();
            textBoxMSUsername = new TextBox();
            dgvManageStudents = new DataGridView();
            panelManageDriver = new Panel();
            panelMDHeader = new Panel();
            textBoxMDMobile = new TextBox();
            textBoxMDLicenceNum = new TextBox();
            textBoxMDPassword = new TextBox();
            textBoxMDUsername = new TextBox();
            textBoxMDFullname = new TextBox();
            buttonMDAddDriver = new Button();
            buttonMDRemove = new Button();
            dgvManageDriver = new DataGridView();
            panelAssignBus = new Panel();
            panelABHeader = new Panel();
            dateTimePickerAssignBus = new DateTimePicker();
            comboBoxABTimeSlot = new ComboBox();
            comboBoxABDriver = new ComboBox();
            comboBoxABRoute = new ComboBox();
            buttonABAssign = new Button();
            dgvAssignBus = new DataGridView();
            panelReports = new Panel();
            panelRHeader = new Panel();
            buttonRRefresh = new Button();
            labelRTotalCollectedAmount = new Label();
            dgvReport = new DataGridView();
            panelHeader.SuspendLayout();
            tableLayoutPanelMenu.SuspendLayout();
            panelManageRoutes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvMRLocations).BeginInit();
            panelMRHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvMRRoutes).BeginInit();
            panelManageStudents.SuspendLayout();
            panelMSHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvManageStudents).BeginInit();
            panelManageDriver.SuspendLayout();
            panelMDHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvManageDriver).BeginInit();
            panelAssignBus.SuspendLayout();
            panelABHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvAssignBus).BeginInit();
            panelReports.SuspendLayout();
            panelRHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvReport).BeginInit();
            SuspendLayout();
            // 
            // buttonManageRoutes
            // 
            buttonManageRoutes.Anchor = AnchorStyles.None;
            buttonManageRoutes.BackColor = Color.SteelBlue;
            buttonManageRoutes.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonManageRoutes.ForeColor = SystemColors.ControlLightLight;
            buttonManageRoutes.Location = new Point(4, 3);
            buttonManageRoutes.Name = "buttonManageRoutes";
            buttonManageRoutes.Size = new Size(185, 44);
            buttonManageRoutes.TabIndex = 1;
            buttonManageRoutes.Text = "Manage Routes";
            buttonManageRoutes.UseVisualStyleBackColor = false;
            buttonManageRoutes.Click += buttonManageRoutes_Click;
            // 
            // buttonManageStudent
            // 
            buttonManageStudent.Anchor = AnchorStyles.None;
            buttonManageStudent.BackColor = Color.SteelBlue;
            buttonManageStudent.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonManageStudent.ForeColor = SystemColors.ControlLightLight;
            buttonManageStudent.Location = new Point(197, 3);
            buttonManageStudent.Name = "buttonManageStudent";
            buttonManageStudent.Size = new Size(218, 44);
            buttonManageStudent.TabIndex = 2;
            buttonManageStudent.Text = "Manage Students";
            buttonManageStudent.UseVisualStyleBackColor = false;
            buttonManageStudent.Click += buttonManageStudent_Click;
            // 
            // buttonReports
            // 
            buttonReports.Anchor = AnchorStyles.None;
            buttonReports.BackColor = Color.SteelBlue;
            buttonReports.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonReports.ForeColor = SystemColors.ControlLightLight;
            buttonReports.Location = new Point(764, 3);
            buttonReports.Name = "buttonReports";
            buttonReports.Size = new Size(170, 44);
            buttonReports.TabIndex = 4;
            buttonReports.Text = "Reports";
            buttonReports.UseVisualStyleBackColor = false;
            buttonReports.Click += buttonReports_Click;
            // 
            // buttonManageDriver
            // 
            buttonManageDriver.Anchor = AnchorStyles.None;
            buttonManageDriver.BackColor = Color.SteelBlue;
            buttonManageDriver.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonManageDriver.ForeColor = SystemColors.ControlLightLight;
            buttonManageDriver.Location = new Point(422, 3);
            buttonManageDriver.Name = "buttonManageDriver";
            buttonManageDriver.Size = new Size(183, 44);
            buttonManageDriver.TabIndex = 3;
            buttonManageDriver.Text = "Manage Driver";
            buttonManageDriver.UseVisualStyleBackColor = false;
            buttonManageDriver.Click += buttonManageDriver_Click;
            // 
            // panelHeader
            // 
            panelHeader.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panelHeader.BackColor = Color.SteelBlue;
            panelHeader.Controls.Add(buttonLogout);
            panelHeader.Controls.Add(labelAdmin);
            panelHeader.Controls.Add(labelAiubBusManagement);
            panelHeader.Location = new Point(0, 0);
            panelHeader.Name = "panelHeader";
            panelHeader.Size = new Size(937, 58);
            panelHeader.TabIndex = 4;
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
            buttonLogout.Location = new Point(835, 7);
            buttonLogout.Margin = new Padding(5);
            buttonLogout.Name = "buttonLogout";
            buttonLogout.Size = new Size(93, 38);
            buttonLogout.TabIndex = 12;
            buttonLogout.Text = "Logout";
            buttonLogout.UseVisualStyleBackColor = false;
            buttonLogout.Click += buttonLogout_Click;
            // 
            // labelAdmin
            // 
            labelAdmin.Anchor = AnchorStyles.None;
            labelAdmin.AutoSize = true;
            labelAdmin.Font = new Font("Arial Narrow", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelAdmin.ForeColor = SystemColors.ControlLightLight;
            labelAdmin.Location = new Point(470, 9);
            labelAdmin.Margin = new Padding(5, 0, 5, 0);
            labelAdmin.Name = "labelAdmin";
            labelAdmin.Size = new Size(84, 31);
            labelAdmin.TabIndex = 11;
            labelAdmin.Text = "Admin";
            // 
            // labelAiubBusManagement
            // 
            labelAiubBusManagement.Anchor = AnchorStyles.None;
            labelAiubBusManagement.AutoSize = true;
            labelAiubBusManagement.Font = new Font("Arial Narrow", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelAiubBusManagement.ForeColor = SystemColors.ControlLightLight;
            labelAiubBusManagement.Location = new Point(3, 9);
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
            tableLayoutPanelMenu.ColumnCount = 5;
            tableLayoutPanelMenu.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20.5976524F));
            tableLayoutPanelMenu.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 24.11953F));
            tableLayoutPanelMenu.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20.1707573F));
            tableLayoutPanelMenu.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.3287086F));
            tableLayoutPanelMenu.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 18.6766281F));
            tableLayoutPanelMenu.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanelMenu.Controls.Add(buttonAssignBus, 3, 0);
            tableLayoutPanelMenu.Controls.Add(buttonManageDriver, 2, 0);
            tableLayoutPanelMenu.Controls.Add(buttonManageRoutes, 0, 0);
            tableLayoutPanelMenu.Controls.Add(buttonReports, 4, 0);
            tableLayoutPanelMenu.Controls.Add(buttonManageStudent, 1, 0);
            tableLayoutPanelMenu.Location = new Point(0, 57);
            tableLayoutPanelMenu.Margin = new Padding(1);
            tableLayoutPanelMenu.Name = "tableLayoutPanelMenu";
            tableLayoutPanelMenu.RowCount = 1;
            tableLayoutPanelMenu.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanelMenu.Size = new Size(937, 50);
            tableLayoutPanelMenu.TabIndex = 6;
            // 
            // buttonAssignBus
            // 
            buttonAssignBus.Anchor = AnchorStyles.None;
            buttonAssignBus.BackColor = Color.SteelBlue;
            buttonAssignBus.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonAssignBus.ForeColor = SystemColors.ControlLightLight;
            buttonAssignBus.Location = new Point(611, 3);
            buttonAssignBus.Name = "buttonAssignBus";
            buttonAssignBus.Size = new Size(147, 44);
            buttonAssignBus.TabIndex = 5;
            buttonAssignBus.Text = "Assign Bus";
            buttonAssignBus.UseVisualStyleBackColor = false;
            buttonAssignBus.Click += buttonAssignBus_Click;
            // 
            // panelManageRoutes
            // 
            panelManageRoutes.Controls.Add(dgvMRLocations);
            panelManageRoutes.Controls.Add(panelMRHeader);
            panelManageRoutes.Controls.Add(dgvMRRoutes);
            panelManageRoutes.Location = new Point(0, 107);
            panelManageRoutes.Name = "panelManageRoutes";
            panelManageRoutes.Size = new Size(940, 480);
            panelManageRoutes.TabIndex = 7;
            // 
            // dgvMRLocations
            // 
            dgvMRLocations.AllowUserToAddRows = false;
            dgvMRLocations.AllowUserToDeleteRows = false;
            dgvMRLocations.AllowUserToResizeColumns = false;
            dgvMRLocations.AllowUserToResizeRows = false;
            dgvMRLocations.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dgvMRLocations.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvMRLocations.BackgroundColor = SystemColors.ControlLightLight;
            dgvMRLocations.ClipboardCopyMode = DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            dgvMRLocations.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMRLocations.Location = new Point(615, 89);
            dgvMRLocations.MultiSelect = false;
            dgvMRLocations.Name = "dgvMRLocations";
            dgvMRLocations.ReadOnly = true;
            dgvMRLocations.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvMRLocations.Size = new Size(315, 391);
            dgvMRLocations.TabIndex = 19;
            // 
            // panelMRHeader
            // 
            panelMRHeader.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panelMRHeader.Controls.Add(buttonMRAddLocation);
            panelMRHeader.Controls.Add(textBoxMRLocationName);
            panelMRHeader.Controls.Add(comboBoxMRDirection);
            panelMRHeader.Controls.Add(textBoxMRRouteName);
            panelMRHeader.Controls.Add(buttonMRCreateRoute);
            panelMRHeader.Location = new Point(1, 5);
            panelMRHeader.Name = "panelMRHeader";
            panelMRHeader.Size = new Size(933, 78);
            panelMRHeader.TabIndex = 17;
            // 
            // buttonMRAddLocation
            // 
            buttonMRAddLocation.Anchor = AnchorStyles.None;
            buttonMRAddLocation.BackColor = Color.Ivory;
            buttonMRAddLocation.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonMRAddLocation.ForeColor = SystemColors.Desktop;
            buttonMRAddLocation.Location = new Point(664, 41);
            buttonMRAddLocation.Name = "buttonMRAddLocation";
            buttonMRAddLocation.Size = new Size(131, 31);
            buttonMRAddLocation.TabIndex = 25;
            buttonMRAddLocation.Text = "Add Location";
            buttonMRAddLocation.UseVisualStyleBackColor = false;
            buttonMRAddLocation.Click += buttonMRAddLocation_Click;
            // 
            // textBoxMRLocationName
            // 
            textBoxMRLocationName.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBoxMRLocationName.ForeColor = SystemColors.InactiveCaption;
            textBoxMRLocationName.Location = new Point(275, 41);
            textBoxMRLocationName.Name = "textBoxMRLocationName";
            textBoxMRLocationName.Size = new Size(221, 29);
            textBoxMRLocationName.TabIndex = 24;
            textBoxMRLocationName.Text = "Location Name";
            textBoxMRLocationName.Enter += textBoxMRLocationName_Enter;
            // 
            // comboBoxMRDirection
            // 
            comboBoxMRDirection.Anchor = AnchorStyles.None;
            comboBoxMRDirection.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            comboBoxMRDirection.FormattingEnabled = true;
            comboBoxMRDirection.Items.AddRange(new object[] { "ToUniversity", "FromUniversity" });
            comboBoxMRDirection.Location = new Point(402, 6);
            comboBoxMRDirection.Name = "comboBoxMRDirection";
            comboBoxMRDirection.Size = new Size(206, 28);
            comboBoxMRDirection.TabIndex = 23;
            comboBoxMRDirection.Text = "Select Direction";
            // 
            // textBoxMRRouteName
            // 
            textBoxMRRouteName.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBoxMRRouteName.ForeColor = SystemColors.InactiveCaption;
            textBoxMRRouteName.Location = new Point(124, 6);
            textBoxMRRouteName.Name = "textBoxMRRouteName";
            textBoxMRRouteName.Size = new Size(221, 29);
            textBoxMRRouteName.TabIndex = 22;
            textBoxMRRouteName.Text = "Route Name";
            textBoxMRRouteName.Enter += textBoxMRRouteName_Enter;
            // 
            // buttonMRCreateRoute
            // 
            buttonMRCreateRoute.Anchor = AnchorStyles.None;
            buttonMRCreateRoute.BackColor = Color.Ivory;
            buttonMRCreateRoute.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonMRCreateRoute.ForeColor = SystemColors.Desktop;
            buttonMRCreateRoute.Location = new Point(664, 4);
            buttonMRCreateRoute.Name = "buttonMRCreateRoute";
            buttonMRCreateRoute.Size = new Size(131, 31);
            buttonMRCreateRoute.TabIndex = 4;
            buttonMRCreateRoute.Text = "Create Route";
            buttonMRCreateRoute.UseVisualStyleBackColor = false;
            buttonMRCreateRoute.Click += buttonMRCreateRoute_Click;
            // 
            // dgvMRRoutes
            // 
            dgvMRRoutes.AllowUserToAddRows = false;
            dgvMRRoutes.AllowUserToDeleteRows = false;
            dgvMRRoutes.AllowUserToResizeColumns = false;
            dgvMRRoutes.AllowUserToResizeRows = false;
            dgvMRRoutes.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dgvMRRoutes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvMRRoutes.BackgroundColor = SystemColors.ControlLightLight;
            dgvMRRoutes.ClipboardCopyMode = DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            dgvMRRoutes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMRRoutes.Location = new Point(0, 89);
            dgvMRRoutes.MultiSelect = false;
            dgvMRRoutes.Name = "dgvMRRoutes";
            dgvMRRoutes.ReadOnly = true;
            dgvMRRoutes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvMRRoutes.Size = new Size(609, 391);
            dgvMRRoutes.TabIndex = 18;
            dgvMRRoutes.SelectionChanged += dgvMRRoutes_SelectionChanged;
            // 
            // panelManageStudents
            // 
            panelManageStudents.Controls.Add(panelMSHeader);
            panelManageStudents.Controls.Add(dgvManageStudents);
            panelManageStudents.Location = new Point(0, 107);
            panelManageStudents.Name = "panelManageStudents";
            panelManageStudents.Size = new Size(940, 480);
            panelManageStudents.TabIndex = 13;
            // 
            // panelMSHeader
            // 
            panelMSHeader.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panelMSHeader.Controls.Add(buttonMSBlock);
            panelMSHeader.Controls.Add(buttonMSActive);
            panelMSHeader.Controls.Add(buttonMSSearch);
            panelMSHeader.Controls.Add(labelMSSearch);
            panelMSHeader.Controls.Add(textBoxMSUsername);
            panelMSHeader.Location = new Point(0, 5);
            panelMSHeader.Name = "panelMSHeader";
            panelMSHeader.Size = new Size(934, 43);
            panelMSHeader.TabIndex = 18;
            // 
            // buttonMSBlock
            // 
            buttonMSBlock.Anchor = AnchorStyles.None;
            buttonMSBlock.BackColor = Color.Ivory;
            buttonMSBlock.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonMSBlock.ForeColor = SystemColors.Desktop;
            buttonMSBlock.Location = new Point(767, 5);
            buttonMSBlock.Name = "buttonMSBlock";
            buttonMSBlock.Size = new Size(131, 31);
            buttonMSBlock.TabIndex = 16;
            buttonMSBlock.Text = "Block";
            buttonMSBlock.UseVisualStyleBackColor = false;
            buttonMSBlock.Click += buttonMSBlock_Click;
            // 
            // buttonMSActive
            // 
            buttonMSActive.Anchor = AnchorStyles.None;
            buttonMSActive.BackColor = Color.Ivory;
            buttonMSActive.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonMSActive.ForeColor = SystemColors.Desktop;
            buttonMSActive.Location = new Point(621, 5);
            buttonMSActive.Name = "buttonMSActive";
            buttonMSActive.Size = new Size(131, 31);
            buttonMSActive.TabIndex = 15;
            buttonMSActive.Text = "Active";
            buttonMSActive.UseVisualStyleBackColor = false;
            buttonMSActive.Click += buttonMSActive_Click;
            // 
            // buttonMSSearch
            // 
            buttonMSSearch.Anchor = AnchorStyles.None;
            buttonMSSearch.BackColor = Color.Ivory;
            buttonMSSearch.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonMSSearch.ForeColor = SystemColors.Desktop;
            buttonMSSearch.Location = new Point(469, 5);
            buttonMSSearch.Name = "buttonMSSearch";
            buttonMSSearch.Size = new Size(131, 31);
            buttonMSSearch.TabIndex = 14;
            buttonMSSearch.Text = "Search";
            buttonMSSearch.UseVisualStyleBackColor = false;
            buttonMSSearch.Click += buttonMSSearch_Click;
            // 
            // labelMSSearch
            // 
            labelMSSearch.Anchor = AnchorStyles.None;
            labelMSSearch.AutoSize = true;
            labelMSSearch.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelMSSearch.ForeColor = SystemColors.ActiveCaptionText;
            labelMSSearch.Location = new Point(56, 9);
            labelMSSearch.Margin = new Padding(5, 0, 5, 0);
            labelMSSearch.Name = "labelMSSearch";
            labelMSSearch.Size = new Size(128, 21);
            labelMSSearch.TabIndex = 13;
            labelMSSearch.Text = "Search Students";
            // 
            // textBoxMSUsername
            // 
            textBoxMSUsername.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBoxMSUsername.Location = new Point(224, 7);
            textBoxMSUsername.Name = "textBoxMSUsername";
            textBoxMSUsername.Size = new Size(221, 27);
            textBoxMSUsername.TabIndex = 0;
            textBoxMSUsername.TextAlign = HorizontalAlignment.Center;
            // 
            // dgvManageStudents
            // 
            dgvManageStudents.AllowUserToAddRows = false;
            dgvManageStudents.AllowUserToDeleteRows = false;
            dgvManageStudents.AllowUserToResizeColumns = false;
            dgvManageStudents.AllowUserToResizeRows = false;
            dgvManageStudents.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dgvManageStudents.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvManageStudents.BackgroundColor = SystemColors.ControlLightLight;
            dgvManageStudents.ClipboardCopyMode = DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            dgvManageStudents.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvManageStudents.Location = new Point(2, 52);
            dgvManageStudents.MultiSelect = false;
            dgvManageStudents.Name = "dgvManageStudents";
            dgvManageStudents.ReadOnly = true;
            dgvManageStudents.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvManageStudents.Size = new Size(932, 428);
            dgvManageStudents.TabIndex = 19;
            // 
            // panelManageDriver
            // 
            panelManageDriver.Controls.Add(panelMDHeader);
            panelManageDriver.Controls.Add(dgvManageDriver);
            panelManageDriver.Location = new Point(0, 107);
            panelManageDriver.Name = "panelManageDriver";
            panelManageDriver.Size = new Size(940, 480);
            panelManageDriver.TabIndex = 20;
            // 
            // panelMDHeader
            // 
            panelMDHeader.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panelMDHeader.Controls.Add(textBoxMDMobile);
            panelMDHeader.Controls.Add(textBoxMDLicenceNum);
            panelMDHeader.Controls.Add(textBoxMDPassword);
            panelMDHeader.Controls.Add(textBoxMDUsername);
            panelMDHeader.Controls.Add(textBoxMDFullname);
            panelMDHeader.Controls.Add(buttonMDAddDriver);
            panelMDHeader.Controls.Add(buttonMDRemove);
            panelMDHeader.Location = new Point(0, 6);
            panelMDHeader.Name = "panelMDHeader";
            panelMDHeader.Size = new Size(934, 115);
            panelMDHeader.TabIndex = 18;
            // 
            // textBoxMDMobile
            // 
            textBoxMDMobile.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBoxMDMobile.ForeColor = SystemColors.InactiveCaption;
            textBoxMDMobile.Location = new Point(420, 67);
            textBoxMDMobile.Name = "textBoxMDMobile";
            textBoxMDMobile.Size = new Size(221, 29);
            textBoxMDMobile.TabIndex = 25;
            textBoxMDMobile.Text = "Mobile No...";
            textBoxMDMobile.Enter += textBoxMDMobile_Enter;
            // 
            // textBoxMDLicenceNum
            // 
            textBoxMDLicenceNum.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBoxMDLicenceNum.ForeColor = SystemColors.InactiveCaption;
            textBoxMDLicenceNum.Location = new Point(109, 67);
            textBoxMDLicenceNum.Name = "textBoxMDLicenceNum";
            textBoxMDLicenceNum.Size = new Size(221, 29);
            textBoxMDLicenceNum.TabIndex = 24;
            textBoxMDLicenceNum.Text = "Licence No...";
            textBoxMDLicenceNum.Enter += textBoxMDLicenceNum_Enter;
            // 
            // textBoxMDPassword
            // 
            textBoxMDPassword.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBoxMDPassword.ForeColor = SystemColors.InactiveCaption;
            textBoxMDPassword.Location = new Point(503, 15);
            textBoxMDPassword.Name = "textBoxMDPassword";
            textBoxMDPassword.Size = new Size(221, 29);
            textBoxMDPassword.TabIndex = 23;
            textBoxMDPassword.Text = "Password";
            textBoxMDPassword.Enter += textBoxMDPassword_Enter;
            // 
            // textBoxMDUsername
            // 
            textBoxMDUsername.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBoxMDUsername.ForeColor = SystemColors.InactiveCaption;
            textBoxMDUsername.Location = new Point(263, 15);
            textBoxMDUsername.Name = "textBoxMDUsername";
            textBoxMDUsername.Size = new Size(221, 29);
            textBoxMDUsername.TabIndex = 22;
            textBoxMDUsername.Text = "Username";
            textBoxMDUsername.Enter += textBoxMDUsername_Enter;
            // 
            // textBoxMDFullname
            // 
            textBoxMDFullname.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBoxMDFullname.ForeColor = SystemColors.InactiveCaption;
            textBoxMDFullname.Location = new Point(22, 14);
            textBoxMDFullname.Name = "textBoxMDFullname";
            textBoxMDFullname.Size = new Size(221, 29);
            textBoxMDFullname.TabIndex = 21;
            textBoxMDFullname.Text = "Full Name";
            textBoxMDFullname.Enter += textBoxMDFullname_Enter;
            // 
            // buttonMDAddDriver
            // 
            buttonMDAddDriver.Anchor = AnchorStyles.None;
            buttonMDAddDriver.BackColor = Color.Ivory;
            buttonMDAddDriver.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonMDAddDriver.ForeColor = SystemColors.Desktop;
            buttonMDAddDriver.Location = new Point(760, 13);
            buttonMDAddDriver.Name = "buttonMDAddDriver";
            buttonMDAddDriver.Size = new Size(131, 31);
            buttonMDAddDriver.TabIndex = 20;
            buttonMDAddDriver.Text = "Add Driver";
            buttonMDAddDriver.UseVisualStyleBackColor = false;
            buttonMDAddDriver.Click += buttonMDAddDriver_Click;
            // 
            // buttonMDRemove
            // 
            buttonMDRemove.Anchor = AnchorStyles.None;
            buttonMDRemove.BackColor = Color.Ivory;
            buttonMDRemove.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonMDRemove.ForeColor = SystemColors.Desktop;
            buttonMDRemove.Location = new Point(760, 66);
            buttonMDRemove.Name = "buttonMDRemove";
            buttonMDRemove.Size = new Size(131, 31);
            buttonMDRemove.TabIndex = 18;
            buttonMDRemove.Text = "Remove";
            buttonMDRemove.UseVisualStyleBackColor = false;
            buttonMDRemove.Click += buttonMDRemove_Click;
            // 
            // dgvManageDriver
            // 
            dgvManageDriver.AllowUserToAddRows = false;
            dgvManageDriver.AllowUserToDeleteRows = false;
            dgvManageDriver.AllowUserToResizeColumns = false;
            dgvManageDriver.AllowUserToResizeRows = false;
            dgvManageDriver.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dgvManageDriver.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvManageDriver.BackgroundColor = SystemColors.ControlLightLight;
            dgvManageDriver.ClipboardCopyMode = DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            dgvManageDriver.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvManageDriver.Location = new Point(0, 127);
            dgvManageDriver.MultiSelect = false;
            dgvManageDriver.Name = "dgvManageDriver";
            dgvManageDriver.ReadOnly = true;
            dgvManageDriver.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvManageDriver.Size = new Size(934, 353);
            dgvManageDriver.TabIndex = 19;
            // 
            // panelAssignBus
            // 
            panelAssignBus.Controls.Add(panelABHeader);
            panelAssignBus.Controls.Add(dgvAssignBus);
            panelAssignBus.Location = new Point(0, 107);
            panelAssignBus.Name = "panelAssignBus";
            panelAssignBus.Size = new Size(940, 480);
            panelAssignBus.TabIndex = 20;
            // 
            // panelABHeader
            // 
            panelABHeader.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panelABHeader.Controls.Add(dateTimePickerAssignBus);
            panelABHeader.Controls.Add(comboBoxABTimeSlot);
            panelABHeader.Controls.Add(comboBoxABDriver);
            panelABHeader.Controls.Add(comboBoxABRoute);
            panelABHeader.Controls.Add(buttonABAssign);
            panelABHeader.Location = new Point(1, 5);
            panelABHeader.Name = "panelABHeader";
            panelABHeader.Size = new Size(933, 78);
            panelABHeader.TabIndex = 17;
            // 
            // dateTimePickerAssignBus
            // 
            dateTimePickerAssignBus.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dateTimePickerAssignBus.Format = DateTimePickerFormat.Short;
            dateTimePickerAssignBus.Location = new Point(396, 44);
            dateTimePickerAssignBus.Name = "dateTimePickerAssignBus";
            dateTimePickerAssignBus.Size = new Size(206, 27);
            dateTimePickerAssignBus.TabIndex = 29;
            // 
            // comboBoxABTimeSlot
            // 
            comboBoxABTimeSlot.Anchor = AnchorStyles.None;
            comboBoxABTimeSlot.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            comboBoxABTimeSlot.FormattingEnabled = true;
            comboBoxABTimeSlot.Location = new Point(157, 43);
            comboBoxABTimeSlot.Name = "comboBoxABTimeSlot";
            comboBoxABTimeSlot.Size = new Size(206, 28);
            comboBoxABTimeSlot.TabIndex = 28;
            comboBoxABTimeSlot.Text = "Select Time Slot";
            // 
            // comboBoxABDriver
            // 
            comboBoxABDriver.Anchor = AnchorStyles.None;
            comboBoxABDriver.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            comboBoxABDriver.FormattingEnabled = true;
            comboBoxABDriver.Location = new Point(396, 7);
            comboBoxABDriver.Name = "comboBoxABDriver";
            comboBoxABDriver.Size = new Size(206, 28);
            comboBoxABDriver.TabIndex = 27;
            comboBoxABDriver.Text = "Select Driver";
            // 
            // comboBoxABRoute
            // 
            comboBoxABRoute.Anchor = AnchorStyles.None;
            comboBoxABRoute.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            comboBoxABRoute.FormattingEnabled = true;
            comboBoxABRoute.Location = new Point(157, 6);
            comboBoxABRoute.Name = "comboBoxABRoute";
            comboBoxABRoute.Size = new Size(206, 28);
            comboBoxABRoute.TabIndex = 26;
            comboBoxABRoute.Text = "Select Route";
            // 
            // buttonABAssign
            // 
            buttonABAssign.Anchor = AnchorStyles.None;
            buttonABAssign.BackColor = Color.Ivory;
            buttonABAssign.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonABAssign.ForeColor = SystemColors.Desktop;
            buttonABAssign.Location = new Point(664, 22);
            buttonABAssign.Name = "buttonABAssign";
            buttonABAssign.Size = new Size(131, 31);
            buttonABAssign.TabIndex = 25;
            buttonABAssign.Text = "Assign";
            buttonABAssign.UseVisualStyleBackColor = false;
            buttonABAssign.Click += buttonABAssign_Click;
            // 
            // dgvAssignBus
            // 
            dgvAssignBus.AllowUserToAddRows = false;
            dgvAssignBus.AllowUserToDeleteRows = false;
            dgvAssignBus.AllowUserToResizeColumns = false;
            dgvAssignBus.AllowUserToResizeRows = false;
            dgvAssignBus.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvAssignBus.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvAssignBus.BackgroundColor = SystemColors.ControlLightLight;
            dgvAssignBus.ClipboardCopyMode = DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            dgvAssignBus.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAssignBus.Location = new Point(0, 89);
            dgvAssignBus.MultiSelect = false;
            dgvAssignBus.Name = "dgvAssignBus";
            dgvAssignBus.ReadOnly = true;
            dgvAssignBus.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvAssignBus.Size = new Size(934, 391);
            dgvAssignBus.TabIndex = 18;
            // 
            // panelReports
            // 
            panelReports.Controls.Add(panelRHeader);
            panelReports.Controls.Add(dgvReport);
            panelReports.Location = new Point(0, 107);
            panelReports.Name = "panelReports";
            panelReports.Size = new Size(940, 480);
            panelReports.TabIndex = 21;
            // 
            // panelRHeader
            // 
            panelRHeader.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panelRHeader.Controls.Add(buttonRRefresh);
            panelRHeader.Controls.Add(labelRTotalCollectedAmount);
            panelRHeader.Location = new Point(3, 4);
            panelRHeader.Name = "panelRHeader";
            panelRHeader.Size = new Size(931, 54);
            panelRHeader.TabIndex = 17;
            // 
            // buttonRRefresh
            // 
            buttonRRefresh.Anchor = AnchorStyles.None;
            buttonRRefresh.BackColor = Color.Ivory;
            buttonRRefresh.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonRRefresh.ForeColor = SystemColors.Desktop;
            buttonRRefresh.Location = new Point(662, 11);
            buttonRRefresh.Name = "buttonRRefresh";
            buttonRRefresh.Size = new Size(131, 31);
            buttonRRefresh.TabIndex = 26;
            buttonRRefresh.Text = "Refresh";
            buttonRRefresh.UseVisualStyleBackColor = false;
            buttonRRefresh.Click += buttonRRefresh_Click;
            // 
            // labelRTotalCollectedAmount
            // 
            labelRTotalCollectedAmount.Anchor = AnchorStyles.None;
            labelRTotalCollectedAmount.AutoSize = true;
            labelRTotalCollectedAmount.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelRTotalCollectedAmount.ForeColor = SystemColors.ActiveCaptionText;
            labelRTotalCollectedAmount.Location = new Point(187, 14);
            labelRTotalCollectedAmount.Margin = new Padding(5, 0, 5, 0);
            labelRTotalCollectedAmount.Name = "labelRTotalCollectedAmount";
            labelRTotalCollectedAmount.Size = new Size(190, 21);
            labelRTotalCollectedAmount.TabIndex = 14;
            labelRTotalCollectedAmount.Text = "Total Collected Amount: ";
            // 
            // dgvReport
            // 
            dgvReport.AllowUserToAddRows = false;
            dgvReport.AllowUserToDeleteRows = false;
            dgvReport.AllowUserToResizeColumns = false;
            dgvReport.AllowUserToResizeRows = false;
            dgvReport.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvReport.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvReport.BackgroundColor = SystemColors.ControlLightLight;
            dgvReport.ClipboardCopyMode = DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            dgvReport.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvReport.Location = new Point(0, 64);
            dgvReport.MultiSelect = false;
            dgvReport.Name = "dgvReport";
            dgvReport.ReadOnly = true;
            dgvReport.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvReport.Size = new Size(934, 413);
            dgvReport.TabIndex = 18;
            // 
            // AdminDashboardControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tableLayoutPanelMenu);
            Controls.Add(panelHeader);
            Controls.Add(panelReports);
            Controls.Add(panelAssignBus);
            Controls.Add(panelManageRoutes);
            Controls.Add(panelManageStudents);
            Controls.Add(panelManageDriver);
            Name = "AdminDashboardControl";
            Size = new Size(940, 590);
            panelHeader.ResumeLayout(false);
            panelHeader.PerformLayout();
            tableLayoutPanelMenu.ResumeLayout(false);
            panelManageRoutes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvMRLocations).EndInit();
            panelMRHeader.ResumeLayout(false);
            panelMRHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvMRRoutes).EndInit();
            panelManageStudents.ResumeLayout(false);
            panelMSHeader.ResumeLayout(false);
            panelMSHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvManageStudents).EndInit();
            panelManageDriver.ResumeLayout(false);
            panelMDHeader.ResumeLayout(false);
            panelMDHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvManageDriver).EndInit();
            panelAssignBus.ResumeLayout(false);
            panelABHeader.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvAssignBus).EndInit();
            panelReports.ResumeLayout(false);
            panelRHeader.ResumeLayout(false);
            panelRHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvReport).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Button buttonManageRoutes;
        private Button buttonManageStudent;
        private Button buttonManageDriver;
        private Button buttonReports;
        private Panel panelHeader;
        private Label labelAdmin;
        private Label labelAiubBusManagement;
        private Button buttonLogout;
        private TableLayoutPanel tableLayoutPanelMenu;
        private Panel panelManageRoutes;
        private Panel panelManageStudents;
        private Panel panelMRHeader;
        private Button buttonMRCreateRoute;
        private DataGridView dgvMRRoutes;
        private DataGridView dgvManageStudents;
        private Panel panelMSHeader;
        private Button buttonMSSearch;
        private Label labelMSSearch;
        private TextBox textBoxMSUsername;
        private Button buttonMSBlock;
        private Button buttonMSActive;
        private Panel panelManageDriver;
        private Panel panelMDHeader;
        private Button buttonMDRemove;
        private DataGridView dgvManageDriver;
        private Button buttonMDAddDriver;
        private TextBox textBoxMDFullname;
        private TextBox textBoxMRRouteName;
        private ComboBox comboBoxMRDirection;
        private TextBox textBoxMRLocationName;
        private Button buttonMRAddLocation;
        private DataGridView dgvMRLocations;
        private Button buttonAssignBus;
        private TextBox textBoxMDMobile;
        private TextBox textBoxMDLicenceNum;
        private TextBox textBoxMDPassword;
        private TextBox textBoxMDUsername;
        private Panel panelAssignBus;
        private Panel panelABHeader;
        private DataGridView dgvAssignBus;
        private Panel panelReports;
        private Panel panelRHeader;
        private DataGridView dgvReport;
        private DateTimePicker dateTimePickerAssignBus;
        private ComboBox comboBoxABTimeSlot;
        private ComboBox comboBoxABDriver;
        private ComboBox comboBoxABRoute;
        private Button buttonABAssign;
        private Label labelRTotalCollectedAmount;
        private Button buttonRRefresh;
    }
}

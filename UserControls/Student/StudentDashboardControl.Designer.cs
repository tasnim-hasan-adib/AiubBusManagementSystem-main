namespace AiubBusManagementSystem.UserControls.Student
{
    partial class StudentDashboardControl
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
            buttonFeePayment = new Button();
            buttonProfileUpdate = new Button();
            buttonPickupSelection = new Button();
            panelHeader = new Panel();
            buttonLogout = new Button();
            labelStudent = new Label();
            labelAiubBusManagement = new Label();
            tableLayoutPanelMenu = new TableLayoutPanel();
            panelPickupSelection = new Panel();
            buttonPSSavePickup = new Button();
            grpLocations = new GroupBox();
            radioButton1 = new RadioButton();
            comboBoxPSRoute = new ComboBox();
            labelPSRoute = new Label();
            comboBoxPSTimeSlot = new ComboBox();
            labelPSSlot = new Label();
            panelFeePayment = new Panel();
            dgvFees = new DataGridView();
            textBoxFPAmount = new TextBox();
            labelPayAmount = new Label();
            labelFPTotalDue = new Label();
            buttonFPPay = new Button();
            panelProfileUpdate = new Panel();
            textBoxPUEmail = new TextBox();
            labelPUEmail = new Label();
            textBoxPUDepartment = new TextBox();
            labelPUDepartment = new Label();
            textBoxPUStudentID = new TextBox();
            labelPUStudentId = new Label();
            buttonPUProfileUpdate = new Button();
            panelHeader.SuspendLayout();
            tableLayoutPanelMenu.SuspendLayout();
            panelPickupSelection.SuspendLayout();
            grpLocations.SuspendLayout();
            panelFeePayment.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvFees).BeginInit();
            panelProfileUpdate.SuspendLayout();
            SuspendLayout();
            // 
            // buttonFeePayment
            // 
            buttonFeePayment.Anchor = AnchorStyles.None;
            buttonFeePayment.BackColor = Color.SteelBlue;
            buttonFeePayment.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonFeePayment.ForeColor = SystemColors.ControlLightLight;
            buttonFeePayment.Location = new Point(315, 3);
            buttonFeePayment.Name = "buttonFeePayment";
            buttonFeePayment.Size = new Size(306, 44);
            buttonFeePayment.TabIndex = 2;
            buttonFeePayment.Text = "Fee Payment";
            buttonFeePayment.UseVisualStyleBackColor = false;
            buttonFeePayment.Click += buttonFeePayment_Click;
            // 
            // buttonProfileUpdate
            // 
            buttonProfileUpdate.Anchor = AnchorStyles.None;
            buttonProfileUpdate.BackColor = Color.SteelBlue;
            buttonProfileUpdate.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonProfileUpdate.ForeColor = SystemColors.ControlLightLight;
            buttonProfileUpdate.Location = new Point(627, 3);
            buttonProfileUpdate.Name = "buttonProfileUpdate";
            buttonProfileUpdate.Size = new Size(307, 44);
            buttonProfileUpdate.TabIndex = 3;
            buttonProfileUpdate.Text = "Profile Update";
            buttonProfileUpdate.UseVisualStyleBackColor = false;
            buttonProfileUpdate.Click += buttonProfileUpdate_Click;
            // 
            // buttonPickupSelection
            // 
            buttonPickupSelection.Anchor = AnchorStyles.None;
            buttonPickupSelection.BackColor = Color.SteelBlue;
            buttonPickupSelection.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonPickupSelection.ForeColor = SystemColors.ControlLightLight;
            buttonPickupSelection.Location = new Point(3, 3);
            buttonPickupSelection.Name = "buttonPickupSelection";
            buttonPickupSelection.Size = new Size(306, 44);
            buttonPickupSelection.TabIndex = 1;
            buttonPickupSelection.Text = "Pickup Selection";
            buttonPickupSelection.UseVisualStyleBackColor = false;
            buttonPickupSelection.Click += buttonPickupSelection_Click;
            // 
            // panelHeader
            // 
            panelHeader.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panelHeader.BackColor = Color.SteelBlue;
            panelHeader.Controls.Add(buttonLogout);
            panelHeader.Controls.Add(labelStudent);
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
            buttonLogout.Location = new Point(839, 9);
            buttonLogout.Margin = new Padding(5);
            buttonLogout.Name = "buttonLogout";
            buttonLogout.Size = new Size(93, 38);
            buttonLogout.TabIndex = 12;
            buttonLogout.Text = "Logout";
            buttonLogout.UseVisualStyleBackColor = false;
            buttonLogout.Click += buttonLogout_Click;
            // 
            // labelStudent
            // 
            labelStudent.Anchor = AnchorStyles.None;
            labelStudent.AutoSize = true;
            labelStudent.Font = new Font("Arial Narrow", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelStudent.ForeColor = SystemColors.ControlLightLight;
            labelStudent.Location = new Point(480, 11);
            labelStudent.Margin = new Padding(5, 0, 5, 0);
            labelStudent.Name = "labelStudent";
            labelStudent.Size = new Size(97, 31);
            labelStudent.TabIndex = 11;
            labelStudent.Text = "Student";
            // 
            // labelAiubBusManagement
            // 
            labelAiubBusManagement.Anchor = AnchorStyles.None;
            labelAiubBusManagement.AutoSize = true;
            labelAiubBusManagement.Font = new Font("Arial Narrow", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelAiubBusManagement.ForeColor = SystemColors.ControlLightLight;
            labelAiubBusManagement.Location = new Point(5, 11);
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
            tableLayoutPanelMenu.ColumnCount = 3;
            tableLayoutPanelMenu.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanelMenu.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanelMenu.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanelMenu.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanelMenu.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanelMenu.Controls.Add(buttonFeePayment, 1, 0);
            tableLayoutPanelMenu.Controls.Add(buttonProfileUpdate, 2, 0);
            tableLayoutPanelMenu.Controls.Add(buttonPickupSelection, 0, 0);
            tableLayoutPanelMenu.Location = new Point(0, 59);
            tableLayoutPanelMenu.Margin = new Padding(1);
            tableLayoutPanelMenu.Name = "tableLayoutPanelMenu";
            tableLayoutPanelMenu.RowCount = 1;
            tableLayoutPanelMenu.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanelMenu.Size = new Size(937, 50);
            tableLayoutPanelMenu.TabIndex = 23;
            // 
            // panelPickupSelection
            // 
            panelPickupSelection.Controls.Add(buttonPSSavePickup);
            panelPickupSelection.Controls.Add(grpLocations);
            panelPickupSelection.Controls.Add(comboBoxPSRoute);
            panelPickupSelection.Controls.Add(labelPSRoute);
            panelPickupSelection.Controls.Add(comboBoxPSTimeSlot);
            panelPickupSelection.Controls.Add(labelPSSlot);
            panelPickupSelection.Location = new Point(0, 107);
            panelPickupSelection.Name = "panelPickupSelection";
            panelPickupSelection.Size = new Size(937, 480);
            panelPickupSelection.TabIndex = 25;
            // 
            // buttonPSSavePickup
            // 
            buttonPSSavePickup.Anchor = AnchorStyles.None;
            buttonPSSavePickup.BackColor = Color.Ivory;
            buttonPSSavePickup.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonPSSavePickup.ForeColor = SystemColors.Desktop;
            buttonPSSavePickup.Location = new Point(391, 395);
            buttonPSSavePickup.Name = "buttonPSSavePickup";
            buttonPSSavePickup.Size = new Size(131, 31);
            buttonPSSavePickup.TabIndex = 36;
            buttonPSSavePickup.Text = "Save Pickup";
            buttonPSSavePickup.UseVisualStyleBackColor = false;
            buttonPSSavePickup.Click += buttonPSSavePickup_Click;
            // 
            // grpLocations
            // 
            grpLocations.Controls.Add(radioButton1);
            grpLocations.Location = new Point(176, 68);
            grpLocations.Name = "grpLocations";
            grpLocations.Size = new Size(585, 304);
            grpLocations.TabIndex = 35;
            grpLocations.TabStop = false;
            grpLocations.Text = "Pickup Locations";
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            radioButton1.Location = new Point(18, 22);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(114, 24);
            radioButton1.TabIndex = 0;
            radioButton1.TabStop = true;
            radioButton1.Text = "radioButton1";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // comboBoxPSRoute
            // 
            comboBoxPSRoute.Anchor = AnchorStyles.None;
            comboBoxPSRoute.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            comboBoxPSRoute.FormattingEnabled = true;
            comboBoxPSRoute.Location = new Point(575, 34);
            comboBoxPSRoute.Name = "comboBoxPSRoute";
            comboBoxPSRoute.Size = new Size(186, 28);
            comboBoxPSRoute.TabIndex = 34;
            comboBoxPSRoute.Text = "Select Route";
            comboBoxPSRoute.SelectedIndexChanged += comboBoxPSRoute_SelectedIndexChanged;
            // 
            // labelPSRoute
            // 
            labelPSRoute.Anchor = AnchorStyles.None;
            labelPSRoute.AutoSize = true;
            labelPSRoute.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelPSRoute.ForeColor = SystemColors.ActiveCaptionText;
            labelPSRoute.Location = new Point(484, 35);
            labelPSRoute.Margin = new Padding(5, 0, 5, 0);
            labelPSRoute.Name = "labelPSRoute";
            labelPSRoute.Size = new Size(65, 21);
            labelPSRoute.TabIndex = 33;
            labelPSRoute.Text = "Routes:";
            // 
            // comboBoxPSTimeSlot
            // 
            comboBoxPSTimeSlot.Anchor = AnchorStyles.None;
            comboBoxPSTimeSlot.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            comboBoxPSTimeSlot.FormattingEnabled = true;
            comboBoxPSTimeSlot.Location = new Point(267, 33);
            comboBoxPSTimeSlot.Name = "comboBoxPSTimeSlot";
            comboBoxPSTimeSlot.Size = new Size(186, 28);
            comboBoxPSTimeSlot.TabIndex = 31;
            comboBoxPSTimeSlot.Text = "Select Time Slot";
            comboBoxPSTimeSlot.SelectedIndexChanged += comboBoxPSTimeSlot_SelectedIndexChanged;
            comboBoxPSTimeSlot.Format += comboBoxPSTimeSlot_Format;
            // 
            // labelPSSlot
            // 
            labelPSSlot.Anchor = AnchorStyles.None;
            labelPSSlot.AutoSize = true;
            labelPSSlot.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelPSSlot.ForeColor = SystemColors.ActiveCaptionText;
            labelPSSlot.Location = new Point(176, 34);
            labelPSSlot.Margin = new Padding(5, 0, 5, 0);
            labelPSSlot.Name = "labelPSSlot";
            labelPSSlot.Size = new Size(83, 21);
            labelPSSlot.TabIndex = 30;
            labelPSSlot.Text = "Time Slot:";
            // 
            // panelFeePayment
            // 
            panelFeePayment.Controls.Add(dgvFees);
            panelFeePayment.Controls.Add(textBoxFPAmount);
            panelFeePayment.Controls.Add(labelPayAmount);
            panelFeePayment.Controls.Add(labelFPTotalDue);
            panelFeePayment.Controls.Add(buttonFPPay);
            panelFeePayment.Location = new Point(0, 107);
            panelFeePayment.Name = "panelFeePayment";
            panelFeePayment.Size = new Size(937, 480);
            panelFeePayment.TabIndex = 37;
            // 
            // dgvFees
            // 
            dgvFees.AllowUserToAddRows = false;
            dgvFees.AllowUserToDeleteRows = false;
            dgvFees.AllowUserToResizeColumns = false;
            dgvFees.AllowUserToResizeRows = false;
            dgvFees.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvFees.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvFees.BackgroundColor = SystemColors.ControlLightLight;
            dgvFees.ClipboardCopyMode = DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            dgvFees.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvFees.Location = new Point(0, 59);
            dgvFees.MultiSelect = false;
            dgvFees.Name = "dgvFees";
            dgvFees.ReadOnly = true;
            dgvFees.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvFees.Size = new Size(932, 421);
            dgvFees.TabIndex = 39;
            // 
            // textBoxFPAmount
            // 
            textBoxFPAmount.Anchor = AnchorStyles.None;
            textBoxFPAmount.Cursor = Cursors.IBeam;
            textBoxFPAmount.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBoxFPAmount.Location = new Point(439, 15);
            textBoxFPAmount.Margin = new Padding(5);
            textBoxFPAmount.Name = "textBoxFPAmount";
            textBoxFPAmount.Size = new Size(116, 33);
            textBoxFPAmount.TabIndex = 38;
            // 
            // labelPayAmount
            // 
            labelPayAmount.Anchor = AnchorStyles.None;
            labelPayAmount.AutoSize = true;
            labelPayAmount.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelPayAmount.ForeColor = SystemColors.ActiveCaptionText;
            labelPayAmount.Location = new Point(327, 24);
            labelPayAmount.Margin = new Padding(5, 0, 5, 0);
            labelPayAmount.Name = "labelPayAmount";
            labelPayAmount.Size = new Size(102, 21);
            labelPayAmount.TabIndex = 38;
            labelPayAmount.Text = "Pay Amount:";
            // 
            // labelFPTotalDue
            // 
            labelFPTotalDue.Anchor = AnchorStyles.None;
            labelFPTotalDue.AutoSize = true;
            labelFPTotalDue.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelFPTotalDue.ForeColor = SystemColors.ActiveCaptionText;
            labelFPTotalDue.Location = new Point(141, 24);
            labelFPTotalDue.Margin = new Padding(5, 0, 5, 0);
            labelFPTotalDue.Name = "labelFPTotalDue";
            labelFPTotalDue.Size = new Size(82, 21);
            labelFPTotalDue.TabIndex = 37;
            labelFPTotalDue.Text = "Total Due:";
            // 
            // buttonFPPay
            // 
            buttonFPPay.Anchor = AnchorStyles.None;
            buttonFPPay.BackColor = Color.Ivory;
            buttonFPPay.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonFPPay.ForeColor = SystemColors.Desktop;
            buttonFPPay.Location = new Point(611, 14);
            buttonFPPay.Name = "buttonFPPay";
            buttonFPPay.Size = new Size(131, 31);
            buttonFPPay.TabIndex = 36;
            buttonFPPay.Text = "Pay";
            buttonFPPay.UseVisualStyleBackColor = false;
            buttonFPPay.Click += buttonFPPay_Click;
            // 
            // panelProfileUpdate
            // 
            panelProfileUpdate.Controls.Add(textBoxPUEmail);
            panelProfileUpdate.Controls.Add(labelPUEmail);
            panelProfileUpdate.Controls.Add(textBoxPUDepartment);
            panelProfileUpdate.Controls.Add(labelPUDepartment);
            panelProfileUpdate.Controls.Add(textBoxPUStudentID);
            panelProfileUpdate.Controls.Add(labelPUStudentId);
            panelProfileUpdate.Controls.Add(buttonPUProfileUpdate);
            panelProfileUpdate.Location = new Point(0, 107);
            panelProfileUpdate.Name = "panelProfileUpdate";
            panelProfileUpdate.Size = new Size(934, 480);
            panelProfileUpdate.TabIndex = 40;
            // 
            // textBoxPUEmail
            // 
            textBoxPUEmail.Anchor = AnchorStyles.None;
            textBoxPUEmail.Cursor = Cursors.IBeam;
            textBoxPUEmail.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBoxPUEmail.Location = new Point(433, 252);
            textBoxPUEmail.Margin = new Padding(5);
            textBoxPUEmail.Name = "textBoxPUEmail";
            textBoxPUEmail.Size = new Size(172, 33);
            textBoxPUEmail.TabIndex = 41;
            // 
            // labelPUEmail
            // 
            labelPUEmail.Anchor = AnchorStyles.None;
            labelPUEmail.AutoSize = true;
            labelPUEmail.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelPUEmail.ForeColor = SystemColors.ActiveCaptionText;
            labelPUEmail.Location = new Point(327, 255);
            labelPUEmail.Margin = new Padding(5, 0, 5, 0);
            labelPUEmail.Name = "labelPUEmail";
            labelPUEmail.Size = new Size(52, 21);
            labelPUEmail.TabIndex = 42;
            labelPUEmail.Text = "Email:";
            // 
            // textBoxPUDepartment
            // 
            textBoxPUDepartment.Anchor = AnchorStyles.None;
            textBoxPUDepartment.Cursor = Cursors.IBeam;
            textBoxPUDepartment.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBoxPUDepartment.Location = new Point(433, 169);
            textBoxPUDepartment.Margin = new Padding(5);
            textBoxPUDepartment.Name = "textBoxPUDepartment";
            textBoxPUDepartment.Size = new Size(172, 33);
            textBoxPUDepartment.TabIndex = 39;
            // 
            // labelPUDepartment
            // 
            labelPUDepartment.Anchor = AnchorStyles.None;
            labelPUDepartment.AutoSize = true;
            labelPUDepartment.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelPUDepartment.ForeColor = SystemColors.ActiveCaptionText;
            labelPUDepartment.Location = new Point(315, 170);
            labelPUDepartment.Margin = new Padding(5, 0, 5, 0);
            labelPUDepartment.Name = "labelPUDepartment";
            labelPUDepartment.Size = new Size(102, 21);
            labelPUDepartment.TabIndex = 40;
            labelPUDepartment.Text = "Department:";
            // 
            // textBoxPUStudentID
            // 
            textBoxPUStudentID.Anchor = AnchorStyles.None;
            textBoxPUStudentID.Cursor = Cursors.IBeam;
            textBoxPUStudentID.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBoxPUStudentID.Location = new Point(433, 90);
            textBoxPUStudentID.Margin = new Padding(5);
            textBoxPUStudentID.Name = "textBoxPUStudentID";
            textBoxPUStudentID.Size = new Size(172, 33);
            textBoxPUStudentID.TabIndex = 38;
            // 
            // labelPUStudentId
            // 
            labelPUStudentId.Anchor = AnchorStyles.None;
            labelPUStudentId.AutoSize = true;
            labelPUStudentId.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelPUStudentId.ForeColor = SystemColors.ActiveCaptionText;
            labelPUStudentId.Location = new Point(315, 96);
            labelPUStudentId.Margin = new Padding(5, 0, 5, 0);
            labelPUStudentId.Name = "labelPUStudentId";
            labelPUStudentId.Size = new Size(92, 21);
            labelPUStudentId.TabIndex = 38;
            labelPUStudentId.Text = "Student ID:";
            // 
            // buttonPUProfileUpdate
            // 
            buttonPUProfileUpdate.Anchor = AnchorStyles.None;
            buttonPUProfileUpdate.BackColor = Color.Ivory;
            buttonPUProfileUpdate.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonPUProfileUpdate.ForeColor = SystemColors.Desktop;
            buttonPUProfileUpdate.Location = new Point(446, 326);
            buttonPUProfileUpdate.Name = "buttonPUProfileUpdate";
            buttonPUProfileUpdate.Size = new Size(131, 31);
            buttonPUProfileUpdate.TabIndex = 36;
            buttonPUProfileUpdate.Text = "Update Profile";
            buttonPUProfileUpdate.UseVisualStyleBackColor = false;
            buttonPUProfileUpdate.Click += buttonPUProfileUpdate_Click;
            // 
            // StudentDashboardControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            Controls.Add(panelHeader);
            Controls.Add(tableLayoutPanelMenu);
            Controls.Add(panelPickupSelection);
            Controls.Add(panelProfileUpdate);
            Controls.Add(panelFeePayment);
            Name = "StudentDashboardControl";
            Size = new Size(940, 590);
            panelHeader.ResumeLayout(false);
            panelHeader.PerformLayout();
            tableLayoutPanelMenu.ResumeLayout(false);
            panelPickupSelection.ResumeLayout(false);
            panelPickupSelection.PerformLayout();
            grpLocations.ResumeLayout(false);
            grpLocations.PerformLayout();
            panelFeePayment.ResumeLayout(false);
            panelFeePayment.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvFees).EndInit();
            panelProfileUpdate.ResumeLayout(false);
            panelProfileUpdate.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Button buttonFeePayment;
        private Button buttonProfileUpdate;
        private Button buttonPickupSelection;
        private Button buttonReports;
        private Panel panelHeader;
        private Button buttonLogout;
        private Label labelStudent;
        private Label labelAiubBusManagement;
        private TableLayoutPanel tableLayoutPanelMenu;
        private Button buttonAssignBus;
        private Panel panelPickupSelection;
        private ComboBox comboBoxPSRoute;
        private Label labelPSRoute;
        private Label labelPSPickuplocation;
        private ComboBox comboBoxPSTimeSlot;
        private Label labelPSSlot;
        private GroupBox grpLocations;
        private RadioButton radioButton1;
        private Button buttonPSSavePickup;
        private Panel panelFeePayment;
        private Button buttonFPPay;
        private Label labelFPTotalDue;
        private Label labelPayAmount;
        private TextBox textBoxFPAmount;
        private DataGridView dgvFees;
        private Panel panelProfileUpdate;
        private TextBox textBoxPUStudentID;
        private Label labelPUStudentId;
        private Button buttonPUProfileUpdate;
        private TextBox textBoxPUEmail;
        private Label labelPUEmail;
        private TextBox textBoxPUDepartment;
        private Label labelPUDepartment;
    }
}

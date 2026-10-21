namespace AiubBusManagementSystem.Forms
{
    partial class RegistrationForm
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
            components = new System.ComponentModel.Container();
            panel1 = new Panel();
            comboBoxDepertment = new ComboBox();
            labelDepertment = new Label();
            labelFullname = new Label();
            textBoxFullname = new TextBox();
            labelStudentID = new Label();
            labelEmail = new Label();
            textBoxStudentID = new TextBox();
            textBoxEmail = new TextBox();
            buttonRegistration = new Button();
            labelPassword = new Label();
            labelUserName = new Label();
            textBoxPassword = new TextBox();
            textBoxUserName = new TextBox();
            label1 = new Label();
            buttonBack = new Button();
            errorProviderPassword = new ErrorProvider(components);
            errorProviderEmail = new ErrorProvider(components);
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)errorProviderPassword).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProviderEmail).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.None;
            panel1.BackColor = SystemColors.Control;
            panel1.Controls.Add(comboBoxDepertment);
            panel1.Controls.Add(labelDepertment);
            panel1.Controls.Add(labelFullname);
            panel1.Controls.Add(textBoxFullname);
            panel1.Controls.Add(labelStudentID);
            panel1.Controls.Add(labelEmail);
            panel1.Controls.Add(textBoxStudentID);
            panel1.Controls.Add(textBoxEmail);
            panel1.Controls.Add(buttonRegistration);
            panel1.Controls.Add(labelPassword);
            panel1.Controls.Add(labelUserName);
            panel1.Controls.Add(textBoxPassword);
            panel1.Controls.Add(textBoxUserName);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(230, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(455, 537);
            panel1.TabIndex = 0;
            // 
            // comboBoxDepertment
            // 
            comboBoxDepertment.Anchor = AnchorStyles.None;
            comboBoxDepertment.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            comboBoxDepertment.FormattingEnabled = true;
            comboBoxDepertment.Items.AddRange(new object[] { "CSE", "CNCS", "BDS", "EEE", "BBA", "LLB", "PHARM" });
            comboBoxDepertment.Location = new Point(48, 356);
            comboBoxDepertment.Name = "comboBoxDepertment";
            comboBoxDepertment.Size = new Size(359, 28);
            comboBoxDepertment.TabIndex = 19;
            comboBoxDepertment.Text = "Select Depertment";
            comboBoxDepertment.KeyPress += comboBoxDepertment_KeyPress;
            // 
            // labelDepertment
            // 
            labelDepertment.Anchor = AnchorStyles.None;
            labelDepertment.AutoSize = true;
            labelDepertment.Cursor = Cursors.IBeam;
            labelDepertment.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelDepertment.Location = new Point(48, 333);
            labelDepertment.Margin = new Padding(5, 0, 5, 0);
            labelDepertment.Name = "labelDepertment";
            labelDepertment.Size = new Size(102, 20);
            labelDepertment.TabIndex = 18;
            labelDepertment.Text = "Depertment: ";
            // 
            // labelFullname
            // 
            labelFullname.Anchor = AnchorStyles.None;
            labelFullname.AutoSize = true;
            labelFullname.Cursor = Cursors.IBeam;
            labelFullname.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelFullname.Location = new Point(48, 73);
            labelFullname.Margin = new Padding(5, 0, 5, 0);
            labelFullname.Name = "labelFullname";
            labelFullname.Size = new Size(84, 20);
            labelFullname.TabIndex = 16;
            labelFullname.Text = "FullName: ";
            // 
            // textBoxFullname
            // 
            textBoxFullname.Anchor = AnchorStyles.None;
            textBoxFullname.Cursor = Cursors.IBeam;
            textBoxFullname.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBoxFullname.Location = new Point(48, 98);
            textBoxFullname.Margin = new Padding(5);
            textBoxFullname.Name = "textBoxFullname";
            textBoxFullname.Size = new Size(359, 33);
            textBoxFullname.TabIndex = 0;
            textBoxFullname.KeyDown += textBoxFullname_KeyDown;
            textBoxFullname.KeyPress += textBoxFullname_KeyPress;
            // 
            // labelStudentID
            // 
            labelStudentID.Anchor = AnchorStyles.None;
            labelStudentID.AutoSize = true;
            labelStudentID.Cursor = Cursors.IBeam;
            labelStudentID.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelStudentID.Location = new Point(48, 265);
            labelStudentID.Margin = new Padding(5, 0, 5, 0);
            labelStudentID.Name = "labelStudentID";
            labelStudentID.Size = new Size(88, 20);
            labelStudentID.TabIndex = 11;
            labelStudentID.Text = "Student ID:";
            // 
            // labelEmail
            // 
            labelEmail.Anchor = AnchorStyles.None;
            labelEmail.AutoSize = true;
            labelEmail.Cursor = Cursors.IBeam;
            labelEmail.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelEmail.Location = new Point(48, 393);
            labelEmail.Margin = new Padding(5, 0, 5, 0);
            labelEmail.Name = "labelEmail";
            labelEmail.Size = new Size(51, 20);
            labelEmail.TabIndex = 10;
            labelEmail.Text = "Email:";
            // 
            // textBoxStudentID
            // 
            textBoxStudentID.Anchor = AnchorStyles.None;
            textBoxStudentID.Cursor = Cursors.IBeam;
            textBoxStudentID.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBoxStudentID.Location = new Point(48, 290);
            textBoxStudentID.Margin = new Padding(5);
            textBoxStudentID.Name = "textBoxStudentID";
            textBoxStudentID.Size = new Size(359, 33);
            textBoxStudentID.TabIndex = 13;
            textBoxStudentID.KeyDown += textBoxStudentID_KeyDown;
            textBoxStudentID.KeyPress += textBoxStudentID_KeyPress;
            textBoxStudentID.KeyUp += textBoxStudentID_KeyUp;
            // 
            // textBoxEmail
            // 
            textBoxEmail.Anchor = AnchorStyles.None;
            textBoxEmail.Cursor = Cursors.IBeam;
            textBoxEmail.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBoxEmail.Location = new Point(48, 418);
            textBoxEmail.Margin = new Padding(5);
            textBoxEmail.Name = "textBoxEmail";
            textBoxEmail.Size = new Size(359, 33);
            textBoxEmail.TabIndex = 12;
            textBoxEmail.TextChanged += textBoxEmail_TextChanged;
            textBoxEmail.KeyDown += textBoxEmail_KeyDown;
            textBoxEmail.KeyPress += textBoxEmail_KeyPress;
            textBoxEmail.KeyUp += textBoxEmail_KeyUp;
            // 
            // buttonRegistration
            // 
            buttonRegistration.BackColor = SystemColors.Info;
            buttonRegistration.BackgroundImageLayout = ImageLayout.None;
            buttonRegistration.Cursor = Cursors.Hand;
            buttonRegistration.FlatStyle = FlatStyle.Popup;
            buttonRegistration.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonRegistration.Location = new Point(168, 461);
            buttonRegistration.Margin = new Padding(5);
            buttonRegistration.Name = "buttonRegistration";
            buttonRegistration.Size = new Size(118, 38);
            buttonRegistration.TabIndex = 9;
            buttonRegistration.Text = "Register";
            buttonRegistration.UseVisualStyleBackColor = false;
            buttonRegistration.Click += buttonRegistration_Click;
            // 
            // labelPassword
            // 
            labelPassword.Anchor = AnchorStyles.None;
            labelPassword.AutoSize = true;
            labelPassword.Cursor = Cursors.IBeam;
            labelPassword.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelPassword.Location = new Point(48, 202);
            labelPassword.Margin = new Padding(5, 0, 5, 0);
            labelPassword.Name = "labelPassword";
            labelPassword.Size = new Size(84, 20);
            labelPassword.TabIndex = 6;
            labelPassword.Text = "Password: ";
            // 
            // labelUserName
            // 
            labelUserName.Anchor = AnchorStyles.None;
            labelUserName.AutoSize = true;
            labelUserName.Cursor = Cursors.IBeam;
            labelUserName.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelUserName.Location = new Point(48, 139);
            labelUserName.Margin = new Padding(5, 0, 5, 0);
            labelUserName.Name = "labelUserName";
            labelUserName.Size = new Size(91, 20);
            labelUserName.TabIndex = 5;
            labelUserName.Text = "UserName: ";
            // 
            // textBoxPassword
            // 
            textBoxPassword.Anchor = AnchorStyles.None;
            textBoxPassword.Cursor = Cursors.IBeam;
            textBoxPassword.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBoxPassword.Location = new Point(48, 227);
            textBoxPassword.Margin = new Padding(5);
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.Size = new Size(359, 33);
            textBoxPassword.TabIndex = 8;
            textBoxPassword.TextChanged += textBoxPassword_TextChanged;
            textBoxPassword.KeyDown += textBoxPassword_KeyDown;
            textBoxPassword.KeyPress += textBoxPassword_KeyPress;
            textBoxPassword.KeyUp += textBoxPassword_KeyUp;
            // 
            // textBoxUserName
            // 
            textBoxUserName.Anchor = AnchorStyles.None;
            textBoxUserName.Cursor = Cursors.IBeam;
            textBoxUserName.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBoxUserName.Location = new Point(48, 164);
            textBoxUserName.Margin = new Padding(5);
            textBoxUserName.Name = "textBoxUserName";
            textBoxUserName.Size = new Size(359, 33);
            textBoxUserName.TabIndex = 7;
            textBoxUserName.KeyDown += textBoxUserName_KeyDown;
            textBoxUserName.KeyPress += textBoxUserName_KeyPress;
            textBoxUserName.KeyUp += textBoxUserName_KeyUp;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(81, 5);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new Size(271, 32);
            label1.TabIndex = 1;
            label1.Text = "Enter Your Informations";
            // 
            // buttonBack
            // 
            buttonBack.BackColor = SystemColors.Info;
            buttonBack.BackgroundImageLayout = ImageLayout.None;
            buttonBack.Cursor = Cursors.Hand;
            buttonBack.FlatStyle = FlatStyle.Popup;
            buttonBack.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonBack.Location = new Point(810, 17);
            buttonBack.Margin = new Padding(5);
            buttonBack.Name = "buttonBack";
            buttonBack.Size = new Size(93, 38);
            buttonBack.TabIndex = 10;
            buttonBack.Text = "Back";
            buttonBack.UseVisualStyleBackColor = false;
            buttonBack.Click += buttonBack_Click;
            // 
            // errorProviderPassword
            // 
            errorProviderPassword.BlinkRate = 350;
            errorProviderPassword.BlinkStyle = ErrorBlinkStyle.AlwaysBlink;
            errorProviderPassword.ContainerControl = this;
            // 
            // errorProviderEmail
            // 
            errorProviderEmail.BlinkRate = 350;
            errorProviderEmail.BlinkStyle = ErrorBlinkStyle.AlwaysBlink;
            errorProviderEmail.ContainerControl = this;
            // 
            // RegistrationForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(934, 561);
            Controls.Add(buttonBack);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "RegistrationForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "RegistrationPage";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)errorProviderPassword).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProviderEmail).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Label labelPassword;
        private Label labelUserName;
        private TextBox textBoxPassword;
        private TextBox textBoxUserName;
        private Button buttonRegistration;
        private Button buttonBack;
        private Label labelStudentID;
        private Label labelEmail;
        private TextBox textBoxStudentID;
        private TextBox textBoxEmail;
        private Label labelFullname;
        private TextBox textBoxFullname;
        private ComboBox comboBoxDepertment;
        private Label labelDepertment;
        private ErrorProvider errorProviderPassword;
        private ErrorProvider errorProviderEmail;
    }
}
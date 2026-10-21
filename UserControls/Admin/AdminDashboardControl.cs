using AiubBusManagementSystem.Services;
using AiubBusManagementSystem.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace AiubBusManagementSystem.UserControls.Admin
{
    public partial class AdminDashboardControl : UserControl
    {
        private Button? activeMenuButton;
        private static readonly Color MenuNormalColor = Color.SteelBlue;
        private static readonly Color MenuActiveColor = Color.DodgerBlue;


        private readonly AdminService adminService = new AdminService();
        public AdminDashboardControl()
        {
            InitializeComponent();
            InitializeDashboard();
        }

        // ================= INITIALIZATION =================

        private void InitializeDashboard()
        {
            HideAllContentPanels();
            SetActiveMenuButton(buttonManageRoutes);
            ShowPanel(panelManageRoutes); // default panel
            LoadRoutes();
        }

        // ================= PANEL MANAGEMENT =================

        private void HideAllContentPanels()
        {
            if (panelManageRoutes != null) panelManageRoutes.Visible = false;
            if (panelManageStudents != null) panelManageStudents.Visible = false;
            if (panelManageDriver != null) panelManageDriver.Visible = false;
            if (panelAssignBus != null) panelAssignBus.Visible = false;
            if (panelReports != null) panelReports.Visible = false;
        }

        private void ShowPanel(Panel panel)
        {
            if (panel == null) return;

            HideAllContentPanels();
            panel.Visible = true;
        }

        // ================= MENU BUTTON EVENTS =================

        private void buttonManageRoutes_Click(object sender, EventArgs e)
        {
            SetActiveMenuButton(sender as Button);
            ShowPanel(panelManageRoutes);
            LoadRoutes();
        }

        private void buttonManageStudent_Click(object sender, EventArgs e)
        {
            SetActiveMenuButton(sender as Button);
            ShowPanel(panelManageStudents);
            LoadStudents();
        }

        private void buttonManageDriver_Click(object sender, EventArgs e)
        {
            SetActiveMenuButton(sender as Button);
            ShowPanel(panelManageDriver);
            LoadDrivers();
        }

        private void buttonAssignBus_Click(object sender, EventArgs e)
        {
            SetActiveMenuButton(sender as Button);
            ShowPanel(panelAssignBus);

            InitializeAssignBusPanel();
        }

        private void buttonReports_Click(object sender, EventArgs e)
        {
            SetActiveMenuButton(sender as Button);
            ShowPanel(panelReports);
            LoadReports();
        }


        private void SetActiveMenuButton(Button? button)
        {
            if (activeMenuButton != null)
            {
                activeMenuButton.BackColor = MenuNormalColor;
            }

            activeMenuButton = button;

            if (activeMenuButton != null)
            {
                activeMenuButton.BackColor = MenuActiveColor;
            }
        }

        // ================= CONTENT PANEL EVENTS =================


        // Manage Routes PANEL EVENTS
        private void textBoxMRRouteName_Enter(object sender, EventArgs e)
        {
            if (textBoxMRRouteName.Text == "Route Name")
            {
                textBoxMRRouteName.Text = "";
                textBoxMRRouteName.ForeColor = Color.Black;
            }
        }

        private void textBoxMRLocationName_Enter(object sender, EventArgs e)
        {
            if (textBoxMRLocationName.Text == "Location Name")
            {
                textBoxMRLocationName.Text = "";
                textBoxMRLocationName.ForeColor = Color.Black;
            }
        }
        private void buttonMRCreateRoute_Click(object sender, EventArgs e)
        {
            string routeName = textBoxMRRouteName.Text.Trim();
            string? direction = comboBoxMRDirection.SelectedItem?.ToString();

            if (string.IsNullOrWhiteSpace(routeName) || routeName == "Route Name")
            {
                MessageBox.Show("Please enter a route name.");
                return;
            }

            if (string.IsNullOrWhiteSpace(direction) || direction == "Select Direction")
            {
                MessageBox.Show("Please select a direction.");
                return;
            }

            adminService.CreateRoute(routeName, direction);
            LoadRoutes();

            textBoxMRRouteName.Text = "Route Name";
            textBoxMRRouteName.ForeColor = Color.Gray;
            comboBoxMRDirection.SelectedIndex = -1;
            comboBoxMRDirection.Text = "Select Direction";
        }

        private void buttonMRAddLocation_Click(object sender, EventArgs e)
        {
            if (dgvMRRoutes.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a route first.");
                return;
            }

            string locationName = textBoxMRLocationName.Text.Trim();
            if (string.IsNullOrWhiteSpace(locationName) || locationName == "Location Name")
            {
                MessageBox.Show("Please enter a location name.");
                return;
            }

            object idValue = dgvMRRoutes.SelectedRows[0].Cells["Id"].Value;
            if (idValue == null || !int.TryParse(idValue.ToString(), out int selectedRouteId))
            {
                MessageBox.Show("Invalid selected route.");
                return;
            }

            adminService.AddLocationToRoute(selectedRouteId, locationName);
            LoadLocations(selectedRouteId);

            textBoxMRLocationName.Text = "Location Name";
            textBoxMRLocationName.ForeColor = Color.Gray;
        }

        private void LoadRoutes()
        {
            dgvMRRoutes.AutoGenerateColumns = true;
            dgvMRRoutes.DataSource = null;
            dgvMRRoutes.DataSource = adminService.GetAllRoutes();


            if (dgvMRRoutes.SelectedRows.Count == 0) return;

            int routeId = Convert.ToInt32(
                dgvMRRoutes.SelectedRows[0].Cells["Id"].Value
            );

            LoadLocations(routeId);
        }

        private void dgvMRRoutes_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvMRRoutes.SelectedRows.Count == 0) return;

            int routeId = Convert.ToInt32(
                dgvMRRoutes.SelectedRows[0].Cells["Id"].Value
            );

            LoadLocations(routeId);
        }

        private void LoadLocations(int routeId)
        {
            dgvMRLocations.AutoGenerateColumns = true;
            dgvMRLocations.DataSource = null;
            dgvMRLocations.DataSource = adminService.GetLocationsByRoute(routeId);
        }

        // Manage Student PANEL EVENTS

        private void buttonMSSearch_Click(object sender, EventArgs e)
        {
            string keyword = textBoxMSUsername.Text.Trim();

            dgvManageStudents.AutoGenerateColumns = true;
            dgvManageStudents.DataSource = null;

            dgvManageStudents.DataSource = adminService.GetAllStudents(keyword);
        }


        private void LoadStudents()
        {
            dgvManageStudents.AutoGenerateColumns = true;
            dgvManageStudents.DataSource = null;
            dgvManageStudents.DataSource = adminService.GetAllStudents();
        }

        private void buttonMSActive_Click(object sender, EventArgs e)
        {
            if (dgvManageStudents.CurrentRow == null)
            {
                MessageBox.Show("Please select a student.");
                return;
            }

            object userIdValue = dgvManageStudents.CurrentRow.Cells["Id"].Value;

            if (userIdValue == null || !int.TryParse(userIdValue.ToString(), out int userId))
            {
                MessageBox.Show("Invalid selected student.");
                return;
            }

            DialogResult confirm = MessageBox.Show(
                "Mark this student as Active?",
                "Confirm",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (confirm != DialogResult.Yes)
            {
                return;
            }

            adminService.ActivateStudent(userId);
            LoadStudents();
        }

        private void buttonMSBlock_Click(object sender, EventArgs e)
        {
            if (dgvManageStudents.CurrentRow == null)
            {
                MessageBox.Show("Please select a student.");
                return;
            }

            object userIdValue = dgvManageStudents.CurrentRow.Cells["Id"].Value;

            if (userIdValue == null || !int.TryParse(userIdValue.ToString(), out int userId))
            {
                MessageBox.Show("Invalid selected student.");
                return;
            }

            DialogResult confirm = MessageBox.Show(
                "Block this student?",
                "Confirm",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (confirm != DialogResult.Yes)
            {
                return;
            }

            adminService.BlockStudent(userId);
            LoadStudents();
        }


        // Manage Drivers PANEL EVENTS

        private void buttonMDAddDriver_Click(object sender, EventArgs e)
        {
            // Required fields check
            if (string.IsNullOrWhiteSpace(textBoxMDFullname.Text) ||
                string.IsNullOrWhiteSpace(textBoxMDUsername.Text) ||
                string.IsNullOrWhiteSpace(textBoxMDPassword.Text) ||
                string.IsNullOrWhiteSpace(textBoxMDLicenceNum.Text) ||
                string.IsNullOrWhiteSpace(textBoxMDMobile.Text) ||
                textBoxMDFullname.Text == "Full Name" ||
                textBoxMDUsername.Text == "Username" ||
                textBoxMDPassword.Text == "Password" ||
                textBoxMDLicenceNum.Text == "Licence No..." ||
                textBoxMDMobile.Text == "Mobile No..."
                )
            {
                MessageBox.Show("All fields must be filled with valid data.", "Validation",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            try
            {
                adminService.CreateDriver(
                    textBoxMDFullname.Text,
                    textBoxMDUsername.Text,
                    textBoxMDPassword.Text,
                    textBoxMDLicenceNum.Text,
                    textBoxMDMobile.Text

                );

                textBoxMDFullname.Text = "Full Name";
                textBoxMDFullname.ForeColor = Color.Gray;
                textBoxMDUsername.Text = "Username";
                textBoxMDUsername.ForeColor = Color.Gray;
                textBoxMDPassword.Text = "Password";
                textBoxMDPassword.ForeColor = Color.Gray;
                textBoxMDLicenceNum.Text = "Licence No...";
                textBoxMDLicenceNum.ForeColor = Color.Gray;
                textBoxMDMobile.Text = "Mobile No...";
                textBoxMDMobile.ForeColor = Color.Gray;

                LoadDrivers();
                MessageBox.Show("Drivers account created successfully.", "Success",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void LoadDrivers()
        {
            dgvManageDriver.AutoGenerateColumns = true;
            dgvManageDriver.DataSource = null;
            dgvManageDriver.DataSource = adminService.GetAllDrivers();
        }

        private void buttonMDRemove_Click(object sender, EventArgs e)
        {
            if (dgvManageDriver.CurrentRow == null)
            {
                MessageBox.Show("Please select a driver.");
                return;
            }

            object userIdValue = dgvManageDriver.CurrentRow.Cells["Id"].Value;

            if (userIdValue == null || !int.TryParse(userIdValue.ToString(), out int userId))
            {
                MessageBox.Show("Invalid selected Driver.");
                return;
            }

            DialogResult confirm = MessageBox.Show(
                "This will permanently delete the drivers account from the database. Continue?",
                "Confirm delete",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (confirm != DialogResult.Yes)
            {
                return;
            }

            try
            {
                adminService.RemoveDriver(userId);
                LoadDrivers();
                MessageBox.Show("Driver deleted successfully.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void textBoxMDFullname_Enter(object sender, EventArgs e)
        {
            if (textBoxMDFullname.Text == "Full Name")
            {
                textBoxMDFullname.Text = "";
                textBoxMDFullname.ForeColor = Color.Black;
            }
        }

        private void textBoxMDUsername_Enter(object sender, EventArgs e)
        {
            if (textBoxMDUsername.Text == "Username")
            {
                textBoxMDUsername.Text = "";
                textBoxMDUsername.ForeColor = Color.Black;
            }
        }

        private void textBoxMDPassword_Enter(object sender, EventArgs e)
        {
            if (textBoxMDPassword.Text == "Password")
            {
                textBoxMDPassword.Text = "";
                textBoxMDPassword.ForeColor = Color.Black;
            }
        }

        private void textBoxMDLicenceNum_Enter(object sender, EventArgs e)
        {
            if (textBoxMDLicenceNum.Text == "Licence No...")
            {
                textBoxMDLicenceNum.Text = "";
                textBoxMDLicenceNum.ForeColor = Color.Black;
            }
        }

        private void textBoxMDMobile_Enter(object sender, EventArgs e)
        {
            if (textBoxMDMobile.Text == "Mobile No...")
            {
                textBoxMDMobile.Text = "";
                textBoxMDMobile.ForeColor = Color.Black;
            }
        }






        // Assign bus panel events

        private void InitializeAssignBusPanel()
        {
           
            List<Models.Route> routes = adminService.GetAllRoutes();
            comboBoxABRoute.DisplayMember = "RouteName";
            comboBoxABRoute.ValueMember = "Id";
            comboBoxABRoute.DataSource = routes;

            
            DataTable drivers = adminService.GetActiveDriversForAssignment();
            comboBoxABDriver.DisplayMember = "Name";
            comboBoxABDriver.ValueMember = "Id";
            comboBoxABDriver.DataSource = drivers;

            
            List<Models.TimeSlot> slots = adminService.GetAllTimeSlots();

            comboBoxABTimeSlot.Format -= comboBoxABTimeSlot_Format;
            comboBoxABTimeSlot.Format += comboBoxABTimeSlot_Format;

            comboBoxABTimeSlot.DisplayMember = nameof(Models.TimeSlot.Id);
            comboBoxABTimeSlot.ValueMember = nameof(Models.TimeSlot.Id);
            comboBoxABTimeSlot.DataSource = slots;

            LoadAssignmentsForPresentDay();
        }

        private void comboBoxABTimeSlot_Format(object? sender, ListControlConvertEventArgs e)
        {
            if (e.ListItem is Models.TimeSlot slot)
            {
                e.Value = $"{slot.StartTime:hh\\:mm} - {slot.EndTime:hh\\:mm}";
            }
        }

        private void LoadAssignmentsForPresentDay()
        {
            dateTimePickerAssignBus.Value = DateTime.Today;

            dgvAssignBus.AutoGenerateColumns = true;
            dgvAssignBus.DataSource = null;
            dgvAssignBus.DataSource = adminService.GetAssignmentsByDateWithDetails(DateTime.Today);

            if (dgvAssignBus.Columns.Contains("Id"))
            {
                dgvAssignBus.Columns["Id"].Visible = false;
            }

            if (dgvAssignBus.Columns.Contains("Date"))
            {
                dgvAssignBus.Columns["Date"].DefaultCellStyle.Format = "yyyy-MM-dd";
            }
        }

        private void buttonABAssign_Click(object sender, EventArgs e)
        {
            if (comboBoxABRoute.SelectedValue == null ||
                comboBoxABDriver.SelectedValue == null ||
                comboBoxABTimeSlot.SelectedValue == null)
            {
                MessageBox.Show("Please select Route, Driver, and Time Slot.");
                return;
            }

            if (!int.TryParse(comboBoxABRoute.SelectedValue.ToString(), out int routeId) ||
                !int.TryParse(comboBoxABDriver.SelectedValue.ToString(), out int driverId) ||
                !int.TryParse(comboBoxABTimeSlot.SelectedValue.ToString(), out int timeSlotId))
            {
                MessageBox.Show("Invalid selections.");
                return;
            }

            try
            {
                adminService.AssignBus(routeId, driverId, timeSlotId, dateTimePickerAssignBus.Value);
                LoadAssignmentsForPresentDay();
                MessageBox.Show("Bus assigned successfully.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }




        // REPORTS PANEL EVENTS

        private void LoadReports()
        {
            dgvReport.AutoGenerateColumns = true;
            dgvReport.DataSource = null;
            dgvReport.DataSource = adminService.GetReport();

            decimal total = adminService.GetTotalCollectedFees();
            labelRTotalCollectedAmount.Text = $"Total Collected Amount: {total:0.00}";
        }

        private void buttonRRefresh_Click(object sender, EventArgs e)
        {
            LoadReports();
        }

        // ================= HEADER EVENTS =================

        private void buttonLogout_Click(object sender, EventArgs e)
        {
            SessionManager.EndSession();
            Application.Restart();
        }

        
    }
}

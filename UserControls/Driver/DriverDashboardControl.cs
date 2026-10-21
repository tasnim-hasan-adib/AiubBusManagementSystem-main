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

namespace AiubBusManagementSystem.UserControls.Driver
{
    public partial class DriverDashboardControl : UserControl
    {
        private Button? activeMenuButton;
        private static readonly Color MenuNormalColor = Color.SteelBlue;
        private static readonly Color MenuActiveColor = Color.DodgerBlue;


        private readonly AdminService adminService = new AdminService();
        private readonly DriverService driverService = new DriverService();

        public DriverDashboardControl()
        {
            InitializeComponent();
            InitializeDashboard();
        }




        // ================= INITIALIZATION =================

        private void InitializeDashboard()
        {
            HideAllContentPanels();
            SetActiveMenuButton(buttonViewAssignedRoutes);
            ShowPanel(panelViewAssignedRoutes); // default panel
            LoadRoutes();
        }

        // ================= PANEL MANAGEMENT =================

        private void HideAllContentPanels()
        {
            if (panelViewAssignedRoutes != null) panelViewAssignedRoutes.Visible = false;
            if (panelConfirmPickups != null) panelConfirmPickups.Visible = false;
        }

        private void ShowPanel(Panel panel)
        {
            if (panel == null) return;

            HideAllContentPanels();
            panel.Visible = true;
        }

        // ================= MENU BUTTON EVENTS =================


        private void buttonViewAssignedRoutes_Click(object sender, EventArgs e)
        {
            SetActiveMenuButton(sender as Button);
            ShowPanel(panelViewAssignedRoutes);
            LoadRoutes();
        }

        private void buttonManagePickupConfirmation_Click(object sender, EventArgs e)
        {
            SetActiveMenuButton(sender as Button);
            ShowPanel(panelConfirmPickups);
            InitializeAssignBusPanel();
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


        // view routes PANEL EVENTS

        private void buttonVARRefresh_Click(object sender, EventArgs e)
        {
            LoadRoutes();
        }
        private void LoadRoutes()
        {
            dgvVARRoutes.AutoGenerateColumns = true;
            dgvVARRoutes.DataSource = null;
            dgvVARRoutes.DataSource = driverService.GetAllRoutesByDriverId(SessionManager.CurrentUser.Id);

            if (dgvVARRoutes.Columns.Contains("RouteId"))
            {
                dgvVARRoutes.Columns["RouteId"].Visible = false;
            }

            if (dgvVARRoutes.SelectedRows.Count == 0) return;

            int routeId = Convert.ToInt32(
                dgvVARRoutes.SelectedRows[0].Cells["RouteId"].Value
            );

            LoadLocations(routeId);
        }



        private void dgvVARRoutes_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvVARRoutes.SelectedRows.Count == 0) return;

            int routeId = Convert.ToInt32(
                dgvVARRoutes.SelectedRows[0].Cells["RouteId"].Value
            );

            LoadLocations(routeId);
        }

        private void LoadLocations(int routeId)
        {
            dgvVARLocations.AutoGenerateColumns = true;
            dgvVARLocations.DataSource = null;
            dgvVARLocations.DataSource = driverService.GetLocationsByRoute(routeId);
        }

        // confirm pickup PANEL EVENTS

        private void InitializeAssignBusPanel()
        {
            List<Models.TimeSlot> slots = driverService.GetAllTimeSlotsByDriverId(SessionManager.CurrentUser.Id);

            comboBoxCPTimeSlot.Format -= comboBoxCPTimeSlot_Format;
            comboBoxCPTimeSlot.Format += comboBoxCPTimeSlot_Format;

            comboBoxCPTimeSlot.DisplayMember = nameof(Models.TimeSlot.Id);
            comboBoxCPTimeSlot.ValueMember = nameof(Models.TimeSlot.Id);
            comboBoxCPTimeSlot.DataSource = slots;

            if (comboBoxCPTimeSlot.Items.Count > 0)
            {
                comboBoxCPTimeSlot.SelectedIndex = 0;
            }

            LoadRouteLocationsForTimeSlot();
        }

        private void comboBoxCPTimeSlot_Format(object sender, ListControlConvertEventArgs e)
        {
            if (e.ListItem is Models.TimeSlot slot)
            {
                e.Value = $"{slot.StartTime:hh\\:mm} - {slot.EndTime:hh\\:mm}";
            }
        }
        private void comboBoxCPTimeSlot_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadRouteLocationsForTimeSlot();
        }
        private void LoadRouteLocationsForTimeSlot()
        {
            if (comboBoxCPTimeSlot.SelectedValue == null ||
                !int.TryParse(comboBoxCPTimeSlot.SelectedValue.ToString(), out int timeSlotId))
            {
                dgvCpLocationAndCounts.DataSource = null;
                dgvCPViewConfirmStudent.DataSource = null;
                return;
            }

            dgvCpLocationAndCounts.AutoGenerateColumns = true;
            dgvCpLocationAndCounts.DataSource = null;
            dgvCpLocationAndCounts.DataSource = driverService.GetLocationCountsForToday(timeSlotId);

            if (dgvCpLocationAndCounts.Columns.Contains("LocationId"))
            {
                dgvCpLocationAndCounts.Columns["LocationId"].Visible = false;
            }

            dgvCPViewConfirmStudent.DataSource = null;
        }

        private void dgvCpLocationAndCounts_SelectionChanged_1(object sender, EventArgs e)
        {
            if (comboBoxCPTimeSlot.SelectedValue == null ||
                !int.TryParse(comboBoxCPTimeSlot.SelectedValue.ToString(), out int timeSlotId))
            {
                return;
            }

            if (dgvCpLocationAndCounts.SelectedRows.Count == 0) return;

            object locationIdValue = dgvCpLocationAndCounts.SelectedRows[0].Cells["LocationId"].Value;
            if (locationIdValue == null || !int.TryParse(locationIdValue.ToString(), out int locationId))
            {
                return;
            }

            dgvCPViewConfirmStudent.AutoGenerateColumns = true;
            dgvCPViewConfirmStudent.DataSource = null;
            dgvCPViewConfirmStudent.DataSource = driverService.GetStudentsForLocationToday(locationId, timeSlotId);

            if (dgvCPViewConfirmStudent.Columns.Contains("StudentUserId"))
            {
                dgvCPViewConfirmStudent.Columns["StudentUserId"].Visible = false;
            }

            if (dgvCPViewConfirmStudent.Columns.Contains("TravelLogId"))
            {
                dgvCPViewConfirmStudent.Columns["TravelLogId"].Visible = false;
            }
        }


        private void buttonCPConfirm_Click_1(object sender, EventArgs e)
        {
            if (dgvCPViewConfirmStudent.CurrentRow == null)
            {
                MessageBox.Show("Please select a student.");
                return;
            }

            object studentIdValue = dgvCPViewConfirmStudent.CurrentRow.Cells["StudentUserId"].Value;
            if (studentIdValue == null || !int.TryParse(studentIdValue.ToString(), out int studentId))
            {
                MessageBox.Show("Invalid selected student.");
                return;
            }

            if (comboBoxCPTimeSlot.SelectedValue == null ||
                !int.TryParse(comboBoxCPTimeSlot.SelectedValue.ToString(), out int timeSlotId))
            {
                MessageBox.Show("Please select a time slot.");
                return;
            }

            try
            {
                int assignmentId = driverService.GetTodayAssignmentIdByTimeSlot(timeSlotId);

                driverService.ConfirmPickup(studentId, assignmentId);

                // Refresh student list for the currently selected location
                dgvCpLocationAndCounts_SelectionChanged_1(sender, e);

                MessageBox.Show("Pickup confirmed.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        // ================= HEADER EVENTS =================

        private void buttonLogout_Click_1(object sender, EventArgs e)
        {
            SessionManager.EndSession();
            Application.Restart();
        }

        
    }
}

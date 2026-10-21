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

namespace AiubBusManagementSystem.UserControls.Student
{
    public partial class StudentDashboardControl : UserControl
    {
        private Button? activeMenuButton;
        private static readonly Color MenuNormalColor = Color.SteelBlue;
        private static readonly Color MenuActiveColor = Color.DodgerBlue;


        private readonly AdminService adminService = new AdminService();
        private readonly StudentService studentService = new StudentService();
        public StudentDashboardControl()
        {
            InitializeComponent();
            InitializeDashboard();
        }



        // ================= INITIALIZATION =================

        private void InitializeDashboard()
        {
            HideAllContentPanels();
            SetActiveMenuButton(buttonPickupSelection);
            ShowPanel(panelPickupSelection); // default panel
            InitializePickupSelection();
        }

        // ================= PANEL MANAGEMENT =================

        private void HideAllContentPanels()
        {
            if (panelPickupSelection != null) panelPickupSelection.Visible = false;
            if (panelFeePayment != null) panelFeePayment.Visible = false;
            if (panelProfileUpdate != null) panelProfileUpdate.Visible = false;
        }

        private void ShowPanel(Panel panel)
        {
            if (panel == null) return;

            HideAllContentPanels();
            panel.Visible = true;
        }

        // ================= MENU BUTTON EVENTS =================

        private void buttonFeePayment_Click(object sender, EventArgs e)
        {
            SetActiveMenuButton(sender as Button);
            ShowPanel(panelFeePayment);
            LoadFees();
        }

        private void buttonPickupSelection_Click(object sender, EventArgs e)
        {
            SetActiveMenuButton(sender as Button);
            ShowPanel(panelPickupSelection);
            InitializePickupSelection();
        }

        private void buttonProfileUpdate_Click(object sender, EventArgs e)
        {
            SetActiveMenuButton(sender as Button);
            ShowPanel(panelProfileUpdate);
            InitializePanelProfileUpdate();
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









        //  pickup selection PANEL EVENTS

        private void InitializePickupSelection()
        {
            List<Models.TimeSlot> slots = adminService.GetAllTimeSlots();

            comboBoxPSTimeSlot.FormattingEnabled = true;
            comboBoxPSTimeSlot.Format -= comboBoxPSTimeSlot_Format;
            comboBoxPSTimeSlot.Format += comboBoxPSTimeSlot_Format;

            comboBoxPSTimeSlot.DisplayMember = nameof(Models.TimeSlot.Id);
            comboBoxPSTimeSlot.ValueMember = nameof(Models.TimeSlot.Id);
            comboBoxPSTimeSlot.DataSource = slots;

            if (comboBoxPSTimeSlot.Items.Count > 0)
            {
                comboBoxPSTimeSlot.SelectedIndex = 0;
            }

            LoadRoutesForSelectedTimeSlot();
        }

        private void comboBoxPSTimeSlot_Format(object sender, ListControlConvertEventArgs e)
        {
            if (e.ListItem is Models.TimeSlot slot)
            {
                e.Value = $"{slot.StartTime:hh\\:mm} - {slot.EndTime:hh\\:mm}";
            }
        }



        // ================= HEADER EVENTS =================



        private void comboBoxPSTimeSlot_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadRoutesForSelectedTimeSlot();
        }

        private void LoadRoutesForSelectedTimeSlot()
        {
            if (comboBoxPSTimeSlot.SelectedValue == null ||
                !int.TryParse(comboBoxPSTimeSlot.SelectedValue.ToString(), out int timeSlotId))
            {
                comboBoxPSRoute.DataSource = null;
                grpLocations.Controls.Clear();
                return;
            }

            DataTable routes = studentService.GetAvailableRoutesForTimeSlotToday(timeSlotId);

            comboBoxPSRoute.DisplayMember = "RouteName";
            comboBoxPSRoute.ValueMember = "RouteId";
            comboBoxPSRoute.DataSource = routes;

            grpLocations.Controls.Clear();
        }

        private void comboBoxPSRoute_SelectedIndexChanged(object sender, EventArgs e)
        {
            grpLocations.Controls.Clear();

            if (comboBoxPSRoute.SelectedValue == null ||
                !int.TryParse(comboBoxPSRoute.SelectedValue.ToString(), out int routeId))
            {
                return;
            }

            List<Models.RouteLocation> locations = adminService.GetLocationsByRoute(routeId);
            if (locations.Count == 0)
            {
                return;
            }

            int top = 25;
            foreach (Models.RouteLocation loc in locations)
            {
                RadioButton rb = new RadioButton
                {
                    AutoSize = true,
                    Left = 15,
                    Top = top,
                    Text = loc.LocationName,
                    Tag = new LocationRadioItem { LocationId = loc.Id }
                };

                grpLocations.Controls.Add(rb);
                top += 28;
            }

            // select first by default
            if (grpLocations.Controls.OfType<RadioButton>().FirstOrDefault() is RadioButton first)
            {
                first.Checked = true;
            }
        }

        private void buttonPSSavePickup_Click(object sender, EventArgs e)
        {
            if (comboBoxPSTimeSlot.SelectedValue == null ||
                !int.TryParse(comboBoxPSTimeSlot.SelectedValue.ToString(), out int timeSlotId))
            {
                MessageBox.Show("Please select a time slot.");
                return;
            }

            RadioButton? selected = grpLocations.Controls
                .OfType<RadioButton>()
                .FirstOrDefault(r => r.Checked);

            if (selected?.Tag is not LocationRadioItem item)
            {
                MessageBox.Show("Please select a location.");
                return;
            }

            try
            {
                studentService.SavePickupSelection(item.LocationId, timeSlotId);
                MessageBox.Show("Pickup saved successfully.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private sealed class LocationRadioItem
        {
            public required int LocationId { get; init; }
        }

        private void buttonLogout_Click(object sender, EventArgs e)
        {
            SessionManager.EndSession();
            Application.Restart();
        }



        private void buttonFPPay_Click(object sender, EventArgs e)
        {
            decimal totalDue = studentService.GetMyTotalDueAmount();

            if (totalDue <= 0)
            {
                MessageBox.Show("No due fees to pay.");
                return;
            }

            if (!decimal.TryParse(textBoxFPAmount.Text.Trim(), out decimal inputAmount))
            {
                MessageBox.Show("Please enter a valid amount.");
                return;
            }

            // STRICT RULE: must match exactly
            if (inputAmount != totalDue)
            {
                MessageBox.Show($"Payment must be exactly {totalDue:0.00}. No partial/extra payment allowed.");
                return;
            }

            try
            {
                bool ok = studentService.PayFees(inputAmount);
                if (!ok)
                {
                    MessageBox.Show("Payment amount mismatch.");
                    return;
                }

                textBoxFPAmount.Text = string.Empty;

                LoadFees();
                MessageBox.Show("Payment successful.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void LoadFees()
        {
            dgvFees.AutoGenerateColumns = true;
            dgvFees.DataSource = null;
            dgvFees.DataSource = studentService.GetMyDueFeesTable();

            if (dgvFees.Columns.Contains("Date"))
            {
                dgvFees.Columns["Date"].DefaultCellStyle.Format = "yyyy-MM-dd";
            }

            decimal totalDue = studentService.GetMyTotalDueAmount();
            labelFPTotalDue.Text = $"Total Due: {totalDue:0.00}";
        }

        private void buttonPUProfileUpdate_Click(object sender, EventArgs e)
        {
            string studentId = textBoxPUStudentID.Text.Trim();
            string department = textBoxPUDepartment.Text.Trim();
            string email = textBoxPUEmail.Text.Trim();

            if (textBoxPUStudentID.ForeColor == Color.Gray) studentId = string.Empty;
            if (textBoxPUDepartment.ForeColor == Color.Gray) department = string.Empty;
            if (textBoxPUEmail.ForeColor == Color.Gray) email = string.Empty;

            if (string.IsNullOrWhiteSpace(studentId) ||
                string.IsNullOrWhiteSpace(department) ||
                string.IsNullOrWhiteSpace(email))
            {
                MessageBox.Show("Please fill Student ID, Department and Email.");
                return;
            }

            try
            {
                studentService.UpdateProfile(studentId, department, email);
                MessageBox.Show("Profile updated successfully.");
                InitializePanelProfileUpdate();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void InitializePanelProfileUpdate()
        {
            try
            {
                Models.StudentProfile profile = studentService.GetMyProfile();

                SetProfileTextBox(textBoxPUStudentID, profile.StudentId, "Student ID");
                SetProfileTextBox(textBoxPUDepartment, profile.Department, "Department");
                SetProfileTextBox(textBoxPUEmail, profile.Email, "Email");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private static void SetProfileTextBox(TextBox textBox, string? value, string placeholder)
        {
            string text = string.IsNullOrWhiteSpace(value) ? placeholder : value;

            textBox.Text = text;
            textBox.ForeColor = (text == placeholder) ? Color.Gray : Color.Black;

            textBox.Enter -= ProfileTextBox_Enter;
            textBox.Enter += ProfileTextBox_Enter;
        }
       
        private static void ProfileTextBox_Enter(object? sender, EventArgs e)
        {
            if (sender is not TextBox tb) return;

            if (tb.ForeColor == Color.Gray)
            {
                tb.Text = string.Empty;
                tb.ForeColor = Color.Black;
            }
        }
    }
}

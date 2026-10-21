using AiubBusManagementSystem.UserControls.Admin;
using AiubBusManagementSystem.UserControls.Driver;
using AiubBusManagementSystem.UserControls.Student;
using AiubBusManagementSystem.Utils;
using System;
using System.Windows.Forms;

namespace AiubBusManagementSystem.Forms
{
    public partial class MainDashboardForm : Form
    {
        public MainDashboardForm()
        {
            InitializeComponent();
        }

        private void MainDashboardForm_Load(object sender, EventArgs e)
        {
            LoadRoleDashboard();
        }

        private void LoadRoleDashboard()
        {
            if (!SessionManager.IsLoggedIn())
            {
                MessageBox.Show("Session expired. Please login again.");
                Application.Restart();
                return;
            }

            string role = (SessionManager.CurrentUser.Role ?? string.Empty).Trim();

            UserControl dashboard = role.ToUpperInvariant() switch
            {
                "ADMIN" => new AdminDashboardControl(),
                "DRIVER" => new DriverDashboardControl(),
                "STUDENT" => new StudentDashboardControl(),
                _ => null
            };

            if (dashboard == null)
            {
                MessageBox.Show($"Unauthorized role: '{role}'.");
                Application.Exit();
                return;
            }

            LoadDashboard(dashboard);
        }

        private void LoadDashboard(UserControl dashboard)
        {
            panelDashboardHost.Controls.Clear();
            dashboard.Dock = DockStyle.Fill;
            panelDashboardHost.Controls.Add(dashboard);
        }
    }
}

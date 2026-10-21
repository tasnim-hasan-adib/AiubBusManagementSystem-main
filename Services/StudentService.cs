using AiubBusManagementSystem.Models;
using AiubBusManagementSystem.Repositories;
using AiubBusManagementSystem.Utils;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AiubBusManagementSystem.Services
{
    internal class StudentService
    {
        private readonly UserRepository _userRepo;
        private readonly StudentProfileRepository _profileRepo;
        private readonly StudentPickupRepository _pickupRepo;
        private readonly BusAssignmentRepository _assignmentRepo;
        private readonly TravelRepository _travelRepo;

        public StudentService()
        {
            _userRepo = new UserRepository();
            _profileRepo = new StudentProfileRepository();
            _pickupRepo = new StudentPickupRepository();
            _assignmentRepo = new BusAssignmentRepository();
            _travelRepo = new TravelRepository();
        }

        // ==================================================
        // REGISTRATION (FROM STEP 6)
        // ==================================================
        public void RegisterStudent(
            string name,
            string username,
            string password,
            string studentId,
            string department,
            string email)
        {
            User user = new User
            {
                Name = name,
                Username = username,
                Password = password,
                Role = "Student",
                Status = "Pending"
            };

            _userRepo.Create(user);

            User createdUser =
                _userRepo.GetByUsernameAndPassword(username, password);

            StudentProfile profile = new StudentProfile
            {
                UserId = createdUser.Id,
                StudentId = studentId,
                Department = department,
                Email = email
            };

            _profileRepo.Create(profile);
        }

        // ==================================================
        // PICKUP SELECTION (MULTIPLE)
        // ==================================================
        public void SelectPickupLocation(int timeSlotId, int locationId)
        {
            int studentId = SessionManager.CurrentUser.Id;

            // DELETE old selection for this time slot
            _pickupRepo.DeleteByStudentAndTimeSlot(studentId, timeSlotId);

            StudentPickupSelection selection = new StudentPickupSelection
            {
                StudentId = studentId,
                LocationId = locationId,
                TimeSlotId = timeSlotId
            };

            _pickupRepo.Create(selection);
        }

        public void SavePickupSelection(int locationId, int timeSlotId)
        {
            int studentId = SessionManager.CurrentUser.Id;

            _pickupRepo.DeleteByStudentAndTimeSlot(studentId, timeSlotId);

            StudentPickupSelection selection = new StudentPickupSelection
            {
                StudentId = studentId,
                LocationId = locationId,
                TimeSlotId = timeSlotId
            };

            _pickupRepo.Create(selection);
        }

        public List<StudentPickupSelection> GetMyPickupSelections()
        {
            int studentId = SessionManager.CurrentUser.Id;
            return _pickupRepo.GetByStudent(studentId);
        }

        // ==================================================
        // VIEW AVAILABLE BUSES (TODAY)
        // ==================================================
        public List<BusAssignment> GetAvailableBuses()
        {
            return _assignmentRepo.GetByDate(DateTime.Today);
        }

        public DataTable GetAvailableRoutesForTimeSlotToday(int timeSlotId)
        {
            return _assignmentRepo.GetAvailableRoutesByTimeSlot(DateTime.Today, timeSlotId);
        }

        // ==================================================
        // FEES
        // ==================================================
        public List<TravelLog> GetMyDueFees()
        {
            int studentId = SessionManager.CurrentUser.Id;
            return _travelRepo.GetDueByStudent(studentId);
        }

        public DataTable GetMyDueFeesTable()
        {
            int studentId = SessionManager.CurrentUser.Id;
            return _travelRepo.GetDueFeesTableByStudent(studentId);
        }

        public decimal GetMyTotalDueAmount()
        {
            return GetMyDueFees().Sum(t => t.Amount);
        }

        public bool PayFees(decimal inputAmount)
        {
            var dueLogs = GetMyDueFees();
            decimal totalDue = dueLogs.Sum(t => t.Amount);

            if (inputAmount != totalDue)
                return false;

            foreach (var log in dueLogs)
            {
                _travelRepo.MarkPaid(log.Id);
            }

            return true;
        }

        // ==================================================
        // PROFILE
        // ==================================================
        public StudentProfile GetMyProfile()
        {
            int studentId = SessionManager.CurrentUser.Id;
            return _profileRepo.GetByUserId(studentId);
        }

        public void UpdateProfile(
            string studentId,
            string department,
            string email)
        {
            int userId = SessionManager.CurrentUser.Id;

            StudentProfile profile = new StudentProfile
            {
                UserId = userId,
                StudentId = studentId,
                Department = department,
                Email = email
            };

            _profileRepo.Update(profile);
        }


    }
}

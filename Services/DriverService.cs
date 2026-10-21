using AiubBusManagementSystem.Models;
using AiubBusManagementSystem.Repositories;
using AiubBusManagementSystem.Utils;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace AiubBusManagementSystem.Services
{
    internal class DriverService
    {
        private readonly BusAssignmentRepository _assignmentRepo;
        private readonly StudentPickupRepository _pickupRepo;
        private readonly TravelRepository _travelRepo;
        private readonly RouteLocationRepository _locationRepo;
        private readonly RouteRepository _routeRepo;

        public DriverService()
        {
            _assignmentRepo = new BusAssignmentRepository();
            _pickupRepo = new StudentPickupRepository();
            _travelRepo = new TravelRepository();
            _locationRepo = new RouteLocationRepository();
            _routeRepo = new RouteRepository();
        }

        // ==================================================
        // GET TODAY'S ASSIGNMENTS FOR LOGGED-IN DRIVER
        // ==================================================
        public List<BusAssignment> GetTodayAssignments()
        {
            int driverId = SessionManager.CurrentUser.Id;
            return _assignmentRepo.GetByDriver(driverId, DateTime.Today);
        }

        public DataTable GetAllRoutesByDriverId(int driverId)
        {
            return _routeRepo.GetAllRoutesByDriverId(driverId);
        }

        public List<RouteLocation> GetLocationsByRoute(int routeId)
        {
            return _locationRepo.GetByRouteId(routeId);
        }

        // ==================================================
        // GET STUDENTS PICKUP LIST FOR A TIME SLOT
        // ==================================================
        public List<StudentPickupSelection> GetPickupsByTimeSlot(int timeSlotId)
        {
            return _pickupRepo.GetByTimeSlot(timeSlotId);
        }
        public List<TimeSlot> GetAllTimeSlotsByDriverId(int driverid)
        {
            TimeSlotRepository repo = new TimeSlotRepository();
            return repo.GetTimeSlotByDriver(driverid);
        }

        // ==================================================
        // CONFIRM STUDENT PICKUP
        // ==================================================
        public void ConfirmPickup(int studentId, int assignmentId)
        {
            // prevent duplicates for the same student + assignment + date
            if (_travelRepo.Exists(studentId, assignmentId, DateTime.Today))
            {
                _travelRepo.MarkPickupConfirmed(studentId, assignmentId, DateTime.Today);
                return;
            }

            TravelLog log = new TravelLog
            {
                StudentId = studentId,
                AssignmentId = assignmentId,
                Amount = 10m,                // Fixed fee
                PickupConfirmed = true,
                IsPaid = false,
                Date = DateTime.Today
            };

            _travelRepo.Create(log);
        }

        public DataTable GetLocationCountsForToday(int timeSlotId)
        {
            int driverId = SessionManager.CurrentUser.Id;
            return _pickupRepo.GetLocationCountsForDriverAndTimeSlot(driverId, timeSlotId, DateTime.Today);
        }

        public DataTable GetStudentsForLocationToday(int locationId, int timeSlotId)
        {
            return _pickupRepo.GetStudentsForLocationAndTimeSlot(locationId, timeSlotId);
        }

        public int GetTodayAssignmentIdByTimeSlot(int timeSlotId)
        {
            int driverId = SessionManager.CurrentUser.Id;

            BusAssignment? assignment = _assignmentRepo
                .GetByDriver(driverId, DateTime.Today)
                .FirstOrDefault(a => a.TimeSlotId == timeSlotId);

            if (assignment == null)
            {
                throw new InvalidOperationException("No bus assignment found for today in the selected time slot.");
            }

            return assignment.Id;
        }
    }
}

using AiubBusManagementSystem.Models;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AiubBusManagementSystem.Utils;

namespace AiubBusManagementSystem.Repositories
{
    internal class StudentPickupRepository
    {
        // -------------------------
        // ADD PICKUP SELECTION
        // -------------------------
        public void Create(StudentPickupSelection selection)
        {
            using (SqlConnection con = DbConnection.GetConnection())
            {
                string query = @"
                    INSERT INTO StudentPickupSelections
                    (StudentId, LocationId, TimeSlotId)
                    VALUES (@StudentId, @LocationId, @TimeSlotId)";

                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@StudentId", selection.StudentId);
                cmd.Parameters.AddWithValue("@LocationId", selection.LocationId);
                cmd.Parameters.AddWithValue("@TimeSlotId", selection.TimeSlotId);

                con.Open();
                cmd.ExecuteNonQuery();
            }
        }

        // -------------------------
        // GET PICKUPS BY STUDENT
        // -------------------------
        public List<StudentPickupSelection> GetByStudent(int studentId)
        {
            List<StudentPickupSelection> selections = new List<StudentPickupSelection>();

            using (SqlConnection con = DbConnection.GetConnection())
            {
                string query = @"
                    SELECT *
                    FROM StudentPickupSelections
                    WHERE StudentId = @StudentId";

                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@StudentId", studentId);

                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    selections.Add(MapSelection(reader));
                }
            }

            return selections;
        }

        // -------------------------
        // GET PICKUPS BY TIME SLOT
        // (Used by Driver)
        // -------------------------
        public List<StudentPickupSelection> GetByTimeSlot(int timeSlotId)
        {
            List<StudentPickupSelection> selections = new List<StudentPickupSelection>();

            using (SqlConnection con = DbConnection.GetConnection())
            {
                string query = @"
                    SELECT *
                    FROM StudentPickupSelections
                    WHERE TimeSlotId = @TimeSlotId";

                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@TimeSlotId", timeSlotId);

                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    selections.Add(MapSelection(reader));
                }
            }

            return selections;
        }

        // -------------------------
        // PRIVATE MAPPER
        // -------------------------
        private StudentPickupSelection MapSelection(SqlDataReader reader)
        {
            return new StudentPickupSelection
            {
                Id = Convert.ToInt32(reader["Id"]),
                StudentId = Convert.ToInt32(reader["StudentId"]),
                LocationId = Convert.ToInt32(reader["LocationId"]),
                TimeSlotId = Convert.ToInt32(reader["TimeSlotId"])
            };
        }

        public DataTable GetLocationCountsForDriverAndTimeSlot(int driverId, int timeSlotId, DateTime date)
        {
            DataTable table = new DataTable();

            using (SqlConnection con = DbConnection.GetConnection())
            {
                const string query = @"
                    SELECT
                        rl.Id AS LocationId,
                        rl.LocationName,
                        COUNT(sps.Id) AS StudentCount
                    FROM BusAssignments ba
                    INNER JOIN RouteLocations rl ON rl.RouteId = ba.RouteId
                    LEFT JOIN StudentPickupSelections sps
                        ON sps.LocationId = rl.Id
                       AND sps.TimeSlotId = ba.TimeSlotId
                    WHERE ba.DriverId = @DriverId
                      AND ba.TimeSlotId = @TimeSlotId
                      AND ba.Date = @Date
                    GROUP BY rl.Id, rl.LocationName
                    ORDER BY rl.LocationName;";

                using SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@DriverId", driverId);
                cmd.Parameters.AddWithValue("@TimeSlotId", timeSlotId);
                cmd.Parameters.AddWithValue("@Date", date.Date);

                using SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(table);
            }

            return table;
        }

        public DataTable GetStudentsForLocationAndTimeSlot(int locationId, int timeSlotId)
        {
            DataTable table = new DataTable();

            using (SqlConnection con = DbConnection.GetConnection())
            {
                const string query = @"
                    SELECT
                        u.Name AS StudentName,
                        sp.StudentId,
                        CASE WHEN tl.PickupConfirmed = 1 THEN 'Picked' ELSE 'Not Picked' END AS PickupStatus,
                        sps.StudentId AS StudentUserId,
                        tl.Id AS TravelLogId
                    FROM StudentPickupSelections sps
                    INNER JOIN Users u ON u.Id = sps.StudentId
                    INNER JOIN StudentProfiles sp ON sp.UserId = u.Id
                    LEFT JOIN TravelLogs tl
                        ON tl.StudentId = sps.StudentId
                       AND tl.Date = CAST(GETDATE() AS date)
                    WHERE sps.LocationId = @LocationId
                      AND sps.TimeSlotId = @TimeSlotId
                    ORDER BY u.Name;";

                using SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@LocationId", locationId);
                cmd.Parameters.AddWithValue("@TimeSlotId", timeSlotId);

                using SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(table);
            }

            return table;
        }

        public void DeleteByStudentAndTimeSlot(int studentId, int timeSlotId)
        {
            using (SqlConnection con = DbConnection.GetConnection())
            {
                string query = @"
            DELETE FROM StudentPickupSelections
            WHERE StudentId = @StudentId
              AND TimeSlotId = @TimeSlotId";

                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@StudentId", studentId);
                cmd.Parameters.AddWithValue("@TimeSlotId", timeSlotId);

                con.Open();
                cmd.ExecuteNonQuery();
            }
        }


    }
}

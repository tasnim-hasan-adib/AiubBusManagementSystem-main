using AiubBusManagementSystem.Models;
using AiubBusManagementSystem.Utils;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AiubBusManagementSystem.Repositories
{
    internal class UserRepository
    {
        // -------------------------
        // LOGIN (Username + Password)
        // -------------------------
        public User GetByUsernameAndPassword(string username, string password)
        {
            using (SqlConnection con = DbConnection.GetConnection())
            {
                string query = @"
                    SELECT *
                    FROM Users
                    WHERE Username = @Username
                      AND Password = @Password";

                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@Username", username);
                cmd.Parameters.AddWithValue("@Password", password);

                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    return MapUser(reader);
                }

                return null;
            }
        }

        // -------------------------
        // CREATE USER (Admin/Driver/Student)
        // -------------------------
        public void Create(User user)
        {
            using (SqlConnection con = DbConnection.GetConnection())
            {
                string query = @"
                    INSERT INTO Users (Name, Username, Password, Role, Status)
                    VALUES (@Name, @Username, @Password, @Role, @Status)";

                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@Name", user.Name);
                cmd.Parameters.AddWithValue("@Username", user.Username);
                cmd.Parameters.AddWithValue("@Password", user.Password);
                cmd.Parameters.AddWithValue("@Role", user.Role);
                cmd.Parameters.AddWithValue("@Status", user.Status);

                con.Open();
                cmd.ExecuteNonQuery();
            }
        }

        // -------------------------
        // GET USER BY ID
        // -------------------------
        public User GetById(int id)
        {
            using (SqlConnection con = DbConnection.GetConnection())
            {
                string query = "SELECT * FROM Users WHERE Id = @Id";

                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@Id", id);

                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    return MapUser(reader);
                }

                return null;
            }
        }

        // -------------------------
        // GET USERS BY ROLE
        // -------------------------
        public List<User> GetByRole(string role)
        {
            List<User> users = new List<User>();

            using (SqlConnection con = DbConnection.GetConnection())
            {
                string query = "SELECT * FROM Users WHERE Role = @Role";

                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@Role", role);

                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    users.Add(MapUser(reader));
                }
            }

            return users;
        }

        public DataTable GetAllStudentsWithDetails()
        {
            DataTable table = new DataTable();

            using (SqlConnection con = DbConnection.GetConnection())
            {
                string query = @"
            SELECT
                u.Id,
                u.Name,
                u.Username,
                sp.StudentId,
                sp.Department,
                sp.Email,
                u.Status
            FROM Users u
            INNER JOIN StudentProfiles sp ON u.Id = sp.UserId
            WHERE u.Role = @Role";

                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@Role", "Student");

                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        da.Fill(table);
                    }
                }
            }

            return table;
        }

        public DataTable SearchStudentsWithDetails(string keyword)
        {
            DataTable table = new DataTable();

            using (SqlConnection con = DbConnection.GetConnection())
            {
                string query = @"
            SELECT
                u.Id,
                u.Name,
                u.Username,
                sp.StudentId,
                sp.Department,
                sp.Email,
                u.Status
            FROM Users u
            INNER JOIN StudentProfiles sp ON u.Id = sp.UserId
            WHERE u.Role = @Role
              AND (
                   u.Username LIKE @k
                OR u.Name LIKE @k
                OR sp.StudentId LIKE @k
                OR sp.Department LIKE @k
                OR sp.Email LIKE @k
              )";

                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@Role", "Student");
                    cmd.Parameters.AddWithValue("@k", $"%{keyword}%");

                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        da.Fill(table);
                    }
                }
            }

            return table;
        }

        public DataTable GetAllDriversWithDetails()
        {
            DataTable table = new DataTable();

            using (SqlConnection con = DbConnection.GetConnection())
            {
                string query = @"
            SELECT
                u.Id,
                u.Name,
                u.Username,
                dp.LicenseNo,
                dp.Phone,
                u.Status
            FROM Users u
            INNER JOIN DriverProfiles dp ON u.Id = dp.UserId
            WHERE u.Role = @Role";

                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@Role", "Driver");

                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        da.Fill(table);
                    }
                }
            }

            return table;
        }

        public DataTable GetActiveDriversForAssignment()
        {
            using (SqlConnection con = DbConnection.GetConnection())
            {
                const string query = @"
            SELECT u.Id, u.Name
            FROM Users u
            INNER JOIN DriverProfiles dp ON dp.UserId = u.Id
            WHERE u.Role = 'Driver'
              AND u.Status = 'Active'
            ORDER BY u.Name;";

                using SqlCommand cmd = new SqlCommand(query, con);
                con.Open();

                using SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }

        // -------------------------
        // UPDATE STATUS (Activate / Block)
        // -------------------------
        public void UpdateStatus(int userId, string status)
        {
            using (SqlConnection con = DbConnection.GetConnection())
            {
                string query = @"
                    UPDATE Users
                    SET Status = @Status
                    WHERE Id = @Id";

                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@Status", status);
                cmd.Parameters.AddWithValue("@Id", userId);

                con.Open();
                cmd.ExecuteNonQuery();
            }
        }

        // -------------------------
        // DELETE USER
        // -------------------------
        public void Delete(int userId)
        {
            using (SqlConnection con = DbConnection.GetConnection())
            {
                con.Open();

                using (SqlTransaction tx = con.BeginTransaction())
                {
                    try
                    {
                        using (SqlCommand cmdProfile = new SqlCommand(
                            "DELETE FROM DriverProfiles WHERE UserId = @UserId",
                            con,
                            tx))
                        {
                            cmdProfile.Parameters.AddWithValue("@UserId", userId);
                            cmdProfile.ExecuteNonQuery();
                        }

                        using (SqlCommand cmdUser = new SqlCommand(
                            "DELETE FROM Users WHERE Id = @Id",
                            con,
                            tx))
                        {
                            cmdUser.Parameters.AddWithValue("@Id", userId);
                            cmdUser.ExecuteNonQuery();
                        }

                        tx.Commit();
                    }
                    catch
                    {
                        tx.Rollback();
                        throw;
                    }
                }
            }
        }

        // -------------------------
        // PRIVATE MAPPER (VERY IMPORTANT)
        // -------------------------
        private User MapUser(SqlDataReader reader)
        {
            return new User
            {
                Id = Convert.ToInt32(reader["Id"]),
                Name = reader["Name"].ToString(),
                Username = reader["Username"].ToString(),
                Password = reader["Password"].ToString(),
                Role = reader["Role"].ToString(),
                Status = reader["Status"].ToString()
            };
        }
    }
}

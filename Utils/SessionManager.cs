using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AiubBusManagementSystem.Models;

namespace AiubBusManagementSystem.Utils
{
    internal class SessionManager
    {
        public static User CurrentUser { get; private set; }

        public static void StartSession(User user)
        {
            CurrentUser = user;
        }

        public static void EndSession()
        {
            CurrentUser = null;
        }

        public static bool IsLoggedIn()
        {
            return CurrentUser != null;
        }

        public static bool IsAdmin()
        {
            return CurrentUser != null && CurrentUser.Role == "Admin";
        }

        public static bool IsDriver()
        {
            return CurrentUser != null && CurrentUser.Role == "Driver";
        }

        public static bool IsStudent()
        {
            return CurrentUser != null && CurrentUser.Role == "Student";
        }
    }
}

using AiubBusManagementSystem.Repositories;
using AiubBusManagementSystem.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AiubBusManagementSystem.Models;

namespace AiubBusManagementSystem.Services
{
    internal class AuthService
    {
        private readonly UserRepository _userRepository;

        public AuthService()
        {
            _userRepository = new UserRepository();
        }

        // -------------------------
        // LOGIN (Username + Password)
        // -------------------------

        public bool Login(string username, string password)
        {
            User user = _userRepository.GetByUsernameAndPassword(username, password);

            if (user == null)
            {
                return false;
            }

            if (user.Status != "Active")
            {
                return false;
            }

            SessionManager.StartSession(user);
            return true;
        }

        // -------------------------
        // LOGOUT
        // -------------------------
        public void Logout()
        {
            SessionManager.EndSession();
        }
    }
}

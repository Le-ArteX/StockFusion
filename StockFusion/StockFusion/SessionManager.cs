using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockFusion
{
    public static class SessionManager
    {
       
        public static string Username { get; set; }  // Stores the logged-in username
        public static string UserType { get; set; }  // Stores the user role (Admin, Manager, etc.)
        public static string Answer { get; set; }
    }

}

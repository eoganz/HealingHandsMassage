using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MassageSite.Models
{
    public static class UserHelper
    {
        public static User GetUserByEmail(string email, UserContext context)
        {
            var userResult = 
                from thisUser in context.Users
                where thisUser.Email == email
                select thisUser;
            
            
            return userResult.FirstOrDefault();
        }

        public static bool CheckCredentials(string email, string password, UserContext context)
        {

            var currUser = GetUserByEmail(email, context);
            
            if(currUser == null)
            {
                return false;
            }

            if(currUser.Email == email && currUser.Password == password)
            {
                return true;
            }

            return false;

        }
    }

    public class LoginHelper
    {
        public string Email { get; set; }
        public string Password { get; set; }
    }


}
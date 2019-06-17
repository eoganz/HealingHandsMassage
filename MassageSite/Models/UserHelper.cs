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
            var userResult = from thisUser in context.Users
                              where thisUser.Email == email
                              select thisUser;

            return (User)userResult;
        }

        public static bool CheckCredentials(string email, string password, UserContext context)
        {
            var userResult = from thisUser in context.Users
                             where thisUser.Email == email &&
                             thisUser.Password == password
                             select thisUser;

            if (userResult != null)
            {
                return true;
            }
            return false;

        }
    }


}
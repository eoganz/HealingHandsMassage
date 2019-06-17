using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Core.Objects;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Web;

namespace MassageSite.Models
{
    public class UserContext : DbContext
    {
        public UserContext(): base()
        {

        }

        public virtual DbSet<User> Users { get; set; }



        public User GetUserByPhoneNumber(string phoneNumber)
        {
            foreach(var user in Users)
            {
                if(phoneNumber == user.PhoneNumber)
                {
                    return user;
                }
            }

            return null;
        }
    }
}
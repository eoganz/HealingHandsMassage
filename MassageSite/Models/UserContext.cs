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


        public User GetUserById(int id)
        {
            return Users.Find(id);
        }
    }
}
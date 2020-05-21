using Funder.Models;
using Funder.Options;
using Funder.Repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace Funder.Services
{
    public class UserManagement : IUserManager
    {
        private FunderDbContext db;

        public UserManagement(FunderDbContext _db)
        {
            db = _db;
        }


        //CRUD
        // create read update delete
        public User CreateUser(UserOption usrOption)
        {
            User user = new User
            {
                FirstName = usrOption.FirstName,
                LastName = usrOption.LastName,
                Email = usrOption.Email,
                Dob = usrOption.Dob,
                isActive = true,

            };


            db.Users.Add(user);
            db.SaveChanges();

            return user;
        }


        public User Update(UserOption usrOption, int userId)
        {

            User user = db.Users.Find(userId);

            if (usrOption.FirstName != null)
                user.FirstName = usrOption.FirstName;
            if (usrOption.LastName != null)
                user.LastName = usrOption.LastName;
            if (usrOption.Email != null)
                user.Email = usrOption.Email;
            if (usrOption.Dob != new DateTime())
                user.Dob = usrOption.Dob;

            db.SaveChanges();
            return user;
        }

        public bool DeleteUserById(int id)
        {
            User user = db.Users.Find(id);
            if (user != null)
            {
                db.Users.Remove(user);
                db.SaveChanges();
                return true;
            }
            return false;
        }

        //public bool SoftDeleteUserById(int id)
        //{
        //    User user = db.Users.Find(id);
        //    if (user != null)
        //    {
        //        user.Active = false;
        //        db.SaveChanges();
        //        return true;
        //    }
        //    return false;
        //}

        //public List<User> GetAllUsers()
        //{
        //    return db.Users.ToList();
        //}

    }
}
   

       
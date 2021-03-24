using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InstagrammeWithEF.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace InstagrammeWithEF.Data.Repositories
{
    public class UserRepo
    {
        private InstagrammeContext _context;

        public UserRepo()
        {
            _context = new InstagrammeContext();
        }

        public object FindUserWithPost(int userId)
        {
            /*
             * SELECT * FROM Users
             * JOIN Posts ON Posts.UserId = Users.UserId
             * WHERE Users.UserId = 1
            */

            return _context.Users
                .Include(x => x.Posts)
                .FirstOrDefault(x => x.UserId == userId);
        }

        public List<User> FindFiveOldestProfiles()
        {
            return GetAllUsers().OrderBy(x => x).Take(5).ToList();
        }

        public List<User> GetAllUsers()
        {
            return _context.Users.ToList();
        }
    }
}
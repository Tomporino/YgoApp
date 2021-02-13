using System;
using System.Collections.Generic;
using System.Linq;

namespace YgoApp.Models.Repositories.Implementations
{
    public class UserRepository : IUserRepository
    {
        private readonly YgoDbContext _context;

        public UserRepository(YgoDbContext context)
        {
            _context = context;
        }
        public void Add(User user)
        {
            if (user != null)
            {
                _context.Add(user);
                _context.SaveChanges();
            }
            else
            {
                throw new ArgumentNullException("There is no user to add!");
            }
        }

        public void Delete(User user)
        {
            if (user != null)
            {
                _context.Remove(user);
                _context.SaveChanges();
            }
            else
            {
                throw new ArgumentNullException("There is no user to delete!");
            }
        }

        public void Update(User user)
        {
            throw new System.NotImplementedException();
        }

        public User Get(long userId)
        {
            User user = _context.Users.Find(userId);
            if (user != null)
            {
                return user;
            }
            else
            {
                throw new KeyNotFoundException("No user found with this userId!");
            }
        }

        public User Get(string userName)
        {
            User user = _context.Users.FirstOrDefault(u => u.UserName == userName);
            if (user != null)
            {
                return user;
            }
            else
            {
                throw new KeyNotFoundException("No user found with this userId!");
            }
        }

        public IEnumerable<User> GetUsers()
        {
            return _context.Users.ToList();
        }
    }
}
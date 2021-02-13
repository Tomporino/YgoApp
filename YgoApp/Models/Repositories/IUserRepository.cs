using System.Collections.Generic;

namespace YgoApp.Models.Repositories
{
    public interface IUserRepository
    {
        void Add(User user);
        void Delete(User user);
        void Update(User user);
        User Get(long userId);
        User Get(string userName);
        IEnumerable<User> GetUsers();
    }
}
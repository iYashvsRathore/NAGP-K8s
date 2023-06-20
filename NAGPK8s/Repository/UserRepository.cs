using NAGPK8s.Model;

namespace NAGPK8s.Repository
{
    public class UserRepository
    {
        private readonly UserDBContect _dBContect;
        public UserRepository(UserDBContect dBContect)
        {
            _dBContect = dBContect;
        }

        public async Task<IEnumerable<User>> GetAllUsers()
        {
            return _dBContect.Users;
        }

        public async Task<User> GetUsersbyID(int id)
        {
            return _dBContect.Users.FirstOrDefault(x => x.Id == id);
        }

        public async Task CreateUser(User user)
        {
            await _dBContect.Users.AddAsync(user);
            await _dBContect.SaveChangesAsync();
        }
    }
}

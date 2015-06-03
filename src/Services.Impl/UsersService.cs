using System.Linq;
using Repositories.Contract;

namespace Services.Impl
{
    public class UsersService
    {
        private readonly IUsersRepository _usersRepository;
        private readonly IOrganizationsRepository _organizationsRepository;

        public UsersService(IUsersRepository usersRepository, IOrganizationsRepository organizationsRepository)
        {
            _usersRepository = usersRepository;
            _organizationsRepository = organizationsRepository;
        }

        public string[] GetOrganizations(string name, string password, string inn)
        {
            var user = _usersRepository.FindUser(name, password);
            var organizations = _organizationsRepository.FindOrganizationsforOwner(user.Id);
            return organizations
                .Where(x => x.Inn == inn)
                .Select(x => x.Name)
                .ToArray();
        }
    }
}
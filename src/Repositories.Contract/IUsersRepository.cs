using System;

namespace Repositories.Contract
{
    public class UserRequisitesDto
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Password { get; set; }
    }

    public interface IUsersRepository
    {
        UserRequisitesDto FindUser(string name, string password);
    }
}
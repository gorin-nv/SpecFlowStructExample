using Moq;
using Repositories.Contract;
using Services.Tests.SpecflowTools;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;

namespace Services.Tests.Environment
{
    [Binding]
    internal class UsersRepositorySteps
    {
        private readonly NamedGuids _namedGuids;
        private readonly Mock<IUsersRepository> _repository;

        public UsersRepositorySteps(Injection<IUsersRepository> injection, NamedGuids namedGuids)
        {
            _namedGuids = namedGuids;
            _repository = Mock.Get(injection.Instance);
        }

        [Given(@"в репозитории пользователей поиск пользователя по имени ""(.*)"" и паролю ""(.*)"" возвращает")]
        public void ВРепозиторииПользователейПоискПользователяПоИмениИПаролюВозвращает(string name, string password, Table table)
        {
            var data = table.CreateInstance<UserRequisitesDtoData>();
            var user = new UserRequisitesDto
            {
                Id = _namedGuids.Ensure(data.UserId),
                Name = data.Name,
                Password = data.Password
            };
            _repository
                .Setup(x => x.FindUser(name, password))
                .Returns(user);
        }

        private class UserRequisitesDtoData
        {
            public string UserId { get; set; }
            public string Name { get; set; }
            public string Password { get; set; }
        }
    }
}
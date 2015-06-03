using System.Linq;
using FluentAssertions;
using Repositories.Contract;
using Services.Impl;
using Services.Tests.SpecflowTools;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;

namespace Services.Tests.Actions
{
    [Binding]
    internal class UsersServicesSteps
    {
        private readonly NamedInstances<string> _namedTexts;
        private readonly UsersService _usersService;

        private string[] _orgsNamesResponce;

        public UsersServicesSteps(Injection<IUsersRepository> usersRepository, Injection<IOrganizationsRepository> organizationsRepository, NamedInstances<string> namedTexts)
        {
            _namedTexts = namedTexts;
            _usersService = new UsersService(usersRepository.Instance, organizationsRepository.Instance);
        }

        [When(@"в сервисе пользователей запрашивается список имен организаций")]
        public void ВСервисеПользователейЗапрашиваетсяСписокИменОрганизаций(Table table)
        {
            var data = table.CreateInstance<OrgsNamesRequestData>();
            var inn = _namedTexts.Ensure(data.Inn, () => "inn=" + data.Inn);
            _orgsNamesResponce = _usersService.GetOrganizations(data.Name, data.Password, inn);
        }

        [Then(@"в сервисе пользователей возвращает список имен организаций")]
        public void ВСервисеПользователейВозвращаетСписокИменОрганизаций(Table table)
        {
            var expected = table.Rows.Select(x => x[0]);

            _orgsNamesResponce.Should().BeEquivalentTo(expected);
        }

        private class OrgsNamesRequestData
        {
            public string Name { get; set; }
            public string Password { get; set; }
            public string Inn { get; set; }
        }
    }
}
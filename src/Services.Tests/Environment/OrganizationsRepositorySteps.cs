using System.Linq;
using Moq;
using Repositories.Contract;
using Services.Tests.SpecflowTools;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;

namespace Services.Tests.Environment
{
    [Binding]
    class OrganizationsRepositorySteps
    {
        private readonly NamedGuids _namedGuids;
        private readonly NamedInstances<string> _namedTexts;
        private readonly Mock<IOrganizationsRepository> _repository;

        public OrganizationsRepositorySteps(Injection<IOrganizationsRepository> injection, NamedGuids namedGuids, NamedInstances<string> namedTexts)
        {
            _namedGuids = namedGuids;
            _namedTexts = namedTexts;
            _repository = Mock.Get(injection.Instance);
        }

        [Given(@"в репозитории организаций поиск организаций по пользователю ""(.*)"" возвращает")]
        public void ВРепозиторииОрганизацийПоискОрганизацийПоПользователюВозвращает(string user, Table table)
        {
            var userId = _namedGuids.Ensure(user);
            var organizations = table
                .CreateSet<OrganizationRequisitesDtoData>()
                .Select(x => new OrganizationRequisitesDto
                {
                    Id = _namedGuids.Ensure(x.OrganizationId),
                    Inn = _namedTexts.Ensure(x.Inn, () => "inn=" + x.Inn),
                    Name = x.Name,
                    OwnerId = _namedGuids.Ensure(x.OwnerId)
                })
                .ToArray();
            _repository
                .Setup(x => x.FindOrganizationsforOwner(userId))
                .Returns(organizations);
        }

        private class OrganizationRequisitesDtoData
        {
            public string OrganizationId { get; set; }
            public string Name { get; set; }
            public string Inn { get; set; }
            public string OwnerId { get; set; }
        }
    }
}
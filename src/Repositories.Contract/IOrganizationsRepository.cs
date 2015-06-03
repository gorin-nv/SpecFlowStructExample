using System;

namespace Repositories.Contract
{
    public class OrganizationRequisitesDto
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Inn { get; set; }
        public Guid OwnerId { get; set; }
    }

    public interface IOrganizationsRepository
    {
        OrganizationRequisitesDto[] FindOrganizationsforOwner(Guid ownerId);
    }
}
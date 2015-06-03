using System;

namespace Services.Tests.SpecflowTools
{
    public class NamedGuids : NamedInstancesBase<Guid>
    {
        protected override Guid CreateInstance()
        {
            return Guid.NewGuid();
        }
    }
}
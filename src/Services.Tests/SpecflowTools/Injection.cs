using Moq;

namespace Services.Tests.SpecflowTools
{
    public class Injection<T>
        where T : class
    {
        private readonly T _mock = Mock.Of<T>();

        public T Instance
        {
            get { return _mock; }
        }
    }
}
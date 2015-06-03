namespace Services.Tests.SpecflowTools
{
    public abstract class NamedInstancesBase<T> : NamedInstances<T>
    {
        public T Ensure(string name)
        {
            return Ensure(name, CreateInstance);
        }

        protected abstract T CreateInstance();
    }
}
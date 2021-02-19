namespace UnityContainerStrategyFactoryInjection.Core
{
    interface IDataFactory<out T>
    {
        T Create();
    }
}

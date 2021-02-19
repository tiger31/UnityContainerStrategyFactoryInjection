namespace UnityContainerStrategyFactoryInjection.Core
{
    using Data.Account;
    using Unity;

    static class EnvironmentExtensions
    {
        public static T BuildUp<T>(this T value, string key)
        {
            var account = Environment.Container.Resolve<IAccount>(key);
            using var container = Environment.TestsContainer.CreateChildContainer();
            container.RegisterInstance<IAccount>(account);

            container.BuildUp(value);
            return value;
        }
    }
}

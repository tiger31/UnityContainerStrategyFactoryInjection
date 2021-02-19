namespace UnityContainerStrategyFactoryInjection.Core
{
    using Data.Account;
    using Data.Manager;
    using Unity;

    sealed class EnvironmentConfigurator
    {
        public static IUnityContainer ConfigureAccounts(IUnityContainer container)
        {
            container.RegisterFactory<AccountFactory>(_ => new AccountFactory());
            container.RegisterInstance<IAccount>("foo", container.Resolve<AccountFactory>().SetKey("foo").Create());
            container.RegisterInstance<IAccount>("bar", container.Resolve<AccountFactory>().SetKey("bar").Create());

            return container;
        }

        public static IUnityContainer ConfigureTests(IUnityContainer container)
        {
            container.RegisterFactory<ManagerFactory>(_ => new ManagerFactory());
            container.RegisterFactory<IManager>(c => c.Resolve<ManagerFactory>().SetContainer(c).Create());

            return container;
        }
    }
}

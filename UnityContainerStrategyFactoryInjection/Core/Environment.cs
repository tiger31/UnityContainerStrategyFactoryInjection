namespace UnityContainerStrategyFactoryInjection.Core
{
    using Unity;

    class Environment
    {
        public static IUnityContainer Container;
        public static IUnityContainer TestsContainer;
        static Environment()
        {
            Container = new UnityContainer();
            EnvironmentConfigurator.ConfigureAccounts(Container);

            TestsContainer = Container.CreateChildContainer();
            EnvironmentConfigurator.ConfigureTests(TestsContainer);
        }
    }
}

namespace UnityContainerStrategyFactoryInjection.Data.Manager
{
    using Account;
    using Core;
    using Unity;

    class ManagerFactory : IDataFactory<IManager>
    {
        private IUnityContainer container;

        public ManagerFactory SetContainer(IUnityContainer container)
        {
            this.container = container;
            return this;
        }

        public IManager Create()
        {
            var account = container.Resolve<IAccount>();
            if (account.GetName() == "foo")
            {
                container.RegisterType<IManager, ManagerFoo>();
            }
            else
            {
                container.RegisterType<IManager, ManagerBar>();
            }

            return container.Resolve<IManager>();
        }
    }
}

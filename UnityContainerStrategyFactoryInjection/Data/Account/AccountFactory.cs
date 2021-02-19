namespace UnityContainerStrategyFactoryInjection.Data.Account
{
    using Core;

    class AccountFactory : IDataFactory<IAccount>
    {
        private string key;
        public IAccount Create()
        {
            return new Account(this.key);
        }

        public AccountFactory SetKey(string key)
        {
            this.key = key;
            return this;
        }
    }
}

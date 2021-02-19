namespace UnityContainerStrategyFactoryInjection.Data.Account
{
    class Account : IAccount
    {
        private string name;

        public Account(string name)
        {
            this.name = name;
        }

        public string GetName()
        {
            return this.name;
        }
    }
}

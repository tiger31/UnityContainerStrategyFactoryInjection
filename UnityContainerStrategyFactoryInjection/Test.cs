namespace UnityContainerStrategyFactoryInjection
{
    using System;
    using Core;
    using Data.Account;
    using Data.Manager;
    using Unity;
    using Xunit;

    public class Test
    {
        public Test() => this.BuildUp("bar");

        [Dependency]
        public IAccount Account { get; set; }

        [Dependency]
        public IManager Manager { get; set; }

        [Fact]
        public void TestFoo()
        {
            if (this.Account.GetName() != "foo")
            {
                throw new Exception($"Expected Account: foo, got {this.Account.GetName()}");
            }

            if (this.Manager.GetName() != "foo")
            {
                throw new Exception($"Expected Manager: foo, got {this.Account.GetName()}");
            }
        }

        [Fact]
        public void TestBar()
        {
            if (this.Account.GetName() != "bar")
            {
                throw new Exception($"Expected Account: bar, got {this.Account.GetName()}");
            }

            if (this.Manager.GetName() != "bar")
            {
                throw new Exception($"Expected Manager: foo, got {this.Account.GetName()}");
            }
        }
    }
}

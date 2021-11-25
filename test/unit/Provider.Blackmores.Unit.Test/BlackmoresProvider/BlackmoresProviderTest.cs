using Castle.Windsor;
using CluedIn.Core;
using CluedIn.Core.Providers;
using CluedIn.Crawling.Blackmores.Infrastructure.Factories;
using Moq;

namespace CluedIn.Provider.Blackmores.Unit.Test.BlackmoresProvider
{
    public abstract class BlackmoresProviderTest
    {
        protected readonly ProviderBase Sut;

        protected Mock<IBlackmoresClientFactory> NameClientFactory;
        protected Mock<IWindsorContainer> Container;

        protected BlackmoresProviderTest()
        {
            Container = new Mock<IWindsorContainer>();
            NameClientFactory = new Mock<IBlackmoresClientFactory>();
            var applicationContext = new ApplicationContext(Container.Object);
            Sut = new Blackmores.BlackmoresProvider(applicationContext, NameClientFactory.Object);
        }
    }
}

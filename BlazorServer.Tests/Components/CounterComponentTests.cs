using BlazorServer.App.Components;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BlazorServer.Tests.Components
{
    [TestClass]
    public class CounterComponentTests
    {
        [TestMethod]
        public void IncrementCount_Invoke_IncreaseCurrentValue()
        {
            var someClass = new CounterComponent();
            someClass.IncrementCount();

            Assert.IsNotNull(someClass.currentCount > 0);
        }
    }
}

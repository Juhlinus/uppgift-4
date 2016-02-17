using Uppgift4.ViewModel;
using Uppgift4.Models;
using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

// Testa i ViewModel

namespace Uppgift4Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Presenter presenter = new Presenter();

            Assert.AreEqual("Linus", presenter.Sender);
            Assert.IsInstanceOfType(presenter.Messages, typeof(Messages));
        }
    }
}

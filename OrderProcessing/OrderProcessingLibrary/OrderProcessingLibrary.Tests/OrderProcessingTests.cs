using NUnit.Framework;
using OrderProcessingLibrary.Models;

namespace OrderProcessingLibrary.Tests
{
    [TestFixture]
    public class OrderProcessingTests
    {
        private User _user;

        [SetUp]
        public void Setup()
        {
            _user = new User
            {
                Name = "Bhargav",
                Email = "vasistabhargav@outlook.com"
            };
        }
        [TestCase]
        public void When_Payment_Is_For_PhysicalProduct_Expect_Generate_Packing_Slip_And_Generate_Comission_Payment()
        {
            PhysicalProduct physicalProduct = new PhysicalProduct();

            OrderProcessing orderProcessing = new OrderProcessing(physicalProduct, _user);

            Assert.That(orderProcessing.ProcessOrder(), Is.True);
        }
    }
}

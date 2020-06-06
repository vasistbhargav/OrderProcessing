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

        [TestCase]
        public void When_Payment_Is_For_Book_Expect_Generate_Packing_Slip_And_Generate_Comission_Payment_And_Create_Duplicate_Packing_Slip()
        {
            Book book = new Book();

            OrderProcessing orderProcessing = new OrderProcessing(book, _user);

            Assert.That(orderProcessing.ProcessOrder(), Is.True);
        }

        [TestCase]
        public void When_Payment_Is_For_Membership_Expect_Activate_The_Membership_And_Send_Email_To_Owner()
        {
            MembershipActivation membership = new MembershipActivation();

            OrderProcessing orderProcessing = new OrderProcessing(membership, _user);

            Assert.That(orderProcessing.ProcessOrder(), Is.True);
        }
    }
}

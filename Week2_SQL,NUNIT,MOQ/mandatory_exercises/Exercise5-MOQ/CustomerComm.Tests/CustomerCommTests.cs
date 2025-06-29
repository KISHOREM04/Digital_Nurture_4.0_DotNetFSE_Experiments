using NUnit.Framework;
using Moq;
using CustomerCommLib;

namespace CustomerComm.Tests
{
    [TestFixture]
    public class CustomerCommTests
    {
        private Mock<IMailSender>? _mockMailSender;
        private CustomerCommLib.CustomerComm? _customerComm;

        [OneTimeSetUp]
        public void Setup()
        {
            _mockMailSender = new Mock<IMailSender>();
            _mockMailSender
                .Setup(m => m.SendMail(It.IsAny<string>(), It.IsAny<string>()))
                .Returns(true);

            _customerComm = new CustomerCommLib.CustomerComm(_mockMailSender.Object);
        }

        [TestCase]
        public void SendMailToCustomer_ReturnsTrue()
        {
            var result = _customerComm!.SendMailToCustomer();
            Assert.That(result, Is.True);
        }
    }
}
using System;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Interview.Repository;

namespace Interview.Tests.Controllers
{
    [TestClass]
    public class ValuesControllerTest
    {
        [TestMethod]
        public void Get()
        {
            // Arrange
            PaymentRepository repo = new PaymentRepository();

            // Act
            var result = repo.GetAllPayments();

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual("3f2b12b8-2a06-45b4-b057-45949279b4e5", result.ElementAt(0).Id);
            Assert.AreEqual("d2032222-47a6-4048-9894-11ab8ebb9f69", result.ElementAt(1).Id);
        }

        [TestMethod]
        public void GetById()
        {
            // Arrange
            PaymentRepository repo = new PaymentRepository();

            // Act
            var result = repo.GetPaymentById(new Guid("3f2b12b8-2a06-45b4-b057-45949279b4e5"));

            // Assert
            Assert.AreEqual(58.26, result.Amount);
        }
    }
}

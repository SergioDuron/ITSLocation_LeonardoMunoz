using ITSLocation.Application.Services;
using ITSLocation.Domain.Entities;
using ITSLocation.Domain.RepositoryInterfaces;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITSLocation.API.UnitTesting.Tests
{
    [TestFixture]
    public class PostalCodeServiceTests
    {
        private Mock<IPostalCodeRepository> _mockRepo;
        private PostalCodeService _service;

        [SetUp]
        public void Setup()
        {
            _mockRepo = new Mock<IPostalCodeRepository>();
            _service = new PostalCodeService(_mockRepo.Object);
        }

        [Test]
        public void GetPostalCode_ShouldReturnPostalCode()
        {
            // Arrange
            var postalCode = new PostalCode { Id = 1, Code = "12345", City = "City A", State = "State A" };
            _mockRepo.Setup(repo => repo.GetPostalCode("12345")).Returns(postalCode);

            // Act
            var result = _service.GetPostalCode("12345");

            // Assert
            Assert.NotNull(result);
            Assert.AreEqual("12345", result.Code);
        }
    }
}

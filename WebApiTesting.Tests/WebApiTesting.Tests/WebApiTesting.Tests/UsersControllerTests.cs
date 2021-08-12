using Moq;
using System;
using System.Web.Http.Results;
using WebApiTesting.Core;
using WebApiTesting.Core.Models;
using Xunit;
using WebApiTesting.Api.Controllers;

namespace WebApiTesting.Tests
{
    public class UsersControllerTests
    {
        // Convention for write Unit test  UnitOfWork-StateUnderTest-ExpectedBehavior

        [Fact]
        public void GetItem_WithUnexistingItem_ReturnNoFound()
        {
            //Arrange
            var repo = new Mock<IUsers>();
            repo.Setup(rep => rep.GetbyId(It.IsAny<Guid>())).Returns((Users)null);

            var item = new UsersController(repo.Object);
            // Act
            var result = item.GetbyId(Guid.NewGuid());

            // Assert
            Assert.IsNotType<NotFoundResult>("404");
        }
    }
}

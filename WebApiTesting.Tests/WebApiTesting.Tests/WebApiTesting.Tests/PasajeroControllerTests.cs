using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http.Results;
using WebApiTesting.Api.Controllers;
using WebApiTesting.Core.Models;
using WebApiTesting.Core.Repositories.Interfaces;
using Xunit;

namespace WebApiTesting.Tests
{
    public class PasajeroControllerTests
    {

        [Fact]
        public void PasajeroController_should()
        {
            //Arrange
            var repo = new Mock<IPasajero>();
            repo.Setup(r => r.GetAll(It.IsAny<int>()));

            var item = new PasajeroController(repo.Object);

            //Act
            var result = item.GetPasajero(1);


            //Assert
            Assert.IsNotType<NotFoundResult>("404");
        }
    }
}

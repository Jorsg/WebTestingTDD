using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http.Results;
using WebApiTesting.Api.Controllers;
using WebApiTesting.Core.Repositories.Interfaces;
using Xunit;

namespace WebApiTesting.Tests
{
    public class ReservaControllerTests
    {
        private readonly Mock<IReserva> repo = new();

        [Fact]
        public void Get_WhenCalled_ReturnAll_Traveler()
        {
            //Arrange            
            repo.Setup(r => r.GetAll());

            var item = new ReservaController(repo.Object);

            //Act
            var result = item.GetReserva();


            //Assert
            Assert.IsNotType<NotFoundResult>(result);
        }

        [Fact]
        public void Get_WhenCalledExistTraveler_ReturnTraveler()
        {
            //Arrange

            repo.Setup(r => r.GetAll(It.IsAny<int>()));

            var item = new ReservaController(repo.Object);

            //Act
            var result = item.GetReserva(1);


            //Assert
            Assert.IsNotType<NotFoundResult>(result);
        }

        [Fact]
        public void Get_WhenCalledUnExistTraveler_ReturnTraveler()
        {
            //Arrange

            repo.Setup(r => r.GetAll(It.IsAny<int>()));

            var item = new ReservaController(repo.Object);

            //Act
            var result = item.GetReserva(0);


            //Assert
            Assert.IsNotType<NotFoundResult>("404");
        }

    }
}

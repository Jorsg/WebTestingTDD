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
        private readonly Mock<IPasajero> repo = new(); 

        [Fact]
        public void Get_WhenCalled_ReturnAll_Traveler()
        {
            //Arrange            
            repo.Setup(r => r.GetAll());

            var item = new PasajeroController(repo.Object);

            //Act
            var result = item.GetPasajero();


            //Assert
            Assert.IsNotType<NotFoundResult>(result);
        }

        [Fact]
        public void Get_WhenCalledExistTraveler_ReturnTraveler()
        {
            //Arrange
           
            repo.Setup(r => r.GetAll(It.IsAny<int>()));

            var item = new PasajeroController(repo.Object);

            //Act
            var result = item.GetPasajero(1);


            //Assert
            Assert.IsNotType<NotFoundResult>(result);
        }

        [Fact]
        public void Get_WhenCalledUnExistTraveler_ReturnTraveler()
        {
            //Arrange
           
            repo.Setup(r => r.GetAll(It.IsAny<int>()));

            var item = new PasajeroController(repo.Object);

            //Act
            var result = item.GetPasajero(0);


            //Assert
            Assert.IsNotType<NotFoundResult>("404");
        }

        [Fact]
        public void Get_WhenCalledCreateTraveler_ReturnTraveler()
        {
            //Arrante
            var traveler = CreateTraveler();
            repo.Setup(r => r.InsertPasajero(traveler)).Returns(1);
            var controller = new PasajeroController(repo.Object);

            //Act
            var result = controller.g();
        }

        private Pasajero CreateTraveler()
        {
            return new()
            {
                Email= "travel@travel.com",
                FechaNacimiento = Convert.ToDateTime("2000-12-12"),
                Genero = "M",
                NombresCompletos = "Joseph Perez",
                IdTipoContacto = 1,
                NumDocumento = "1203584466",
                TelefonoContacto = "5148576325",
                TipoDocumento = "Passport"
            };
        }
    }
}

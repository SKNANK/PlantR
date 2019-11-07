using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PlantRService.Model;
using PlantRService.Repo;

namespace PlantRTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Databasecheck()
        {

        }

        [TestMethod]
        public void CreatePlantT()
        {
            //Arrange
            int plantID = 1;
            int accID = 0;
            int daysWater = 3;
            string nName = "planty";
            Account acc = new Account { ID = accID };
            AccountRepository accRepo = new AccountRepository();
            accRepo.GetAllPlants();
            //Act
            accRepo.AddPlant(plantID, accID, daysWater, nName);
            //Assert
            Assert.IsNotNull(acc.PlantList);
        }

        [TestMethod]
        public void ReadPlantT()
        {

        }

        [TestMethod]
        public void UpdatePLantT()
        {

        }

        [TestMethod]
        public void DeletePlantT()
        {

        }

    }
}

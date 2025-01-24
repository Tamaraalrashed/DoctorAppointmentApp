using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DoctorAppointmentApp.Tests.Controllers
{
    [TestClass]
    public class TestSeed<T> where T : class
    {
        private InMemoryRepository<T> _repository;
        private List<T> _seedData;



        [TestMethod]
        public void FindAllDoctorSlots()
        {
            // Arrange

            Doctor doctor = InMemoryDataStore.Instance.Doctor;
            var docRepo = new DoctorRepository();
            var savedDoctor = docRepo.FindAll(x => x.Id == doctor.Id).FirstOrDefault();

            // Act
            // var allEntities = _repository.FindAll();

            // Assert
            // Assert.AreEqual(1, allEntities.Count());

        }

        [TestMethod]
        public void GetAll_ShouldReturnAllItems()
        {
            // Act

            //var allItems = _repository.GetAll();

            // Assert
            // Assert.AreEqual(3, allItems.Count());
        }
    }
}

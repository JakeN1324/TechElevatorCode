using Microsoft.VisualStudio.TestTools.UnitTesting;
using PetInfo;
using PetInfo.Classes.DAO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Transactions;

namespace PetInfoTest
{
    [TestClass]
    public class PetDAOTest
    {
        PetDAO petDAO;
        private string connectionString = "Data Source=.\\sqlexpress;Initial Catalog=PetInfo;Integrated Security=True";

        TransactionScope tran;

        private int count = 0;

        [TestInitialize]
        public void Setup()
        {
            tran = new TransactionScope();

            // Arrange
            petDAO = new PetDAO(connectionString);

            List<Pet> pets = petDAO.GetPets();
            int count = pets.Count;

            int petId = 0;

            Pet pet = new Pet("Xyzzy", "dog", "Afghan");
            petDAO.AddPet(pet);

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                SqlCommand cmd = new SqlCommand("SELECT id FROM pet WHERE name = @name", conn);
                cmd.Parameters.AddWithValue("@name", "Xyzzy");

                petId = Convert.ToInt32(cmd.ExecuteScalar());
            }
        }

        [TestCleanup]
        public void Cleanup()
        {
            tran.Dispose(); 
        }

        [TestMethod]
        public void PetDAOConstructor()
        {
            List<Pet> pets;
            pets = petDAO.GetPets();
            int afterCount = pets.Count;

            Assert.IsNotNull(pets);
            Assert.AreEqual(count + 1, afterCount);
        }

        [TestMethod]
        [DataRow("Dog 1", "dog", "All American")]
        public void PetDAOAddPetTest(string name, string type, string breed)
        {
            //Act
            petDAO.AddPet(name, type, breed);
            List<Pet> pets = petDAO.GetPets();

            //Assert
            Assert.AreEqual(name, pets[pets.Count - 1].Name);           
        }

        [TestMethod]
        public void PetDAOGetPetsTest()
        {
            List<Pet> pets;

            pets = petDAO.GetPets();

            Assert.IsNotNull(pets);
        }

        [TestMethod]
        public void PetDAODeletePetTest()
        {

        }
    }
}

using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Data.SqlClient;
using System.Transactions;
using USCitiesAndParks.DAO;
using USCitiesAndParks.Models;

namespace USCitiesAndParksTests
{
    [TestClass]
    public class CitySqlDaoTests : CitiesAndParksTests
    {
        

        [TestMethod]
        public void CityCreationTest()
        {
            City city = new City();
            Assert.IsNotNull(city);
        }

        [TestMethod]
        public void GetCityTest()
        {
            CitySqlDao cityDao = new CitySqlDao(ConnectionString);

            City city = cityDao.GetCity(170);

            Assert.IsNotNull(city);
        }

        [TestMethod]
        public void CreateCityTest()
        {
            CitySqlDao cityDao = new CitySqlDao(ConnectionString);
            City city = new City();
            city.CityName = "Concrete";
            city.Population = 3;
            city.StateAbbreviation = "XY";
            city.Area = 2;

            City newCity = cityDao.CreateCity(city);

            Assert.IsNotNull(newCity);

        }

        protected int GetRowCount(string table)
        {
            using (SqlConnection conn = new SqlConnection(ConnectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand($"SELECT COUNT(*) FROM {table}", conn);
                int count = Convert.ToInt32(cmd.ExecuteScalar());
                return count;
            }
        }
    }
}

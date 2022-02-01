using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Reflection;

namespace BankTellerExercise.Tests
{
    [TestClass]
    public class BankAccountTests
    {
        private Type type;
        private PropertyInfo[] properties;

        [TestInitialize]
        public void SetUpBankAccount()
        {
            type = Type.GetType("BankTellerExercise.BankAccount, BankTellerExercise");
            properties = type.GetProperties();
        }

        [TestMethod]
        public void TransferTest()
        {
            BankAccount source = new BankAccount("", "", 50);
            BankAccount destination = new BankAccount("", "");

            MethodInfo method = type.GetMethod("TransferTo");

            object[] methodParameters = new object[] { destination, 24M };

            method.Invoke(source, methodParameters);

            object newSourceBalance = GetPropertyValue(source, "Balance");

            Assert.AreEqual(26M, newSourceBalance);
            Assert.AreEqual(24M, destination.Balance);
            Assert.AreEqual(26M, source.Balance);
        }

        private object GetPropertyValue(object instance, string propName)
        {
            object retVal = new object();
            foreach (PropertyInfo prop in properties)
            {
                if (prop.Name == propName)
                {
                    retVal = prop.GetValue(instance);
                }
            }
            return retVal;
        }
    }
}

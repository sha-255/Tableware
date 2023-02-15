using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace Tableware01.Tests
{
    [TestClass]
    public class DataBaseTest
    {
        private string selectQuery = 
            $"SELECT Number, Name, Password from Users where Name = 'a'";

        /// <summary>
        /// Test current connection to Server.
        /// </summary>
        [TestMethod]
        public void Connetion()
        {
            //Arrange
            var currentConnetion = false;
            //Act
            currentConnetion = DataBase.IsConnect;
            //Assert
            Assert.AreEqual(true, currentConnetion);
        }

        [TestMethod]
        public void CheckDataSeach()
        {
            var hasInDatabase = false;
            hasInDatabase = DataBase.TrySelect(selectQuery);
            Assert.AreEqual(true, hasInDatabase);
        }

        [TestMethod]
        public void CheckTable()
        {
            var data = new List<string[]>()
            {
                new []
                {
                    "1", "a", "a"
                }
            };
            var headers = new[] { "№", "Имя", "Пароль" };
            var expected = (data, headers);
            var query = selectQuery;
            var actual = DataBase.GetTable(query, headers);
            CheckTableAssert(expected, actual);
        }

        private static void CheckTableAssert((List<string[]> data, string[] headers) expected, (List<string[]> data, string[] headers) actual)
        {
            Assert.AreEqual(expected.data.Count, actual.data.Count);
            for (var i = 0; i < expected.data.Count; i++)
                Assert.AreEqual(expected.data[i].Length, actual.data[i].Length);
            for (var i = 0; i < expected.data.Count; i++)
                for (var j = 0; j < expected.data[i].Length; j++)
                    Assert.AreEqual(expected.data[i][j], actual.data[i][j]);
            Assert.AreEqual(expected.headers, actual.headers);
        }
    }
}
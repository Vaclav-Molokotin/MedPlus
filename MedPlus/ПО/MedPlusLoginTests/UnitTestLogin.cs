using MedPlus.Data.DataBaseModel;
using MedPlus.Libs;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace MedPlusLoginTests
{
    /// <summary>
    /// Класс для тестирования модуля входа в систему.
    /// </summary>
    [TestClass]
    public class UnitTestLogin
    {
        /// <summary>
        /// Метод. Проводит позитивное тестирование метода GetUserByLoginPassword.
        /// </summary>
        [TestMethod]
        public void GetUserByLoginPassword_Login_rom_rad_Password_123_NotNullReturned()
        {
            // arrange
            string login = "rom_rad";
            string password = "123";
            // act
            User result = LibUser.GetUserByLoginPassword(login, password);
            // assert
            Assert.IsNotNull(result);
        }

        /// <summary>
        /// Метод. Проводит негативное тестирование метода GetUserByLoginPassword.
        /// </summary>
        [TestMethod]
        public void GetUserByLoginPassword_Login_Rom_Rad_Password_123_NullReturned()
        {
            // arrange
            string login = "Rom_Rad";
            string password = "123";
            // act
            User result = LibUser.GetUserByLoginPassword(login, password);
            // assert
            Assert.IsNull(result);
        }
    }
}

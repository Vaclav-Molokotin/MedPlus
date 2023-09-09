using MedPlus.Data.DataBaseModel;
using MedPlus.Libs.DB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace MedPlus.Libs
{
    public static class LibUser
    {
        public static User CurrentUser;
        public static string GetFullName(User user)
        {
            return $"{user.LName} {user.FName} {user.MName}";
        }
        /// <summary>
        /// Статический метод. Получает пользователя по указанному логину и паролю. При остутствии результатов возвращает NULL
        /// </summary>
        /// <param name="login"></param>
        /// <param name="password"></param>
        /// <returns>Пользователь с указанным логином и паролем либо NULL, если такой пользователь не найден</returns>
        public static User GetUserByLoginPassword(string login, string password)
        {
            password = getMD5Hash(password);
            List<User> results = LibDB.GetContext().Users.Where(p => p.Login == login && p.Password == password).ToList();
            if (results.Count > 0 && login == results[0].Login)
                return results[0];
            return null;
        }

        private static string getMD5Hash(string password)
        {
            MD5 md5 = MD5.Create();
            byte[] data = md5.ComputeHash(Encoding.UTF8.GetBytes(password));

            StringBuilder result = new StringBuilder();

            for (int i = 0; i < data.Length; i++)
            {
                result.Append(data[i].ToString("x2"));
            }
            return result.ToString();
        }
    }
}

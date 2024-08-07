using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASS2_PROGRAMING__
{
    internal class User
    {
        private static string[,] users = new string[100, 2]; // Giả sử lưu tối đa 100 người dùng
        private static int userCount = 0;

        // Thêm người dùng vào mảng
        public static void AddUser(string username, string password)
        {
            if (userCount < users.GetLength(0))
            {
                users[userCount, 0] = username;
                users[userCount, 1] = password;
                userCount++;
            }
        }

        // Kiểm tra thông tin người dùng
        public static bool ValidateUser(string username, string password)
        {
            for (int i = 0; i < userCount; i++)
            {
                if (users[i, 0] == username && users[i, 1] == password)
                {
                    return true;
                }
            }
            return false;
        }
    }
}

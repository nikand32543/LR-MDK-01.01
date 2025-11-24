

using System;

namespace Диски
{
    class userRequest
    {
        static public string InputUserRequest() /// ввод запроса пользователя
        {
            Console.WriteLine("Введите локальный диск (Диск C или Диск D): ");
            return Console.ReadLine();
        }
    }
}

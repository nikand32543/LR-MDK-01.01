using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestFileStorage
{
    public class FileUserStorage : IUserInterface
    {
        public List<User> Load()
        {
            List<User> allUser = new List<User>();
            string path = @"D:\repo Andrianov\TestFileStorage\info.txt";
            StreamReader SR = new StreamReader(path);

            string line;

            while((line = SR.ReadLine()) != null)
            {
                string[] lines = line.Split('-');
                allUser.Add(new User(lines[0], lines[1]));
            }
            return allUser;
        }
    }
}

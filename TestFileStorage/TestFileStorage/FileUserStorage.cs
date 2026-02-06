using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

        public bool UserRegistration(User u)
        {
            string line = "D:\\repo Andrianov\\TestFileStorage\\info.txt";
            return 
        }

        public bool UserVerification(string log)
        {
            List<User> loginIdentification = Load();
            foreach(User u in loginIdentification)
            {
                if (u.Login == log)
                {
                    return true;
                }
            }
            return false;
        }

       
    }
}

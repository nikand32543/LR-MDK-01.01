using System.Collections.Generic;

namespace TestFileStorage
{
    public interface IUserInterface
    {
        List<User> Load();

        bool UserVerification(string log);
        bool UserRegistration(User u);
    }
}

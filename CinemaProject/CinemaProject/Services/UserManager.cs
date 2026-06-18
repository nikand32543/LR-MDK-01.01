using CinemaProject.Models;
using CinemaProject.Services;
using CinemaProject.Repositories;
using System.Collections.Generic;

namespace CinemaProject.Managers
{
    public class UserManager
    {
        private List<User> users_ = new List<User>();
        private User currentUser_ = new User();
        private readonly UserRepository _repo = new UserRepository();

        public User CurrentUser
        {
            get { return currentUser_; }
        }

        public bool Register(string login, string password)
        {
            if (_repo.IsLoginExists(login)) return false;
            _repo.RegisterUser(login, password, "User");
            return true;
        }

        public User Authenticate(string login, string password)
        {
            User user = _repo.Authenticate(login, password);
            if (user != null)
            {
                user.History = _repo.GetUserHistory(user.Id);
                currentUser_ = user;
                return currentUser_;
            }
            return null;
        }

        public void AddToHistory(int movieId)
        {
            if (currentUser_ == null) return;
            _repo.AddToHistory(currentUser_.Id, movieId);
            if (!currentUser_.History.Contains(movieId))
            {
                currentUser_.History.Add(movieId);
            }
        }

        public List<Movie> GetPersonalRecommendations(MovieManager movieManager)
        {
            return _repo.GetPersonalRecommendations(currentUser_.Id);
        }
    }
}
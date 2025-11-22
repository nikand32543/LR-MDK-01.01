

namespace NFSConsoleApp
{
    public class Car
    {
        private string model_;
        private int speed_;

        public string GetModel()
        {
            return model_;
        }
        public void SetModel(string model)
        {
            model_ = model;
        }
        public int GetSpeed()
        {
            return speed_;
        }
        public void SetSpeed(int speed)
        {
            speed_ = speed;
        }
    }
}

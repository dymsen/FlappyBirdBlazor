using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Dynamic;
using System.Linq;
using System.Threading.Tasks;

namespace FlappyBirdDemo.Web.Models
{
    public class GameManager : INotifyPropertyChanged
    {
        private readonly int _gravity = 2;

        public event PropertyChangedEventHandler PropertyChanged;

        public BirdModel Bird { get; set; }
        public bool IsRunning { get; set; } = false;
        public GameManager()
        {
            Bird = new BirdModel();
        }

        public async void MainLoop()
        {
            IsRunning = true;
            while (IsRunning)
            {
                Bird.Fall(_gravity);
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Bird)));

                if (Bird.DistanceFromGround <= 0)
                {
                    IsRunning = false;
                }

                await Task.Delay(20);
            }
        }
    }
}

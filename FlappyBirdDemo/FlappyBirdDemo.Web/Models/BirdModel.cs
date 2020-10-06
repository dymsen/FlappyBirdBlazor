﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FlappyBirdDemo.Web.Models
{
    public class BirdModel
    {
        public int DistanceFromGround { get; private set; } = 100;
        public int JumpStrength { get; private set; } = 50;

        public void Fall(int gravity)
        {
            DistanceFromGround -= gravity;  
        }
        public void Jump()
        {
            if (DistanceFromGround <= 530)
                DistanceFromGround += JumpStrength;
        }
    }
}

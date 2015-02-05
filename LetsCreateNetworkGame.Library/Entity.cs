﻿//------------------------------------------------------
// 
// Copyright - (c) - 2014 - Mille Boström 
//
// Youtube channel - https://www.youtube.com/user/Maloooon
//------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LetsCreateNetworkGame.Library
{
    public class Entity
    {
        public Position Position { get; set; }

        public Entity(Position position)
        {
            Position = position;
        }

        public Entity() { }

        public virtual void Update(double gameTime)
        {
            
        }
    }
}

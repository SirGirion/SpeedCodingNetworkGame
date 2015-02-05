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

namespace LetsCreateNetworkGame.Library.AI.Movement
{
    class RandomMovement : BaseMovement
    {

        private double _frequency;
        private double _count;
        private Direction _direction;
        private Random _rnd;
        private int _speed; 

        public RandomMovement(Position position) : base(position)
        {
            _frequency = 200;
            _count = 0;
            _rnd = new Random();
            _direction = (Direction) _rnd.Next(0, 3);
            _speed = 1; 
        }

        public override void Update(double gameTime)
        {
            _count += gameTime;
            if (_count > _frequency)
            {
                _direction = (Direction) _rnd.Next(0, 3);
                _count = 0; 
            }

            switch (_direction)
            {
                case Direction.Left:
                    Position.XPosition -= _speed; 
                    break;
                case Direction.Right:
                    Position.XPosition += _speed; 
                    break;
                case Direction.Up:
                    Position.YPosition -= _speed;
                    break;
                case Direction.Down:
                    Position.YPosition += _speed; 
                    break;
                default:
                    throw new ArgumentOutOfRangeException();
            }
        }
    }
}

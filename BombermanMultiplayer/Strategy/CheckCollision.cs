using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using System.Media;
using System.Diagnostics;
using System.Collections;
using BombermanMultiplayer.Objects;

namespace BombermanMultiplayer
{
    public class CheckCollision
    {
        private ICheckCollisionStrategy _strategy;
        public CheckCollision(ICheckCollisionStrategy chosenStrategy)
        {
            _strategy = chosenStrategy;
        }
        public bool CheckDirection(Player movingPlayer, Player player2, Tile[,] map)
        {
            return _strategy.CheckDirection(movingPlayer, player2, map);
        }
    }
}

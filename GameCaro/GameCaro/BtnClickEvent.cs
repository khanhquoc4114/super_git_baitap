﻿using System;
using System.Drawing;

namespace GameCaro
{
    internal class BtnClickEvent : EventArgs
    {
        private Point clickedPoint;

        public Point ClickedPoint { get => clickedPoint; set => clickedPoint = value; }
        public BtnClickEvent(Point clickedPoint)
        {
            this.ClickedPoint = clickedPoint;
        }
    }
}

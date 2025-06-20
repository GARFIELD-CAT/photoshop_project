﻿using System;
using System.Drawing;


namespace MyPhotoshop
{
	public class RotateTransformer : ITransformer<RotationParameters>
    {
        public Size OriginalSize { get; private set; }
        public Size ResultSize { get; private set; }
        public double Angle { get; private set; }

        public void Prepare(Size size, RotationParameters parameters)
        {
            OriginalSize = size;

            Angle = Math.PI * parameters.Angle / 180;
            ResultSize = new Size(
                (int)(size.Width * Math.Abs(Math.Cos(Angle)) + size.Height * Math.Abs(Math.Sin(Angle))),
                (int)(size.Height * Math.Abs(Math.Cos(Angle)) + size.Width * Math.Abs(Math.Sin(Angle)))
                );
        }
        
        public Point? MapPoint(Point newPoint)
        {
            var newSize = ResultSize;
            var angle = Angle;
            var oldSize = OriginalSize;

            var point = new Point(newPoint.X - newSize.Width / 2, newPoint.Y - newSize.Height / 2);
            var x = oldSize.Width / 2 + (int)(point.X * Math.Cos(angle) + point.Y * Math.Sin(angle));
            var y = oldSize.Height / 2 + (int)(-point.X * Math.Sin(angle) + point.Y * Math.Cos(angle));

            if (x < 0 || x >= oldSize.Width || y < 0 || y >= oldSize.Height) return null;

            return new Point(x, y);
        }
	}
}
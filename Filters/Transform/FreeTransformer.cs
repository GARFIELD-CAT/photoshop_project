using System;
using System.Drawing;


namespace MyPhotoshop
{
    public class FreeTransformer : ITransformer<EmptyParameters>
    {
        Func<Size, Size> sizeTransformer;
        Func<Point, Size, Point> pointTransformer;

        public Size OldSize { get; private set; }
        public Size ResultSize { get; private set; }

        public FreeTransformer(Func<Size, Size> sizeTransformer, Func<Point, Size, Point> pointTransformer)
        {
            this.sizeTransformer = sizeTransformer;
            this.pointTransformer = pointTransformer;
        }

        public void Prepare(Size size, EmptyParameters parameters)
        {
            OldSize = size;
            ResultSize = sizeTransformer(OldSize);
        }

        public Point? MapPoint(Point newPoint)
        {
            return pointTransformer(newPoint, OldSize);
        }



    }
}

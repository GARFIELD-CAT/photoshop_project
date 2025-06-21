using System;
using System.Drawing;

namespace MyPhotoshop
{
    public class TransformFilter : TransformFilter<EmptyParameters>
    {
        public TransformFilter(string name, Func<Size, Size> sizeTransform, Func<Point, Size, Point> pointTransformer)
            : base(name, new FreeTransformer(sizeTransform, pointTransformer)) { }
  
        public override string ToString()
        {
            return name;
        }
    }
}

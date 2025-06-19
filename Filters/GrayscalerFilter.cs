using System;
using System.Reflection;

namespace MyPhotoshop
{
    public class GrayscalerFilter : PixelFilter
    {
        public GrayscalerFilter() : base(new EmptyParameters()) { }

        public override string ToString()
        {
            return "50 оттенков серого / СПб скай";
        }

        public override Pixel ProcessPixel(Pixel original, IParameters parameters)
        {
            var lightness = original.R + original.G + original.B;
            lightness /= 3;

            return new Pixel(lightness, lightness, lightness);
        }
    }
}


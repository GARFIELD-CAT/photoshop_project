using System;
using System.Reflection;

namespace MyPhotoshop
{
    public class GrayscalerFilter : PixelFilter<EmptyParameters>
    {
        public override string ToString()
        {
            return "50 оттенков серого / СПб скай";
        }

        public override Pixel ProcessPixel(Pixel original, EmptyParameters parameters)
        {
            var lightness = original.R + original.G + original.B;
            lightness /= 3;

            return new Pixel(lightness, lightness, lightness);
        }
    }
}


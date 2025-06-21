using System;

namespace MyPhotoshop
{
	public class RotationParameters: IParameters
    {
        [ParameterInfo(Name = "����", MaxValue = 360, MinValue = 0, Increment = 5, DefaultValue = 0)]
        public double Angle { get; set; }
    }
}


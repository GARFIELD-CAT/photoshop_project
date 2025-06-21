using System;
using System.Reflection;

namespace MyPhotoshop
{
	public class LighteningParameters: IParameters
    {
        [ParameterInfo(Name = "�����������", MaxValue = 10, MinValue = 0, Increment = 0.1, DefaultValue = 1)]
        public double Coefficient { get; set; }
    }
}


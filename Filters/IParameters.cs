using System;
using System.Reflection;

namespace MyPhotoshop
{
	public interface IParameters
	{
        ParameterInfo[] GetDescription();
        void SetValues(double[] values);
    }
}


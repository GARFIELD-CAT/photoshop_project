using System;
using System.Reflection;
using System.Linq;
using System.Runtime.CompilerServices;


namespace MyPhotoshop
{
	public static class ParametersExtentions
	{
		public static ParameterInfo[] GetDescription(this IParameters parameters)
		{
            return parameters
                .GetType()
                .GetProperties()
                .Select(z => z.GetCustomAttributes(typeof(ParameterInfo), false))
                .Where(z => z.Length > 0)
                .Select(z => z[0])
                .Cast<ParameterInfo>()
                .ToArray();
        }

        public static void SetValues(this IParameters parameters, double[] values)
		{
            var properties = parameters
                .GetType()
                .GetProperties()
                .Where(z => z.GetCustomAttributes(typeof(ParameterInfo), false).Length > 0)
                .ToArray();

            for (int i = 0; i < values.Length; i++)
            {
                properties[i].SetValue(parameters, values[i], new object[0]);
            }
        }
    }
}
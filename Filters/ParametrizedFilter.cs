using System;
using System.Reflection;

namespace MyPhotoshop
{
	public abstract class ParametrizedFilter : IFilter
    {
        IParameters parameters;

        public ParametrizedFilter(IParameters parameters)
        {
            this.parameters = parameters;
        }


        public ParameterInfo[] GetParameters()
        {
            return parameters.GetDescription();
        }

        public Photo Process(Photo original, double[] values)
        {
            this.parameters.SetValues(values);
            return Process(original, this.parameters);
        }

        public abstract Photo Process(Photo original, IParameters parameters);
    }
}


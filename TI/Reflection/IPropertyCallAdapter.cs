using System;
using System.Reflection;

namespace TI.Reflection
{
	public interface IPropertyCallAdapter<TThis>
	{
		object InvokeGet(TThis @this);
		void InvokeSet(TThis @this, Object value);

		MethodInfo getGetter();
		MethodInfo getSetter();
	}
}


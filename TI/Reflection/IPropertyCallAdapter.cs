using System;

namespace TI.Reflection
{
	public interface IPropertyCallAdapter<TThis>
	{
		object InvokeGet(TThis @this);
		void InvokeSet(TThis @this, Object value);
	}
}


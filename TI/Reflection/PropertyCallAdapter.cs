using System;

namespace TI.Reflection
{
	public class PropertyCallAdapter<TThis, TResult> : IPropertyCallAdapter<TThis>
	{
		private readonly Func<TThis, TResult> _getterInvocation;
		private readonly Action<TThis, Object> _setterInvocation;

		public PropertyCallAdapter(Func<TThis, TResult> getterInvocation,  Action<TThis, Object> setterInvocation)
		{
			_getterInvocation = getterInvocation;
			_setterInvocation = setterInvocation;
		}

		public object InvokeGet(TThis @this)
		{
			return _getterInvocation.Invoke(@this);
		}

		public void InvokeSet (TThis @this, Object value)
		{
			_setterInvocation.Invoke (@this, value);
		}
	}
}


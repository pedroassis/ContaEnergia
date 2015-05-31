using System;
using System.Reflection;

namespace TI.Reflection
{
	public class PropertyCallAdapter<TThis, TResult> : IPropertyCallAdapter<TThis>
	{
		private readonly Func<TThis, TResult> _getterInvocation;
		private readonly Action<TThis, Object> _setterInvocation;

		private readonly MethodInfo getter;
		private readonly MethodInfo setter;

		public PropertyCallAdapter(
			Func<TThis, TResult> getterInvocation,  
			Action<TThis, Object> setterInvocation,
			MethodInfo getter,
			MethodInfo setter)
		{
			_getterInvocation = getterInvocation;
			_setterInvocation = setterInvocation;
			this.getter = getter;
			this.setter = setter;
		}

		public object InvokeGet(TThis @this)
		{
			return _getterInvocation.Invoke(@this);
		}

		public void InvokeSet (TThis @this, Object value)
		{
			_setterInvocation.Invoke (@this, value);
		}

		public MethodInfo getGetter ()
		{
			return getter;
		}

		public MethodInfo getSetter ()
		{
			return setter;
		}
	}
}


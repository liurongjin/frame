using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Linq.Expressions;

namespace sct.cm.data
{
	public static class Extensions
	{
		public static void ForEach<T>(this IEnumerable<T> source, Action<T> action)
		{
			foreach (T element in source)
				action(element);
		}

		/// <summary>
		/// 如果类型是Nullable&lt;T&gt;，则返回T，否则返回自身
		/// </summary>
		/// <param name="type"></param>
		/// <returns></returns>
		public static Type GetNonNullableType(this Type type)
		{
			if (IsNullableType(type))
			{
				return type.GetGenericArguments()[0];
			}
			return type;
		}

		/// <summary>
		/// 是否Nullable&lt;T&gt;类型
		/// </summary>
		/// <param name="type"></param>
		/// <returns></returns>
		public static bool IsNullableType(this Type type)
		{
			return type != null && type.IsGenericType && type.GetGenericTypeDefinition() == typeof(Nullable<>);
		}

		/// <summary>
		/// 获取Lambda表达式的参数表达式
		/// </summary>
		/// <typeparam name="T"></typeparam>
		/// <typeparam name="S"></typeparam>
		/// <param name="expr"></param>
		/// <returns></returns>
		public static ParameterExpression[] GetParameters<T, S>(this Expression<Func<T, S>> expr)
		{
			return expr.Parameters.ToArray();
		}
	}
}

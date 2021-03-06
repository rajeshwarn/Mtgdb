using System;
using System.Collections.Generic;
using System.Linq;

namespace Mtgdb
{
	public static class CollectionExtensions
	{
		public static TVal TryGet<TKey, TVal>(this IDictionary<TKey, TVal> dict, TKey key)
		{
			if (key == null)
				return default;

			dict.TryGetValue(key, out var val);

			return val;
		}

		public static TVal TryGet<TKey, TVal>(this IDictionary<TKey, TVal> dict, TKey key, TVal defaultValue)
		{
			if (key == null)
				return defaultValue;

			dict.TryGetValue(key, out var val);

			return val;
		}

		public static TVal TryPeek<TVal>(this Stack<TVal> stack)
		{
			if (stack.Count == 0)
				return default;

			return stack.Peek();
		}

		public static TVal Get<TVal>(this HashSet<TVal> collection, TVal value)
		{
			var result = collection.First(_ => collection.Comparer.Equals(_, value));
			return result;
		}

		public static bool Contains<TVal>(this HashSet<TVal> collection, TVal? value)
			where TVal : struct
		{
			return value.HasValue && collection.Contains(value.Value);
		}

		public static char? TryGetFirst(this string value)
		{
			if (string.IsNullOrEmpty(value))
				return null;

			return value[0];
		}

		public static char? TryGetLast(this string value)
		{
			if (string.IsNullOrEmpty(value))
				return null;

			return value[value.Length - 1];
		}

		public static TVal TryGetLast<TVal>(this IList<TVal> list)
		{
			if (list.Count == 0)
				return default;

			return list[list.Count - 1];
		}

		public static List<TVal> SkipFirst<TVal>(this List<TVal> list, int countToSkip)
		{
			if (countToSkip <= 0)
				return list;

			var result = new List<TVal>();
			result.AddRange(list.Skip(countToSkip));

			return result;
		}

		public static List<TVal> TakeFirst<TVal>(this List<TVal> list, int countToTake)
		{
			if (countToTake == list.Count)
				return list;

			var result = new List<TVal>();
			result.AddRange(list.Take(countToTake));

			return result;
		}

		public static TVal TryGet<TVal>(this IList<TVal> list, int index)
		{
			if (index < 0 || index >= list.Count)
				return default;

			return list[index];
		}

		public static Dictionary<TKey, TVal> ToDictionary<TKey, TVal>(
			this IEnumerable<KeyValuePair<TKey, TVal>> dict,
			IEqualityComparer<TKey> equalityComparer = null)
		{
			if (equalityComparer == null)
				return dict.ToDictionary(_ => _.Key, _ => _.Value);

			return dict.ToDictionary(_ => _.Key, _ => _.Value, equalityComparer);
		}

		public static bool IsEqualTo<TKey, TVal>(this Dictionary<TKey, TVal> dict, Dictionary<TKey, TVal> dict2)
		{
			if ((dict?.Count ?? 0) != (dict2?.Count ?? 0))
				return false;

			if ((dict?.Count ?? 0) == 0)
				return true;

			// ReSharper disable PossibleNullReferenceException
			foreach (var pair in dict)
			{
				if (!dict2.TryGetValue(pair.Key, out var value2))
					return false;

				// ReSharper enable PossibleNullReferenceException
				if (!value2.Equals(pair.Value))
					return false;
			}

			return true;
		}


		public static string Non(this string value, string empty)
		{
			if (value == empty)
				return null;

			return value;
		}

		public static IList<TVal> NonEmpty<TVal>(this IList<TVal> value)
		{
			if (value.Count == 0)
				return null;

			return value;
		}

		public static ICollection<TVal> NonEmpty<TVal>(this ICollection<TVal> value)
		{
			if (value.Count == 0)
				return null;

			return value;
		}

		public static List<TVal> NonEmpty<TVal>(this List<TVal> value)
		{
			if (value.Count == 0)
				return null;

			return value;
		}

		public static TResult Invoke<TObj, TParam, TResult>(this TObj target, Func<TObj, TParam, TResult> getter, TParam param) =>
			getter(target, param);

		public static TResult Invoke2<TObj, TParam, TResult>(this TObj target, Func<TParam, TObj, TResult> getter, TParam param) =>
			getter(param, target);

		public static TResult InvokeMethod<TObj, TResult>(this TObj target, Func<TObj, TResult> getter)
		{
			return getter(target);
		}

		public static IOrderedEnumerable<TVal> OrderBy<TVal>(this IEnumerable<TVal> sequence, IComparer<TVal> comparer) =>
			sequence.OrderBy(_ => _, comparer);

		public static IOrderedEnumerable<TVal> ThenBy<TVal>(this IOrderedEnumerable<TVal> sequence, IComparer<TVal> comparer) =>
			sequence.ThenBy(_ => _, comparer);

		public static void UnionWithNullable<T>(this HashSet<T> set, IEnumerable<T> values)
		{
			if (values == null)
				return;

			set.UnionWith(values);
		}

		public static IEnumerable<T> Append<T>(this IEnumerable<T> sequence, T value) => sequence.Concat(Sequence.From(value));

		public static IEnumerable<T> Prepend<T>(this IEnumerable<T> sequence, T value) => Sequence.From(value).Concat(sequence);

		public static HashSet<T> ToHashSet<T>(this IEnumerable<T> sequence) => 
			new HashSet<T>(sequence);

		public static HashSet<T> ToHashSet<T>(this IEnumerable<T> sequence, IEqualityComparer<T> comparer) => 
			new HashSet<T>(sequence, comparer);

		public static int IndexOf<T>(this IList<T> list, T value, IEqualityComparer<T> comparer)
		{
			for (int i = 0; i < list.Count; i++)
				if (comparer.Equals(list[i], value))
					return i;

			return -1;
		}

		public static MultiDictionary<TKey, TSource> ToMultiDictionary<TKey, TSource>(
			this IEnumerable<TSource> vals,
			Func<TSource, TKey> keySelector,
			IEqualityComparer<TKey> keyComparer = null,
			IEqualityComparer<TSource> valComparer = null) =>
			ToMultiDictionary(vals, keySelector, val => val, keyComparer, valComparer);

		public static MultiDictionary<TKey, TVal> ToMultiDictionary<TKey, TVal, TSource>(
			this IEnumerable<TSource> vals,
			Func<TSource, TKey> keySelector,
			Func<TSource, TVal> valSelector,
			IEqualityComparer<TKey> keyComparer = null,
			IEqualityComparer<TVal> valComparer = null)
		{
			var result = new MultiDictionary<TKey, TVal>(keyComparer, valComparer);

			foreach (var srcVal in vals)
			{
				var key = keySelector(srcVal);
				var val = valSelector(srcVal);

				result.Add(key, val);
			}

			return result;
		}
	}
}
#define DEBUG
using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace KoiVM.Core.Helpers.System;

public static class Tuple
{
	public static Tuple<T1> Create<T1>(T1 item1)
	{
		return new Tuple<T1>(item1);
	}

	public static Tuple<T1, T2> Create<T1, T2>(T1 item1, T2 item2)
	{
		return new Tuple<T1, T2>(item1, item2);
	}

	public static Tuple<T1, T2, T3> Create<T1, T2, T3>(T1 item1, T2 item2, T3 item3)
	{
		return new Tuple<T1, T2, T3>(item1, item2, item3);
	}

	public static Tuple<T1, T2, T3, T4> Create<T1, T2, T3, T4>(T1 item1, T2 item2, T3 item3, T4 item4)
	{
		return new Tuple<T1, T2, T3, T4>(item1, item2, item3, item4);
	}

	public static Tuple<T1, T2, T3, T4, T5> Create<T1, T2, T3, T4, T5>(T1 item1, T2 item2, T3 item3, T4 item4, T5 item5)
	{
		return new Tuple<T1, T2, T3, T4, T5>(item1, item2, item3, item4, item5);
	}

	public static Tuple<T1, T2, T3, T4, T5, T6> Create<T1, T2, T3, T4, T5, T6>(T1 item1, T2 item2, T3 item3, T4 item4, T5 item5, T6 item6)
	{
		return new Tuple<T1, T2, T3, T4, T5, T6>(item1, item2, item3, item4, item5, item6);
	}

	public static Tuple<T1, T2, T3, T4, T5, T6, T7> Create<T1, T2, T3, T4, T5, T6, T7>(T1 item1, T2 item2, T3 item3, T4 item4, T5 item5, T6 item6, T7 item7)
	{
		return new Tuple<T1, T2, T3, T4, T5, T6, T7>(item1, item2, item3, item4, item5, item6, item7);
	}

	public static Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8>> Create<T1, T2, T3, T4, T5, T6, T7, T8>(T1 item1, T2 item2, T3 item3, T4 item4, T5 item5, T6 item6, T7 item7, T8 item8)
	{
		return new Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8>>(item1, item2, item3, item4, item5, item6, item7, new Tuple<T8>(item8));
	}

	internal static int CombineHashCodes(int h1, int h2)
	{
		return ((h1 << 5) + h1) ^ h2;
	}

	internal static int CombineHashCodes(int h1, int h2, int h3)
	{
		return CombineHashCodes(CombineHashCodes(h1, h2), h3);
	}

	internal static int CombineHashCodes(int h1, int h2, int h3, int h4)
	{
		return CombineHashCodes(CombineHashCodes(h1, h2), CombineHashCodes(h3, h4));
	}

	internal static int CombineHashCodes(int h1, int h2, int h3, int h4, int h5)
	{
		return CombineHashCodes(CombineHashCodes(h1, h2, h3, h4), h5);
	}

	internal static int CombineHashCodes(int h1, int h2, int h3, int h4, int h5, int h6)
	{
		return CombineHashCodes(CombineHashCodes(h1, h2, h3, h4), CombineHashCodes(h5, h6));
	}

	internal static int CombineHashCodes(int h1, int h2, int h3, int h4, int h5, int h6, int h7)
	{
		return CombineHashCodes(CombineHashCodes(h1, h2, h3, h4), CombineHashCodes(h5, h6, h7));
	}

	internal static int CombineHashCodes(int h1, int h2, int h3, int h4, int h5, int h6, int h7, int h8)
	{
		return CombineHashCodes(CombineHashCodes(h1, h2, h3, h4), CombineHashCodes(h5, h6, h7, h8));
	}
}
[Serializable]
public class Tuple<T1> : IStructuralEquatable, IStructuralComparable, IComparable, ITuple
{
	private readonly T1 m_Item1;

	public T1 Item1 => m_Item1;

	int ITuple.Size => 1;

	public Tuple(T1 item1)
	{
		m_Item1 = item1;
	}

	public override bool Equals(object obj)
	{
		return ((IStructuralEquatable)this).Equals(obj, (IEqualityComparer)EqualityComparer<object>.Default);
	}

	bool IStructuralEquatable.Equals(object other, IEqualityComparer comparer)
	{
		if (other == null)
		{
			return false;
		}
		if (!(other is Tuple<T1> tuple))
		{
			return false;
		}
		return comparer.Equals(m_Item1, tuple.m_Item1);
	}

	int IComparable.CompareTo(object obj)
	{
		return ((IStructuralComparable)this).CompareTo(obj, (IComparer)Comparer<object>.Default);
	}

	int IStructuralComparable.CompareTo(object other, IComparer comparer)
	{
		if (other == null)
		{
			return 1;
		}
		if (!(other is Tuple<T1> tuple))
		{
			throw new ArgumentException($"Argument must be of type {GetType().ToString()}.", "other");
		}
		return comparer.Compare(m_Item1, tuple.m_Item1);
	}

	public override int GetHashCode()
	{
		return ((IStructuralEquatable)this).GetHashCode((IEqualityComparer)EqualityComparer<object>.Default);
	}

	int IStructuralEquatable.GetHashCode(IEqualityComparer comparer)
	{
		return comparer.GetHashCode(m_Item1);
	}

	int ITuple.GetHashCode(IEqualityComparer comparer)
	{
		return ((IStructuralEquatable)this).GetHashCode(comparer);
	}

	public override string ToString()
	{
		StringBuilder stringBuilder = new StringBuilder();
		stringBuilder.Append("(");
		return ((ITuple)this).ToString(stringBuilder);
	}

	string ITuple.ToString(StringBuilder sb)
	{
		sb.Append(m_Item1);
		sb.Append(")");
		return sb.ToString();
	}
}
[Serializable]
public class Tuple<T1, T2> : IStructuralEquatable, IStructuralComparable, IComparable, ITuple
{
	private readonly T1 m_Item1;

	private readonly T2 m_Item2;

	public T1 Item1 => m_Item1;

	public T2 Item2 => m_Item2;

	int ITuple.Size => 2;

	public Tuple(T1 item1, T2 item2)
	{
		m_Item1 = item1;
		m_Item2 = item2;
	}

	public override bool Equals(object obj)
	{
		return ((IStructuralEquatable)this).Equals(obj, (IEqualityComparer)EqualityComparer<object>.Default);
	}

	bool IStructuralEquatable.Equals(object other, IEqualityComparer comparer)
	{
		if (other == null)
		{
			return false;
		}
		if (!(other is Tuple<T1, T2> tuple))
		{
			return false;
		}
		return comparer.Equals(m_Item1, tuple.m_Item1) && comparer.Equals(m_Item2, tuple.m_Item2);
	}

	int IComparable.CompareTo(object obj)
	{
		return ((IStructuralComparable)this).CompareTo(obj, (IComparer)Comparer<object>.Default);
	}

	int IStructuralComparable.CompareTo(object other, IComparer comparer)
	{
		if (other == null)
		{
			return 1;
		}
		if (!(other is Tuple<T1, T2> tuple))
		{
			throw new ArgumentException($"Argument must be of type {GetType().ToString()}.", "other");
		}
		int num = 0;
		num = comparer.Compare(m_Item1, tuple.m_Item1);
		if (num != 0)
		{
			return num;
		}
		return comparer.Compare(m_Item2, tuple.m_Item2);
	}

	public override int GetHashCode()
	{
		return ((IStructuralEquatable)this).GetHashCode((IEqualityComparer)EqualityComparer<object>.Default);
	}

	int IStructuralEquatable.GetHashCode(IEqualityComparer comparer)
	{
		return Tuple.CombineHashCodes(comparer.GetHashCode(m_Item1), comparer.GetHashCode(m_Item2));
	}

	int ITuple.GetHashCode(IEqualityComparer comparer)
	{
		return ((IStructuralEquatable)this).GetHashCode(comparer);
	}

	public override string ToString()
	{
		StringBuilder stringBuilder = new StringBuilder();
		stringBuilder.Append("(");
		return ((ITuple)this).ToString(stringBuilder);
	}

	string ITuple.ToString(StringBuilder sb)
	{
		sb.Append(m_Item1);
		sb.Append(", ");
		sb.Append(m_Item2);
		sb.Append(")");
		return sb.ToString();
	}
}
[Serializable]
public class Tuple<T1, T2, T3> : IStructuralEquatable, IStructuralComparable, IComparable, ITuple
{
	private readonly T1 m_Item1;

	private readonly T2 m_Item2;

	private readonly T3 m_Item3;

	public T1 Item1 => m_Item1;

	public T2 Item2 => m_Item2;

	public T3 Item3 => m_Item3;

	int ITuple.Size => 3;

	public Tuple(T1 item1, T2 item2, T3 item3)
	{
		m_Item1 = item1;
		m_Item2 = item2;
		m_Item3 = item3;
	}

	public override bool Equals(object obj)
	{
		return ((IStructuralEquatable)this).Equals(obj, (IEqualityComparer)EqualityComparer<object>.Default);
	}

	bool IStructuralEquatable.Equals(object other, IEqualityComparer comparer)
	{
		if (other == null)
		{
			return false;
		}
		if (!(other is Tuple<T1, T2, T3> tuple))
		{
			return false;
		}
		return comparer.Equals(m_Item1, tuple.m_Item1) && comparer.Equals(m_Item2, tuple.m_Item2) && comparer.Equals(m_Item3, tuple.m_Item3);
	}

	int IComparable.CompareTo(object obj)
	{
		return ((IStructuralComparable)this).CompareTo(obj, (IComparer)Comparer<object>.Default);
	}

	int IStructuralComparable.CompareTo(object other, IComparer comparer)
	{
		if (other == null)
		{
			return 1;
		}
		if (!(other is Tuple<T1, T2, T3> tuple))
		{
			throw new ArgumentException($"Argument must be of type {GetType().ToString()}.", "other");
		}
		int num = 0;
		num = comparer.Compare(m_Item1, tuple.m_Item1);
		if (num != 0)
		{
			return num;
		}
		num = comparer.Compare(m_Item2, tuple.m_Item2);
		if (num != 0)
		{
			return num;
		}
		return comparer.Compare(m_Item3, tuple.m_Item3);
	}

	public override int GetHashCode()
	{
		return ((IStructuralEquatable)this).GetHashCode((IEqualityComparer)EqualityComparer<object>.Default);
	}

	int IStructuralEquatable.GetHashCode(IEqualityComparer comparer)
	{
		return Tuple.CombineHashCodes(comparer.GetHashCode(m_Item1), comparer.GetHashCode(m_Item2), comparer.GetHashCode(m_Item3));
	}

	int ITuple.GetHashCode(IEqualityComparer comparer)
	{
		return ((IStructuralEquatable)this).GetHashCode(comparer);
	}

	public override string ToString()
	{
		StringBuilder stringBuilder = new StringBuilder();
		stringBuilder.Append("(");
		return ((ITuple)this).ToString(stringBuilder);
	}

	string ITuple.ToString(StringBuilder sb)
	{
		sb.Append(m_Item1);
		sb.Append(", ");
		sb.Append(m_Item2);
		sb.Append(", ");
		sb.Append(m_Item3);
		sb.Append(")");
		return sb.ToString();
	}
}
[Serializable]
public class Tuple<T1, T2, T3, T4> : IStructuralEquatable, IStructuralComparable, IComparable, ITuple
{
	private readonly T1 m_Item1;

	private readonly T2 m_Item2;

	private readonly T3 m_Item3;

	private readonly T4 m_Item4;

	public T1 Item1 => m_Item1;

	public T2 Item2 => m_Item2;

	public T3 Item3 => m_Item3;

	public T4 Item4 => m_Item4;

	int ITuple.Size => 4;

	public Tuple(T1 item1, T2 item2, T3 item3, T4 item4)
	{
		m_Item1 = item1;
		m_Item2 = item2;
		m_Item3 = item3;
		m_Item4 = item4;
	}

	public override bool Equals(object obj)
	{
		return ((IStructuralEquatable)this).Equals(obj, (IEqualityComparer)EqualityComparer<object>.Default);
	}

	bool IStructuralEquatable.Equals(object other, IEqualityComparer comparer)
	{
		if (other == null)
		{
			return false;
		}
		if (!(other is Tuple<T1, T2, T3, T4> tuple))
		{
			return false;
		}
		return comparer.Equals(m_Item1, tuple.m_Item1) && comparer.Equals(m_Item2, tuple.m_Item2) && comparer.Equals(m_Item3, tuple.m_Item3) && comparer.Equals(m_Item4, tuple.m_Item4);
	}

	int IComparable.CompareTo(object obj)
	{
		return ((IStructuralComparable)this).CompareTo(obj, (IComparer)Comparer<object>.Default);
	}

	int IStructuralComparable.CompareTo(object other, IComparer comparer)
	{
		if (other == null)
		{
			return 1;
		}
		if (!(other is Tuple<T1, T2, T3, T4> tuple))
		{
			throw new ArgumentException($"Argument must be of type {GetType().ToString()}.", "other");
		}
		int num = 0;
		num = comparer.Compare(m_Item1, tuple.m_Item1);
		if (num != 0)
		{
			return num;
		}
		num = comparer.Compare(m_Item2, tuple.m_Item2);
		if (num != 0)
		{
			return num;
		}
		num = comparer.Compare(m_Item3, tuple.m_Item3);
		if (num != 0)
		{
			return num;
		}
		return comparer.Compare(m_Item4, tuple.m_Item4);
	}

	public override int GetHashCode()
	{
		return ((IStructuralEquatable)this).GetHashCode((IEqualityComparer)EqualityComparer<object>.Default);
	}

	int IStructuralEquatable.GetHashCode(IEqualityComparer comparer)
	{
		return Tuple.CombineHashCodes(comparer.GetHashCode(m_Item1), comparer.GetHashCode(m_Item2), comparer.GetHashCode(m_Item3), comparer.GetHashCode(m_Item4));
	}

	int ITuple.GetHashCode(IEqualityComparer comparer)
	{
		return ((IStructuralEquatable)this).GetHashCode(comparer);
	}

	public override string ToString()
	{
		StringBuilder stringBuilder = new StringBuilder();
		stringBuilder.Append("(");
		return ((ITuple)this).ToString(stringBuilder);
	}

	string ITuple.ToString(StringBuilder sb)
	{
		sb.Append(m_Item1);
		sb.Append(", ");
		sb.Append(m_Item2);
		sb.Append(", ");
		sb.Append(m_Item3);
		sb.Append(", ");
		sb.Append(m_Item4);
		sb.Append(")");
		return sb.ToString();
	}
}
[Serializable]
public class Tuple<T1, T2, T3, T4, T5> : IStructuralEquatable, IStructuralComparable, IComparable, ITuple
{
	private readonly T1 m_Item1;

	private readonly T2 m_Item2;

	private readonly T3 m_Item3;

	private readonly T4 m_Item4;

	private readonly T5 m_Item5;

	public T1 Item1 => m_Item1;

	public T2 Item2 => m_Item2;

	public T3 Item3 => m_Item3;

	public T4 Item4 => m_Item4;

	public T5 Item5 => m_Item5;

	int ITuple.Size => 5;

	public Tuple(T1 item1, T2 item2, T3 item3, T4 item4, T5 item5)
	{
		m_Item1 = item1;
		m_Item2 = item2;
		m_Item3 = item3;
		m_Item4 = item4;
		m_Item5 = item5;
	}

	public override bool Equals(object obj)
	{
		return ((IStructuralEquatable)this).Equals(obj, (IEqualityComparer)EqualityComparer<object>.Default);
	}

	bool IStructuralEquatable.Equals(object other, IEqualityComparer comparer)
	{
		if (other == null)
		{
			return false;
		}
		if (!(other is Tuple<T1, T2, T3, T4, T5> tuple))
		{
			return false;
		}
		return comparer.Equals(m_Item1, tuple.m_Item1) && comparer.Equals(m_Item2, tuple.m_Item2) && comparer.Equals(m_Item3, tuple.m_Item3) && comparer.Equals(m_Item4, tuple.m_Item4) && comparer.Equals(m_Item5, tuple.m_Item5);
	}

	int IComparable.CompareTo(object obj)
	{
		return ((IStructuralComparable)this).CompareTo(obj, (IComparer)Comparer<object>.Default);
	}

	int IStructuralComparable.CompareTo(object other, IComparer comparer)
	{
		if (other == null)
		{
			return 1;
		}
		if (!(other is Tuple<T1, T2, T3, T4, T5> tuple))
		{
			throw new ArgumentException($"Argument must be of type {GetType().ToString()}.", "other");
		}
		int num = 0;
		num = comparer.Compare(m_Item1, tuple.m_Item1);
		if (num != 0)
		{
			return num;
		}
		num = comparer.Compare(m_Item2, tuple.m_Item2);
		if (num != 0)
		{
			return num;
		}
		num = comparer.Compare(m_Item3, tuple.m_Item3);
		if (num != 0)
		{
			return num;
		}
		num = comparer.Compare(m_Item4, tuple.m_Item4);
		if (num != 0)
		{
			return num;
		}
		return comparer.Compare(m_Item5, tuple.m_Item5);
	}

	public override int GetHashCode()
	{
		return ((IStructuralEquatable)this).GetHashCode((IEqualityComparer)EqualityComparer<object>.Default);
	}

	int IStructuralEquatable.GetHashCode(IEqualityComparer comparer)
	{
		return Tuple.CombineHashCodes(comparer.GetHashCode(m_Item1), comparer.GetHashCode(m_Item2), comparer.GetHashCode(m_Item3), comparer.GetHashCode(m_Item4), comparer.GetHashCode(m_Item5));
	}

	int ITuple.GetHashCode(IEqualityComparer comparer)
	{
		return ((IStructuralEquatable)this).GetHashCode(comparer);
	}

	public override string ToString()
	{
		StringBuilder stringBuilder = new StringBuilder();
		stringBuilder.Append("(");
		return ((ITuple)this).ToString(stringBuilder);
	}

	string ITuple.ToString(StringBuilder sb)
	{
		sb.Append(m_Item1);
		sb.Append(", ");
		sb.Append(m_Item2);
		sb.Append(", ");
		sb.Append(m_Item3);
		sb.Append(", ");
		sb.Append(m_Item4);
		sb.Append(", ");
		sb.Append(m_Item5);
		sb.Append(")");
		return sb.ToString();
	}
}
[Serializable]
public class Tuple<T1, T2, T3, T4, T5, T6> : IStructuralEquatable, IStructuralComparable, IComparable, ITuple
{
	private readonly T1 m_Item1;

	private readonly T2 m_Item2;

	private readonly T3 m_Item3;

	private readonly T4 m_Item4;

	private readonly T5 m_Item5;

	private readonly T6 m_Item6;

	public T1 Item1 => m_Item1;

	public T2 Item2 => m_Item2;

	public T3 Item3 => m_Item3;

	public T4 Item4 => m_Item4;

	public T5 Item5 => m_Item5;

	public T6 Item6 => m_Item6;

	int ITuple.Size => 6;

	public Tuple(T1 item1, T2 item2, T3 item3, T4 item4, T5 item5, T6 item6)
	{
		m_Item1 = item1;
		m_Item2 = item2;
		m_Item3 = item3;
		m_Item4 = item4;
		m_Item5 = item5;
		m_Item6 = item6;
	}

	public override bool Equals(object obj)
	{
		return ((IStructuralEquatable)this).Equals(obj, (IEqualityComparer)EqualityComparer<object>.Default);
	}

	bool IStructuralEquatable.Equals(object other, IEqualityComparer comparer)
	{
		if (other == null)
		{
			return false;
		}
		if (!(other is Tuple<T1, T2, T3, T4, T5, T6> tuple))
		{
			return false;
		}
		return comparer.Equals(m_Item1, tuple.m_Item1) && comparer.Equals(m_Item2, tuple.m_Item2) && comparer.Equals(m_Item3, tuple.m_Item3) && comparer.Equals(m_Item4, tuple.m_Item4) && comparer.Equals(m_Item5, tuple.m_Item5) && comparer.Equals(m_Item6, tuple.m_Item6);
	}

	int IComparable.CompareTo(object obj)
	{
		return ((IStructuralComparable)this).CompareTo(obj, (IComparer)Comparer<object>.Default);
	}

	int IStructuralComparable.CompareTo(object other, IComparer comparer)
	{
		if (other == null)
		{
			return 1;
		}
		if (!(other is Tuple<T1, T2, T3, T4, T5, T6> tuple))
		{
			throw new ArgumentException($"Argument must be of type {GetType().ToString()}.", "other");
		}
		int num = 0;
		num = comparer.Compare(m_Item1, tuple.m_Item1);
		if (num != 0)
		{
			return num;
		}
		num = comparer.Compare(m_Item2, tuple.m_Item2);
		if (num != 0)
		{
			return num;
		}
		num = comparer.Compare(m_Item3, tuple.m_Item3);
		if (num != 0)
		{
			return num;
		}
		num = comparer.Compare(m_Item4, tuple.m_Item4);
		if (num != 0)
		{
			return num;
		}
		num = comparer.Compare(m_Item5, tuple.m_Item5);
		if (num != 0)
		{
			return num;
		}
		return comparer.Compare(m_Item6, tuple.m_Item6);
	}

	public override int GetHashCode()
	{
		return ((IStructuralEquatable)this).GetHashCode((IEqualityComparer)EqualityComparer<object>.Default);
	}

	int IStructuralEquatable.GetHashCode(IEqualityComparer comparer)
	{
		return Tuple.CombineHashCodes(comparer.GetHashCode(m_Item1), comparer.GetHashCode(m_Item2), comparer.GetHashCode(m_Item3), comparer.GetHashCode(m_Item4), comparer.GetHashCode(m_Item5), comparer.GetHashCode(m_Item6));
	}

	int ITuple.GetHashCode(IEqualityComparer comparer)
	{
		return ((IStructuralEquatable)this).GetHashCode(comparer);
	}

	public override string ToString()
	{
		StringBuilder stringBuilder = new StringBuilder();
		stringBuilder.Append("(");
		return ((ITuple)this).ToString(stringBuilder);
	}

	string ITuple.ToString(StringBuilder sb)
	{
		sb.Append(m_Item1);
		sb.Append(", ");
		sb.Append(m_Item2);
		sb.Append(", ");
		sb.Append(m_Item3);
		sb.Append(", ");
		sb.Append(m_Item4);
		sb.Append(", ");
		sb.Append(m_Item5);
		sb.Append(", ");
		sb.Append(m_Item6);
		sb.Append(")");
		return sb.ToString();
	}
}
[Serializable]
public class Tuple<T1, T2, T3, T4, T5, T6, T7> : IStructuralEquatable, IStructuralComparable, IComparable, ITuple
{
	private readonly T1 m_Item1;

	private readonly T2 m_Item2;

	private readonly T3 m_Item3;

	private readonly T4 m_Item4;

	private readonly T5 m_Item5;

	private readonly T6 m_Item6;

	private readonly T7 m_Item7;

	public T1 Item1 => m_Item1;

	public T2 Item2 => m_Item2;

	public T3 Item3 => m_Item3;

	public T4 Item4 => m_Item4;

	public T5 Item5 => m_Item5;

	public T6 Item6 => m_Item6;

	public T7 Item7 => m_Item7;

	int ITuple.Size => 7;

	public Tuple(T1 item1, T2 item2, T3 item3, T4 item4, T5 item5, T6 item6, T7 item7)
	{
		m_Item1 = item1;
		m_Item2 = item2;
		m_Item3 = item3;
		m_Item4 = item4;
		m_Item5 = item5;
		m_Item6 = item6;
		m_Item7 = item7;
	}

	public override bool Equals(object obj)
	{
		return ((IStructuralEquatable)this).Equals(obj, (IEqualityComparer)EqualityComparer<object>.Default);
	}

	bool IStructuralEquatable.Equals(object other, IEqualityComparer comparer)
	{
		if (other == null)
		{
			return false;
		}
		if (!(other is Tuple<T1, T2, T3, T4, T5, T6, T7> tuple))
		{
			return false;
		}
		return comparer.Equals(m_Item1, tuple.m_Item1) && comparer.Equals(m_Item2, tuple.m_Item2) && comparer.Equals(m_Item3, tuple.m_Item3) && comparer.Equals(m_Item4, tuple.m_Item4) && comparer.Equals(m_Item5, tuple.m_Item5) && comparer.Equals(m_Item6, tuple.m_Item6) && comparer.Equals(m_Item7, tuple.m_Item7);
	}

	int IComparable.CompareTo(object obj)
	{
		return ((IStructuralComparable)this).CompareTo(obj, (IComparer)Comparer<object>.Default);
	}

	int IStructuralComparable.CompareTo(object other, IComparer comparer)
	{
		if (other == null)
		{
			return 1;
		}
		if (!(other is Tuple<T1, T2, T3, T4, T5, T6, T7> tuple))
		{
			throw new ArgumentException($"Argument must be of type {GetType().ToString()}.", "other");
		}
		int num = 0;
		num = comparer.Compare(m_Item1, tuple.m_Item1);
		if (num != 0)
		{
			return num;
		}
		num = comparer.Compare(m_Item2, tuple.m_Item2);
		if (num != 0)
		{
			return num;
		}
		num = comparer.Compare(m_Item3, tuple.m_Item3);
		if (num != 0)
		{
			return num;
		}
		num = comparer.Compare(m_Item4, tuple.m_Item4);
		if (num != 0)
		{
			return num;
		}
		num = comparer.Compare(m_Item5, tuple.m_Item5);
		if (num != 0)
		{
			return num;
		}
		num = comparer.Compare(m_Item6, tuple.m_Item6);
		if (num != 0)
		{
			return num;
		}
		return comparer.Compare(m_Item7, tuple.m_Item7);
	}

	public override int GetHashCode()
	{
		return ((IStructuralEquatable)this).GetHashCode((IEqualityComparer)EqualityComparer<object>.Default);
	}

	int IStructuralEquatable.GetHashCode(IEqualityComparer comparer)
	{
		return Tuple.CombineHashCodes(comparer.GetHashCode(m_Item1), comparer.GetHashCode(m_Item2), comparer.GetHashCode(m_Item3), comparer.GetHashCode(m_Item4), comparer.GetHashCode(m_Item5), comparer.GetHashCode(m_Item6), comparer.GetHashCode(m_Item7));
	}

	int ITuple.GetHashCode(IEqualityComparer comparer)
	{
		return ((IStructuralEquatable)this).GetHashCode(comparer);
	}

	public override string ToString()
	{
		StringBuilder stringBuilder = new StringBuilder();
		stringBuilder.Append("(");
		return ((ITuple)this).ToString(stringBuilder);
	}

	string ITuple.ToString(StringBuilder sb)
	{
		sb.Append(m_Item1);
		sb.Append(", ");
		sb.Append(m_Item2);
		sb.Append(", ");
		sb.Append(m_Item3);
		sb.Append(", ");
		sb.Append(m_Item4);
		sb.Append(", ");
		sb.Append(m_Item5);
		sb.Append(", ");
		sb.Append(m_Item6);
		sb.Append(", ");
		sb.Append(m_Item7);
		sb.Append(")");
		return sb.ToString();
	}
}
[Serializable]
public class Tuple<T1, T2, T3, T4, T5, T6, T7, TRest> : IStructuralEquatable, IStructuralComparable, IComparable, ITuple
{
	private readonly T1 m_Item1;

	private readonly T2 m_Item2;

	private readonly T3 m_Item3;

	private readonly T4 m_Item4;

	private readonly T5 m_Item5;

	private readonly T6 m_Item6;

	private readonly T7 m_Item7;

	private readonly TRest m_Rest;

	public T1 Item1 => m_Item1;

	public T2 Item2 => m_Item2;

	public T3 Item3 => m_Item3;

	public T4 Item4 => m_Item4;

	public T5 Item5 => m_Item5;

	public T6 Item6 => m_Item6;

	public T7 Item7 => m_Item7;

	public TRest Rest => m_Rest;

	int ITuple.Size => 7 + ((ITuple)(object)m_Rest).Size;

	public Tuple(T1 item1, T2 item2, T3 item3, T4 item4, T5 item5, T6 item6, T7 item7, TRest rest)
	{
		if (!(rest is ITuple))
		{
			throw new ArgumentException($"The last element of an eight element tuple must be a Tuple.");
		}
		m_Item1 = item1;
		m_Item2 = item2;
		m_Item3 = item3;
		m_Item4 = item4;
		m_Item5 = item5;
		m_Item6 = item6;
		m_Item7 = item7;
		m_Rest = rest;
	}

	public override bool Equals(object obj)
	{
		return ((IStructuralEquatable)this).Equals(obj, (IEqualityComparer)EqualityComparer<object>.Default);
	}

	bool IStructuralEquatable.Equals(object other, IEqualityComparer comparer)
	{
		if (other == null)
		{
			return false;
		}
		if (!(other is Tuple<T1, T2, T3, T4, T5, T6, T7, TRest> tuple))
		{
			return false;
		}
		return comparer.Equals(m_Item1, tuple.m_Item1) && comparer.Equals(m_Item2, tuple.m_Item2) && comparer.Equals(m_Item3, tuple.m_Item3) && comparer.Equals(m_Item4, tuple.m_Item4) && comparer.Equals(m_Item5, tuple.m_Item5) && comparer.Equals(m_Item6, tuple.m_Item6) && comparer.Equals(m_Item7, tuple.m_Item7) && comparer.Equals(m_Rest, tuple.m_Rest);
	}

	int IComparable.CompareTo(object obj)
	{
		return ((IStructuralComparable)this).CompareTo(obj, (IComparer)Comparer<object>.Default);
	}

	int IStructuralComparable.CompareTo(object other, IComparer comparer)
	{
		if (other == null)
		{
			return 1;
		}
		if (!(other is Tuple<T1, T2, T3, T4, T5, T6, T7, TRest> tuple))
		{
			throw new ArgumentException($"Argument must be of type {GetType().ToString()}.", "other");
		}
		int num = 0;
		num = comparer.Compare(m_Item1, tuple.m_Item1);
		if (num != 0)
		{
			return num;
		}
		num = comparer.Compare(m_Item2, tuple.m_Item2);
		if (num != 0)
		{
			return num;
		}
		num = comparer.Compare(m_Item3, tuple.m_Item3);
		if (num != 0)
		{
			return num;
		}
		num = comparer.Compare(m_Item4, tuple.m_Item4);
		if (num != 0)
		{
			return num;
		}
		num = comparer.Compare(m_Item5, tuple.m_Item5);
		if (num != 0)
		{
			return num;
		}
		num = comparer.Compare(m_Item6, tuple.m_Item6);
		if (num != 0)
		{
			return num;
		}
		num = comparer.Compare(m_Item7, tuple.m_Item7);
		if (num != 0)
		{
			return num;
		}
		return comparer.Compare(m_Rest, tuple.m_Rest);
	}

	public override int GetHashCode()
	{
		return ((IStructuralEquatable)this).GetHashCode((IEqualityComparer)EqualityComparer<object>.Default);
	}

	int IStructuralEquatable.GetHashCode(IEqualityComparer comparer)
	{
		ITuple tuple = (ITuple)(object)m_Rest;
		if (tuple.Size >= 8)
		{
			return tuple.GetHashCode(comparer);
		}
		switch (8 - tuple.Size)
		{
		case 1:
			return Tuple.CombineHashCodes(comparer.GetHashCode(m_Item7), tuple.GetHashCode(comparer));
		case 2:
			return Tuple.CombineHashCodes(comparer.GetHashCode(m_Item6), comparer.GetHashCode(m_Item7), tuple.GetHashCode(comparer));
		case 3:
			return Tuple.CombineHashCodes(comparer.GetHashCode(m_Item5), comparer.GetHashCode(m_Item6), comparer.GetHashCode(m_Item7), tuple.GetHashCode(comparer));
		case 4:
			return Tuple.CombineHashCodes(comparer.GetHashCode(m_Item4), comparer.GetHashCode(m_Item5), comparer.GetHashCode(m_Item6), comparer.GetHashCode(m_Item7), tuple.GetHashCode(comparer));
		case 5:
			return Tuple.CombineHashCodes(comparer.GetHashCode(m_Item3), comparer.GetHashCode(m_Item4), comparer.GetHashCode(m_Item5), comparer.GetHashCode(m_Item6), comparer.GetHashCode(m_Item7), tuple.GetHashCode(comparer));
		case 6:
			return Tuple.CombineHashCodes(comparer.GetHashCode(m_Item2), comparer.GetHashCode(m_Item3), comparer.GetHashCode(m_Item4), comparer.GetHashCode(m_Item5), comparer.GetHashCode(m_Item6), comparer.GetHashCode(m_Item7), tuple.GetHashCode(comparer));
		case 7:
			return Tuple.CombineHashCodes(comparer.GetHashCode(m_Item1), comparer.GetHashCode(m_Item2), comparer.GetHashCode(m_Item3), comparer.GetHashCode(m_Item4), comparer.GetHashCode(m_Item5), comparer.GetHashCode(m_Item6), comparer.GetHashCode(m_Item7), tuple.GetHashCode(comparer));
		default:
			Debug.Assert(condition: false, "Missed all cases for computing Tuple hash code");
			return -1;
		}
	}

	int ITuple.GetHashCode(IEqualityComparer comparer)
	{
		return ((IStructuralEquatable)this).GetHashCode(comparer);
	}

	public override string ToString()
	{
		StringBuilder stringBuilder = new StringBuilder();
		stringBuilder.Append("(");
		return ((ITuple)this).ToString(stringBuilder);
	}

	string ITuple.ToString(StringBuilder sb)
	{
		sb.Append(m_Item1);
		sb.Append(", ");
		sb.Append(m_Item2);
		sb.Append(", ");
		sb.Append(m_Item3);
		sb.Append(", ");
		sb.Append(m_Item4);
		sb.Append(", ");
		sb.Append(m_Item5);
		sb.Append(", ");
		sb.Append(m_Item6);
		sb.Append(", ");
		sb.Append(m_Item7);
		sb.Append(", ");
		return ((ITuple)(object)m_Rest).ToString(sb);
	}
}

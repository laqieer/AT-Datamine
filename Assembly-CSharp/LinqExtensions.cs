// Decompiled with JetBrains decompiler
// Type: LinqExtensions
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;
using System.Linq;

#nullable disable
[Token(Token = "0x20001DA")]
public static class LinqExtensions
{
  [Token(Token = "0x6000BEC")]
  public static IEnumerable<T> Distinct<T, TKey>(this IEnumerable<T> source, Func<T, TKey> selector)
  {
    return (IEnumerable<T>) null;
  }

  [Token(Token = "0x6000BED")]
  public static HashSet<T> ToHashSet<T>(this IEnumerable<T> source) => (HashSet<T>) null;

  [Token(Token = "0x6000BEE")]
  public static IOrderedEnumerable<TSource> OrderBy<TSource>(
    this IEnumerable<TSource> source,
    Func<TSource, TSource, int> comparer)
  {
    return (IOrderedEnumerable<TSource>) null;
  }

  [Token(Token = "0x6000BEF")]
  public static IOrderedEnumerable<TSource> OrderBy<TSource, TKey>(
    this IEnumerable<TSource> source,
    Func<TSource, TKey> keySelector,
    Func<TKey, TKey, int> comparer)
  {
    return (IOrderedEnumerable<TSource>) null;
  }

  [Token(Token = "0x6000BF0")]
  public static IOrderedEnumerable<TSource> ThenBy<TSource>(
    this IOrderedEnumerable<TSource> source,
    Func<TSource, TSource, int> comparer)
  {
    return (IOrderedEnumerable<TSource>) null;
  }

  [Token(Token = "0x6000BF1")]
  public static SortedDictionary<TKey, TSource> ToSortedDictionary<TSource, TKey>(
    this IEnumerable<TSource> source,
    Func<TSource, TKey> keySelector)
  {
    return (SortedDictionary<TKey, TSource>) null;
  }
}

// Decompiled with JetBrains decompiler
// Type: FreeMapParamListExtension
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using FreeMap.Parameter.UIParam;
using Il2CppDummyDll;
using System.Collections.Generic;

#nullable disable
[Token(Token = "0x20001E4")]
public static class FreeMapParamListExtension
{
  [Token(Token = "0x6000C22")]
  public static IEnumerable<TCast> FilteringCast<TBase, TCast>(this IEnumerable<TBase> list)
    where TBase : FreeMapUIParamBase
    where TCast : FreeMapUIParamBase
  {
    return (IEnumerable<TCast>) null;
  }

  [Token(Token = "0x6000C23")]
  public static IEnumerable<T> InArea<T>(this IEnumerable<T> list, int areaID) where T : FreeMapUIParamBase
  {
    return (IEnumerable<T>) null;
  }

  [Token(Token = "0x6000C24")]
  public static IEnumerable<T> IsActive<T>(this IEnumerable<T> list, int sequenceID) where T : FreeMapUIParamBase
  {
    return (IEnumerable<T>) null;
  }
}

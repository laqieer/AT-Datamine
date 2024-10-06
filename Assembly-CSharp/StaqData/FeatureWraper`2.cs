// Decompiled with JetBrains decompiler
// Type: StaqData.FeatureWraper`2
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;

#nullable disable
namespace StaqData
{
  [Token(Token = "0x2001FF8")]
  public class FeatureWraper<TFeature, TValue> where TFeature : Enum
  {
    [Token(Token = "0x4008872")]
    [FieldOffset(Offset = "0x0")]
    private Dictionary<int, TValue> dic;

    [Token(Token = "0x600BE69")]
    public void Add(TFeature key, TValue value)
    {
    }

    [Token(Token = "0x600BE6A")]
    public void Remove(TFeature key)
    {
    }

    [Token(Token = "0x600BE6B")]
    public bool TryGetValue(TFeature key, out TValue value) => new bool();

    [Token(Token = "0x600BE6C")]
    public (TFeature, TValue)[] GetValues() => ((TFeature, TValue)[]) null;

    [Token(Token = "0x600BE6D")]
    public void ResetDic()
    {
    }

    [Token(Token = "0x600BE6E")]
    public FeatureWraper()
    {
    }
  }
}

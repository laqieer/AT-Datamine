// Decompiled with JetBrains decompiler
// Type: Battle.Logic.EffectValueBuilder
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;

#nullable disable
namespace Battle.Logic
{
  [Token(Token = "0x20024DF")]
  public class EffectValueBuilder
  {
    [Token(Token = "0x4009E36")]
    [FieldOffset(Offset = "0x10")]
    private Queue<IEffectValueCalculator> calculateQueue;

    [Token(Token = "0x170030B0")]
    public IReadOnlyCollection<IEffectValueCalculator> CalculateQueue
    {
      [Token(Token = "0x600E342"), Address(RVA = "0x40277FC", Offset = "0x40277FC", VA = "0x40277FC")] get
      {
        return (IReadOnlyCollection<IEffectValueCalculator>) null;
      }
    }

    [Token(Token = "0x600E343")]
    [Address(RVA = "0x4024074", Offset = "0x4024074", VA = "0x4024074")]
    public EffectValueBuilder()
    {
    }

    [Token(Token = "0x600E344")]
    [Address(RVA = "0x40257D4", Offset = "0x40257D4", VA = "0x40257D4")]
    public EffectValueBuilder(List<IEffectValueCalculator> calcs)
    {
    }

    [Token(Token = "0x600E345")]
    [Address(RVA = "0x4025960", Offset = "0x4025960", VA = "0x4025960")]
    public EffectValueBuilder Enqueue(IEffectValueCalculator calculator)
    {
      return (EffectValueBuilder) null;
    }

    [Token(Token = "0x600E346")]
    [Address(RVA = "0x4024410", Offset = "0x4024410", VA = "0x4024410")]
    public EffectValueBuilder Enqueue(IReadOnlyList<IEffectValueCalculator> calculators)
    {
      return (EffectValueBuilder) null;
    }

    [Token(Token = "0x600E347")]
    [Address(RVA = "0x4027804", Offset = "0x4027804", VA = "0x4027804")]
    public EffectValueBuilder Reset() => (EffectValueBuilder) null;

    [Token(Token = "0x600E348")]
    [Address(RVA = "0x4024C88", Offset = "0x4024C88", VA = "0x4024C88")]
    public int Build(Decimal initial = 0M) => new int();
  }
}

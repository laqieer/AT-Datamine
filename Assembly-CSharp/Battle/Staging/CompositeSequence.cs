// Decompiled with JetBrains decompiler
// Type: Battle.Staging.CompositeSequence
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;

#nullable disable
namespace Battle.Staging
{
  [Token(Token = "0x200259D")]
  public sealed class CompositeSequence : StagingDirector.ISequence, IStepUpdate
  {
    [Token(Token = "0x400A1CA")]
    [FieldOffset(Offset = "0x18")]
    private Queue<StagingDirector.ISequence> sequences;
    [Token(Token = "0x400A1CB")]
    [FieldOffset(Offset = "0x20")]
    private StagingDirector.ISequence currentSequence;
    [Token(Token = "0x400A1CC")]
    [FieldOffset(Offset = "0x28")]
    private Action onCompleted;

    [Token(Token = "0x600E84A")]
    [Address(RVA = "0x4C3F578", Offset = "0x4C3F578", VA = "0x4C3F578")]
    public static CompositeSequence Create(
      IEnumerable<StagingDirector.ISequence> sequences,
      Action onComplete)
    {
      return (CompositeSequence) null;
    }

    [Token(Token = "0x170031A2")]
    public bool IsCompleted
    {
      [Token(Token = "0x600E84B"), Address(RVA = "0x4C3F680", Offset = "0x4C3F680", VA = "0x4C3F680", Slot = "4")] get
      {
        return new bool();
      }
      [Token(Token = "0x600E84C"), Address(RVA = "0x4C3F688", Offset = "0x4C3F688", VA = "0x4C3F688")] private set
      {
      }
    }

    [Token(Token = "0x600E84D")]
    [Address(RVA = "0x4C3F5E8", Offset = "0x4C3F5E8", VA = "0x4C3F5E8")]
    private CompositeSequence(IEnumerable<StagingDirector.ISequence> sequences, Action onComplete)
    {
    }

    [Token(Token = "0x600E84E")]
    [Address(RVA = "0x4C3F694", Offset = "0x4C3F694", VA = "0x4C3F694", Slot = "5")]
    public void Start()
    {
    }

    [Token(Token = "0x600E84F")]
    [Address(RVA = "0x4C3F8DC", Offset = "0x4C3F8DC", VA = "0x4C3F8DC", Slot = "8")]
    public void Step(float delta)
    {
    }

    [Token(Token = "0x600E850")]
    [Address(RVA = "0x4C3F7C8", Offset = "0x4C3F7C8", VA = "0x4C3F7C8", Slot = "7")]
    public void Complete()
    {
    }

    [Token(Token = "0x600E851")]
    [Address(RVA = "0x4C3FA98", Offset = "0x4C3FA98", VA = "0x4C3FA98", Slot = "6")]
    public void Abort()
    {
    }

    [Token(Token = "0x600E852")]
    [Address(RVA = "0x4C3F750", Offset = "0x4C3F750", VA = "0x4C3F750")]
    private StagingDirector.ISequence GetNext() => (StagingDirector.ISequence) null;
  }
}

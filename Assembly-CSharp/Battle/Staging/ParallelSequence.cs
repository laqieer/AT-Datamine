// Decompiled with JetBrains decompiler
// Type: Battle.Staging.ParallelSequence
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;

#nullable disable
namespace Battle.Staging
{
  [Token(Token = "0x20025A0")]
  public sealed class ParallelSequence : StagingDirector.ISequence, IStepUpdate
  {
    [Token(Token = "0x400A1D0")]
    [FieldOffset(Offset = "0x18")]
    private List<StagingDirector.ISequence> sequences;
    [Token(Token = "0x400A1D1")]
    [FieldOffset(Offset = "0x20")]
    private Action onCompleted;

    [Token(Token = "0x600E85A")]
    [Address(RVA = "0x4C3C894", Offset = "0x4C3C894", VA = "0x4C3C894")]
    public static ParallelSequence Create(
      IEnumerable<StagingDirector.ISequence> sequences,
      Action onComplete)
    {
      return (ParallelSequence) null;
    }

    [Token(Token = "0x170031A3")]
    public bool IsCompleted
    {
      [Token(Token = "0x600E85B"), Address(RVA = "0x4C40628", Offset = "0x4C40628", VA = "0x4C40628", Slot = "4")] get
      {
        return new bool();
      }
      [Token(Token = "0x600E85C"), Address(RVA = "0x4C40630", Offset = "0x4C40630", VA = "0x4C40630")] private set
      {
      }
    }

    [Token(Token = "0x600E85D")]
    [Address(RVA = "0x4C404C4", Offset = "0x4C404C4", VA = "0x4C404C4")]
    private ParallelSequence(IEnumerable<StagingDirector.ISequence> sequences, Action onComplete)
    {
    }

    [Token(Token = "0x600E85E")]
    [Address(RVA = "0x4C4063C", Offset = "0x4C4063C", VA = "0x4C4063C", Slot = "5")]
    public void Start()
    {
    }

    [Token(Token = "0x600E85F")]
    [Address(RVA = "0x4C4073C", Offset = "0x4C4073C", VA = "0x4C4073C", Slot = "8")]
    public void Step(float delta)
    {
    }

    [Token(Token = "0x600E860")]
    [Address(RVA = "0x4C40A70", Offset = "0x4C40A70", VA = "0x4C40A70", Slot = "7")]
    public void Complete()
    {
    }

    [Token(Token = "0x600E861")]
    [Address(RVA = "0x4C40B94", Offset = "0x4C40B94", VA = "0x4C40B94", Slot = "6")]
    public void Abort()
    {
    }
  }
}

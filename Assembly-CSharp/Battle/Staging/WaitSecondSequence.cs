// Decompiled with JetBrains decompiler
// Type: Battle.Staging.WaitSecondSequence
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;

#nullable disable
namespace Battle.Staging
{
  [Token(Token = "0x20025B9")]
  public class WaitSecondSequence : StagingDirector.ISequence, IStepUpdate
  {
    [Token(Token = "0x400A24B")]
    [FieldOffset(Offset = "0x14")]
    private float duration;
    [Token(Token = "0x400A24C")]
    [FieldOffset(Offset = "0x18")]
    private float totalDelta;
    [Token(Token = "0x400A24D")]
    [FieldOffset(Offset = "0x20")]
    private Action onCompleted;

    [Token(Token = "0x600E8E2")]
    [Address(RVA = "0x4C3C974", Offset = "0x4C3C974", VA = "0x4C3C974")]
    public static WaitSecondSequence Create(float duration, Action onCompleted)
    {
      return (WaitSecondSequence) null;
    }

    [Token(Token = "0x170031B3")]
    public bool IsCompleted
    {
      [Token(Token = "0x600E8E3"), Address(RVA = "0x4C461F8", Offset = "0x4C461F8", VA = "0x4C461F8", Slot = "4")] get
      {
        return new bool();
      }
      [Token(Token = "0x600E8E4"), Address(RVA = "0x4C46200", Offset = "0x4C46200", VA = "0x4C46200")] private set
      {
      }
    }

    [Token(Token = "0x600E8E5")]
    [Address(RVA = "0x4C4611C", Offset = "0x4C4611C", VA = "0x4C4611C")]
    protected WaitSecondSequence(float duration, Action onCompleted)
    {
    }

    [Token(Token = "0x600E8E6")]
    [Address(RVA = "0x4C46184", Offset = "0x4C46184", VA = "0x4C46184", Slot = "9")]
    public virtual void Start()
    {
    }

    [Token(Token = "0x600E8E7")]
    [Address(RVA = "0x4C4620C", Offset = "0x4C4620C", VA = "0x4C4620C", Slot = "8")]
    public void Step(float delta)
    {
    }

    [Token(Token = "0x600E8E8")]
    [Address(RVA = "0x4C461C8", Offset = "0x4C461C8", VA = "0x4C461C8", Slot = "10")]
    public virtual void Complete()
    {
    }

    [Token(Token = "0x600E8E9")]
    [Address(RVA = "0x4C46230", Offset = "0x4C46230", VA = "0x4C46230", Slot = "6")]
    public void Abort()
    {
    }
  }
}

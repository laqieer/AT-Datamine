// Decompiled with JetBrains decompiler
// Type: Battle.Staging.SlowMotionSequence
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;

#nullable disable
namespace Battle.Staging
{
  [Token(Token = "0x20025B8")]
  public sealed class SlowMotionSequence : WaitSecondSequence
  {
    [Token(Token = "0x400A248")]
    [FieldOffset(Offset = "0x28")]
    private float timeScaleRate;
    [Token(Token = "0x400A249")]
    [FieldOffset(Offset = "0x2C")]
    private float orgTimaScale;

    [Token(Token = "0x600E8DE")]
    [Address(RVA = "0x4C46060", Offset = "0x4C46060", VA = "0x4C46060")]
    public static SlowMotionSequence Create(
      float timeScaleRate,
      float duration,
      Action onCompleted)
    {
      return (SlowMotionSequence) null;
    }

    [Token(Token = "0x600E8DF")]
    [Address(RVA = "0x4C460DC", Offset = "0x4C460DC", VA = "0x4C460DC")]
    private SlowMotionSequence(float timeScaleRate, float duration, Action onCompleted)
    {
    }

    [Token(Token = "0x600E8E0")]
    [Address(RVA = "0x4C46154", Offset = "0x4C46154", VA = "0x4C46154", Slot = "9")]
    public override void Start()
    {
    }

    [Token(Token = "0x600E8E1")]
    [Address(RVA = "0x4C4618C", Offset = "0x4C4618C", VA = "0x4C4618C", Slot = "10")]
    public override void Complete()
    {
    }
  }
}

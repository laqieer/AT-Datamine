// Decompiled with JetBrains decompiler
// Type: Battle.Staging.DodgeScequence
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Battle.Unit;
using Il2CppDummyDll;
using System;

#nullable disable
namespace Battle.Staging
{
  [Token(Token = "0x2002578")]
  public sealed class DodgeScequence : StagingDirector.ISequence, IStepUpdate
  {
    [Token(Token = "0x400A0E9")]
    [FieldOffset(Offset = "0x18")]
    private CharacterActor target;
    [Token(Token = "0x400A0EA")]
    [FieldOffset(Offset = "0x20")]
    private FieldDamageDirector dmgEmitter;
    [Token(Token = "0x400A0EB")]
    [FieldOffset(Offset = "0x28")]
    private Vector3Curve dodgeCurve;
    [Token(Token = "0x400A0EC")]
    [FieldOffset(Offset = "0x30")]
    private Action onCompleted;

    [Token(Token = "0x600E720")]
    [Address(RVA = "0x487008C", Offset = "0x487008C", VA = "0x487008C")]
    public static StagingDirector.ISequence Create(
      CharacterActor target,
      FieldDamageDirector dmgEmitter,
      Action onCompleted)
    {
      return (StagingDirector.ISequence) null;
    }

    [Token(Token = "0x17003185")]
    public bool IsCompleted
    {
      [Token(Token = "0x600E721"), Address(RVA = "0x487B794", Offset = "0x487B794", VA = "0x487B794", Slot = "4")] get
      {
        return new bool();
      }
      [Token(Token = "0x600E722"), Address(RVA = "0x487B79C", Offset = "0x487B79C", VA = "0x487B79C")] private set
      {
      }
    }

    [Token(Token = "0x600E723")]
    [Address(RVA = "0x487B6BC", Offset = "0x487B6BC", VA = "0x487B6BC")]
    private DodgeScequence(
      CharacterActor target,
      FieldDamageDirector dmgEmitter,
      Action onCompleted)
    {
    }

    [Token(Token = "0x600E724")]
    [Address(RVA = "0x487B7A8", Offset = "0x487B7A8", VA = "0x487B7A8", Slot = "5")]
    public void Start()
    {
    }

    [Token(Token = "0x600E725")]
    [Address(RVA = "0x487B8D0", Offset = "0x487B8D0", VA = "0x487B8D0", Slot = "8")]
    public void Step(float delta)
    {
    }

    [Token(Token = "0x600E726")]
    [Address(RVA = "0x487B9A4", Offset = "0x487B9A4", VA = "0x487B9A4", Slot = "7")]
    public void Complete()
    {
    }

    [Token(Token = "0x600E727")]
    [Address(RVA = "0x487B9D4", Offset = "0x487B9D4", VA = "0x487B9D4", Slot = "6")]
    public void Abort()
    {
    }

    [Token(Token = "0x600E728")]
    [Address(RVA = "0x487B7DC", Offset = "0x487B7DC", VA = "0x487B7DC")]
    private void PlayDodge()
    {
    }

    [Token(Token = "0x600E729")]
    [Address(RVA = "0x487B8AC", Offset = "0x487B8AC", VA = "0x487B8AC")]
    private void ShowMiss()
    {
    }
  }
}

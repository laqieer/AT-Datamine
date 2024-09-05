// Decompiled with JetBrains decompiler
// Type: Battle.Staging.CureBadStatusSequence
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Battle.Data;
using Battle.Data.Board;
using Battle.Particle;
using Battle.Unit;
using Il2CppDummyDll;
using System;

#nullable disable
namespace Battle.Staging
{
  [Token(Token = "0x2002576")]
  public sealed class CureBadStatusSequence : StagingDirector.ISequence, IStepUpdate
  {
    [Token(Token = "0x400A0D4")]
    [FieldOffset(Offset = "0x18")]
    private UnitParameterData target;
    [Token(Token = "0x400A0D5")]
    [FieldOffset(Offset = "0x20")]
    private CharacterActor targetActor;
    [Token(Token = "0x400A0D6")]
    [FieldOffset(Offset = "0x28")]
    private IDirector mainDirector;
    [Token(Token = "0x400A0D7")]
    [FieldOffset(Offset = "0x30")]
    private ParticleEmitter particleEmitter;
    [Token(Token = "0x400A0D8")]
    [FieldOffset(Offset = "0x38")]
    private ParticleEmitter.Handle particleHandle;
    [Token(Token = "0x400A0D9")]
    [FieldOffset(Offset = "0x48")]
    private BattleConfigAsset config;
    [Token(Token = "0x400A0DA")]
    [FieldOffset(Offset = "0x50")]
    private Action onCompleted;

    [Token(Token = "0x600E70A")]
    [Address(RVA = "0x486F66C", Offset = "0x486F66C", VA = "0x486F66C")]
    public static CureBadStatusSequence Create(
      UnitParameterData target,
      CharacterActor targetActor,
      IDirector mainDirector,
      Action onCompleted)
    {
      return (CureBadStatusSequence) null;
    }

    [Token(Token = "0x17003183")]
    public bool IsCompleted
    {
      [Token(Token = "0x600E70B"), Address(RVA = "0x487A9A8", Offset = "0x487A9A8", VA = "0x487A9A8", Slot = "4")] get
      {
        return new bool();
      }
      [Token(Token = "0x600E70C"), Address(RVA = "0x487A9B0", Offset = "0x487A9B0", VA = "0x487A9B0")] private set
      {
      }
    }

    [Token(Token = "0x600E70D")]
    [Address(RVA = "0x487A838", Offset = "0x487A838", VA = "0x487A838")]
    private CureBadStatusSequence(
      UnitParameterData target,
      CharacterActor targetActor,
      IDirector mainDirector,
      Action onCompleted)
    {
    }

    [Token(Token = "0x600E70E")]
    [Address(RVA = "0x487A9BC", Offset = "0x487A9BC", VA = "0x487A9BC", Slot = "5")]
    public void Start()
    {
    }

    [Token(Token = "0x600E70F")]
    [Address(RVA = "0x487AA94", Offset = "0x487AA94", VA = "0x487AA94", Slot = "8")]
    public void Step(float delta)
    {
    }

    [Token(Token = "0x600E710")]
    [Address(RVA = "0x487AB34", Offset = "0x487AB34", VA = "0x487AB34", Slot = "7")]
    public void Complete()
    {
    }

    [Token(Token = "0x600E711")]
    [Address(RVA = "0x487AB64", Offset = "0x487AB64", VA = "0x487AB64", Slot = "6")]
    public void Abort()
    {
    }

    [Token(Token = "0x600E712")]
    [Address(RVA = "0x487A9C0", Offset = "0x487A9C0", VA = "0x487A9C0")]
    private void ShowRaiseEffect()
    {
    }
  }
}

// Decompiled with JetBrains decompiler
// Type: Battle.Staging.TakenOtherSkillEffectSequence
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Battle.Data.Board;
using Battle.Particle;
using Il2CppDummyDll;
using System;

#nullable disable
namespace Battle.Staging
{
  [Token(Token = "0x2002599")]
  public sealed class TakenOtherSkillEffectSequence : StagingDirector.ISequence, IStepUpdate
  {
    [Token(Token = "0x400A1B3")]
    [FieldOffset(Offset = "0x18")]
    private UnitParameterData target;
    [Token(Token = "0x400A1B4")]
    [FieldOffset(Offset = "0x20")]
    private IDirector mainDirector;
    [Token(Token = "0x400A1B5")]
    [FieldOffset(Offset = "0x28")]
    private ParticleEmitter particleEmitter;
    [Token(Token = "0x400A1B6")]
    [FieldOffset(Offset = "0x30")]
    private ActorDirector actorDirector;
    [Token(Token = "0x400A1B7")]
    [FieldOffset(Offset = "0x38")]
    private EffectData takenEffect;
    [Token(Token = "0x400A1B8")]
    [FieldOffset(Offset = "0x40")]
    private bool isManyEffect;
    [Token(Token = "0x400A1B9")]
    [FieldOffset(Offset = "0x48")]
    private ParticleEmitter.Handle particleHandle;
    [Token(Token = "0x400A1BA")]
    [FieldOffset(Offset = "0x58")]
    private Action onCompleted;

    [Token(Token = "0x600E829")]
    [Address(RVA = "0x4C3E968", Offset = "0x4C3E968", VA = "0x4C3E968")]
    public static TakenOtherSkillEffectSequence Create(
      UnitParameterData target,
      EffectData takenEffect,
      bool isManyEffect,
      IDirector mainDirector,
      Action onCompleted)
    {
      return (TakenOtherSkillEffectSequence) null;
    }

    [Token(Token = "0x1700319E")]
    public bool IsCompleted
    {
      [Token(Token = "0x600E82A"), Address(RVA = "0x4C3EB7C", Offset = "0x4C3EB7C", VA = "0x4C3EB7C", Slot = "4")] get
      {
        return new bool();
      }
      [Token(Token = "0x600E82B"), Address(RVA = "0x4C3EB84", Offset = "0x4C3EB84", VA = "0x4C3EB84")] private set
      {
      }
    }

    [Token(Token = "0x600E82C")]
    [Address(RVA = "0x4C3E9F8", Offset = "0x4C3E9F8", VA = "0x4C3E9F8")]
    private TakenOtherSkillEffectSequence(
      UnitParameterData target,
      EffectData takenEffect,
      bool isManyEffect,
      IDirector mainDirector,
      Action onCompleted)
    {
    }

    [Token(Token = "0x600E82D")]
    [Address(RVA = "0x4C3EB90", Offset = "0x4C3EB90", VA = "0x4C3EB90", Slot = "5")]
    public void Start()
    {
    }

    [Token(Token = "0x600E82E")]
    [Address(RVA = "0x4C3ECC0", Offset = "0x4C3ECC0", VA = "0x4C3ECC0", Slot = "8")]
    public void Step(float delta)
    {
    }

    [Token(Token = "0x600E82F")]
    [Address(RVA = "0x4C3ECF8", Offset = "0x4C3ECF8", VA = "0x4C3ECF8", Slot = "7")]
    public void Complete()
    {
    }

    [Token(Token = "0x600E830")]
    [Address(RVA = "0x4C3ED9C", Offset = "0x4C3ED9C", VA = "0x4C3ED9C", Slot = "6")]
    public void Abort()
    {
    }

    [Token(Token = "0x600E831")]
    [Address(RVA = "0x4C3EB94", Offset = "0x4C3EB94", VA = "0x4C3EB94")]
    private void ShowRaiseEffect()
    {
    }
  }
}

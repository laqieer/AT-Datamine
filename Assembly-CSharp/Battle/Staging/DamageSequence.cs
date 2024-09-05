// Decompiled with JetBrains decompiler
// Type: Battle.Staging.DamageSequence
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Battle.Data.Board;
using Battle.Unit;
using GameCore.MasterData;
using Il2CppDummyDll;
using System;

#nullable disable
namespace Battle.Staging
{
  [Token(Token = "0x2002577")]
  public sealed class DamageSequence : StagingDirector.ISequence, IStepUpdate
  {
    [Token(Token = "0x400A0DC")]
    [FieldOffset(Offset = "0x18")]
    private UnitParameterData target;
    [Token(Token = "0x400A0DD")]
    [FieldOffset(Offset = "0x20")]
    private bool cameraMove;
    [Token(Token = "0x400A0DE")]
    [FieldOffset(Offset = "0x28")]
    private ActiveSkillData usingSkill;
    [Token(Token = "0x400A0DF")]
    [FieldOffset(Offset = "0x30")]
    private AttackTypeEnum attackType;
    [Token(Token = "0x400A0E0")]
    [FieldOffset(Offset = "0x34")]
    private ElementTypeEnum elementType;
    [Token(Token = "0x400A0E1")]
    [FieldOffset(Offset = "0x38")]
    private WeaponParameterData weaponData;
    [Token(Token = "0x400A0E2")]
    [FieldOffset(Offset = "0x40")]
    private int damage;
    [Token(Token = "0x400A0E3")]
    [FieldOffset(Offset = "0x44")]
    private bool isCritical;
    [Token(Token = "0x400A0E4")]
    [FieldOffset(Offset = "0x48")]
    private CharacterActor targetActor;
    [Token(Token = "0x400A0E5")]
    [FieldOffset(Offset = "0x50")]
    private IDirector mainDirector;
    [Token(Token = "0x400A0E6")]
    [FieldOffset(Offset = "0x58")]
    private Action onCompleted;
    [Token(Token = "0x400A0E7")]
    [FieldOffset(Offset = "0x60")]
    private ShakeVector3Curve shakeCurve;

    [Token(Token = "0x600E713")]
    [Address(RVA = "0x486FF30", Offset = "0x486FF30", VA = "0x486FF30")]
    public static DamageSequence Create(
      UnitParameterData target,
      AttackTypeEnum attackType,
      ElementTypeEnum elementType,
      WeaponParameterData weaponData,
      int damage,
      bool isCritical,
      IDirector mainDirector,
      bool cameraMove,
      Action onCompleted)
    {
      return (DamageSequence) null;
    }

    [Token(Token = "0x17003184")]
    public bool IsCompleted
    {
      [Token(Token = "0x600E714"), Address(RVA = "0x487AC6C", Offset = "0x487AC6C", VA = "0x487AC6C", Slot = "4")] get
      {
        return new bool();
      }
      [Token(Token = "0x600E715"), Address(RVA = "0x487AC74", Offset = "0x487AC74", VA = "0x487AC74")] private set
      {
      }
    }

    [Token(Token = "0x600E716")]
    [Address(RVA = "0x487AB68", Offset = "0x487AB68", VA = "0x487AB68")]
    private DamageSequence(
      UnitParameterData target,
      ActiveSkillData usingSkill,
      AttackTypeEnum attackType,
      ElementTypeEnum elementType,
      WeaponParameterData weaponData,
      int damage,
      bool isCritical,
      CharacterActor targetActor,
      IDirector mainDirector,
      bool cameraMove,
      Action onCompleted)
    {
    }

    [Token(Token = "0x600E717")]
    [Address(RVA = "0x487AC80", Offset = "0x487AC80", VA = "0x487AC80", Slot = "5")]
    public void Start()
    {
    }

    [Token(Token = "0x600E718")]
    [Address(RVA = "0x487B16C", Offset = "0x487B16C", VA = "0x487B16C", Slot = "8")]
    public void Step(float delta)
    {
    }

    [Token(Token = "0x600E719")]
    [Address(RVA = "0x487B374", Offset = "0x487B374", VA = "0x487B374", Slot = "7")]
    public void Complete()
    {
    }

    [Token(Token = "0x600E71A")]
    [Address(RVA = "0x487B4DC", Offset = "0x487B4DC", VA = "0x487B4DC", Slot = "6")]
    public void Abort()
    {
    }

    [Token(Token = "0x600E71B")]
    [Address(RVA = "0x487AE5C", Offset = "0x487AE5C", VA = "0x487AE5C")]
    private void KnockbackIfDamaged()
    {
    }

    [Token(Token = "0x600E71C")]
    [Address(RVA = "0x487AF2C", Offset = "0x487AF2C", VA = "0x487AF2C")]
    private void ShowDamage()
    {
    }

    [Token(Token = "0x600E71D")]
    [Address(RVA = "0x487B004", Offset = "0x487B004", VA = "0x487B004")]
    private void ShowHitEffects()
    {
    }

    [Token(Token = "0x600E71E")]
    [Address(RVA = "0x487B4E0", Offset = "0x487B4E0", VA = "0x487B4E0")]
    private void PlaySkillHitEffect()
    {
    }

    [Token(Token = "0x600E71F")]
    [Address(RVA = "0x487B588", Offset = "0x487B588", VA = "0x487B588")]
    private void PlayHitEffect(string assetName)
    {
    }
  }
}

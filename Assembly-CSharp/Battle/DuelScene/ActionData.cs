// Decompiled with JetBrains decompiler
// Type: Battle.DuelScene.ActionData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Battle.Data;
using Battle.Data.Board;
using Il2CppDummyDll;
using System.Collections.Generic;

#nullable disable
namespace Battle.DuelScene
{
  [Token(Token = "0x2002543")]
  public sealed class ActionData
  {
    [Token(Token = "0x400A02F")]
    [FieldOffset(Offset = "0x10")]
    public ActiveSkillActionGroup Group;
    [Token(Token = "0x400A030")]
    [FieldOffset(Offset = "0x14")]
    public ActionType Action;
    [Token(Token = "0x400A031")]
    [FieldOffset(Offset = "0x18")]
    public WeaponParameterData UsingWeapon;
    [Token(Token = "0x400A032")]
    [FieldOffset(Offset = "0x20")]
    public SkillParameterData UsingSkill;
    [Token(Token = "0x400A033")]
    [FieldOffset(Offset = "0x28")]
    public EffectData UsingEffect;
    [Token(Token = "0x400A034")]
    [FieldOffset(Offset = "0x30")]
    public SkillParameterData SupportAttackSkillParam;
    [Token(Token = "0x400A035")]
    [FieldOffset(Offset = "0x38")]
    public SkillParameterData SupportGuardSkillParam;
    [Token(Token = "0x400A036")]
    [FieldOffset(Offset = "0x40")]
    public SkillParameterData SupportHealSkillParam;
    [Token(Token = "0x400A037")]
    [FieldOffset(Offset = "0x48")]
    public int HitRate;
    [Token(Token = "0x400A038")]
    [FieldOffset(Offset = "0x4C")]
    public int CriticalRate;
    [Token(Token = "0x400A039")]
    [FieldOffset(Offset = "0x50")]
    public UnitParameterData ActionOwner;
    [Token(Token = "0x400A03A")]
    [FieldOffset(Offset = "0x58")]
    public GridData ActionGrid;
    [Token(Token = "0x400A03B")]
    [FieldOffset(Offset = "0x60")]
    public List<ActionTargetResultData> TargetResults;
    [Token(Token = "0x400A03C")]
    [FieldOffset(Offset = "0x68")]
    public UnitParameterChange OwnerBeforeParam;
    [Token(Token = "0x400A03D")]
    [FieldOffset(Offset = "0x70")]
    public UnitParameterChange OwnerAfterParam;

    [Token(Token = "0x1700316D")]
    public bool AttackedBySupport
    {
      [Token(Token = "0x600E61F"), Address(RVA = "0x486C7EC", Offset = "0x486C7EC", VA = "0x486C7EC")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x1700316E")]
    public bool GuardedBySupport
    {
      [Token(Token = "0x600E620"), Address(RVA = "0x486C7FC", Offset = "0x486C7FC", VA = "0x486C7FC")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x1700316F")]
    public bool HealedBySupport
    {
      [Token(Token = "0x600E621"), Address(RVA = "0x486C8A8", Offset = "0x486C8A8", VA = "0x486C8A8")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17003170")]
    public bool IsNormalAttackSkill
    {
      [Token(Token = "0x600E622"), Address(RVA = "0x486C8B8", Offset = "0x486C8B8", VA = "0x486C8B8")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17003171")]
    public bool IsSingleSkill
    {
      [Token(Token = "0x600E623"), Address(RVA = "0x486C918", Offset = "0x486C918", VA = "0x486C918")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17003172")]
    public bool IsCommonSkill
    {
      [Token(Token = "0x600E624"), Address(RVA = "0x486C93C", Offset = "0x486C93C", VA = "0x486C93C")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17003173")]
    public bool IsActivateSupportSkill
    {
      [Token(Token = "0x600E625"), Address(RVA = "0x486C97C", Offset = "0x486C97C", VA = "0x486C97C")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17003174")]
    public ActionTargetResultData MainTargetResult
    {
      [Token(Token = "0x600E626"), Address(RVA = "0x486C830", Offset = "0x486C830", VA = "0x486C830")] get
      {
        return (ActionTargetResultData) null;
      }
    }

    [Token(Token = "0x600E627")]
    [Address(RVA = "0x486C9A4", Offset = "0x486C9A4", VA = "0x486C9A4")]
    public string ToJson() => (string) null;

    [Token(Token = "0x600E628")]
    [Address(RVA = "0x486CE2C", Offset = "0x486CE2C", VA = "0x486CE2C")]
    public ActionData()
    {
    }
  }
}

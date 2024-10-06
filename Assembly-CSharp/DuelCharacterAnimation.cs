// Decompiled with JetBrains decompiler
// Type: DuelCharacterAnimation
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.MasterData;
using Il2CppDummyDll;
using System;

#nullable disable
[Token(Token = "0x2000160")]
[Serializable]
public class DuelCharacterAnimation
{
  [Token(Token = "0x40008D9")]
  [FieldOffset(Offset = "0x10")]
  public DuelCharacterAnimation.AnimationType animationType;
  [Token(Token = "0x40008DA")]
  [FieldOffset(Offset = "0x14")]
  public ElementEffectItem.ElementType animationElementType;
  [Token(Token = "0x40008DB")]
  [FieldOffset(Offset = "0x18")]
  public StratagemDirectionTypeEnum stratagemDirectionType;
  [Token(Token = "0x40008DC")]
  [FieldOffset(Offset = "0x1C")]
  public WeaponTypeEnum animationWeaponType;
  [Token(Token = "0x40008DD")]
  [FieldOffset(Offset = "0x20")]
  public DuelCharacterAnimation.MainAnimationType mainAnimationType;
  [Token(Token = "0x40008DE")]
  [FieldOffset(Offset = "0x24")]
  public DuelCharacterAnimation.NormalAttackType normalAttackType;
  [Token(Token = "0x40008DF")]
  [FieldOffset(Offset = "0x28")]
  public DuelCharacterCommonSkillTimelineSettingsAsset commonSkillTimelineData;
  [Token(Token = "0x40008E0")]
  [FieldOffset(Offset = "0x30")]
  public DuelCharacterSingleSkillTimelineSettingsAsset singleSkillTimelineData;
  [Token(Token = "0x40008E1")]
  [FieldOffset(Offset = "0x38")]
  public DuelCharacterStratagemTimelineSettingsAsset stratagemTimelineData;
  [Token(Token = "0x40008E2")]
  [FieldOffset(Offset = "0x40")]
  public DuelCharacterFierceAttackTimelineSettingsAsset fierceAttackTimelineData;
  [Token(Token = "0x40008E3")]
  [FieldOffset(Offset = "0x48")]
  public bool isAbnormalState;
  [Token(Token = "0x40008E4")]
  [FieldOffset(Offset = "0x4C")]
  public BattleBadStatusTypeEnum abnormalState;
  [Token(Token = "0x40008E5")]
  [FieldOffset(Offset = "0x50")]
  public DuelCharacterAnimation.PassiveAnimationType passiveAnimationType;
  [Token(Token = "0x40008E6")]
  [FieldOffset(Offset = "0x54")]
  public bool isPassiveKOAnimation;
  [Token(Token = "0x40008E7")]
  [FieldOffset(Offset = "0x55")]
  public bool isWeaponDreak;
  [Token(Token = "0x40008E8")]
  [FieldOffset(Offset = "0x56")]
  public bool isChaseAttack;
  [Token(Token = "0x40008E9")]
  [FieldOffset(Offset = "0x57")]
  public bool isResistByBarrier;
  [Token(Token = "0x40008EA")]
  [FieldOffset(Offset = "0x58")]
  public bool isGuardedBySupport;

  [Token(Token = "0x60009D4")]
  [Address(RVA = "0x4775FF8", Offset = "0x4775FF8", VA = "0x4775FF8")]
  public DuelCharacterAnimation()
  {
  }

  [Token(Token = "0x2000161")]
  public enum AnimationType
  {
    [Token(Token = "0x40008EC")] None,
    [Token(Token = "0x40008ED")] Main,
    [Token(Token = "0x40008EE")] Active,
    [Token(Token = "0x40008EF")] Passive,
  }

  [Token(Token = "0x2000162")]
  public enum MainAnimationType
  {
    [Token(Token = "0x40008F1")] NormalAttack,
    [Token(Token = "0x40008F2")] CommonSkill,
    [Token(Token = "0x40008F3")] SingleSkill,
    [Token(Token = "0x40008F4")] Stratagem,
    [Token(Token = "0x40008F5")] FierceAttack,
  }

  [Token(Token = "0x2000163")]
  public enum NormalAttackType
  {
    [Token(Token = "0x40008F7")] NormalAttack,
    [Token(Token = "0x40008F8")] ComboAttack1,
    [Token(Token = "0x40008F9")] ComboAttack2,
    [Token(Token = "0x40008FA")] CriticalAttack,
  }

  [Token(Token = "0x2000164")]
  public enum MainAnimationRange
  {
    [Token(Token = "0x40008FC")] CloseRange,
    [Token(Token = "0x40008FD")] LongRange,
  }

  [Token(Token = "0x2000165")]
  public enum PassiveAnimationType
  {
    [Token(Token = "0x40008FF")] None,
    [Token(Token = "0x4000900")] Damage,
    [Token(Token = "0x4000901")] Escape,
    [Token(Token = "0x4000902")] DualGuard,
    [Token(Token = "0x4000903")] SingleGuard,
    [Token(Token = "0x4000904")] NoAction,
    [Token(Token = "0x4000905")] ReceiveSupport,
  }
}

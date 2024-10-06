// Decompiled with JetBrains decompiler
// Type: Staq.Tools.DuelDebugTool.DuelDebugAction
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Battle;
using GameCore.MasterData;
using Il2CppDummyDll;
using System;

#nullable disable
namespace Staq.Tools.DuelDebugTool
{
  [Token(Token = "0x2000979")]
  [Serializable]
  public class DuelDebugAction : IDuelDebugToolActionSettings
  {
    [Token(Token = "0x4002C06")]
    [FieldOffset(Offset = "0x10")]
    public DuelCharacterAnimation.AnimationType AnimationType;
    [Token(Token = "0x4002C07")]
    [FieldOffset(Offset = "0x14")]
    public ActiveSkillActionGroup ActionGroup;
    [Token(Token = "0x4002C08")]
    [FieldOffset(Offset = "0x18")]
    public DuelDebugAction.OffenceActionData OffenceAction;
    [Token(Token = "0x4002C09")]
    [FieldOffset(Offset = "0x20")]
    public DuelDebugAction.DefenceActionData DefenceAction;

    [Token(Token = "0x60035D5")]
    [Address(RVA = "0x3530920", Offset = "0x3530920", VA = "0x3530920", Slot = "4")]
    public DuelCharacterAnimation.AnimationType GetActionType()
    {
      return new DuelCharacterAnimation.AnimationType();
    }

    [Token(Token = "0x60035D6")]
    [Address(RVA = "0x3530928", Offset = "0x3530928", VA = "0x3530928", Slot = "5")]
    public ActiveSkillActionGroup GetActionGroup() => new ActiveSkillActionGroup();

    [Token(Token = "0x60035D7")]
    [Address(RVA = "0x3530930", Offset = "0x3530930", VA = "0x3530930", Slot = "6")]
    public string GetSkillID() => (string) null;

    [Token(Token = "0x60035D8")]
    [Address(RVA = "0x3530950", Offset = "0x3530950", VA = "0x3530950", Slot = "7")]
    public DuelCharacterAnimation.MainAnimationType GetMainActionType()
    {
      return new DuelCharacterAnimation.MainAnimationType();
    }

    [Token(Token = "0x60035D9")]
    [Address(RVA = "0x353096C", Offset = "0x353096C", VA = "0x353096C", Slot = "8")]
    public bool GetIsChaseAttack() => new bool();

    [Token(Token = "0x60035DA")]
    [Address(RVA = "0x3530988", Offset = "0x3530988", VA = "0x3530988", Slot = "9")]
    public ElementTypeEnum GetElementType() => new ElementTypeEnum();

    [Token(Token = "0x60035DB")]
    [Address(RVA = "0x35309A4", Offset = "0x35309A4", VA = "0x35309A4", Slot = "10")]
    public string GetDuelResourceName() => (string) null;

    [Token(Token = "0x60035DC")]
    [Address(RVA = "0x3530A54", Offset = "0x3530A54", VA = "0x3530A54", Slot = "11")]
    public DuelCharacterAnimation.NormalAttackType GetNormalAttackType()
    {
      return new DuelCharacterAnimation.NormalAttackType();
    }

    [Token(Token = "0x60035DD")]
    [Address(RVA = "0x3530A70", Offset = "0x3530A70", VA = "0x3530A70", Slot = "12")]
    public bool GetIsWeaponBreak() => new bool();

    [Token(Token = "0x60035DE")]
    [Address(RVA = "0x3530A8C", Offset = "0x3530A8C", VA = "0x3530A8C", Slot = "13")]
    public DuelCharacterAnimation.PassiveAnimationType GetPassiveActionType()
    {
      return new DuelCharacterAnimation.PassiveAnimationType();
    }

    [Token(Token = "0x60035DF")]
    [Address(RVA = "0x3530AA8", Offset = "0x3530AA8", VA = "0x3530AA8", Slot = "14")]
    public bool GetIsKO() => new bool();

    [Token(Token = "0x60035E0")]
    [Address(RVA = "0x3530AC4", Offset = "0x3530AC4", VA = "0x3530AC4", Slot = "15")]
    public bool GetIsCritical() => new bool();

    [Token(Token = "0x60035E1")]
    [Address(RVA = "0x3530AE0", Offset = "0x3530AE0", VA = "0x3530AE0", Slot = "16")]
    public bool GetIsAbnormalState() => new bool();

    [Token(Token = "0x60035E2")]
    [Address(RVA = "0x3530AFC", Offset = "0x3530AFC", VA = "0x3530AFC", Slot = "17")]
    public BattleBadStatusTypeEnum GetAbnormalState() => new BattleBadStatusTypeEnum();

    [Token(Token = "0x60035E3")]
    [Address(RVA = "0x3530B18", Offset = "0x3530B18", VA = "0x3530B18", Slot = "18")]
    public int GetOldHP() => new int();

    [Token(Token = "0x60035E4")]
    [Address(RVA = "0x3530B20", Offset = "0x3530B20", VA = "0x3530B20", Slot = "19")]
    public int GetNewHP() => new int();

    [Token(Token = "0x60035E5")]
    [Address(RVA = "0x3530B28", Offset = "0x3530B28", VA = "0x3530B28", Slot = "20")]
    public WeaponTypeEnum GetStratagemWeaponType() => new WeaponTypeEnum();

    [Token(Token = "0x60035E6")]
    [Address(RVA = "0x3530B44", Offset = "0x3530B44", VA = "0x3530B44", Slot = "21")]
    public StratagemDirectionTypeEnum GetStratagemDirectionType()
    {
      return new StratagemDirectionTypeEnum();
    }

    [Token(Token = "0x60035E7")]
    [Address(RVA = "0x3530B60", Offset = "0x3530B60", VA = "0x3530B60")]
    public static DuelDebugAction CreateNormalAttackAction() => (DuelDebugAction) null;

    [Token(Token = "0x60035E8")]
    [Address(RVA = "0x3530D38", Offset = "0x3530D38", VA = "0x3530D38")]
    public static DuelDebugAction CreateNormalDamageAction() => (DuelDebugAction) null;

    [Token(Token = "0x60035E9")]
    [Address(RVA = "0x3530E34", Offset = "0x3530E34", VA = "0x3530E34")]
    public static DuelDebugAction CreateNoneAction() => (DuelDebugAction) null;

    [Token(Token = "0x60035EA")]
    [Address(RVA = "0x3530C5C", Offset = "0x3530C5C", VA = "0x3530C5C")]
    public DuelDebugAction()
    {
    }

    [Token(Token = "0x200097A")]
    [Serializable]
    public class OffenceActionData
    {
      [Token(Token = "0x4002C0A")]
      [FieldOffset(Offset = "0x10")]
      public int SkillId;
      [Token(Token = "0x4002C0B")]
      [FieldOffset(Offset = "0x14")]
      public DuelCharacterAnimation.MainAnimationType MainAnimationType;
      [Token(Token = "0x4002C0C")]
      [FieldOffset(Offset = "0x18")]
      public DuelCharacterAnimation.NormalAttackType NormalAttackType;
      [Token(Token = "0x4002C0D")]
      [FieldOffset(Offset = "0x1C")]
      public bool IsChaseAttack;
      [Token(Token = "0x4002C0E")]
      [FieldOffset(Offset = "0x1D")]
      public bool IsWeaponBreak;
      [Token(Token = "0x4002C0F")]
      [FieldOffset(Offset = "0x20")]
      public ElementTypeEnum ElementTypeEnum;
      [Token(Token = "0x4002C10")]
      [FieldOffset(Offset = "0x24")]
      public WeaponTypeEnum WeaponTypeEnum;
      [Token(Token = "0x4002C11")]
      [FieldOffset(Offset = "0x28")]
      public StratagemDirectionTypeEnum StratagemDirectionType;

      [Token(Token = "0x60035EB")]
      [Address(RVA = "0x3530D10", Offset = "0x3530D10", VA = "0x3530D10")]
      public OffenceActionData()
      {
      }
    }

    [Token(Token = "0x200097B")]
    [Serializable]
    public class DefenceActionData
    {
      [Token(Token = "0x4002C12")]
      [FieldOffset(Offset = "0x10")]
      public DuelCharacterAnimation.PassiveAnimationType PassiveAnimationType;
      [Token(Token = "0x4002C13")]
      [FieldOffset(Offset = "0x14")]
      public bool IsKo;
      [Token(Token = "0x4002C14")]
      [FieldOffset(Offset = "0x15")]
      public bool IsCritical;
      [Token(Token = "0x4002C15")]
      [FieldOffset(Offset = "0x16")]
      public bool ReceiveBadStatus;
      [Token(Token = "0x4002C16")]
      [FieldOffset(Offset = "0x18")]
      public BattleBadStatusTypeEnum ReceivedBadStatusTypeEnum;

      [Token(Token = "0x60035EC")]
      [Address(RVA = "0x3530D28", Offset = "0x3530D28", VA = "0x3530D28")]
      public DefenceActionData()
      {
      }
    }
  }
}

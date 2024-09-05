// Decompiled with JetBrains decompiler
// Type: Battle.IDuelDebugToolActionSettings
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.MasterData;
using Il2CppDummyDll;

#nullable disable
namespace Battle
{
  [Token(Token = "0x2002287")]
  public interface IDuelDebugToolActionSettings
  {
    [Token(Token = "0x600D277")]
    DuelCharacterAnimation.AnimationType GetActionType();

    [Token(Token = "0x600D278")]
    ActiveSkillActionGroup GetActionGroup();

    [Token(Token = "0x600D279")]
    string GetSkillID();

    [Token(Token = "0x600D27A")]
    DuelCharacterAnimation.MainAnimationType GetMainActionType();

    [Token(Token = "0x600D27B")]
    bool GetIsChaseAttack();

    [Token(Token = "0x600D27C")]
    ElementTypeEnum GetElementType();

    [Token(Token = "0x600D27D")]
    string GetDuelResourceName();

    [Token(Token = "0x600D27E")]
    DuelCharacterAnimation.NormalAttackType GetNormalAttackType();

    [Token(Token = "0x600D27F")]
    bool GetIsWeaponBreak();

    [Token(Token = "0x600D280")]
    DuelCharacterAnimation.PassiveAnimationType GetPassiveActionType();

    [Token(Token = "0x600D281")]
    bool GetIsKO();

    [Token(Token = "0x600D282")]
    bool GetIsCritical();

    [Token(Token = "0x600D283")]
    bool GetIsAbnormalState();

    [Token(Token = "0x600D284")]
    BattleBadStatusTypeEnum GetAbnormalState();

    [Token(Token = "0x600D285")]
    int GetOldHP();

    [Token(Token = "0x600D286")]
    int GetNewHP();

    [Token(Token = "0x600D287")]
    WeaponTypeEnum GetStratagemWeaponType();

    [Token(Token = "0x600D288")]
    StratagemDirectionTypeEnum GetStratagemDirectionType();
  }
}

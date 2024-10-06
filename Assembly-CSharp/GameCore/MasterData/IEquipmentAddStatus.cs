// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.IEquipmentAddStatus
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x2001440")]
  public interface IEquipmentAddStatus
  {
    [Token(Token = "0x6007208")]
    int GetElementReinforceValue(ElementTypeEnum element, int level);

    [Token(Token = "0x6007209")]
    int GetAttackReinforceValue(AttackTypeEnum attackType, int level);

    [Token(Token = "0x600720A")]
    int GetBadStatusReinforceValue(BattleBadStatusTypeEnum badStatusType, int level);

    [Token(Token = "0x600720B")]
    int GetElementResistValue(ElementTypeEnum element, int level);

    [Token(Token = "0x600720C")]
    int GetAttackResistValue(AttackTypeEnum attackType, int level);

    [Token(Token = "0x600720D")]
    int GetBadStatusResistValue(BattleBadStatusTypeEnum badStatusType, int level);

    [Token(Token = "0x600720E")]
    bool IsAddedStatusElementReinforceValue(ElementTypeEnum elementType);

    [Token(Token = "0x600720F")]
    bool IsAddedStatusAttackReinforceValue(AttackTypeEnum attackType);

    [Token(Token = "0x6007210")]
    bool IsAddedStatusBadStatusReinforceValue(BattleBadStatusTypeEnum battleBadStatusType);

    [Token(Token = "0x6007211")]
    bool IsAddedStatusElementResistValue(ElementTypeEnum elementType);

    [Token(Token = "0x6007212")]
    bool IsAddedStatusAttackResistValue(AttackTypeEnum attackType);

    [Token(Token = "0x6007213")]
    bool IsAddedStatusBadStatusResistValue(BattleBadStatusTypeEnum battleBadStatusType);
  }
}

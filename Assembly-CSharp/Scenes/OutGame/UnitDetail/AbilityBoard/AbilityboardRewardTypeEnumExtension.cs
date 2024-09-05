// Decompiled with JetBrains decompiler
// Type: Scenes.OutGame.UnitDetail.AbilityBoard.AbilityboardRewardTypeEnumExtension
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.MasterData;
using Il2CppDummyDll;
using StaqData;
using System;

#nullable disable
namespace Scenes.OutGame.UnitDetail.AbilityBoard
{
  [Token(Token = "0x200333A")]
  internal static class AbilityboardRewardTypeEnumExtension
  {
    [Token(Token = "0x400DDC3")]
    [FieldOffset(Offset = "0x0")]
    private static Func<string, string> GetText;

    [Token(Token = "0x601420F")]
    [Address(RVA = "0x20CCD30", Offset = "0x20CCD30", VA = "0x20CCD30")]
    public static string GetLocalizedText(this AbilityboardRewardTypeEnum rewardTypeEnum)
    {
      return (string) null;
    }

    [Token(Token = "0x6014210")]
    [Address(RVA = "0x20CD59C", Offset = "0x20CD59C", VA = "0x20CD59C")]
    public static int GetParameterValue(
      this AbilityboardRewardTypeEnum rewardTypeEnum,
      StyleParameter styleParameter)
    {
      return new int();
    }

    [Token(Token = "0x6014211")]
    [Address(RVA = "0x20CD634", Offset = "0x20CD634", VA = "0x20CD634")]
    public static int GetElementReinforceValue(
      this AbilityboardRewardTypeEnum rewardTypeEnum,
      StyleParameter styleParameter)
    {
      return new int();
    }

    [Token(Token = "0x6014212")]
    [Address(RVA = "0x20CD818", Offset = "0x20CD818", VA = "0x20CD818")]
    public static int GetAtkTypeReinforceValue(
      this AbilityboardRewardTypeEnum rewardTypeEnum,
      StyleParameter styleParameter)
    {
      return new int();
    }

    [Token(Token = "0x6014213")]
    [Address(RVA = "0x20CD9C4", Offset = "0x20CD9C4", VA = "0x20CD9C4")]
    public static int GetElementResistValue(
      this AbilityboardRewardTypeEnum rewardTypeEnum,
      StyleParameter styleParameter)
    {
      return new int();
    }

    [Token(Token = "0x6014214")]
    [Address(RVA = "0x20CDBA8", Offset = "0x20CDBA8", VA = "0x20CDBA8")]
    public static int GetAtkTypeResistValue(
      this AbilityboardRewardTypeEnum rewardTypeEnum,
      StyleParameter styleParameter)
    {
      return new int();
    }

    [Token(Token = "0x6014215")]
    [Address(RVA = "0x20CDD54", Offset = "0x20CDD54", VA = "0x20CDD54")]
    public static int GetStyleMasterExpValue(
      this AbilityboardRewardTypeEnum rewardTypeEnum,
      PlayerProfile playerProfile)
    {
      return new int();
    }

    [Token(Token = "0x6014216")]
    [Address(RVA = "0x20CDE90", Offset = "0x20CDE90", VA = "0x20CDE90")]
    static AbilityboardRewardTypeEnumExtension()
    {
    }
  }
}

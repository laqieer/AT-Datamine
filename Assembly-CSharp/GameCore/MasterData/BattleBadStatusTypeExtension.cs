// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.BattleBadStatusTypeExtension
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using StaqData;
using System.Collections.Generic;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x20013F2")]
  public static class BattleBadStatusTypeExtension
  {
    [Token(Token = "0x4005CE5")]
    [FieldOffset(Offset = "0x0")]
    public static readonly BattleBadStatusTypeEnum[] Values;

    [Token(Token = "0x6006FF3")]
    [Address(RVA = "0x4207590", Offset = "0x4207590", VA = "0x4207590")]
    public static string DisplayName(this BattleBadStatusTypeEnum self) => (string) null;

    [Token(Token = "0x6006FF4")]
    [Address(RVA = "0x42078A4", Offset = "0x42078A4", VA = "0x42078A4")]
    public static int GetReinforceValue(this BattleBadStatusTypeEnum self, StyleData data)
    {
      return new int();
    }

    [Token(Token = "0x6006FF5")]
    [Address(RVA = "0x420795C", Offset = "0x420795C", VA = "0x420795C")]
    public static int GetResistValue(this BattleBadStatusTypeEnum self, StyleData data)
    {
      return new int();
    }

    [Token(Token = "0x6006FF6")]
    [Address(RVA = "0x4207A14", Offset = "0x4207A14", VA = "0x4207A14")]
    public static List<BattleBadStatusTypeEnum> GetIconDisplayList()
    {
      return (List<BattleBadStatusTypeEnum>) null;
    }

    [Token(Token = "0x6006FF7")]
    [Address(RVA = "0x4207B5C", Offset = "0x4207B5C", VA = "0x4207B5C")]
    public static float GetReinforceValue(
      this BattleBadStatusTypeEnum self,
      WeaponOptionEffect[] optionEffects)
    {
      return new float();
    }

    [Token(Token = "0x6006FF8")]
    [Address(RVA = "0x4207BD8", Offset = "0x4207BD8", VA = "0x4207BD8")]
    public static float GetReinforceValue(
      this BattleBadStatusTypeEnum self,
      AccessoryOptionEffect[] optionEffects)
    {
      return new float();
    }

    [Token(Token = "0x6006FF9")]
    [Address(RVA = "0x4207C54", Offset = "0x4207C54", VA = "0x4207C54")]
    public static float GetResistValue(
      this BattleBadStatusTypeEnum self,
      AccessoryOptionEffect[] optionEffects)
    {
      return new float();
    }

    [Token(Token = "0x6006FFA")]
    [Address(RVA = "0x4207CD0", Offset = "0x4207CD0", VA = "0x4207CD0")]
    static BattleBadStatusTypeExtension()
    {
    }
  }
}

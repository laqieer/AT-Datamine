// Decompiled with JetBrains decompiler
// Type: Battle.Data.BattleMissionTypeExtension
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.MasterData;
using Il2CppDummyDll;

#nullable disable
namespace Battle.Data
{
  [Token(Token = "0x20026F5")]
  public static class BattleMissionTypeExtension
  {
    [Token(Token = "0x600F125")]
    [Address(RVA = "0x41AC58C", Offset = "0x41AC58C", VA = "0x41AC58C")]
    public static bool IsSpecifiedMissionType(this BattleMissionTypeEnum self) => new bool();

    [Token(Token = "0x600F126")]
    [Address(RVA = "0x41AC59C", Offset = "0x41AC59C", VA = "0x41AC59C")]
    public static bool IsMissionConditionType(this BattleMissionTypeEnum self) => new bool();

    [Token(Token = "0x600F127")]
    [Address(RVA = "0x41AC5B8", Offset = "0x41AC5B8", VA = "0x41AC5B8")]
    public static bool IsNone(this BattleMissionTypeEnum self) => new bool();
  }
}

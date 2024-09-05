// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.TargettableUnitTypeEnum
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x2000F2F")]
  public enum TargettableUnitTypeEnum
  {
    [Token(Token = "0x4004C07")] Own = 1,
    [Token(Token = "0x4004C08")] OwnAndDoubled = 2,
    [Token(Token = "0x4004C09")] OwnDoubledFront = 3,
    [Token(Token = "0x4004C0A")] OwnDoubledBack = 4,
    [Token(Token = "0x4004C0B")] Ally = 5,
    [Token(Token = "0x4004C0C")] AllyAndDoubled = 6,
    [Token(Token = "0x4004C0D")] AllyDoubledBack = 7,
    [Token(Token = "0x4004C0E")] Enemy = 8,
    [Token(Token = "0x4004C0F")] EnemyAndDoubled = 9,
    [Token(Token = "0x4004C10")] EnemyDoubledBack = 10, // 0x0000000A
    [Token(Token = "0x4004C11")] AnyUnit = 11, // 0x0000000B
    [Token(Token = "0x4004C12")] AnyFrontUnit = 12, // 0x0000000C
    [Token(Token = "0x4004C13")] AnyBackUnit = 13, // 0x0000000D
    [Token(Token = "0x4004C14")] OwnParty = 14, // 0x0000000E
  }
}

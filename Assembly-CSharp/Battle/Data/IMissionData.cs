// Decompiled with JetBrains decompiler
// Type: Battle.Data.IMissionData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.MasterData;
using Il2CppDummyDll;

#nullable disable
namespace Battle.Data
{
  [Token(Token = "0x20026F6")]
  public interface IMissionData
  {
    [Token(Token = "0x17003300")]
    int ID { [Token(Token = "0x600F128")] get; }

    [Token(Token = "0x17003301")]
    int rewardGroupId { [Token(Token = "0x600F129")] get; }

    [Token(Token = "0x17003302")]
    string description { [Token(Token = "0x600F12A")] get; }

    [Token(Token = "0x17003303")]
    BattleMissionTypeEnum missionType1 { [Token(Token = "0x600F12B")] get; }

    [Token(Token = "0x17003304")]
    int value1 { [Token(Token = "0x600F12C")] get; }

    [Token(Token = "0x17003305")]
    int value2 { [Token(Token = "0x600F12D")] get; }

    [Token(Token = "0x17003306")]
    BattleMissionTypeEnum missionType2 { [Token(Token = "0x600F12E")] get; }

    [Token(Token = "0x17003307")]
    int value3 { [Token(Token = "0x600F12F")] get; }

    [Token(Token = "0x17003308")]
    int value4 { [Token(Token = "0x600F130")] get; }

    [Token(Token = "0x17003309")]
    BattleMissionTypeEnum missionType3 { [Token(Token = "0x600F131")] get; }

    [Token(Token = "0x1700330A")]
    int value5 { [Token(Token = "0x600F132")] get; }

    [Token(Token = "0x1700330B")]
    int value6 { [Token(Token = "0x600F133")] get; }
  }
}

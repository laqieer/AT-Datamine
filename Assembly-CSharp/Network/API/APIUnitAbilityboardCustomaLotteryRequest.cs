// Decompiled with JetBrains decompiler
// Type: Network.API.APIUnitAbilityboardCustomaLotteryRequest
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;

#nullable disable
namespace Network.API
{
  [Token(Token = "0x2001E8B")]
  [Serializable]
  public class APIUnitAbilityboardCustomaLotteryRequest
  {
    [Token(Token = "0x400833F")]
    [FieldOffset(Offset = "0x10")]
    public string player_unit_id;
    [Token(Token = "0x4008340")]
    [FieldOffset(Offset = "0x18")]
    public int board_setting_id;
    [Token(Token = "0x4008341")]
    [FieldOffset(Offset = "0x1C")]
    public int item_id;
    [Token(Token = "0x4008342")]
    [FieldOffset(Offset = "0x20")]
    public int lottery_count;

    [Token(Token = "0x600B54D")]
    [Address(RVA = "0x22E8C64", Offset = "0x22E8C64", VA = "0x22E8C64")]
    public string GetQuery() => (string) null;

    [Token(Token = "0x600B54E")]
    [Address(RVA = "0x22E8CAC", Offset = "0x22E8CAC", VA = "0x22E8CAC")]
    public APIUnitAbilityboardCustomaLotteryRequest()
    {
    }
  }
}

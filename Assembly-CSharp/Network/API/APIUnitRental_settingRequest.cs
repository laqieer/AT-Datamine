// Decompiled with JetBrains decompiler
// Type: Network.API.APIUnitRental_settingRequest
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;

#nullable disable
namespace Network.API
{
  [Token(Token = "0x2001ED3")]
  [Serializable]
  public class APIUnitRental_settingRequest
  {
    [Token(Token = "0x4008464")]
    [FieldOffset(Offset = "0x10")]
    public string player_wildcard_unit_id;
    [Token(Token = "0x4008465")]
    [FieldOffset(Offset = "0x18")]
    public string player_fire_unit_id;
    [Token(Token = "0x4008466")]
    [FieldOffset(Offset = "0x20")]
    public string player_ice_unit_id;
    [Token(Token = "0x4008467")]
    [FieldOffset(Offset = "0x28")]
    public string player_thunder_unit_id;
    [Token(Token = "0x4008468")]
    [FieldOffset(Offset = "0x30")]
    public string player_wind_unit_id;
    [Token(Token = "0x4008469")]
    [FieldOffset(Offset = "0x38")]
    public string player_light_unit_id;
    [Token(Token = "0x400846A")]
    [FieldOffset(Offset = "0x40")]
    public string player_dark_unit_id;

    [Token(Token = "0x600B717")]
    [Address(RVA = "0x212F8F0", Offset = "0x212F8F0", VA = "0x212F8F0")]
    public string GetQuery() => (string) null;

    [Token(Token = "0x600B718")]
    [Address(RVA = "0x212F938", Offset = "0x212F938", VA = "0x212F938")]
    public APIUnitRental_settingRequest()
    {
    }
  }
}

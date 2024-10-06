// Decompiled with JetBrains decompiler
// Type: Network.API.APIUnitAbilityboardCustomaSelectRequest
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;

#nullable disable
namespace Network.API
{
  [Token(Token = "0x2001E93")]
  [Serializable]
  public class APIUnitAbilityboardCustomaSelectRequest
  {
    [Token(Token = "0x4008360")]
    [FieldOffset(Offset = "0x10")]
    public string player_unit_id;
    [Token(Token = "0x4008361")]
    [FieldOffset(Offset = "0x18")]
    public int board_setting_id;
    [Token(Token = "0x4008362")]
    [FieldOffset(Offset = "0x20")]
    public string select_id;
    [Token(Token = "0x4008363")]
    [FieldOffset(Offset = "0x28")]
    public bool use_current_param;

    [Token(Token = "0x600B580")]
    [Address(RVA = "0x22E9734", Offset = "0x22E9734", VA = "0x22E9734")]
    public string GetQuery() => (string) null;

    [Token(Token = "0x600B581")]
    [Address(RVA = "0x22E977C", Offset = "0x22E977C", VA = "0x22E977C")]
    public APIUnitAbilityboardCustomaSelectRequest()
    {
    }
  }
}

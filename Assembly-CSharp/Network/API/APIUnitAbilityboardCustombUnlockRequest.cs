// Decompiled with JetBrains decompiler
// Type: Network.API.APIUnitAbilityboardCustombUnlockRequest
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;

#nullable disable
namespace Network.API
{
  [Token(Token = "0x2001E97")]
  [Serializable]
  public class APIUnitAbilityboardCustombUnlockRequest
  {
    [Token(Token = "0x4008374")]
    [FieldOffset(Offset = "0x10")]
    public string player_unit_id;
    [Token(Token = "0x4008375")]
    [FieldOffset(Offset = "0x18")]
    public int board_setting_id;

    [Token(Token = "0x600B59B")]
    [Address(RVA = "0x22E9CA8", Offset = "0x22E9CA8", VA = "0x22E9CA8")]
    public string GetQuery() => (string) null;

    [Token(Token = "0x600B59C")]
    [Address(RVA = "0x22E9CF0", Offset = "0x22E9CF0", VA = "0x22E9CF0")]
    public APIUnitAbilityboardCustombUnlockRequest()
    {
    }
  }
}

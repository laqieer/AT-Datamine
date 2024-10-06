// Decompiled with JetBrains decompiler
// Type: Network.API.APIWeaponOption_change_requestRequest
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;

#nullable disable
namespace Network.API
{
  [Token(Token = "0x2001F03")]
  [Serializable]
  public class APIWeaponOption_change_requestRequest
  {
    [Token(Token = "0x400851F")]
    [FieldOffset(Offset = "0x10")]
    public string player_weapon_id;
    [Token(Token = "0x4008520")]
    [FieldOffset(Offset = "0x18")]
    public int reroll_num;

    [Token(Token = "0x600B83E")]
    [Address(RVA = "0x2133978", Offset = "0x2133978", VA = "0x2133978")]
    public string GetQuery() => (string) null;

    [Token(Token = "0x600B83F")]
    [Address(RVA = "0x21339C0", Offset = "0x21339C0", VA = "0x21339C0")]
    public APIWeaponOption_change_requestRequest()
    {
    }
  }
}

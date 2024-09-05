// Decompiled with JetBrains decompiler
// Type: Network.API.APIWeaponOption_change_confirmRequest
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;

#nullable disable
namespace Network.API
{
  [Token(Token = "0x2001EFF")]
  [Serializable]
  public class APIWeaponOption_change_confirmRequest
  {
    [Token(Token = "0x4008511")]
    [FieldOffset(Offset = "0x10")]
    public string player_weapon_id;
    [Token(Token = "0x4008512")]
    [FieldOffset(Offset = "0x18")]
    public int candidate_id;

    [Token(Token = "0x600B827")]
    [Address(RVA = "0x2133424", Offset = "0x2133424", VA = "0x2133424")]
    public string GetQuery() => (string) null;

    [Token(Token = "0x600B828")]
    [Address(RVA = "0x213346C", Offset = "0x213346C", VA = "0x213346C")]
    public APIWeaponOption_change_confirmRequest()
    {
    }
  }
}

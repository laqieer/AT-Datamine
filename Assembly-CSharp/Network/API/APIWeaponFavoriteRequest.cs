// Decompiled with JetBrains decompiler
// Type: Network.API.APIWeaponFavoriteRequest
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;

#nullable disable
namespace Network.API
{
  [Token(Token = "0x2001EF3")]
  [Serializable]
  public class APIWeaponFavoriteRequest
  {
    [Token(Token = "0x40084E6")]
    [FieldOffset(Offset = "0x10")]
    public List<string> favorite_weapon_ids;
    [Token(Token = "0x40084E7")]
    [FieldOffset(Offset = "0x18")]
    public List<string> unfavorite_weapon_ids;

    [Token(Token = "0x600B7DF")]
    [Address(RVA = "0x2132410", Offset = "0x2132410", VA = "0x2132410")]
    public string GetQuery() => (string) null;

    [Token(Token = "0x600B7E0")]
    [Address(RVA = "0x2132458", Offset = "0x2132458", VA = "0x2132458")]
    public APIWeaponFavoriteRequest()
    {
    }
  }
}

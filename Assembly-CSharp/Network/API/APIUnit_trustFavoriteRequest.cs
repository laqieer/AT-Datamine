// Decompiled with JetBrains decompiler
// Type: Network.API.APIUnit_trustFavoriteRequest
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;

#nullable disable
namespace Network.API
{
  [Token(Token = "0x2001EEB")]
  [Serializable]
  public class APIUnit_trustFavoriteRequest
  {
    [Token(Token = "0x40084C5")]
    [FieldOffset(Offset = "0x10")]
    public List<string> lock_unit_trust_ids;
    [Token(Token = "0x40084C6")]
    [FieldOffset(Offset = "0x18")]
    public List<string> unlock_unit_trust_ids;

    [Token(Token = "0x600B7AC")]
    [Address(RVA = "0x2131940", Offset = "0x2131940", VA = "0x2131940")]
    public string GetQuery() => (string) null;

    [Token(Token = "0x600B7AD")]
    [Address(RVA = "0x2131988", Offset = "0x2131988", VA = "0x2131988")]
    public APIUnit_trustFavoriteRequest()
    {
    }
  }
}

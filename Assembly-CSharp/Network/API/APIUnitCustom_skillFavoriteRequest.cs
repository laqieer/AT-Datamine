// Decompiled with JetBrains decompiler
// Type: Network.API.APIUnitCustom_skillFavoriteRequest
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;

#nullable disable
namespace Network.API
{
  [Token(Token = "0x2001EB7")]
  [Serializable]
  public class APIUnitCustom_skillFavoriteRequest
  {
    [Token(Token = "0x40083F8")]
    [FieldOffset(Offset = "0x10")]
    public List<string> favorite_custom_skill_ids;
    [Token(Token = "0x40083F9")]
    [FieldOffset(Offset = "0x18")]
    public List<string> unfavorite_custom_skill_ids;

    [Token(Token = "0x600B66A")]
    [Address(RVA = "0x22EC800", Offset = "0x22EC800", VA = "0x22EC800")]
    public string GetQuery() => (string) null;

    [Token(Token = "0x600B66B")]
    [Address(RVA = "0x22EC848", Offset = "0x22EC848", VA = "0x22EC848")]
    public APIUnitCustom_skillFavoriteRequest()
    {
    }
  }
}

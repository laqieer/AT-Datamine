// Decompiled with JetBrains decompiler
// Type: Network.API.APIUnitFavoriteRequest
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;

#nullable disable
namespace Network.API
{
  [Token(Token = "0x2001EBF")]
  [Serializable]
  public class APIUnitFavoriteRequest
  {
    [Token(Token = "0x4008413")]
    [FieldOffset(Offset = "0x10")]
    public List<string> player_unit_ids;
    [Token(Token = "0x4008414")]
    [FieldOffset(Offset = "0x18")]
    public List<string> unlock_player_unit_ids;

    [Token(Token = "0x600B698")]
    [Address(RVA = "0x22ED2A8", Offset = "0x22ED2A8", VA = "0x22ED2A8")]
    public string GetQuery() => (string) null;

    [Token(Token = "0x600B699")]
    [Address(RVA = "0x22ED2F0", Offset = "0x22ED2F0", VA = "0x22ED2F0")]
    public APIUnitFavoriteRequest()
    {
    }
  }
}

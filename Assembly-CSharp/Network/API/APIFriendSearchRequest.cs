// Decompiled with JetBrains decompiler
// Type: Network.API.APIFriendSearchRequest
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;

#nullable disable
namespace Network.API
{
  [Token(Token = "0x2001C6B")]
  [Serializable]
  public class APIFriendSearchRequest
  {
    [Token(Token = "0x40079A9")]
    [FieldOffset(Offset = "0x10")]
    public long target_player_short_id;

    [Token(Token = "0x600A75D")]
    [Address(RVA = "0x190E150", Offset = "0x190E150", VA = "0x190E150")]
    public string GetQuery() => (string) null;

    [Token(Token = "0x600A75E")]
    [Address(RVA = "0x190E198", Offset = "0x190E198", VA = "0x190E198")]
    public APIFriendSearchRequest()
    {
    }
  }
}

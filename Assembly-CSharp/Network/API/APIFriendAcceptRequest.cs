// Decompiled with JetBrains decompiler
// Type: Network.API.APIFriendAcceptRequest
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;

#nullable disable
namespace Network.API
{
  [Token(Token = "0x2001C4F")]
  [Serializable]
  public class APIFriendAcceptRequest
  {
    [Token(Token = "0x400794E")]
    [FieldOffset(Offset = "0x10")]
    public string target_player_id;

    [Token(Token = "0x600A6BA")]
    [Address(RVA = "0x190BBF4", Offset = "0x190BBF4", VA = "0x190BBF4")]
    public string GetQuery() => (string) null;

    [Token(Token = "0x600A6BB")]
    [Address(RVA = "0x190BC3C", Offset = "0x190BC3C", VA = "0x190BC3C")]
    public APIFriendAcceptRequest()
    {
    }
  }
}

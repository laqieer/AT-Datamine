// Decompiled with JetBrains decompiler
// Type: Network.API.APIFriendRejectRequest
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;

#nullable disable
namespace Network.API
{
  [Token(Token = "0x2001C63")]
  [Serializable]
  public class APIFriendRejectRequest
  {
    [Token(Token = "0x400798F")]
    [FieldOffset(Offset = "0x10")]
    public string target_player_id;

    [Token(Token = "0x600A72F")]
    [Address(RVA = "0x190D6A8", Offset = "0x190D6A8", VA = "0x190D6A8")]
    public string GetQuery() => (string) null;

    [Token(Token = "0x600A730")]
    [Address(RVA = "0x190D6F0", Offset = "0x190D6F0", VA = "0x190D6F0")]
    public APIFriendRejectRequest()
    {
    }
  }
}

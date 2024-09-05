// Decompiled with JetBrains decompiler
// Type: Network.API.APIFriendCancelRequest
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;

#nullable disable
namespace Network.API
{
  [Token(Token = "0x2001C57")]
  [Serializable]
  public class APIFriendCancelRequest
  {
    [Token(Token = "0x4007968")]
    [FieldOffset(Offset = "0x10")]
    public string target_player_id;

    [Token(Token = "0x600A6E8")]
    [Address(RVA = "0x190C69C", Offset = "0x190C69C", VA = "0x190C69C")]
    public string GetQuery() => (string) null;

    [Token(Token = "0x600A6E9")]
    [Address(RVA = "0x190C6E4", Offset = "0x190C6E4", VA = "0x190C6E4")]
    public APIFriendCancelRequest()
    {
    }
  }
}

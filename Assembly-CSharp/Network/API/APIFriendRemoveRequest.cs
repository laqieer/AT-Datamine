// Decompiled with JetBrains decompiler
// Type: Network.API.APIFriendRemoveRequest
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;

#nullable disable
namespace Network.API
{
  [Token(Token = "0x2001C67")]
  [Serializable]
  public class APIFriendRemoveRequest
  {
    [Token(Token = "0x400799C")]
    [FieldOffset(Offset = "0x10")]
    public string target_player_id;

    [Token(Token = "0x600A746")]
    [Address(RVA = "0x190DBFC", Offset = "0x190DBFC", VA = "0x190DBFC")]
    public string GetQuery() => (string) null;

    [Token(Token = "0x600A747")]
    [Address(RVA = "0x190DC44", Offset = "0x190DC44", VA = "0x190DC44")]
    public APIFriendRemoveRequest()
    {
    }
  }
}

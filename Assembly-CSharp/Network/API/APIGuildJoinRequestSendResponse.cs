// Decompiled with JetBrains decompiler
// Type: Network.API.APIGuildJoinRequestSendResponse
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using Network.Param;
using System;
using UnityEngine;

#nullable disable
namespace Network.API
{
  [Token(Token = "0x2001CF8")]
  [Serializable]
  public class APIGuildJoinRequestSendResponse
  {
    [Token(Token = "0x4007BC4")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private GuildJoinRequestType join_request;

    [Token(Token = "0x170020F0")]
    public GuildJoinRequestType JoinRequest
    {
      [Token(Token = "0x600AAB9"), Address(RVA = "0x1919DB4", Offset = "0x1919DB4", VA = "0x1919DB4")] get
      {
        return (GuildJoinRequestType) null;
      }
    }

    [Token(Token = "0x600AABA")]
    [Address(RVA = "0x1919DBC", Offset = "0x1919DBC", VA = "0x1919DBC")]
    public APIGuildJoinRequestSendResponse()
    {
    }
  }
}

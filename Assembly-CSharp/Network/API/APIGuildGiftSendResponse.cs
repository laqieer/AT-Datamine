// Decompiled with JetBrains decompiler
// Type: Network.API.APIGuildGiftSendResponse
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using Network.Param;
using System;
using System.Collections.Generic;
using UnityEngine;

#nullable disable
namespace Network.API
{
  [Token(Token = "0x2001CD0")]
  [Serializable]
  public class APIGuildGiftSendResponse
  {
    [Token(Token = "0x4007B2A")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private List<GuildGiftTarget> unsent_members;

    [Token(Token = "0x1700209F")]
    public List<GuildGiftTarget> UnsentMembers
    {
      [Token(Token = "0x600A9C8"), Address(RVA = "0x1916814", Offset = "0x1916814", VA = "0x1916814")] get
      {
        return (List<GuildGiftTarget>) null;
      }
    }

    [Token(Token = "0x600A9C9")]
    [Address(RVA = "0x191681C", Offset = "0x191681C", VA = "0x191681C")]
    public APIGuildGiftSendResponse()
    {
    }
  }
}

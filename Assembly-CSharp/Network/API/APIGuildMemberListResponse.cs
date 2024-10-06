// Decompiled with JetBrains decompiler
// Type: Network.API.APIGuildMemberListResponse
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
  [Token(Token = "0x2001D04")]
  [Serializable]
  public class APIGuildMemberListResponse
  {
    [Token(Token = "0x4007BED")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private List<GuildMemberType> members;

    [Token(Token = "0x17002106")]
    public List<GuildMemberType> Members
    {
      [Token(Token = "0x600AAFF"), Address(RVA = "0x1A41868", Offset = "0x1A41868", VA = "0x1A41868")] get
      {
        return (List<GuildMemberType>) null;
      }
    }

    [Token(Token = "0x600AB00")]
    [Address(RVA = "0x1A41870", Offset = "0x1A41870", VA = "0x1A41870")]
    public APIGuildMemberListResponse()
    {
    }
  }
}

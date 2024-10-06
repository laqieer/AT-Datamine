// Decompiled with JetBrains decompiler
// Type: Network.API.APIAreaNodeClearResponse
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
  [Token(Token = "0x2001B68")]
  [Serializable]
  public class APIAreaNodeClearResponse : ICommonApiResult
  {
    [Token(Token = "0x4007573")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private NoticeData notice;
    [Token(Token = "0x4007574")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private PlayerAreaNodeType player_area_node;

    [Token(Token = "0x17001D61")]
    public NoticeData Notice
    {
      [Token(Token = "0x600A0EA"), Address(RVA = "0x46C6248", Offset = "0x46C6248", VA = "0x46C6248", Slot = "4")] get
      {
        return (NoticeData) null;
      }
    }

    [Token(Token = "0x17001D62")]
    public PlayerAreaNodeType PlayerAreaNode
    {
      [Token(Token = "0x600A0EB"), Address(RVA = "0x46C6250", Offset = "0x46C6250", VA = "0x46C6250")] get
      {
        return (PlayerAreaNodeType) null;
      }
    }

    [Token(Token = "0x600A0EC")]
    [Address(RVA = "0x46C6258", Offset = "0x46C6258", VA = "0x46C6258")]
    public APIAreaNodeClearResponse()
    {
    }
  }
}

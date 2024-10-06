// Decompiled with JetBrains decompiler
// Type: Network.API.APIExpeditionBoxLevel_upResponse
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
  [Token(Token = "0x2001C18")]
  [Serializable]
  public class APIExpeditionBoxLevel_upResponse
  {
    [Token(Token = "0x4007839")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private PlayerType player;
    [Token(Token = "0x400783A")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private PlayerExpeditionType player_expedition;

    [Token(Token = "0x17001EE6")]
    public PlayerType Player
    {
      [Token(Token = "0x600A52F"), Address(RVA = "0x1906F54", Offset = "0x1906F54", VA = "0x1906F54")] get
      {
        return (PlayerType) null;
      }
    }

    [Token(Token = "0x17001EE7")]
    public PlayerExpeditionType PlayerExpedition
    {
      [Token(Token = "0x600A530"), Address(RVA = "0x1906F5C", Offset = "0x1906F5C", VA = "0x1906F5C")] get
      {
        return (PlayerExpeditionType) null;
      }
    }

    [Token(Token = "0x600A531")]
    [Address(RVA = "0x1906F64", Offset = "0x1906F64", VA = "0x1906F64")]
    public APIExpeditionBoxLevel_upResponse()
    {
    }
  }
}

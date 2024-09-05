// Decompiled with JetBrains decompiler
// Type: Network.API.APIExpeditionSoul_tankLevel_upResponse
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
  [Token(Token = "0x2001C34")]
  [Serializable]
  public class APIExpeditionSoul_tankLevel_upResponse
  {
    [Token(Token = "0x40078C3")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private PlayerType player;
    [Token(Token = "0x40078C4")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private PlayerExpeditionSoulTankType player_expedition_soul_tank;

    [Token(Token = "0x17001F44")]
    public PlayerType Player
    {
      [Token(Token = "0x600A5FD"), Address(RVA = "0x1909608", Offset = "0x1909608", VA = "0x1909608")] get
      {
        return (PlayerType) null;
      }
    }

    [Token(Token = "0x17001F45")]
    public PlayerExpeditionSoulTankType PlayerExpeditionSoulTank
    {
      [Token(Token = "0x600A5FE"), Address(RVA = "0x1909610", Offset = "0x1909610", VA = "0x1909610")] get
      {
        return (PlayerExpeditionSoulTankType) null;
      }
    }

    [Token(Token = "0x600A5FF")]
    [Address(RVA = "0x1909618", Offset = "0x1909618", VA = "0x1909618")]
    public APIExpeditionSoul_tankLevel_upResponse()
    {
    }
  }
}

// Decompiled with JetBrains decompiler
// Type: Network.API.APIFggfcMissionResponse
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
  [Token(Token = "0x2001C40")]
  [Serializable]
  public class APIFggfcMissionResponse
  {
    [Token(Token = "0x40078F9")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private int fggid_game_id;
    [Token(Token = "0x40078FA")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private List<PlayerFggIDRegisterGame> register_games;
    [Token(Token = "0x40078FB")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private List<PlayerFggfcCoin> coins;
    [Token(Token = "0x40078FC")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private List<PlayerFggIDAchievementMission> achievement_missions;
    [Token(Token = "0x40078FD")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private List<PlayerFggfcCoinMission> coin_missions;

    [Token(Token = "0x17001F67")]
    public int FggidGameId
    {
      [Token(Token = "0x600A650"), Address(RVA = "0x190A674", Offset = "0x190A674", VA = "0x190A674")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17001F68")]
    public List<PlayerFggIDRegisterGame> RegisterGames
    {
      [Token(Token = "0x600A651"), Address(RVA = "0x190A67C", Offset = "0x190A67C", VA = "0x190A67C")] get
      {
        return (List<PlayerFggIDRegisterGame>) null;
      }
    }

    [Token(Token = "0x17001F69")]
    public List<PlayerFggfcCoin> Coins
    {
      [Token(Token = "0x600A652"), Address(RVA = "0x190A684", Offset = "0x190A684", VA = "0x190A684")] get
      {
        return (List<PlayerFggfcCoin>) null;
      }
    }

    [Token(Token = "0x17001F6A")]
    public List<PlayerFggIDAchievementMission> AchievementMissions
    {
      [Token(Token = "0x600A653"), Address(RVA = "0x190A68C", Offset = "0x190A68C", VA = "0x190A68C")] get
      {
        return (List<PlayerFggIDAchievementMission>) null;
      }
    }

    [Token(Token = "0x17001F6B")]
    public List<PlayerFggfcCoinMission> CoinMissions
    {
      [Token(Token = "0x600A654"), Address(RVA = "0x190A694", Offset = "0x190A694", VA = "0x190A694")] get
      {
        return (List<PlayerFggfcCoinMission>) null;
      }
    }

    [Token(Token = "0x600A655")]
    [Address(RVA = "0x190A69C", Offset = "0x190A69C", VA = "0x190A69C")]
    public APIFggfcMissionResponse()
    {
    }
  }
}

// Decompiled with JetBrains decompiler
// Type: Network.API.APIFggfcMissionAcceptResponse
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
  [Token(Token = "0x2001C44")]
  [Serializable]
  public class APIFggfcMissionAcceptResponse
  {
    [Token(Token = "0x400790B")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private List<PlayerFggIDRegisterGame> register_games;
    [Token(Token = "0x400790C")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private List<PlayerFggfcCoin> coins;
    [Token(Token = "0x400790D")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private List<PlayerFggIDAchievementMission> achievement_missions;
    [Token(Token = "0x400790E")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private List<PlayerFggfcCoinMission> coin_missions;

    [Token(Token = "0x17001F72")]
    public List<PlayerFggIDRegisterGame> RegisterGames
    {
      [Token(Token = "0x600A66B"), Address(RVA = "0x190ABE8", Offset = "0x190ABE8", VA = "0x190ABE8")] get
      {
        return (List<PlayerFggIDRegisterGame>) null;
      }
    }

    [Token(Token = "0x17001F73")]
    public List<PlayerFggfcCoin> Coins
    {
      [Token(Token = "0x600A66C"), Address(RVA = "0x190ABF0", Offset = "0x190ABF0", VA = "0x190ABF0")] get
      {
        return (List<PlayerFggfcCoin>) null;
      }
    }

    [Token(Token = "0x17001F74")]
    public List<PlayerFggIDAchievementMission> AchievementMissions
    {
      [Token(Token = "0x600A66D"), Address(RVA = "0x190ABF8", Offset = "0x190ABF8", VA = "0x190ABF8")] get
      {
        return (List<PlayerFggIDAchievementMission>) null;
      }
    }

    [Token(Token = "0x17001F75")]
    public List<PlayerFggfcCoinMission> CoinMissions
    {
      [Token(Token = "0x600A66E"), Address(RVA = "0x190AC00", Offset = "0x190AC00", VA = "0x190AC00")] get
      {
        return (List<PlayerFggfcCoinMission>) null;
      }
    }

    [Token(Token = "0x600A66F")]
    [Address(RVA = "0x190AC08", Offset = "0x190AC08", VA = "0x190AC08")]
    public APIFggfcMissionAcceptResponse()
    {
    }
  }
}

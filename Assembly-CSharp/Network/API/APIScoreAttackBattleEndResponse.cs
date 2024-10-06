// Decompiled with JetBrains decompiler
// Type: Network.API.APIScoreAttackBattleEndResponse
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
  [Token(Token = "0x2001DF4")]
  [Serializable]
  public class APIScoreAttackBattleEndResponse : IPostApiResult, ICommonApiResult
  {
    [Token(Token = "0x4008042")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private NoticeData notice;
    [Token(Token = "0x4008043")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private UpdatedPlayerDataSet updated_player_data_set;
    [Token(Token = "0x4008044")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private PlayerCoinType player_coin;
    [Token(Token = "0x4008045")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private PlayerScoreAttackBattleResult results;
    [Token(Token = "0x4008046")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private List<Reward> high_score_rewards;
    [Token(Token = "0x4008047")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    private List<Reward> cumulative_score_rewards;

    [Token(Token = "0x1700237F")]
    public NoticeData Notice
    {
      [Token(Token = "0x600B138"), Address(RVA = "0x22DBCD4", Offset = "0x22DBCD4", VA = "0x22DBCD4", Slot = "6")] get
      {
        return (NoticeData) null;
      }
    }

    [Token(Token = "0x17002380")]
    public UpdatedPlayerDataSet UpdatedPlayerDataSet
    {
      [Token(Token = "0x600B139"), Address(RVA = "0x22DBCDC", Offset = "0x22DBCDC", VA = "0x22DBCDC", Slot = "4")] get
      {
        return (UpdatedPlayerDataSet) null;
      }
    }

    [Token(Token = "0x17002381")]
    public PlayerCoinType PlayerCoin
    {
      [Token(Token = "0x600B13A"), Address(RVA = "0x22DBCE4", Offset = "0x22DBCE4", VA = "0x22DBCE4", Slot = "5")] get
      {
        return (PlayerCoinType) null;
      }
    }

    [Token(Token = "0x17002382")]
    public PlayerScoreAttackBattleResult Results
    {
      [Token(Token = "0x600B13B"), Address(RVA = "0x22DBCEC", Offset = "0x22DBCEC", VA = "0x22DBCEC")] get
      {
        return (PlayerScoreAttackBattleResult) null;
      }
    }

    [Token(Token = "0x17002383")]
    public List<Reward> HighScoreRewards
    {
      [Token(Token = "0x600B13C"), Address(RVA = "0x22DBCF4", Offset = "0x22DBCF4", VA = "0x22DBCF4")] get
      {
        return (List<Reward>) null;
      }
    }

    [Token(Token = "0x17002384")]
    public List<Reward> CumulativeScoreRewards
    {
      [Token(Token = "0x600B13D"), Address(RVA = "0x22DBCFC", Offset = "0x22DBCFC", VA = "0x22DBCFC")] get
      {
        return (List<Reward>) null;
      }
    }

    [Token(Token = "0x600B13E")]
    [Address(RVA = "0x22DBD04", Offset = "0x22DBD04", VA = "0x22DBD04")]
    public APIScoreAttackBattleEndResponse()
    {
    }
  }
}

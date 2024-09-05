// Decompiled with JetBrains decompiler
// Type: Network.API.APIScenarioEventFreeQuestBattleSkipResponse
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
  [Token(Token = "0x2001DD8")]
  [Serializable]
  public class APIScenarioEventFreeQuestBattleSkipResponse : IPostApiResult, ICommonApiResult
  {
    [Token(Token = "0x4007F88")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private NoticeData notice;
    [Token(Token = "0x4007F89")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private UpdatedPlayerDataSet updated_player_data_set;
    [Token(Token = "0x4007F8A")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private PlayerCoinType player_coin;
    [Token(Token = "0x4007F8B")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private PlayerBattleSkipResult results;

    [Token(Token = "0x17002325")]
    public NoticeData Notice
    {
      [Token(Token = "0x600B06E"), Address(RVA = "0x1A537EC", Offset = "0x1A537EC", VA = "0x1A537EC", Slot = "6")] get
      {
        return (NoticeData) null;
      }
    }

    [Token(Token = "0x17002326")]
    public UpdatedPlayerDataSet UpdatedPlayerDataSet
    {
      [Token(Token = "0x600B06F"), Address(RVA = "0x1A537F4", Offset = "0x1A537F4", VA = "0x1A537F4", Slot = "4")] get
      {
        return (UpdatedPlayerDataSet) null;
      }
    }

    [Token(Token = "0x17002327")]
    public PlayerCoinType PlayerCoin
    {
      [Token(Token = "0x600B070"), Address(RVA = "0x1A537FC", Offset = "0x1A537FC", VA = "0x1A537FC", Slot = "5")] get
      {
        return (PlayerCoinType) null;
      }
    }

    [Token(Token = "0x17002328")]
    public PlayerBattleSkipResult Results
    {
      [Token(Token = "0x600B071"), Address(RVA = "0x1A53804", Offset = "0x1A53804", VA = "0x1A53804")] get
      {
        return (PlayerBattleSkipResult) null;
      }
    }

    [Token(Token = "0x600B072")]
    [Address(RVA = "0x1A5380C", Offset = "0x1A5380C", VA = "0x1A5380C")]
    public APIScenarioEventFreeQuestBattleSkipResponse()
    {
    }
  }
}

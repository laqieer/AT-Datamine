// Decompiled with JetBrains decompiler
// Type: Network.API.APIMissionAccept_progress_rewardsResponse
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
  [Token(Token = "0x2001D6C")]
  [Serializable]
  public class APIMissionAccept_progress_rewardsResponse : IPostApiResult, ICommonApiResult
  {
    [Token(Token = "0x4007DB2")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private NoticeData notice;
    [Token(Token = "0x4007DB3")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private UpdatedPlayerDataSet updated_player_data_set;
    [Token(Token = "0x4007DB4")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private PlayerCoinType player_coin;
    [Token(Token = "0x4007DB5")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private List<Reward> reward_results;
    [Token(Token = "0x4007DB6")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private List<PlayerMissionProgressType> player_mission_progresses;
    [Token(Token = "0x4007DB7")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    private List<int> accept_mission_progress_reward_ids;
    [Token(Token = "0x4007DB8")]
    [FieldOffset(Offset = "0x40")]
    [SerializeField]
    private PlayerType player;
    [Token(Token = "0x4007DB9")]
    [FieldOffset(Offset = "0x48")]
    [SerializeField]
    private UpdatedPlayerItems updated_player_items;
    [Token(Token = "0x4007DBA")]
    [FieldOffset(Offset = "0x50")]
    [SerializeField]
    private List<int> not_accepted_progress_reward_ids;

    [Token(Token = "0x17002207")]
    public NoticeData Notice
    {
      [Token(Token = "0x600ADA0"), Address(RVA = "0x1A4A528", Offset = "0x1A4A528", VA = "0x1A4A528", Slot = "6")] get
      {
        return (NoticeData) null;
      }
    }

    [Token(Token = "0x17002208")]
    public UpdatedPlayerDataSet UpdatedPlayerDataSet
    {
      [Token(Token = "0x600ADA1"), Address(RVA = "0x1A4A530", Offset = "0x1A4A530", VA = "0x1A4A530", Slot = "4")] get
      {
        return (UpdatedPlayerDataSet) null;
      }
    }

    [Token(Token = "0x17002209")]
    public PlayerCoinType PlayerCoin
    {
      [Token(Token = "0x600ADA2"), Address(RVA = "0x1A4A538", Offset = "0x1A4A538", VA = "0x1A4A538", Slot = "5")] get
      {
        return (PlayerCoinType) null;
      }
    }

    [Token(Token = "0x1700220A")]
    public List<Reward> RewardResults
    {
      [Token(Token = "0x600ADA3"), Address(RVA = "0x1A4A540", Offset = "0x1A4A540", VA = "0x1A4A540")] get
      {
        return (List<Reward>) null;
      }
    }

    [Token(Token = "0x1700220B")]
    public List<PlayerMissionProgressType> PlayerMissionProgresses
    {
      [Token(Token = "0x600ADA4"), Address(RVA = "0x1A4A548", Offset = "0x1A4A548", VA = "0x1A4A548")] get
      {
        return (List<PlayerMissionProgressType>) null;
      }
    }

    [Token(Token = "0x1700220C")]
    public List<int> AcceptMissionProgressRewardIds
    {
      [Token(Token = "0x600ADA5"), Address(RVA = "0x1A4A550", Offset = "0x1A4A550", VA = "0x1A4A550")] get
      {
        return (List<int>) null;
      }
    }

    [Token(Token = "0x1700220D")]
    public PlayerType Player
    {
      [Token(Token = "0x600ADA6"), Address(RVA = "0x1A4A558", Offset = "0x1A4A558", VA = "0x1A4A558")] get
      {
        return (PlayerType) null;
      }
    }

    [Token(Token = "0x1700220E")]
    public UpdatedPlayerItems UpdatedPlayerItems
    {
      [Token(Token = "0x600ADA7"), Address(RVA = "0x1A4A560", Offset = "0x1A4A560", VA = "0x1A4A560")] get
      {
        return (UpdatedPlayerItems) null;
      }
    }

    [Token(Token = "0x1700220F")]
    public List<int> NotAcceptedProgressRewardIds
    {
      [Token(Token = "0x600ADA8"), Address(RVA = "0x1A4A568", Offset = "0x1A4A568", VA = "0x1A4A568")] get
      {
        return (List<int>) null;
      }
    }

    [Token(Token = "0x600ADA9")]
    [Address(RVA = "0x1A4A570", Offset = "0x1A4A570", VA = "0x1A4A570")]
    public APIMissionAccept_progress_rewardsResponse()
    {
    }
  }
}

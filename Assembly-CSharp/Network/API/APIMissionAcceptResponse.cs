// Decompiled with JetBrains decompiler
// Type: Network.API.APIMissionAcceptResponse
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
  [Token(Token = "0x2001D68")]
  [Serializable]
  public class APIMissionAcceptResponse : IPostApiResult, ICommonApiResult
  {
    [Token(Token = "0x4007D9B")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private NoticeData notice;
    [Token(Token = "0x4007D9C")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private UpdatedPlayerDataSet updated_player_data_set;
    [Token(Token = "0x4007D9D")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private PlayerCoinType player_coin;
    [Token(Token = "0x4007D9E")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private List<Reward> reward_results;
    [Token(Token = "0x4007D9F")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private List<Reward> progress_reward_results;
    [Token(Token = "0x4007DA0")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    private List<PlayerMissionProgressType> player_mission_progresses;
    [Token(Token = "0x4007DA1")]
    [FieldOffset(Offset = "0x40")]
    [SerializeField]
    private List<int> accept_mission_progress_reward_ids;
    [Token(Token = "0x4007DA2")]
    [FieldOffset(Offset = "0x48")]
    [SerializeField]
    private PlayerType player;
    [Token(Token = "0x4007DA3")]
    [FieldOffset(Offset = "0x50")]
    [SerializeField]
    private UpdatedPlayerItems updated_player_items;
    [Token(Token = "0x4007DA4")]
    [FieldOffset(Offset = "0x58")]
    [SerializeField]
    private List<int> not_accepted_mission_ids;
    [Token(Token = "0x4007DA5")]
    [FieldOffset(Offset = "0x60")]
    [SerializeField]
    private List<int> not_accepted_progress_reward_ids;

    [Token(Token = "0x170021F6")]
    public NoticeData Notice
    {
      [Token(Token = "0x600AD7F"), Address(RVA = "0x1A49F84", Offset = "0x1A49F84", VA = "0x1A49F84", Slot = "6")] get
      {
        return (NoticeData) null;
      }
    }

    [Token(Token = "0x170021F7")]
    public UpdatedPlayerDataSet UpdatedPlayerDataSet
    {
      [Token(Token = "0x600AD80"), Address(RVA = "0x1A49F8C", Offset = "0x1A49F8C", VA = "0x1A49F8C", Slot = "4")] get
      {
        return (UpdatedPlayerDataSet) null;
      }
    }

    [Token(Token = "0x170021F8")]
    public PlayerCoinType PlayerCoin
    {
      [Token(Token = "0x600AD81"), Address(RVA = "0x1A49F94", Offset = "0x1A49F94", VA = "0x1A49F94", Slot = "5")] get
      {
        return (PlayerCoinType) null;
      }
    }

    [Token(Token = "0x170021F9")]
    public List<Reward> RewardResults
    {
      [Token(Token = "0x600AD82"), Address(RVA = "0x1A49F9C", Offset = "0x1A49F9C", VA = "0x1A49F9C")] get
      {
        return (List<Reward>) null;
      }
    }

    [Token(Token = "0x170021FA")]
    public List<Reward> ProgressRewardResults
    {
      [Token(Token = "0x600AD83"), Address(RVA = "0x1A49FA4", Offset = "0x1A49FA4", VA = "0x1A49FA4")] get
      {
        return (List<Reward>) null;
      }
    }

    [Token(Token = "0x170021FB")]
    public List<PlayerMissionProgressType> PlayerMissionProgresses
    {
      [Token(Token = "0x600AD84"), Address(RVA = "0x1A49FAC", Offset = "0x1A49FAC", VA = "0x1A49FAC")] get
      {
        return (List<PlayerMissionProgressType>) null;
      }
    }

    [Token(Token = "0x170021FC")]
    public List<int> AcceptMissionProgressRewardIds
    {
      [Token(Token = "0x600AD85"), Address(RVA = "0x1A49FB4", Offset = "0x1A49FB4", VA = "0x1A49FB4")] get
      {
        return (List<int>) null;
      }
    }

    [Token(Token = "0x170021FD")]
    public PlayerType Player
    {
      [Token(Token = "0x600AD86"), Address(RVA = "0x1A49FBC", Offset = "0x1A49FBC", VA = "0x1A49FBC")] get
      {
        return (PlayerType) null;
      }
    }

    [Token(Token = "0x170021FE")]
    public UpdatedPlayerItems UpdatedPlayerItems
    {
      [Token(Token = "0x600AD87"), Address(RVA = "0x1A49FC4", Offset = "0x1A49FC4", VA = "0x1A49FC4")] get
      {
        return (UpdatedPlayerItems) null;
      }
    }

    [Token(Token = "0x170021FF")]
    public List<int> NotAcceptedMissionIds
    {
      [Token(Token = "0x600AD88"), Address(RVA = "0x1A49FCC", Offset = "0x1A49FCC", VA = "0x1A49FCC")] get
      {
        return (List<int>) null;
      }
    }

    [Token(Token = "0x17002200")]
    public List<int> NotAcceptedProgressRewardIds
    {
      [Token(Token = "0x600AD89"), Address(RVA = "0x1A49FD4", Offset = "0x1A49FD4", VA = "0x1A49FD4")] get
      {
        return (List<int>) null;
      }
    }

    [Token(Token = "0x600AD8A")]
    [Address(RVA = "0x1A49FDC", Offset = "0x1A49FDC", VA = "0x1A49FDC")]
    public APIMissionAcceptResponse()
    {
    }
  }
}

// Decompiled with JetBrains decompiler
// Type: Network.API.APIStoryFreeactionChestOpenResponse
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
  [Token(Token = "0x2001E3C")]
  [Serializable]
  public class APIStoryFreeactionChestOpenResponse : IPostApiResult, ICommonApiResult
  {
    [Token(Token = "0x4008188")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private NoticeData notice;
    [Token(Token = "0x4008189")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private UpdatedPlayerDataSet updated_player_data_set;
    [Token(Token = "0x400818A")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private PlayerCoinType player_coin;
    [Token(Token = "0x400818B")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private List<RewardGiveResultEntityType> rewards;

    [Token(Token = "0x17002439")]
    public NoticeData Notice
    {
      [Token(Token = "0x600B312"), Address(RVA = "0x22E1E9C", Offset = "0x22E1E9C", VA = "0x22E1E9C", Slot = "6")] get
      {
        return (NoticeData) null;
      }
    }

    [Token(Token = "0x1700243A")]
    public UpdatedPlayerDataSet UpdatedPlayerDataSet
    {
      [Token(Token = "0x600B313"), Address(RVA = "0x22E1EA4", Offset = "0x22E1EA4", VA = "0x22E1EA4", Slot = "4")] get
      {
        return (UpdatedPlayerDataSet) null;
      }
    }

    [Token(Token = "0x1700243B")]
    public PlayerCoinType PlayerCoin
    {
      [Token(Token = "0x600B314"), Address(RVA = "0x22E1EAC", Offset = "0x22E1EAC", VA = "0x22E1EAC", Slot = "5")] get
      {
        return (PlayerCoinType) null;
      }
    }

    [Token(Token = "0x1700243C")]
    public List<RewardGiveResultEntityType> Rewards
    {
      [Token(Token = "0x600B315"), Address(RVA = "0x22E1EB4", Offset = "0x22E1EB4", VA = "0x22E1EB4")] get
      {
        return (List<RewardGiveResultEntityType>) null;
      }
    }

    [Token(Token = "0x600B316")]
    [Address(RVA = "0x22E1EBC", Offset = "0x22E1EBC", VA = "0x22E1EBC")]
    public APIStoryFreeactionChestOpenResponse()
    {
    }
  }
}

// Decompiled with JetBrains decompiler
// Type: Network.API.APIStoryFreeactionBreakableCrushResponse
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
  [Token(Token = "0x2001E38")]
  [Serializable]
  public class APIStoryFreeactionBreakableCrushResponse : IPostApiResult, ICommonApiResult
  {
    [Token(Token = "0x4008177")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private NoticeData notice;
    [Token(Token = "0x4008178")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private UpdatedPlayerDataSet updated_player_data_set;
    [Token(Token = "0x4008179")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private PlayerCoinType player_coin;
    [Token(Token = "0x400817A")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private List<RewardGiveResultEntityType> rewards;

    [Token(Token = "0x1700242F")]
    public NoticeData Notice
    {
      [Token(Token = "0x600B2F8"), Address(RVA = "0x22E1930", Offset = "0x22E1930", VA = "0x22E1930", Slot = "6")] get
      {
        return (NoticeData) null;
      }
    }

    [Token(Token = "0x17002430")]
    public UpdatedPlayerDataSet UpdatedPlayerDataSet
    {
      [Token(Token = "0x600B2F9"), Address(RVA = "0x22E1938", Offset = "0x22E1938", VA = "0x22E1938", Slot = "4")] get
      {
        return (UpdatedPlayerDataSet) null;
      }
    }

    [Token(Token = "0x17002431")]
    public PlayerCoinType PlayerCoin
    {
      [Token(Token = "0x600B2FA"), Address(RVA = "0x22E1940", Offset = "0x22E1940", VA = "0x22E1940", Slot = "5")] get
      {
        return (PlayerCoinType) null;
      }
    }

    [Token(Token = "0x17002432")]
    public List<RewardGiveResultEntityType> Rewards
    {
      [Token(Token = "0x600B2FB"), Address(RVA = "0x22E1948", Offset = "0x22E1948", VA = "0x22E1948")] get
      {
        return (List<RewardGiveResultEntityType>) null;
      }
    }

    [Token(Token = "0x600B2FC")]
    [Address(RVA = "0x22E1950", Offset = "0x22E1950", VA = "0x22E1950")]
    public APIStoryFreeactionBreakableCrushResponse()
    {
    }
  }
}

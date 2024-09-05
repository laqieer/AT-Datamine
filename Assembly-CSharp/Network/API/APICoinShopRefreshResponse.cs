// Decompiled with JetBrains decompiler
// Type: Network.API.APICoinShopRefreshResponse
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
  [Token(Token = "0x2001BE0")]
  [Serializable]
  public class APICoinShopRefreshResponse : IPostApiResult, ICommonApiResult
  {
    [Token(Token = "0x400775C")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private NoticeData notice;
    [Token(Token = "0x400775D")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private UpdatedPlayerDataSet updated_player_data_set;
    [Token(Token = "0x400775E")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private PlayerCoinType player_coin;
    [Token(Token = "0x400775F")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private List<PlayerCoinShopType> coin_shops;
    [Token(Token = "0x4007760")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private List<PlayerRewardPassType> player_reward_pass;

    [Token(Token = "0x17001E69")]
    public NoticeData Notice
    {
      [Token(Token = "0x600A3D2"), Address(RVA = "0x46D03D0", Offset = "0x46D03D0", VA = "0x46D03D0", Slot = "6")] get
      {
        return (NoticeData) null;
      }
    }

    [Token(Token = "0x17001E6A")]
    public UpdatedPlayerDataSet UpdatedPlayerDataSet
    {
      [Token(Token = "0x600A3D3"), Address(RVA = "0x46D03D8", Offset = "0x46D03D8", VA = "0x46D03D8", Slot = "4")] get
      {
        return (UpdatedPlayerDataSet) null;
      }
    }

    [Token(Token = "0x17001E6B")]
    public PlayerCoinType PlayerCoin
    {
      [Token(Token = "0x600A3D4"), Address(RVA = "0x46D03E0", Offset = "0x46D03E0", VA = "0x46D03E0", Slot = "5")] get
      {
        return (PlayerCoinType) null;
      }
    }

    [Token(Token = "0x17001E6C")]
    public List<PlayerCoinShopType> CoinShops
    {
      [Token(Token = "0x600A3D5"), Address(RVA = "0x46D03E8", Offset = "0x46D03E8", VA = "0x46D03E8")] get
      {
        return (List<PlayerCoinShopType>) null;
      }
    }

    [Token(Token = "0x17001E6D")]
    public List<PlayerRewardPassType> PlayerRewardPass
    {
      [Token(Token = "0x600A3D6"), Address(RVA = "0x46D03F0", Offset = "0x46D03F0", VA = "0x46D03F0")] get
      {
        return (List<PlayerRewardPassType>) null;
      }
    }

    [Token(Token = "0x600A3D7")]
    [Address(RVA = "0x46D03F8", Offset = "0x46D03F8", VA = "0x46D03F8")]
    public APICoinShopRefreshResponse()
    {
    }
  }
}

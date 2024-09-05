// Decompiled with JetBrains decompiler
// Type: Network.API.APIItemSellResponse
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
  [Token(Token = "0x2001D40")]
  [Serializable]
  public class APIItemSellResponse : IPostApiResult, ICommonApiResult
  {
    [Token(Token = "0x4007CE6")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private NoticeData notice;
    [Token(Token = "0x4007CE7")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private UpdatedPlayerDataSet updated_player_data_set;
    [Token(Token = "0x4007CE8")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private PlayerCoinType player_coin;
    [Token(Token = "0x4007CE9")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private UpdatedPlayerItems updated_player_items;

    [Token(Token = "0x17002192")]
    public NoticeData Notice
    {
      [Token(Token = "0x600AC7B"), Address(RVA = "0x1A4695C", Offset = "0x1A4695C", VA = "0x1A4695C", Slot = "6")] get
      {
        return (NoticeData) null;
      }
    }

    [Token(Token = "0x17002193")]
    public UpdatedPlayerDataSet UpdatedPlayerDataSet
    {
      [Token(Token = "0x600AC7C"), Address(RVA = "0x1A46964", Offset = "0x1A46964", VA = "0x1A46964", Slot = "4")] get
      {
        return (UpdatedPlayerDataSet) null;
      }
    }

    [Token(Token = "0x17002194")]
    public PlayerCoinType PlayerCoin
    {
      [Token(Token = "0x600AC7D"), Address(RVA = "0x1A4696C", Offset = "0x1A4696C", VA = "0x1A4696C", Slot = "5")] get
      {
        return (PlayerCoinType) null;
      }
    }

    [Token(Token = "0x17002195")]
    public UpdatedPlayerItems UpdatedPlayerItems
    {
      [Token(Token = "0x600AC7E"), Address(RVA = "0x1A46974", Offset = "0x1A46974", VA = "0x1A46974")] get
      {
        return (UpdatedPlayerItems) null;
      }
    }

    [Token(Token = "0x600AC7F")]
    [Address(RVA = "0x1A4697C", Offset = "0x1A4697C", VA = "0x1A4697C")]
    public APIItemSellResponse()
    {
    }
  }
}

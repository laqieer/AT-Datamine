// Decompiled with JetBrains decompiler
// Type: Network.API.APIExpeditionSoul_spotLevel_upResponse
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
  [Token(Token = "0x2001C30")]
  [Serializable]
  public class APIExpeditionSoul_spotLevel_upResponse : IPostApiResult, ICommonApiResult
  {
    [Token(Token = "0x40078B1")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private NoticeData notice;
    [Token(Token = "0x40078B2")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private UpdatedPlayerDataSet updated_player_data_set;
    [Token(Token = "0x40078B3")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private PlayerCoinType player_coin;
    [Token(Token = "0x40078B4")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private PlayerType player;
    [Token(Token = "0x40078B5")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private PlayerExpeditionSoulSpotType player_expedition_soul_spot;
    [Token(Token = "0x40078B6")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    private UpdatedPlayerItems updated_player_items;

    [Token(Token = "0x17001F38")]
    public NoticeData Notice
    {
      [Token(Token = "0x600A5E1"), Address(RVA = "0x190908C", Offset = "0x190908C", VA = "0x190908C", Slot = "6")] get
      {
        return (NoticeData) null;
      }
    }

    [Token(Token = "0x17001F39")]
    public UpdatedPlayerDataSet UpdatedPlayerDataSet
    {
      [Token(Token = "0x600A5E2"), Address(RVA = "0x1909094", Offset = "0x1909094", VA = "0x1909094", Slot = "4")] get
      {
        return (UpdatedPlayerDataSet) null;
      }
    }

    [Token(Token = "0x17001F3A")]
    public PlayerCoinType PlayerCoin
    {
      [Token(Token = "0x600A5E3"), Address(RVA = "0x190909C", Offset = "0x190909C", VA = "0x190909C", Slot = "5")] get
      {
        return (PlayerCoinType) null;
      }
    }

    [Token(Token = "0x17001F3B")]
    public PlayerType Player
    {
      [Token(Token = "0x600A5E4"), Address(RVA = "0x19090A4", Offset = "0x19090A4", VA = "0x19090A4")] get
      {
        return (PlayerType) null;
      }
    }

    [Token(Token = "0x17001F3C")]
    public PlayerExpeditionSoulSpotType PlayerExpeditionSoulSpot
    {
      [Token(Token = "0x600A5E5"), Address(RVA = "0x19090AC", Offset = "0x19090AC", VA = "0x19090AC")] get
      {
        return (PlayerExpeditionSoulSpotType) null;
      }
    }

    [Token(Token = "0x17001F3D")]
    public UpdatedPlayerItems UpdatedPlayerItems
    {
      [Token(Token = "0x600A5E6"), Address(RVA = "0x19090B4", Offset = "0x19090B4", VA = "0x19090B4")] get
      {
        return (UpdatedPlayerItems) null;
      }
    }

    [Token(Token = "0x600A5E7")]
    [Address(RVA = "0x19090BC", Offset = "0x19090BC", VA = "0x19090BC")]
    public APIExpeditionSoul_spotLevel_upResponse()
    {
    }
  }
}

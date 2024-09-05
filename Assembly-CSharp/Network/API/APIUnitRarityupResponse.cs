// Decompiled with JetBrains decompiler
// Type: Network.API.APIUnitRarityupResponse
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
  [Token(Token = "0x2001EC4")]
  [Serializable]
  public class APIUnitRarityupResponse : IPostApiResult, ICommonApiResult
  {
    [Token(Token = "0x4008423")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private NoticeData notice;
    [Token(Token = "0x4008424")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private UpdatedPlayerDataSet updated_player_data_set;
    [Token(Token = "0x4008425")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private PlayerCoinType player_coin;
    [Token(Token = "0x4008426")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private PlayerUnitType player_unit;
    [Token(Token = "0x4008427")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private UpdatedPlayerItems consume_items;

    [Token(Token = "0x170025B8")]
    public NoticeData Notice
    {
      [Token(Token = "0x600B6B1"), Address(RVA = "0x22ED84C", Offset = "0x22ED84C", VA = "0x22ED84C", Slot = "6")] get
      {
        return (NoticeData) null;
      }
    }

    [Token(Token = "0x170025B9")]
    public UpdatedPlayerDataSet UpdatedPlayerDataSet
    {
      [Token(Token = "0x600B6B2"), Address(RVA = "0x22ED854", Offset = "0x22ED854", VA = "0x22ED854", Slot = "4")] get
      {
        return (UpdatedPlayerDataSet) null;
      }
    }

    [Token(Token = "0x170025BA")]
    public PlayerCoinType PlayerCoin
    {
      [Token(Token = "0x600B6B3"), Address(RVA = "0x22ED85C", Offset = "0x22ED85C", VA = "0x22ED85C", Slot = "5")] get
      {
        return (PlayerCoinType) null;
      }
    }

    [Token(Token = "0x170025BB")]
    public PlayerUnitType PlayerUnit
    {
      [Token(Token = "0x600B6B4"), Address(RVA = "0x22ED864", Offset = "0x22ED864", VA = "0x22ED864")] get
      {
        return (PlayerUnitType) null;
      }
    }

    [Token(Token = "0x170025BC")]
    public UpdatedPlayerItems ConsumeItems
    {
      [Token(Token = "0x600B6B5"), Address(RVA = "0x22ED86C", Offset = "0x22ED86C", VA = "0x22ED86C")] get
      {
        return (UpdatedPlayerItems) null;
      }
    }

    [Token(Token = "0x600B6B6")]
    [Address(RVA = "0x22ED874", Offset = "0x22ED874", VA = "0x22ED874")]
    public APIUnitRarityupResponse()
    {
    }
  }
}

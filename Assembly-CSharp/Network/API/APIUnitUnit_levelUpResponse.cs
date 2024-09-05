// Decompiled with JetBrains decompiler
// Type: Network.API.APIUnitUnit_levelUpResponse
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
  [Token(Token = "0x2001EE0")]
  [Serializable]
  public class APIUnitUnit_levelUpResponse : IPostApiResult, ICommonApiResult
  {
    [Token(Token = "0x4008497")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private NoticeData notice;
    [Token(Token = "0x4008498")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private UpdatedPlayerDataSet updated_player_data_set;
    [Token(Token = "0x4008499")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private PlayerCoinType player_coin;
    [Token(Token = "0x400849A")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private PlayerUnitType player_unit;
    [Token(Token = "0x400849B")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private UpdatedPlayerItems consume_items;

    [Token(Token = "0x170025F8")]
    public NoticeData Notice
    {
      [Token(Token = "0x600B761"), Address(RVA = "0x2130954", Offset = "0x2130954", VA = "0x2130954", Slot = "6")] get
      {
        return (NoticeData) null;
      }
    }

    [Token(Token = "0x170025F9")]
    public UpdatedPlayerDataSet UpdatedPlayerDataSet
    {
      [Token(Token = "0x600B762"), Address(RVA = "0x213095C", Offset = "0x213095C", VA = "0x213095C", Slot = "4")] get
      {
        return (UpdatedPlayerDataSet) null;
      }
    }

    [Token(Token = "0x170025FA")]
    public PlayerCoinType PlayerCoin
    {
      [Token(Token = "0x600B763"), Address(RVA = "0x2130964", Offset = "0x2130964", VA = "0x2130964", Slot = "5")] get
      {
        return (PlayerCoinType) null;
      }
    }

    [Token(Token = "0x170025FB")]
    public PlayerUnitType PlayerUnit
    {
      [Token(Token = "0x600B764"), Address(RVA = "0x213096C", Offset = "0x213096C", VA = "0x213096C")] get
      {
        return (PlayerUnitType) null;
      }
    }

    [Token(Token = "0x170025FC")]
    public UpdatedPlayerItems ConsumeItems
    {
      [Token(Token = "0x600B765"), Address(RVA = "0x2130974", Offset = "0x2130974", VA = "0x2130974")] get
      {
        return (UpdatedPlayerItems) null;
      }
    }

    [Token(Token = "0x600B766")]
    [Address(RVA = "0x213097C", Offset = "0x213097C", VA = "0x213097C")]
    public APIUnitUnit_levelUpResponse()
    {
    }
  }
}

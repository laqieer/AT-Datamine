// Decompiled with JetBrains decompiler
// Type: Network.API.APIAccessoryLimit_breakResponse
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
  [Token(Token = "0x2001B3C")]
  [Serializable]
  public class APIAccessoryLimit_breakResponse : IPostApiResult, ICommonApiResult
  {
    [Token(Token = "0x40074D4")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private NoticeData notice;
    [Token(Token = "0x40074D5")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private UpdatedPlayerDataSet updated_player_data_set;
    [Token(Token = "0x40074D6")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private PlayerCoinType player_coin;
    [Token(Token = "0x40074D7")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private PlayerGearAccessoryType player_accessory;
    [Token(Token = "0x40074D8")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private List<PlayerAccessoryPieceType> player_accessory_pieces;

    [Token(Token = "0x17001D0A")]
    public NoticeData Notice
    {
      [Token(Token = "0x6009FE3"), Address(RVA = "0x46C275C", Offset = "0x46C275C", VA = "0x46C275C", Slot = "6")] get
      {
        return (NoticeData) null;
      }
    }

    [Token(Token = "0x17001D0B")]
    public UpdatedPlayerDataSet UpdatedPlayerDataSet
    {
      [Token(Token = "0x6009FE4"), Address(RVA = "0x46C2764", Offset = "0x46C2764", VA = "0x46C2764", Slot = "4")] get
      {
        return (UpdatedPlayerDataSet) null;
      }
    }

    [Token(Token = "0x17001D0C")]
    public PlayerCoinType PlayerCoin
    {
      [Token(Token = "0x6009FE5"), Address(RVA = "0x46C276C", Offset = "0x46C276C", VA = "0x46C276C", Slot = "5")] get
      {
        return (PlayerCoinType) null;
      }
    }

    [Token(Token = "0x17001D0D")]
    public PlayerGearAccessoryType PlayerAccessory
    {
      [Token(Token = "0x6009FE6"), Address(RVA = "0x46C2774", Offset = "0x46C2774", VA = "0x46C2774")] get
      {
        return (PlayerGearAccessoryType) null;
      }
    }

    [Token(Token = "0x17001D0E")]
    public List<PlayerAccessoryPieceType> PlayerAccessoryPieces
    {
      [Token(Token = "0x6009FE7"), Address(RVA = "0x46C277C", Offset = "0x46C277C", VA = "0x46C277C")] get
      {
        return (List<PlayerAccessoryPieceType>) null;
      }
    }

    [Token(Token = "0x6009FE8")]
    [Address(RVA = "0x46C2784", Offset = "0x46C2784", VA = "0x46C2784")]
    public APIAccessoryLimit_breakResponse()
    {
    }
  }
}

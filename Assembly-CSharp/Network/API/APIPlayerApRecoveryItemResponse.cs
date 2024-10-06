// Decompiled with JetBrains decompiler
// Type: Network.API.APIPlayerApRecoveryItemResponse
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
  [Token(Token = "0x2001D84")]
  [Serializable]
  public class APIPlayerApRecoveryItemResponse : IPostApiResult, ICommonApiResult
  {
    [Token(Token = "0x4007E0C")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private NoticeData notice;
    [Token(Token = "0x4007E0D")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private UpdatedPlayerDataSet updated_player_data_set;
    [Token(Token = "0x4007E0E")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private PlayerCoinType player_coin;
    [Token(Token = "0x4007E0F")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private PlayerApType player_ap;
    [Token(Token = "0x4007E10")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private UpdatedPlayerItems updated_player_items;

    [Token(Token = "0x1700223C")]
    public NoticeData Notice
    {
      [Token(Token = "0x600AE35"), Address(RVA = "0x1A4C568", Offset = "0x1A4C568", VA = "0x1A4C568", Slot = "6")] get
      {
        return (NoticeData) null;
      }
    }

    [Token(Token = "0x1700223D")]
    public UpdatedPlayerDataSet UpdatedPlayerDataSet
    {
      [Token(Token = "0x600AE36"), Address(RVA = "0x1A4C570", Offset = "0x1A4C570", VA = "0x1A4C570", Slot = "4")] get
      {
        return (UpdatedPlayerDataSet) null;
      }
    }

    [Token(Token = "0x1700223E")]
    public PlayerCoinType PlayerCoin
    {
      [Token(Token = "0x600AE37"), Address(RVA = "0x1A4C578", Offset = "0x1A4C578", VA = "0x1A4C578", Slot = "5")] get
      {
        return (PlayerCoinType) null;
      }
    }

    [Token(Token = "0x1700223F")]
    public PlayerApType PlayerAp
    {
      [Token(Token = "0x600AE38"), Address(RVA = "0x1A4C580", Offset = "0x1A4C580", VA = "0x1A4C580")] get
      {
        return (PlayerApType) null;
      }
    }

    [Token(Token = "0x17002240")]
    public UpdatedPlayerItems UpdatedPlayerItems
    {
      [Token(Token = "0x600AE39"), Address(RVA = "0x1A4C588", Offset = "0x1A4C588", VA = "0x1A4C588")] get
      {
        return (UpdatedPlayerItems) null;
      }
    }

    [Token(Token = "0x600AE3A")]
    [Address(RVA = "0x1A4C590", Offset = "0x1A4C590", VA = "0x1A4C590")]
    public APIPlayerApRecoveryItemResponse()
    {
    }
  }
}

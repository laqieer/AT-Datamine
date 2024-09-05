// Decompiled with JetBrains decompiler
// Type: Network.API.APIMind_equipmentLimit_breakResponse
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
  [Token(Token = "0x2001D60")]
  [Serializable]
  public class APIMind_equipmentLimit_breakResponse : IPostApiResult, ICommonApiResult
  {
    [Token(Token = "0x4007D79")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private NoticeData notice;
    [Token(Token = "0x4007D7A")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private UpdatedPlayerDataSet updated_player_data_set;
    [Token(Token = "0x4007D7B")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private PlayerCoinType player_coin;
    [Token(Token = "0x4007D7C")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private PlayerGearMindEquipmentType player_mind_equipment;

    [Token(Token = "0x170021E1")]
    public NoticeData Notice
    {
      [Token(Token = "0x600AD4A"), Address(RVA = "0x1A494A4", Offset = "0x1A494A4", VA = "0x1A494A4", Slot = "6")] get
      {
        return (NoticeData) null;
      }
    }

    [Token(Token = "0x170021E2")]
    public UpdatedPlayerDataSet UpdatedPlayerDataSet
    {
      [Token(Token = "0x600AD4B"), Address(RVA = "0x1A494AC", Offset = "0x1A494AC", VA = "0x1A494AC", Slot = "4")] get
      {
        return (UpdatedPlayerDataSet) null;
      }
    }

    [Token(Token = "0x170021E3")]
    public PlayerCoinType PlayerCoin
    {
      [Token(Token = "0x600AD4C"), Address(RVA = "0x1A494B4", Offset = "0x1A494B4", VA = "0x1A494B4", Slot = "5")] get
      {
        return (PlayerCoinType) null;
      }
    }

    [Token(Token = "0x170021E4")]
    public PlayerGearMindEquipmentType PlayerMindEquipment
    {
      [Token(Token = "0x600AD4D"), Address(RVA = "0x1A494BC", Offset = "0x1A494BC", VA = "0x1A494BC")] get
      {
        return (PlayerGearMindEquipmentType) null;
      }
    }

    [Token(Token = "0x600AD4E")]
    [Address(RVA = "0x1A494C4", Offset = "0x1A494C4", VA = "0x1A494C4")]
    public APIMind_equipmentLimit_breakResponse()
    {
    }
  }
}

// Decompiled with JetBrains decompiler
// Type: Network.API.APIMind_equipmentMedal_exchangeResponse
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
  [Token(Token = "0x2001D64")]
  [Serializable]
  public class APIMind_equipmentMedal_exchangeResponse : IPostApiResult, ICommonApiResult
  {
    [Token(Token = "0x4007D89")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private NoticeData notice;
    [Token(Token = "0x4007D8A")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private UpdatedPlayerDataSet updated_player_data_set;
    [Token(Token = "0x4007D8B")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private PlayerCoinType player_coin;
    [Token(Token = "0x4007D8C")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private List<PlayerGearMindEquipmentType> player_mind_equipments;
    [Token(Token = "0x4007D8D")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private List<PlayerMedalType> player_medals;

    [Token(Token = "0x170021EB")]
    public NoticeData Notice
    {
      [Token(Token = "0x600AD64"), Address(RVA = "0x1A49A10", Offset = "0x1A49A10", VA = "0x1A49A10", Slot = "6")] get
      {
        return (NoticeData) null;
      }
    }

    [Token(Token = "0x170021EC")]
    public UpdatedPlayerDataSet UpdatedPlayerDataSet
    {
      [Token(Token = "0x600AD65"), Address(RVA = "0x1A49A18", Offset = "0x1A49A18", VA = "0x1A49A18", Slot = "4")] get
      {
        return (UpdatedPlayerDataSet) null;
      }
    }

    [Token(Token = "0x170021ED")]
    public PlayerCoinType PlayerCoin
    {
      [Token(Token = "0x600AD66"), Address(RVA = "0x1A49A20", Offset = "0x1A49A20", VA = "0x1A49A20", Slot = "5")] get
      {
        return (PlayerCoinType) null;
      }
    }

    [Token(Token = "0x170021EE")]
    public List<PlayerGearMindEquipmentType> PlayerMindEquipments
    {
      [Token(Token = "0x600AD67"), Address(RVA = "0x1A49A28", Offset = "0x1A49A28", VA = "0x1A49A28")] get
      {
        return (List<PlayerGearMindEquipmentType>) null;
      }
    }

    [Token(Token = "0x170021EF")]
    public List<PlayerMedalType> PlayerMedals
    {
      [Token(Token = "0x600AD68"), Address(RVA = "0x1A49A30", Offset = "0x1A49A30", VA = "0x1A49A30")] get
      {
        return (List<PlayerMedalType>) null;
      }
    }

    [Token(Token = "0x600AD69")]
    [Address(RVA = "0x1A49A38", Offset = "0x1A49A38", VA = "0x1A49A38")]
    public APIMind_equipmentMedal_exchangeResponse()
    {
    }
  }
}

// Decompiled with JetBrains decompiler
// Type: Network.API.APIMind_equipmentEnhanceResponse
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
  [Token(Token = "0x2001D58")]
  [Serializable]
  public class APIMind_equipmentEnhanceResponse : IPostApiResult, ICommonApiResult
  {
    [Token(Token = "0x4007D58")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private NoticeData notice;
    [Token(Token = "0x4007D59")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private UpdatedPlayerDataSet updated_player_data_set;
    [Token(Token = "0x4007D5A")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private PlayerCoinType player_coin;
    [Token(Token = "0x4007D5B")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private PlayerGearMindEquipmentType player_mind_equipment;
    [Token(Token = "0x4007D5C")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private PlayerUnitCustomSkillType player_custom_skill;
    [Token(Token = "0x4007D5D")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    private List<PlayerSoulType> player_souls;

    [Token(Token = "0x170021CE")]
    public NoticeData Notice
    {
      [Token(Token = "0x600AD17"), Address(RVA = "0x1A489D4", Offset = "0x1A489D4", VA = "0x1A489D4", Slot = "6")] get
      {
        return (NoticeData) null;
      }
    }

    [Token(Token = "0x170021CF")]
    public UpdatedPlayerDataSet UpdatedPlayerDataSet
    {
      [Token(Token = "0x600AD18"), Address(RVA = "0x1A489DC", Offset = "0x1A489DC", VA = "0x1A489DC", Slot = "4")] get
      {
        return (UpdatedPlayerDataSet) null;
      }
    }

    [Token(Token = "0x170021D0")]
    public PlayerCoinType PlayerCoin
    {
      [Token(Token = "0x600AD19"), Address(RVA = "0x1A489E4", Offset = "0x1A489E4", VA = "0x1A489E4", Slot = "5")] get
      {
        return (PlayerCoinType) null;
      }
    }

    [Token(Token = "0x170021D1")]
    public PlayerGearMindEquipmentType PlayerMindEquipment
    {
      [Token(Token = "0x600AD1A"), Address(RVA = "0x1A489EC", Offset = "0x1A489EC", VA = "0x1A489EC")] get
      {
        return (PlayerGearMindEquipmentType) null;
      }
    }

    [Token(Token = "0x170021D2")]
    public PlayerUnitCustomSkillType PlayerCustomSkill
    {
      [Token(Token = "0x600AD1B"), Address(RVA = "0x1A489F4", Offset = "0x1A489F4", VA = "0x1A489F4")] get
      {
        return (PlayerUnitCustomSkillType) null;
      }
    }

    [Token(Token = "0x170021D3")]
    public List<PlayerSoulType> PlayerSouls
    {
      [Token(Token = "0x600AD1C"), Address(RVA = "0x1A489FC", Offset = "0x1A489FC", VA = "0x1A489FC")] get
      {
        return (List<PlayerSoulType>) null;
      }
    }

    [Token(Token = "0x600AD1D")]
    [Address(RVA = "0x1A48A04", Offset = "0x1A48A04", VA = "0x1A48A04")]
    public APIMind_equipmentEnhanceResponse()
    {
    }
  }
}

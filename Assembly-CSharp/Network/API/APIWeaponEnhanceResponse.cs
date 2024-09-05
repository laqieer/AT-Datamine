// Decompiled with JetBrains decompiler
// Type: Network.API.APIWeaponEnhanceResponse
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
  [Token(Token = "0x2001EF0")]
  [Serializable]
  public class APIWeaponEnhanceResponse : IPostApiResult, ICommonApiResult
  {
    [Token(Token = "0x40084D5")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private NoticeData notice;
    [Token(Token = "0x40084D6")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private UpdatedPlayerDataSet updated_player_data_set;
    [Token(Token = "0x40084D7")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private PlayerCoinType player_coin;
    [Token(Token = "0x40084D8")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private PlayerGearWeaponType weapon;
    [Token(Token = "0x40084D9")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private List<PlayerWeaponMasterBonusType> player_weapon_master_bonuses;
    [Token(Token = "0x40084DA")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    private List<PlayerSoulType> player_souls;

    [Token(Token = "0x1700261C")]
    public NoticeData Notice
    {
      [Token(Token = "0x600B7C5"), Address(RVA = "0x2131EE4", Offset = "0x2131EE4", VA = "0x2131EE4", Slot = "6")] get
      {
        return (NoticeData) null;
      }
    }

    [Token(Token = "0x1700261D")]
    public UpdatedPlayerDataSet UpdatedPlayerDataSet
    {
      [Token(Token = "0x600B7C6"), Address(RVA = "0x2131EEC", Offset = "0x2131EEC", VA = "0x2131EEC", Slot = "4")] get
      {
        return (UpdatedPlayerDataSet) null;
      }
    }

    [Token(Token = "0x1700261E")]
    public PlayerCoinType PlayerCoin
    {
      [Token(Token = "0x600B7C7"), Address(RVA = "0x2131EF4", Offset = "0x2131EF4", VA = "0x2131EF4", Slot = "5")] get
      {
        return (PlayerCoinType) null;
      }
    }

    [Token(Token = "0x1700261F")]
    public PlayerGearWeaponType Weapon
    {
      [Token(Token = "0x600B7C8"), Address(RVA = "0x2131EFC", Offset = "0x2131EFC", VA = "0x2131EFC")] get
      {
        return (PlayerGearWeaponType) null;
      }
    }

    [Token(Token = "0x17002620")]
    public List<PlayerWeaponMasterBonusType> PlayerWeaponMasterBonuses
    {
      [Token(Token = "0x600B7C9"), Address(RVA = "0x2131F04", Offset = "0x2131F04", VA = "0x2131F04")] get
      {
        return (List<PlayerWeaponMasterBonusType>) null;
      }
    }

    [Token(Token = "0x17002621")]
    public List<PlayerSoulType> PlayerSouls
    {
      [Token(Token = "0x600B7CA"), Address(RVA = "0x2131F0C", Offset = "0x2131F0C", VA = "0x2131F0C")] get
      {
        return (List<PlayerSoulType>) null;
      }
    }

    [Token(Token = "0x600B7CB")]
    [Address(RVA = "0x2131F14", Offset = "0x2131F14", VA = "0x2131F14")]
    public APIWeaponEnhanceResponse()
    {
    }
  }
}

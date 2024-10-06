// Decompiled with JetBrains decompiler
// Type: Network.API.APIWeaponLimit_breakResponse
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
  [Token(Token = "0x2001EF8")]
  [Serializable]
  public class APIWeaponLimit_breakResponse : IPostApiResult, ICommonApiResult
  {
    [Token(Token = "0x40084F6")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private NoticeData notice;
    [Token(Token = "0x40084F7")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private UpdatedPlayerDataSet updated_player_data_set;
    [Token(Token = "0x40084F8")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private PlayerCoinType player_coin;
    [Token(Token = "0x40084F9")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private PlayerGearWeaponType player_weapon;
    [Token(Token = "0x40084FA")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private List<PlayerWeaponPieceType> player_weapon_pieces;

    [Token(Token = "0x1700262F")]
    public NoticeData Notice
    {
      [Token(Token = "0x600B7F8"), Address(RVA = "0x21329B4", Offset = "0x21329B4", VA = "0x21329B4", Slot = "6")] get
      {
        return (NoticeData) null;
      }
    }

    [Token(Token = "0x17002630")]
    public UpdatedPlayerDataSet UpdatedPlayerDataSet
    {
      [Token(Token = "0x600B7F9"), Address(RVA = "0x21329BC", Offset = "0x21329BC", VA = "0x21329BC", Slot = "4")] get
      {
        return (UpdatedPlayerDataSet) null;
      }
    }

    [Token(Token = "0x17002631")]
    public PlayerCoinType PlayerCoin
    {
      [Token(Token = "0x600B7FA"), Address(RVA = "0x21329C4", Offset = "0x21329C4", VA = "0x21329C4", Slot = "5")] get
      {
        return (PlayerCoinType) null;
      }
    }

    [Token(Token = "0x17002632")]
    public PlayerGearWeaponType PlayerWeapon
    {
      [Token(Token = "0x600B7FB"), Address(RVA = "0x21329CC", Offset = "0x21329CC", VA = "0x21329CC")] get
      {
        return (PlayerGearWeaponType) null;
      }
    }

    [Token(Token = "0x17002633")]
    public List<PlayerWeaponPieceType> PlayerWeaponPieces
    {
      [Token(Token = "0x600B7FC"), Address(RVA = "0x21329D4", Offset = "0x21329D4", VA = "0x21329D4")] get
      {
        return (List<PlayerWeaponPieceType>) null;
      }
    }

    [Token(Token = "0x600B7FD")]
    [Address(RVA = "0x21329DC", Offset = "0x21329DC", VA = "0x21329DC")]
    public APIWeaponLimit_breakResponse()
    {
    }
  }
}

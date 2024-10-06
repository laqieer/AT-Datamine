// Decompiled with JetBrains decompiler
// Type: Network.API.APIWeaponOption_change_requestResponse
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
  [Token(Token = "0x2001F04")]
  [Serializable]
  public class APIWeaponOption_change_requestResponse : IPostApiResult, ICommonApiResult
  {
    [Token(Token = "0x4008521")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private NoticeData notice;
    [Token(Token = "0x4008522")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private UpdatedPlayerDataSet updated_player_data_set;
    [Token(Token = "0x4008523")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private PlayerCoinType player_coin;
    [Token(Token = "0x4008524")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private List<PlayerGearOptionCandidateType> candidates;
    [Token(Token = "0x4008525")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private List<PlayerWeaponPieceType> player_weapon_pieces;

    [Token(Token = "0x17002647")]
    public NoticeData Notice
    {
      [Token(Token = "0x600B840"), Address(RVA = "0x21339C8", Offset = "0x21339C8", VA = "0x21339C8", Slot = "6")] get
      {
        return (NoticeData) null;
      }
    }

    [Token(Token = "0x17002648")]
    public UpdatedPlayerDataSet UpdatedPlayerDataSet
    {
      [Token(Token = "0x600B841"), Address(RVA = "0x21339D0", Offset = "0x21339D0", VA = "0x21339D0", Slot = "4")] get
      {
        return (UpdatedPlayerDataSet) null;
      }
    }

    [Token(Token = "0x17002649")]
    public PlayerCoinType PlayerCoin
    {
      [Token(Token = "0x600B842"), Address(RVA = "0x21339D8", Offset = "0x21339D8", VA = "0x21339D8", Slot = "5")] get
      {
        return (PlayerCoinType) null;
      }
    }

    [Token(Token = "0x1700264A")]
    public List<PlayerGearOptionCandidateType> Candidates
    {
      [Token(Token = "0x600B843"), Address(RVA = "0x21339E0", Offset = "0x21339E0", VA = "0x21339E0")] get
      {
        return (List<PlayerGearOptionCandidateType>) null;
      }
    }

    [Token(Token = "0x1700264B")]
    public List<PlayerWeaponPieceType> PlayerWeaponPieces
    {
      [Token(Token = "0x600B844"), Address(RVA = "0x21339E8", Offset = "0x21339E8", VA = "0x21339E8")] get
      {
        return (List<PlayerWeaponPieceType>) null;
      }
    }

    [Token(Token = "0x600B845")]
    [Address(RVA = "0x21339F0", Offset = "0x21339F0", VA = "0x21339F0")]
    public APIWeaponOption_change_requestResponse()
    {
    }
  }
}

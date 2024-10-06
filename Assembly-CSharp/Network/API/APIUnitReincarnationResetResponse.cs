// Decompiled with JetBrains decompiler
// Type: Network.API.APIUnitReincarnationResetResponse
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
  [Token(Token = "0x2001ECC")]
  [Serializable]
  public class APIUnitReincarnationResetResponse : IPostApiResult, ICommonApiResult
  {
    [Token(Token = "0x4008443")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private NoticeData notice;
    [Token(Token = "0x4008444")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private UpdatedPlayerDataSet updated_player_data_set;
    [Token(Token = "0x4008445")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private PlayerCoinType player_coin;
    [Token(Token = "0x4008446")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private UpdatedPlayerItems updated_player_items;
    [Token(Token = "0x4008447")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private PlayerUnitType updated_unit;
    [Token(Token = "0x4008448")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    private PlayerUnitWarrantyParameterType updated_player_unit_warranty_parameter;
    [Token(Token = "0x4008449")]
    [FieldOffset(Offset = "0x40")]
    [SerializeField]
    private PlayerGearUnitTrustType got_unit_trust;
    [Token(Token = "0x400844A")]
    [FieldOffset(Offset = "0x48")]
    [SerializeField]
    private List<PlayerUnitReincarnationMemoryType> player_unit_reincarnation_memories;

    [Token(Token = "0x170025CA")]
    public NoticeData Notice
    {
      [Token(Token = "0x600B6E3"), Address(RVA = "0x22EE314", Offset = "0x22EE314", VA = "0x22EE314", Slot = "6")] get
      {
        return (NoticeData) null;
      }
    }

    [Token(Token = "0x170025CB")]
    public UpdatedPlayerDataSet UpdatedPlayerDataSet
    {
      [Token(Token = "0x600B6E4"), Address(RVA = "0x22EE31C", Offset = "0x22EE31C", VA = "0x22EE31C", Slot = "4")] get
      {
        return (UpdatedPlayerDataSet) null;
      }
    }

    [Token(Token = "0x170025CC")]
    public PlayerCoinType PlayerCoin
    {
      [Token(Token = "0x600B6E5"), Address(RVA = "0x22EE324", Offset = "0x22EE324", VA = "0x22EE324", Slot = "5")] get
      {
        return (PlayerCoinType) null;
      }
    }

    [Token(Token = "0x170025CD")]
    public UpdatedPlayerItems UpdatedPlayerItems
    {
      [Token(Token = "0x600B6E6"), Address(RVA = "0x22EE32C", Offset = "0x22EE32C", VA = "0x22EE32C")] get
      {
        return (UpdatedPlayerItems) null;
      }
    }

    [Token(Token = "0x170025CE")]
    public PlayerUnitType UpdatedUnit
    {
      [Token(Token = "0x600B6E7"), Address(RVA = "0x22EE334", Offset = "0x22EE334", VA = "0x22EE334")] get
      {
        return (PlayerUnitType) null;
      }
    }

    [Token(Token = "0x170025CF")]
    public PlayerUnitWarrantyParameterType UpdatedPlayerUnitWarrantyParameter
    {
      [Token(Token = "0x600B6E8"), Address(RVA = "0x22EE33C", Offset = "0x22EE33C", VA = "0x22EE33C")] get
      {
        return (PlayerUnitWarrantyParameterType) null;
      }
    }

    [Token(Token = "0x170025D0")]
    public PlayerGearUnitTrustType GotUnitTrust
    {
      [Token(Token = "0x600B6E9"), Address(RVA = "0x22EE344", Offset = "0x22EE344", VA = "0x22EE344")] get
      {
        return (PlayerGearUnitTrustType) null;
      }
    }

    [Token(Token = "0x170025D1")]
    public List<PlayerUnitReincarnationMemoryType> PlayerUnitReincarnationMemories
    {
      [Token(Token = "0x600B6EA"), Address(RVA = "0x22EE34C", Offset = "0x22EE34C", VA = "0x22EE34C")] get
      {
        return (List<PlayerUnitReincarnationMemoryType>) null;
      }
    }

    [Token(Token = "0x600B6EB")]
    [Address(RVA = "0x22EE354", Offset = "0x22EE354", VA = "0x22EE354")]
    public APIUnitReincarnationResetResponse()
    {
    }
  }
}

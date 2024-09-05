// Decompiled with JetBrains decompiler
// Type: Network.API.APIG0001PayResponse
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
  [Token(Token = "0x2001C84")]
  [Serializable]
  public class APIG0001PayResponse : IPostApiResult, ICommonApiResult
  {
    [Token(Token = "0x4007A00")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private NoticeData notice;
    [Token(Token = "0x4007A01")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private UpdatedPlayerDataSet updated_player_data_set;
    [Token(Token = "0x4007A02")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private PlayerCoinType player_coin;
    [Token(Token = "0x4007A03")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private G0001GachaDetailType gacha_detail;
    [Token(Token = "0x4007A04")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private List<RewardGiveResultEntityType> result;
    [Token(Token = "0x4007A05")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    private List<RewardGiveResultEntityType> bonus_result;

    [Token(Token = "0x17001FF8")]
    public NoticeData Notice
    {
      [Token(Token = "0x600A7F1"), Address(RVA = "0x19101D8", Offset = "0x19101D8", VA = "0x19101D8", Slot = "6")] get
      {
        return (NoticeData) null;
      }
    }

    [Token(Token = "0x17001FF9")]
    public UpdatedPlayerDataSet UpdatedPlayerDataSet
    {
      [Token(Token = "0x600A7F2"), Address(RVA = "0x19101E0", Offset = "0x19101E0", VA = "0x19101E0", Slot = "4")] get
      {
        return (UpdatedPlayerDataSet) null;
      }
    }

    [Token(Token = "0x17001FFA")]
    public PlayerCoinType PlayerCoin
    {
      [Token(Token = "0x600A7F3"), Address(RVA = "0x19101E8", Offset = "0x19101E8", VA = "0x19101E8", Slot = "5")] get
      {
        return (PlayerCoinType) null;
      }
    }

    [Token(Token = "0x17001FFB")]
    public G0001GachaDetailType GachaDetail
    {
      [Token(Token = "0x600A7F4"), Address(RVA = "0x19101F0", Offset = "0x19101F0", VA = "0x19101F0")] get
      {
        return (G0001GachaDetailType) null;
      }
    }

    [Token(Token = "0x17001FFC")]
    public List<RewardGiveResultEntityType> Result
    {
      [Token(Token = "0x600A7F5"), Address(RVA = "0x19101F8", Offset = "0x19101F8", VA = "0x19101F8")] get
      {
        return (List<RewardGiveResultEntityType>) null;
      }
    }

    [Token(Token = "0x17001FFD")]
    public List<RewardGiveResultEntityType> BonusResult
    {
      [Token(Token = "0x600A7F6"), Address(RVA = "0x1910200", Offset = "0x1910200", VA = "0x1910200")] get
      {
        return (List<RewardGiveResultEntityType>) null;
      }
    }

    [Token(Token = "0x600A7F7")]
    [Address(RVA = "0x1910208", Offset = "0x1910208", VA = "0x1910208")]
    public APIG0001PayResponse()
    {
    }
  }
}

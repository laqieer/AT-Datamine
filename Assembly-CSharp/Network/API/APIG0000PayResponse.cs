// Decompiled with JetBrains decompiler
// Type: Network.API.APIG0000PayResponse
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
  [Token(Token = "0x2001C74")]
  [Serializable]
  public class APIG0000PayResponse : IPostApiResult, ICommonApiResult
  {
    [Token(Token = "0x40079C7")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private NoticeData notice;
    [Token(Token = "0x40079C8")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private UpdatedPlayerDataSet updated_player_data_set;
    [Token(Token = "0x40079C9")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private PlayerCoinType player_coin;
    [Token(Token = "0x40079CA")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private G0000GachaDetailType gacha_detail;
    [Token(Token = "0x40079CB")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private List<RewardGiveResultEntityType> result;
    [Token(Token = "0x40079CC")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    private List<RewardGiveResultEntityType> bonus_result;

    [Token(Token = "0x17001FD7")]
    public NoticeData Notice
    {
      [Token(Token = "0x600A790"), Address(RVA = "0x190EC60", Offset = "0x190EC60", VA = "0x190EC60", Slot = "6")] get
      {
        return (NoticeData) null;
      }
    }

    [Token(Token = "0x17001FD8")]
    public UpdatedPlayerDataSet UpdatedPlayerDataSet
    {
      [Token(Token = "0x600A791"), Address(RVA = "0x190EC68", Offset = "0x190EC68", VA = "0x190EC68", Slot = "4")] get
      {
        return (UpdatedPlayerDataSet) null;
      }
    }

    [Token(Token = "0x17001FD9")]
    public PlayerCoinType PlayerCoin
    {
      [Token(Token = "0x600A792"), Address(RVA = "0x190EC70", Offset = "0x190EC70", VA = "0x190EC70", Slot = "5")] get
      {
        return (PlayerCoinType) null;
      }
    }

    [Token(Token = "0x17001FDA")]
    public G0000GachaDetailType GachaDetail
    {
      [Token(Token = "0x600A793"), Address(RVA = "0x190EC78", Offset = "0x190EC78", VA = "0x190EC78")] get
      {
        return (G0000GachaDetailType) null;
      }
    }

    [Token(Token = "0x17001FDB")]
    public List<RewardGiveResultEntityType> Result
    {
      [Token(Token = "0x600A794"), Address(RVA = "0x190EC80", Offset = "0x190EC80", VA = "0x190EC80")] get
      {
        return (List<RewardGiveResultEntityType>) null;
      }
    }

    [Token(Token = "0x17001FDC")]
    public List<RewardGiveResultEntityType> BonusResult
    {
      [Token(Token = "0x600A795"), Address(RVA = "0x190EC88", Offset = "0x190EC88", VA = "0x190EC88")] get
      {
        return (List<RewardGiveResultEntityType>) null;
      }
    }

    [Token(Token = "0x600A796")]
    [Address(RVA = "0x190EC90", Offset = "0x190EC90", VA = "0x190EC90")]
    public APIG0000PayResponse()
    {
    }
  }
}

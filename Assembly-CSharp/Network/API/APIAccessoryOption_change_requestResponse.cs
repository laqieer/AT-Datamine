// Decompiled with JetBrains decompiler
// Type: Network.API.APIAccessoryOption_change_requestResponse
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
  [Token(Token = "0x2001B48")]
  [Serializable]
  public class APIAccessoryOption_change_requestResponse : IPostApiResult, ICommonApiResult
  {
    [Token(Token = "0x40074FF")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private NoticeData notice;
    [Token(Token = "0x4007500")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private UpdatedPlayerDataSet updated_player_data_set;
    [Token(Token = "0x4007501")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private PlayerCoinType player_coin;
    [Token(Token = "0x4007502")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private List<PlayerGearOptionCandidateType> candidates;
    [Token(Token = "0x4007503")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private List<PlayerAccessoryPieceType> player_accessories_pieces;

    [Token(Token = "0x17001D22")]
    public NoticeData Notice
    {
      [Token(Token = "0x600A02B"), Address(RVA = "0x46C3770", Offset = "0x46C3770", VA = "0x46C3770", Slot = "6")] get
      {
        return (NoticeData) null;
      }
    }

    [Token(Token = "0x17001D23")]
    public UpdatedPlayerDataSet UpdatedPlayerDataSet
    {
      [Token(Token = "0x600A02C"), Address(RVA = "0x46C3778", Offset = "0x46C3778", VA = "0x46C3778", Slot = "4")] get
      {
        return (UpdatedPlayerDataSet) null;
      }
    }

    [Token(Token = "0x17001D24")]
    public PlayerCoinType PlayerCoin
    {
      [Token(Token = "0x600A02D"), Address(RVA = "0x46C3780", Offset = "0x46C3780", VA = "0x46C3780", Slot = "5")] get
      {
        return (PlayerCoinType) null;
      }
    }

    [Token(Token = "0x17001D25")]
    public List<PlayerGearOptionCandidateType> Candidates
    {
      [Token(Token = "0x600A02E"), Address(RVA = "0x46C3788", Offset = "0x46C3788", VA = "0x46C3788")] get
      {
        return (List<PlayerGearOptionCandidateType>) null;
      }
    }

    [Token(Token = "0x17001D26")]
    public List<PlayerAccessoryPieceType> PlayerAccessoriesPieces
    {
      [Token(Token = "0x600A02F"), Address(RVA = "0x46C3790", Offset = "0x46C3790", VA = "0x46C3790")] get
      {
        return (List<PlayerAccessoryPieceType>) null;
      }
    }

    [Token(Token = "0x600A030")]
    [Address(RVA = "0x46C3798", Offset = "0x46C3798", VA = "0x46C3798")]
    public APIAccessoryOption_change_requestResponse()
    {
    }
  }
}

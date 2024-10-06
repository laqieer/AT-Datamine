// Decompiled with JetBrains decompiler
// Type: Network.API.APIStorySubquestReceiptResponse
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
  [Token(Token = "0x2001E80")]
  [Serializable]
  public class APIStorySubquestReceiptResponse : IPostApiResult, ICommonApiResult
  {
    [Token(Token = "0x4008313")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private NoticeData notice;
    [Token(Token = "0x4008314")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private UpdatedPlayerDataSet updated_player_data_set;
    [Token(Token = "0x4008315")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private PlayerCoinType player_coin;
    [Token(Token = "0x4008316")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private PlayerStorySubQuestType player_subquest;

    [Token(Token = "0x1700251A")]
    public NoticeData Notice
    {
      [Token(Token = "0x600B503"), Address(RVA = "0x22E7C80", Offset = "0x22E7C80", VA = "0x22E7C80", Slot = "6")] get
      {
        return (NoticeData) null;
      }
    }

    [Token(Token = "0x1700251B")]
    public UpdatedPlayerDataSet UpdatedPlayerDataSet
    {
      [Token(Token = "0x600B504"), Address(RVA = "0x22E7C88", Offset = "0x22E7C88", VA = "0x22E7C88", Slot = "4")] get
      {
        return (UpdatedPlayerDataSet) null;
      }
    }

    [Token(Token = "0x1700251C")]
    public PlayerCoinType PlayerCoin
    {
      [Token(Token = "0x600B505"), Address(RVA = "0x22E7C90", Offset = "0x22E7C90", VA = "0x22E7C90", Slot = "5")] get
      {
        return (PlayerCoinType) null;
      }
    }

    [Token(Token = "0x1700251D")]
    public PlayerStorySubQuestType PlayerSubquest
    {
      [Token(Token = "0x600B506"), Address(RVA = "0x22E7C98", Offset = "0x22E7C98", VA = "0x22E7C98")] get
      {
        return (PlayerStorySubQuestType) null;
      }
    }

    [Token(Token = "0x600B507")]
    [Address(RVA = "0x22E7CA0", Offset = "0x22E7CA0", VA = "0x22E7CA0")]
    public APIStorySubquestReceiptResponse()
    {
    }
  }
}

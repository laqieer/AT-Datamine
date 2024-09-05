// Decompiled with JetBrains decompiler
// Type: Network.API.APIBattleLimitedeventquestSkipResponse
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
  [Token(Token = "0x2001BA4")]
  [Serializable]
  public class APIBattleLimitedeventquestSkipResponse : IPostApiResult, ICommonApiResult
  {
    [Token(Token = "0x400768B")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private NoticeData notice;
    [Token(Token = "0x400768C")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private UpdatedPlayerDataSet updated_player_data_set;
    [Token(Token = "0x400768D")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private PlayerCoinType player_coin;
    [Token(Token = "0x400768E")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private PlayerBattleSkipResult results;

    [Token(Token = "0x17001DF8")]
    public NoticeData Notice
    {
      [Token(Token = "0x600A271"), Address(RVA = "0x46CB3A4", Offset = "0x46CB3A4", VA = "0x46CB3A4", Slot = "6")] get
      {
        return (NoticeData) null;
      }
    }

    [Token(Token = "0x17001DF9")]
    public UpdatedPlayerDataSet UpdatedPlayerDataSet
    {
      [Token(Token = "0x600A272"), Address(RVA = "0x46CB3AC", Offset = "0x46CB3AC", VA = "0x46CB3AC", Slot = "4")] get
      {
        return (UpdatedPlayerDataSet) null;
      }
    }

    [Token(Token = "0x17001DFA")]
    public PlayerCoinType PlayerCoin
    {
      [Token(Token = "0x600A273"), Address(RVA = "0x46CB3B4", Offset = "0x46CB3B4", VA = "0x46CB3B4", Slot = "5")] get
      {
        return (PlayerCoinType) null;
      }
    }

    [Token(Token = "0x17001DFB")]
    public PlayerBattleSkipResult Results
    {
      [Token(Token = "0x600A274"), Address(RVA = "0x46CB3BC", Offset = "0x46CB3BC", VA = "0x46CB3BC")] get
      {
        return (PlayerBattleSkipResult) null;
      }
    }

    [Token(Token = "0x600A275")]
    [Address(RVA = "0x46CB3C4", Offset = "0x46CB3C4", VA = "0x46CB3C4")]
    public APIBattleLimitedeventquestSkipResponse()
    {
    }
  }
}

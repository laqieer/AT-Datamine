// Decompiled with JetBrains decompiler
// Type: Network.API.APILimitedEventQuestBattleEndResponse
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
  [Token(Token = "0x2001D44")]
  [Serializable]
  public class APILimitedEventQuestBattleEndResponse : IPostApiResult, ICommonApiResult
  {
    [Token(Token = "0x4007D01")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private NoticeData notice;
    [Token(Token = "0x4007D02")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private UpdatedPlayerDataSet updated_player_data_set;
    [Token(Token = "0x4007D03")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private PlayerCoinType player_coin;
    [Token(Token = "0x4007D04")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private PlayerBattleResult results;

    [Token(Token = "0x1700219C")]
    public NoticeData Notice
    {
      [Token(Token = "0x600AC95"), Address(RVA = "0x1A46EC8", Offset = "0x1A46EC8", VA = "0x1A46EC8", Slot = "6")] get
      {
        return (NoticeData) null;
      }
    }

    [Token(Token = "0x1700219D")]
    public UpdatedPlayerDataSet UpdatedPlayerDataSet
    {
      [Token(Token = "0x600AC96"), Address(RVA = "0x1A46ED0", Offset = "0x1A46ED0", VA = "0x1A46ED0", Slot = "4")] get
      {
        return (UpdatedPlayerDataSet) null;
      }
    }

    [Token(Token = "0x1700219E")]
    public PlayerCoinType PlayerCoin
    {
      [Token(Token = "0x600AC97"), Address(RVA = "0x1A46ED8", Offset = "0x1A46ED8", VA = "0x1A46ED8", Slot = "5")] get
      {
        return (PlayerCoinType) null;
      }
    }

    [Token(Token = "0x1700219F")]
    public PlayerBattleResult Results
    {
      [Token(Token = "0x600AC98"), Address(RVA = "0x1A46EE0", Offset = "0x1A46EE0", VA = "0x1A46EE0")] get
      {
        return (PlayerBattleResult) null;
      }
    }

    [Token(Token = "0x600AC99")]
    [Address(RVA = "0x1A46EE8", Offset = "0x1A46EE8", VA = "0x1A46EE8")]
    public APILimitedEventQuestBattleEndResponse()
    {
    }
  }
}

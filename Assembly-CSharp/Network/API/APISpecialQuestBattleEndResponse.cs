// Decompiled with JetBrains decompiler
// Type: Network.API.APISpecialQuestBattleEndResponse
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
  [Token(Token = "0x2001E1C")]
  [Serializable]
  public class APISpecialQuestBattleEndResponse : IPostApiResult, ICommonApiResult
  {
    [Token(Token = "0x40080E7")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private NoticeData notice;
    [Token(Token = "0x40080E8")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private UpdatedPlayerDataSet updated_player_data_set;
    [Token(Token = "0x40080E9")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private PlayerCoinType player_coin;
    [Token(Token = "0x40080EA")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private PlayerBattleResult results;

    [Token(Token = "0x170023D8")]
    public NoticeData Notice
    {
      [Token(Token = "0x600B231"), Address(RVA = "0x22DF2B4", Offset = "0x22DF2B4", VA = "0x22DF2B4", Slot = "6")] get
      {
        return (NoticeData) null;
      }
    }

    [Token(Token = "0x170023D9")]
    public UpdatedPlayerDataSet UpdatedPlayerDataSet
    {
      [Token(Token = "0x600B232"), Address(RVA = "0x22DF2BC", Offset = "0x22DF2BC", VA = "0x22DF2BC", Slot = "4")] get
      {
        return (UpdatedPlayerDataSet) null;
      }
    }

    [Token(Token = "0x170023DA")]
    public PlayerCoinType PlayerCoin
    {
      [Token(Token = "0x600B233"), Address(RVA = "0x22DF2C4", Offset = "0x22DF2C4", VA = "0x22DF2C4", Slot = "5")] get
      {
        return (PlayerCoinType) null;
      }
    }

    [Token(Token = "0x170023DB")]
    public PlayerBattleResult Results
    {
      [Token(Token = "0x600B234"), Address(RVA = "0x22DF2CC", Offset = "0x22DF2CC", VA = "0x22DF2CC")] get
      {
        return (PlayerBattleResult) null;
      }
    }

    [Token(Token = "0x600B235")]
    [Address(RVA = "0x22DF2D4", Offset = "0x22DF2D4", VA = "0x22DF2D4")]
    public APISpecialQuestBattleEndResponse()
    {
    }
  }
}

// Decompiled with JetBrains decompiler
// Type: Network.API.APIFreeQuestBattleEndResponse
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
  [Token(Token = "0x2001C48")]
  [Serializable]
  public class APIFreeQuestBattleEndResponse : IPostApiResult, ICommonApiResult
  {
    [Token(Token = "0x4007926")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private NoticeData notice;
    [Token(Token = "0x4007927")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private UpdatedPlayerDataSet updated_player_data_set;
    [Token(Token = "0x4007928")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private PlayerCoinType player_coin;
    [Token(Token = "0x4007929")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private PlayerBattleResult results;

    [Token(Token = "0x17001F7C")]
    public NoticeData Notice
    {
      [Token(Token = "0x600A685"), Address(RVA = "0x190B154", Offset = "0x190B154", VA = "0x190B154", Slot = "6")] get
      {
        return (NoticeData) null;
      }
    }

    [Token(Token = "0x17001F7D")]
    public UpdatedPlayerDataSet UpdatedPlayerDataSet
    {
      [Token(Token = "0x600A686"), Address(RVA = "0x190B15C", Offset = "0x190B15C", VA = "0x190B15C", Slot = "4")] get
      {
        return (UpdatedPlayerDataSet) null;
      }
    }

    [Token(Token = "0x17001F7E")]
    public PlayerCoinType PlayerCoin
    {
      [Token(Token = "0x600A687"), Address(RVA = "0x190B164", Offset = "0x190B164", VA = "0x190B164", Slot = "5")] get
      {
        return (PlayerCoinType) null;
      }
    }

    [Token(Token = "0x17001F7F")]
    public PlayerBattleResult Results
    {
      [Token(Token = "0x600A688"), Address(RVA = "0x190B16C", Offset = "0x190B16C", VA = "0x190B16C")] get
      {
        return (PlayerBattleResult) null;
      }
    }

    [Token(Token = "0x600A689")]
    [Address(RVA = "0x190B174", Offset = "0x190B174", VA = "0x190B174")]
    public APIFreeQuestBattleEndResponse()
    {
    }
  }
}

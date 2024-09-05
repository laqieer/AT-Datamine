// Decompiled with JetBrains decompiler
// Type: Network.API.APIAreaQuestBattleSkipResponse
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
  [Token(Token = "0x2001B74")]
  [Serializable]
  public class APIAreaQuestBattleSkipResponse : IPostApiResult, ICommonApiResult
  {
    [Token(Token = "0x40075B4")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private NoticeData notice;
    [Token(Token = "0x40075B5")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private UpdatedPlayerDataSet updated_player_data_set;
    [Token(Token = "0x40075B6")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private PlayerCoinType player_coin;
    [Token(Token = "0x40075B7")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private PlayerBattleSkipResult results;

    [Token(Token = "0x17001D80")]
    public NoticeData Notice
    {
      [Token(Token = "0x600A139"), Address(RVA = "0x46C7294", Offset = "0x46C7294", VA = "0x46C7294", Slot = "6")] get
      {
        return (NoticeData) null;
      }
    }

    [Token(Token = "0x17001D81")]
    public UpdatedPlayerDataSet UpdatedPlayerDataSet
    {
      [Token(Token = "0x600A13A"), Address(RVA = "0x46C729C", Offset = "0x46C729C", VA = "0x46C729C", Slot = "4")] get
      {
        return (UpdatedPlayerDataSet) null;
      }
    }

    [Token(Token = "0x17001D82")]
    public PlayerCoinType PlayerCoin
    {
      [Token(Token = "0x600A13B"), Address(RVA = "0x46C72A4", Offset = "0x46C72A4", VA = "0x46C72A4", Slot = "5")] get
      {
        return (PlayerCoinType) null;
      }
    }

    [Token(Token = "0x17001D83")]
    public PlayerBattleSkipResult Results
    {
      [Token(Token = "0x600A13C"), Address(RVA = "0x46C72AC", Offset = "0x46C72AC", VA = "0x46C72AC")] get
      {
        return (PlayerBattleSkipResult) null;
      }
    }

    [Token(Token = "0x600A13D")]
    [Address(RVA = "0x46C72B4", Offset = "0x46C72B4", VA = "0x46C72B4")]
    public APIAreaQuestBattleSkipResponse()
    {
    }
  }
}

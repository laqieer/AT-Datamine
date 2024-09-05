// Decompiled with JetBrains decompiler
// Type: Network.API.APIScenarioEventFreeQuestBattleEndResponse
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
  [Token(Token = "0x2001DD4")]
  [Serializable]
  public class APIScenarioEventFreeQuestBattleEndResponse : IPostApiResult, ICommonApiResult
  {
    [Token(Token = "0x4007F73")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private NoticeData notice;
    [Token(Token = "0x4007F74")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private UpdatedPlayerDataSet updated_player_data_set;
    [Token(Token = "0x4007F75")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private PlayerCoinType player_coin;
    [Token(Token = "0x4007F76")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private PlayerBattleResult results;

    [Token(Token = "0x1700231B")]
    public NoticeData Notice
    {
      [Token(Token = "0x600B054"), Address(RVA = "0x1A53280", Offset = "0x1A53280", VA = "0x1A53280", Slot = "6")] get
      {
        return (NoticeData) null;
      }
    }

    [Token(Token = "0x1700231C")]
    public UpdatedPlayerDataSet UpdatedPlayerDataSet
    {
      [Token(Token = "0x600B055"), Address(RVA = "0x1A53288", Offset = "0x1A53288", VA = "0x1A53288", Slot = "4")] get
      {
        return (UpdatedPlayerDataSet) null;
      }
    }

    [Token(Token = "0x1700231D")]
    public PlayerCoinType PlayerCoin
    {
      [Token(Token = "0x600B056"), Address(RVA = "0x1A53290", Offset = "0x1A53290", VA = "0x1A53290", Slot = "5")] get
      {
        return (PlayerCoinType) null;
      }
    }

    [Token(Token = "0x1700231E")]
    public PlayerBattleResult Results
    {
      [Token(Token = "0x600B057"), Address(RVA = "0x1A53298", Offset = "0x1A53298", VA = "0x1A53298")] get
      {
        return (PlayerBattleResult) null;
      }
    }

    [Token(Token = "0x600B058")]
    [Address(RVA = "0x1A532A0", Offset = "0x1A532A0", VA = "0x1A532A0")]
    public APIScenarioEventFreeQuestBattleEndResponse()
    {
    }
  }
}

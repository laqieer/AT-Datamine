// Decompiled with JetBrains decompiler
// Type: Network.API.APIBattleFreequestSkipResponse
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
  [Token(Token = "0x2001BA0")]
  [Serializable]
  public class APIBattleFreequestSkipResponse : IPostApiResult, ICommonApiResult
  {
    [Token(Token = "0x4007676")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private NoticeData notice;
    [Token(Token = "0x4007677")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private UpdatedPlayerDataSet updated_player_data_set;
    [Token(Token = "0x4007678")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private PlayerCoinType player_coin;
    [Token(Token = "0x4007679")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private PlayerBattleSkipResult results;

    [Token(Token = "0x17001DEE")]
    public NoticeData Notice
    {
      [Token(Token = "0x600A257"), Address(RVA = "0x46CAE38", Offset = "0x46CAE38", VA = "0x46CAE38", Slot = "6")] get
      {
        return (NoticeData) null;
      }
    }

    [Token(Token = "0x17001DEF")]
    public UpdatedPlayerDataSet UpdatedPlayerDataSet
    {
      [Token(Token = "0x600A258"), Address(RVA = "0x46CAE40", Offset = "0x46CAE40", VA = "0x46CAE40", Slot = "4")] get
      {
        return (UpdatedPlayerDataSet) null;
      }
    }

    [Token(Token = "0x17001DF0")]
    public PlayerCoinType PlayerCoin
    {
      [Token(Token = "0x600A259"), Address(RVA = "0x46CAE48", Offset = "0x46CAE48", VA = "0x46CAE48", Slot = "5")] get
      {
        return (PlayerCoinType) null;
      }
    }

    [Token(Token = "0x17001DF1")]
    public PlayerBattleSkipResult Results
    {
      [Token(Token = "0x600A25A"), Address(RVA = "0x46CAE50", Offset = "0x46CAE50", VA = "0x46CAE50")] get
      {
        return (PlayerBattleSkipResult) null;
      }
    }

    [Token(Token = "0x600A25B")]
    [Address(RVA = "0x46CAE58", Offset = "0x46CAE58", VA = "0x46CAE58")]
    public APIBattleFreequestSkipResponse()
    {
    }
  }
}

// Decompiled with JetBrains decompiler
// Type: Network.API.APIExpeditionPartySlotReleaseResponse
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
  [Token(Token = "0x2001C24")]
  [Serializable]
  public class APIExpeditionPartySlotReleaseResponse : IPostApiResult, ICommonApiResult
  {
    [Token(Token = "0x4007874")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private NoticeData notice;
    [Token(Token = "0x4007875")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private UpdatedPlayerDataSet updated_player_data_set;
    [Token(Token = "0x4007876")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private PlayerCoinType player_coin;
    [Token(Token = "0x4007877")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private PlayerExpeditionPartyType player_expedition_party;

    [Token(Token = "0x17001F10")]
    public NoticeData Notice
    {
      [Token(Token = "0x600A589"), Address(RVA = "0x1907FF8", Offset = "0x1907FF8", VA = "0x1907FF8", Slot = "6")] get
      {
        return (NoticeData) null;
      }
    }

    [Token(Token = "0x17001F11")]
    public UpdatedPlayerDataSet UpdatedPlayerDataSet
    {
      [Token(Token = "0x600A58A"), Address(RVA = "0x1908000", Offset = "0x1908000", VA = "0x1908000", Slot = "4")] get
      {
        return (UpdatedPlayerDataSet) null;
      }
    }

    [Token(Token = "0x17001F12")]
    public PlayerCoinType PlayerCoin
    {
      [Token(Token = "0x600A58B"), Address(RVA = "0x1908008", Offset = "0x1908008", VA = "0x1908008", Slot = "5")] get
      {
        return (PlayerCoinType) null;
      }
    }

    [Token(Token = "0x17001F13")]
    public PlayerExpeditionPartyType PlayerExpeditionParty
    {
      [Token(Token = "0x600A58C"), Address(RVA = "0x1908010", Offset = "0x1908010", VA = "0x1908010")] get
      {
        return (PlayerExpeditionPartyType) null;
      }
    }

    [Token(Token = "0x600A58D")]
    [Address(RVA = "0x1908018", Offset = "0x1908018", VA = "0x1908018")]
    public APIExpeditionPartySlotReleaseResponse()
    {
    }
  }
}

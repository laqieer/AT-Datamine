// Decompiled with JetBrains decompiler
// Type: Network.API.APIScoreAttackBattleStartResponse
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
  [Token(Token = "0x2001DF8")]
  [Serializable]
  public class APIScoreAttackBattleStartResponse : ICommonApiResult
  {
    [Token(Token = "0x4008059")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private NoticeData notice;
    [Token(Token = "0x400805A")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private PlayerDeckType player_deck;
    [Token(Token = "0x400805B")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private string battle_uuid;

    [Token(Token = "0x1700238B")]
    public NoticeData Notice
    {
      [Token(Token = "0x600B154"), Address(RVA = "0x22DC250", Offset = "0x22DC250", VA = "0x22DC250", Slot = "4")] get
      {
        return (NoticeData) null;
      }
    }

    [Token(Token = "0x1700238C")]
    public PlayerDeckType PlayerDeck
    {
      [Token(Token = "0x600B155"), Address(RVA = "0x22DC258", Offset = "0x22DC258", VA = "0x22DC258")] get
      {
        return (PlayerDeckType) null;
      }
    }

    [Token(Token = "0x1700238D")]
    public string BattleUuid
    {
      [Token(Token = "0x600B156"), Address(RVA = "0x22DC260", Offset = "0x22DC260", VA = "0x22DC260")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x600B157")]
    [Address(RVA = "0x22DC268", Offset = "0x22DC268", VA = "0x22DC268")]
    public APIScoreAttackBattleStartResponse()
    {
    }
  }
}

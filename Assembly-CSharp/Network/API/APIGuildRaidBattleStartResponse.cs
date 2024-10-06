// Decompiled with JetBrains decompiler
// Type: Network.API.APIGuildRaidBattleStartResponse
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
  [Token(Token = "0x2001D0C")]
  [Serializable]
  public class APIGuildRaidBattleStartResponse : ICommonApiResult
  {
    [Token(Token = "0x4007C1A")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private NoticeData notice;
    [Token(Token = "0x4007C1B")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private PlayerDeckType player_deck;
    [Token(Token = "0x4007C1C")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private int rollback_count;
    [Token(Token = "0x4007C1D")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private string battle_uuid;
    [Token(Token = "0x4007C1E")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private GuildRaidPositionType position_info;

    [Token(Token = "0x1700211B")]
    public NoticeData Notice
    {
      [Token(Token = "0x600AB34"), Address(RVA = "0x1A42348", Offset = "0x1A42348", VA = "0x1A42348", Slot = "4")] get
      {
        return (NoticeData) null;
      }
    }

    [Token(Token = "0x1700211C")]
    public PlayerDeckType PlayerDeck
    {
      [Token(Token = "0x600AB35"), Address(RVA = "0x1A42350", Offset = "0x1A42350", VA = "0x1A42350")] get
      {
        return (PlayerDeckType) null;
      }
    }

    [Token(Token = "0x1700211D")]
    public int RollbackCount
    {
      [Token(Token = "0x600AB36"), Address(RVA = "0x1A42358", Offset = "0x1A42358", VA = "0x1A42358")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x1700211E")]
    public string BattleUuid
    {
      [Token(Token = "0x600AB37"), Address(RVA = "0x1A42360", Offset = "0x1A42360", VA = "0x1A42360")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x1700211F")]
    public GuildRaidPositionType PositionInfo
    {
      [Token(Token = "0x600AB38"), Address(RVA = "0x1A42368", Offset = "0x1A42368", VA = "0x1A42368")] get
      {
        return (GuildRaidPositionType) null;
      }
    }

    [Token(Token = "0x600AB39")]
    [Address(RVA = "0x1A42370", Offset = "0x1A42370", VA = "0x1A42370")]
    public APIGuildRaidBattleStartResponse()
    {
    }
  }
}

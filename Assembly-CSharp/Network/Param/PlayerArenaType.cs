// Decompiled with JetBrains decompiler
// Type: Network.Param.PlayerArenaType
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace Network.Param
{
  [Token(Token = "0x2001A88")]
  [Serializable]
  public class PlayerArenaType
  {
    [Token(Token = "0x40071B7")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private ArenaGroupType arena_group;
    [Token(Token = "0x40071B8")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private long arena_id;
    [Token(Token = "0x40071B9")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private int remain_arena_battle_count;
    [Token(Token = "0x40071BA")]
    [FieldOffset(Offset = "0x24")]
    [SerializeField]
    private int remain_arena_battle_reset_coin_count;
    [Token(Token = "0x40071BB")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private int remain_arena_battle_reset_ticket_count;
    [Token(Token = "0x40071BC")]
    [FieldOffset(Offset = "0x2C")]
    [SerializeField]
    private int best_ranking;

    [Token(Token = "0x170019FB")]
    public ArenaGroupType ArenaGroup
    {
      [Token(Token = "0x6009907"), Address(RVA = "0x48F0634", Offset = "0x48F0634", VA = "0x48F0634")] get
      {
        return (ArenaGroupType) null;
      }
      [Token(Token = "0x6009908"), Address(RVA = "0x48F063C", Offset = "0x48F063C", VA = "0x48F063C")] set
      {
      }
    }

    [Token(Token = "0x170019FC")]
    public long ArenaId
    {
      [Token(Token = "0x6009909"), Address(RVA = "0x48F0644", Offset = "0x48F0644", VA = "0x48F0644")] get
      {
        return new long();
      }
      [Token(Token = "0x600990A"), Address(RVA = "0x48F064C", Offset = "0x48F064C", VA = "0x48F064C")] set
      {
      }
    }

    [Token(Token = "0x170019FD")]
    public int RemainArenaBattleCount
    {
      [Token(Token = "0x600990B"), Address(RVA = "0x48F0654", Offset = "0x48F0654", VA = "0x48F0654")] get
      {
        return new int();
      }
      [Token(Token = "0x600990C"), Address(RVA = "0x48F065C", Offset = "0x48F065C", VA = "0x48F065C")] set
      {
      }
    }

    [Token(Token = "0x170019FE")]
    public int RemainArenaBattleResetCoinCount
    {
      [Token(Token = "0x600990D"), Address(RVA = "0x48F0664", Offset = "0x48F0664", VA = "0x48F0664")] get
      {
        return new int();
      }
      [Token(Token = "0x600990E"), Address(RVA = "0x48F066C", Offset = "0x48F066C", VA = "0x48F066C")] set
      {
      }
    }

    [Token(Token = "0x170019FF")]
    public int RemainArenaBattleResetTicketCount
    {
      [Token(Token = "0x600990F"), Address(RVA = "0x48F0674", Offset = "0x48F0674", VA = "0x48F0674")] get
      {
        return new int();
      }
      [Token(Token = "0x6009910"), Address(RVA = "0x48F067C", Offset = "0x48F067C", VA = "0x48F067C")] set
      {
      }
    }

    [Token(Token = "0x17001A00")]
    public int BestRanking
    {
      [Token(Token = "0x6009911"), Address(RVA = "0x48F0684", Offset = "0x48F0684", VA = "0x48F0684")] get
      {
        return new int();
      }
      [Token(Token = "0x6009912"), Address(RVA = "0x48F068C", Offset = "0x48F068C", VA = "0x48F068C")] set
      {
      }
    }

    [Token(Token = "0x6009913")]
    [Address(RVA = "0x48F0694", Offset = "0x48F0694", VA = "0x48F0694")]
    public PlayerArenaType()
    {
    }
  }
}

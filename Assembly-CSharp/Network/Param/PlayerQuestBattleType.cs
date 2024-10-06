// Decompiled with JetBrains decompiler
// Type: Network.Param.PlayerQuestBattleType
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace Network.Param
{
  [Token(Token = "0x2001AD0")]
  [Serializable]
  public class PlayerQuestBattleType
  {
    [Token(Token = "0x40072E8")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private int quest_id;
    [Token(Token = "0x40072E9")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    private int total_clear_count;
    [Token(Token = "0x40072EA")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private int clear_count;
    [Token(Token = "0x40072EB")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private string count_at;

    [Token(Token = "0x17001B4A")]
    public int QuestId
    {
      [Token(Token = "0x6009BCF"), Address(RVA = "0x48F1F04", Offset = "0x48F1F04", VA = "0x48F1F04")] get
      {
        return new int();
      }
      [Token(Token = "0x6009BD0"), Address(RVA = "0x48F1F0C", Offset = "0x48F1F0C", VA = "0x48F1F0C")] set
      {
      }
    }

    [Token(Token = "0x17001B4B")]
    public int TotalClearCount
    {
      [Token(Token = "0x6009BD1"), Address(RVA = "0x48F1F14", Offset = "0x48F1F14", VA = "0x48F1F14")] get
      {
        return new int();
      }
      [Token(Token = "0x6009BD2"), Address(RVA = "0x48F1F1C", Offset = "0x48F1F1C", VA = "0x48F1F1C")] set
      {
      }
    }

    [Token(Token = "0x17001B4C")]
    public int ClearCount
    {
      [Token(Token = "0x6009BD3"), Address(RVA = "0x48F1F24", Offset = "0x48F1F24", VA = "0x48F1F24")] get
      {
        return new int();
      }
      [Token(Token = "0x6009BD4"), Address(RVA = "0x48F1F2C", Offset = "0x48F1F2C", VA = "0x48F1F2C")] set
      {
      }
    }

    [Token(Token = "0x17001B4D")]
    public string CountAt
    {
      [Token(Token = "0x6009BD5"), Address(RVA = "0x48F1F34", Offset = "0x48F1F34", VA = "0x48F1F34")] get
      {
        return (string) null;
      }
      [Token(Token = "0x6009BD6"), Address(RVA = "0x48F1F3C", Offset = "0x48F1F3C", VA = "0x48F1F3C")] set
      {
      }
    }

    [Token(Token = "0x6009BD7")]
    [Address(RVA = "0x48F1F44", Offset = "0x48F1F44", VA = "0x48F1F44")]
    public PlayerQuestBattleType()
    {
    }
  }
}

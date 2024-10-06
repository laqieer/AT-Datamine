// Decompiled with JetBrains decompiler
// Type: Network.Param.PlayerStoryAreaEventQuestType
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace Network.Param
{
  [Token(Token = "0x2001AE2")]
  [Serializable]
  public class PlayerStoryAreaEventQuestType
  {
    [Token(Token = "0x400734C")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private int area_event_quest_id;
    [Token(Token = "0x400734D")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    private bool is_receipted;
    [Token(Token = "0x400734E")]
    [FieldOffset(Offset = "0x15")]
    [SerializeField]
    private bool is_completed;
    [Token(Token = "0x400734F")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private int flags;
    [Token(Token = "0x4007350")]
    [FieldOffset(Offset = "0x1C")]
    [SerializeField]
    private int total_complete_count;

    [Token(Token = "0x17001BAE")]
    public int AreaEventQuestId
    {
      [Token(Token = "0x6009CA9"), Address(RVA = "0x48F25E0", Offset = "0x48F25E0", VA = "0x48F25E0")] get
      {
        return new int();
      }
      [Token(Token = "0x6009CAA"), Address(RVA = "0x48F25E8", Offset = "0x48F25E8", VA = "0x48F25E8")] set
      {
      }
    }

    [Token(Token = "0x17001BAF")]
    public bool IsReceipted
    {
      [Token(Token = "0x6009CAB"), Address(RVA = "0x48F25F0", Offset = "0x48F25F0", VA = "0x48F25F0")] get
      {
        return new bool();
      }
      [Token(Token = "0x6009CAC"), Address(RVA = "0x48F25F8", Offset = "0x48F25F8", VA = "0x48F25F8")] set
      {
      }
    }

    [Token(Token = "0x17001BB0")]
    public bool IsCompleted
    {
      [Token(Token = "0x6009CAD"), Address(RVA = "0x48F2604", Offset = "0x48F2604", VA = "0x48F2604")] get
      {
        return new bool();
      }
      [Token(Token = "0x6009CAE"), Address(RVA = "0x48F260C", Offset = "0x48F260C", VA = "0x48F260C")] set
      {
      }
    }

    [Token(Token = "0x17001BB1")]
    public int Flags
    {
      [Token(Token = "0x6009CAF"), Address(RVA = "0x48F2618", Offset = "0x48F2618", VA = "0x48F2618")] get
      {
        return new int();
      }
      [Token(Token = "0x6009CB0"), Address(RVA = "0x48F2620", Offset = "0x48F2620", VA = "0x48F2620")] set
      {
      }
    }

    [Token(Token = "0x17001BB2")]
    public int TotalCompleteCount
    {
      [Token(Token = "0x6009CB1"), Address(RVA = "0x48F2628", Offset = "0x48F2628", VA = "0x48F2628")] get
      {
        return new int();
      }
      [Token(Token = "0x6009CB2"), Address(RVA = "0x48F2630", Offset = "0x48F2630", VA = "0x48F2630")] set
      {
      }
    }

    [Token(Token = "0x6009CB3")]
    [Address(RVA = "0x48F2638", Offset = "0x48F2638", VA = "0x48F2638")]
    public PlayerStoryAreaEventQuestType()
    {
    }
  }
}

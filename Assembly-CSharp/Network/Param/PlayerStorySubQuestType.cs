// Decompiled with JetBrains decompiler
// Type: Network.Param.PlayerStorySubQuestType
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace Network.Param
{
  [Token(Token = "0x2001AEB")]
  [Serializable]
  public class PlayerStorySubQuestType
  {
    [Token(Token = "0x400736A")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private int subquest_id;
    [Token(Token = "0x400736B")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    private bool is_receipted;
    [Token(Token = "0x400736C")]
    [FieldOffset(Offset = "0x15")]
    [SerializeField]
    private bool is_completed;
    [Token(Token = "0x400736D")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private int flags;
    [Token(Token = "0x400736E")]
    [FieldOffset(Offset = "0x1C")]
    [SerializeField]
    private int total_complete_count;
    [Token(Token = "0x400736F")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private int receipt_sequence_id;

    [Token(Token = "0x17001BCC")]
    public int SubquestId
    {
      [Token(Token = "0x6009CEE"), Address(RVA = "0x48F2810", Offset = "0x48F2810", VA = "0x48F2810")] get
      {
        return new int();
      }
      [Token(Token = "0x6009CEF"), Address(RVA = "0x48F2818", Offset = "0x48F2818", VA = "0x48F2818")] set
      {
      }
    }

    [Token(Token = "0x17001BCD")]
    public bool IsReceipted
    {
      [Token(Token = "0x6009CF0"), Address(RVA = "0x48F2820", Offset = "0x48F2820", VA = "0x48F2820")] get
      {
        return new bool();
      }
      [Token(Token = "0x6009CF1"), Address(RVA = "0x48F2828", Offset = "0x48F2828", VA = "0x48F2828")] set
      {
      }
    }

    [Token(Token = "0x17001BCE")]
    public bool IsCompleted
    {
      [Token(Token = "0x6009CF2"), Address(RVA = "0x48F2834", Offset = "0x48F2834", VA = "0x48F2834")] get
      {
        return new bool();
      }
      [Token(Token = "0x6009CF3"), Address(RVA = "0x48F283C", Offset = "0x48F283C", VA = "0x48F283C")] set
      {
      }
    }

    [Token(Token = "0x17001BCF")]
    public int Flags
    {
      [Token(Token = "0x6009CF4"), Address(RVA = "0x48F2848", Offset = "0x48F2848", VA = "0x48F2848")] get
      {
        return new int();
      }
      [Token(Token = "0x6009CF5"), Address(RVA = "0x48F2850", Offset = "0x48F2850", VA = "0x48F2850")] set
      {
      }
    }

    [Token(Token = "0x17001BD0")]
    public int TotalCompleteCount
    {
      [Token(Token = "0x6009CF6"), Address(RVA = "0x48F2858", Offset = "0x48F2858", VA = "0x48F2858")] get
      {
        return new int();
      }
      [Token(Token = "0x6009CF7"), Address(RVA = "0x48F2860", Offset = "0x48F2860", VA = "0x48F2860")] set
      {
      }
    }

    [Token(Token = "0x17001BD1")]
    public int ReceiptSequenceId
    {
      [Token(Token = "0x6009CF8"), Address(RVA = "0x48F2868", Offset = "0x48F2868", VA = "0x48F2868")] get
      {
        return new int();
      }
      [Token(Token = "0x6009CF9"), Address(RVA = "0x48F2870", Offset = "0x48F2870", VA = "0x48F2870")] set
      {
      }
    }

    [Token(Token = "0x6009CFA")]
    [Address(RVA = "0x48F2878", Offset = "0x48F2878", VA = "0x48F2878")]
    public PlayerStorySubQuestType()
    {
    }
  }
}

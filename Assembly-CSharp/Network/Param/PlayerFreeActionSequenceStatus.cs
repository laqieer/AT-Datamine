// Decompiled with JetBrains decompiler
// Type: Network.Param.PlayerFreeActionSequenceStatus
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace Network.Param
{
  [Token(Token = "0x2001AB5")]
  [Serializable]
  public class PlayerFreeActionSequenceStatus
  {
    [Token(Token = "0x4007279")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private int acted_count;
    [Token(Token = "0x400727A")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    private bool in_obliviae;
    [Token(Token = "0x400727B")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private int obliviae_clear_count_in_sequence;

    [Token(Token = "0x17001AC6")]
    public int ActedCount
    {
      [Token(Token = "0x6009AC1"), Address(RVA = "0x48F1510", Offset = "0x48F1510", VA = "0x48F1510")] get
      {
        return new int();
      }
      [Token(Token = "0x6009AC2"), Address(RVA = "0x48F1518", Offset = "0x48F1518", VA = "0x48F1518")] set
      {
      }
    }

    [Token(Token = "0x17001AC7")]
    public bool InObliviae
    {
      [Token(Token = "0x6009AC3"), Address(RVA = "0x48F1520", Offset = "0x48F1520", VA = "0x48F1520")] get
      {
        return new bool();
      }
      [Token(Token = "0x6009AC4"), Address(RVA = "0x48F1528", Offset = "0x48F1528", VA = "0x48F1528")] set
      {
      }
    }

    [Token(Token = "0x17001AC8")]
    public int ObliviaeClearCountInSequence
    {
      [Token(Token = "0x6009AC5"), Address(RVA = "0x48F1534", Offset = "0x48F1534", VA = "0x48F1534")] get
      {
        return new int();
      }
      [Token(Token = "0x6009AC6"), Address(RVA = "0x48F153C", Offset = "0x48F153C", VA = "0x48F153C")] set
      {
      }
    }

    [Token(Token = "0x6009AC7")]
    [Address(RVA = "0x48F1544", Offset = "0x48F1544", VA = "0x48F1544")]
    public PlayerFreeActionSequenceStatus()
    {
    }
  }
}
